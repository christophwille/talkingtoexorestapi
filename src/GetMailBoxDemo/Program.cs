using AdminApiClient.For.ExchangeOnline;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.OData.Client;
using PanoramicData.OData.Client;
using System.Net.Http.Headers;
using ExO = AdminApiClient.For.ExchangeOnline.OData;

var builder = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .AddJsonFile("appsettings.Development.json", optional: true, reloadOnChange: true);

IConfigurationRoot configuration = builder.Build();

var loggerFactory = LoggerFactory.Create(configure =>
{
    configure.AddConfiguration(configuration.GetSection("Logging"));
    configure.AddConsole();
});
var logger = loggerFactory.CreateLogger<Program>();

var tenantIdViaOpenId = await ExOAuthorizationBase.GetTenantIdFromOpenIdConfiguration(configuration["Organization"]);

// PICK either app or interactive authentication
var authTokenService = ExOAppAuthorization.Create(configuration["AppId"], configuration["Organization"], configuration["PfxPath"]);
// var authTokenService = ExOInteractiveAuthorization.Create();
var (tenantId, authResult) = await authTokenService.AcquireFirstTokenParseTenantId();

// ALWAYS get the current metadata document
await GetCurrentMetadata();

string mailboxesAsString = await Scenario_PlainHttpAndJson();
Console.WriteLine(mailboxesAsString);

var mailboxesAsEnumberable = await Scenario_PDODataClient_CustomDto();
var mailboxes = mailboxesAsEnumberable.ToList();
mailboxesAsEnumberable.ToList().ForEach(x => Console.WriteLine(x.UserPrincipalName + ", " + x.RecipientType));
Console.WriteLine(mailboxes.Count);

await Scenario_MsODataClientRaw();

var allMailboxes = await Scenario_PDODataClient_GeneratedDto(followNextPageLinks: false);
Console.WriteLine(allMailboxes.Count);

var firstHundred = await Scenario_PDODataClient_OptimizeWithCustomDto();

await Scenario_PDODataClient_VariousQueries();
// await Scenario_PDODataClient_MaxPageSize_LocalMetadataDoc();
await Scenario_PDODataClient_MailboxStatistics();

Console.ReadKey();

async Task GetCurrentMetadata()
{
    using var client = new HttpClient();
    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authResult.AccessToken);

    string metadataDoc = await client.GetStringAsync($"https://outlook.office.com/adminApi/beta/{tenantId}/$metadata");
    await File.WriteAllTextAsync("metadata.xml", metadataDoc);
}

async Task<string> Scenario_PlainHttpAndJson()
{
    using var client = new HttpClient();
    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authResult.AccessToken);

    return await client.GetStringAsync($"https://outlook.office.com/adminApi/beta/{tenantId}/Mailbox");
}

ODataClient ConfigureStandardClient()
{
    return new ODataClient(new ODataClientOptions
    {
        BaseUrl = $"https://outlook.office.com/adminApi/beta/{tenantId}",
        ConfigureRequest = request =>
        {
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", authResult.AccessToken);
        },
        Logger = logger,
        // https://github.com/panoramicdata/PanoramicData.OData.Client/blob/main/Documentation/metadata.md#metadata-caching
        MetadataCacheDuration = TimeSpan.FromHours(1)
    });
}

async Task<List<Mailbox>> Scenario_PDODataClient_CustomDto()
{
    var client = ConfigureStandardClient();
    return (await client.For<Mailbox>().GetAllAsync()).Value;
}

async Task<List<ExO.Mailbox>> Scenario_PDODataClient_GeneratedDto(bool followNextPageLinks)
{
    var client = ConfigureStandardClient();

    var propertySets = string.Join(",", new[] { "Minimum", "AddressList" });

    var mailboxes = (await client
        .For<ExO.Mailbox>()
        .WithHeader("Prefer", $"odata.maxpagesize=1000;") // Default page size without this is 100
        .Select(m => new { m.UserPrincipalName, m.Alias })
        .QueryOptions($"PropertySet={propertySets}")
        .Filter(m => m.RecipientTypeDetails == "SharedMailbox")
        .GetAllAsync())
        .Value;


    return mailboxes;
}

// Exchange.Mailbox is a huge object. Cut it down to a custom result object, need to specify collection name in For<>
async Task<List<Mailbox>> Scenario_PDODataClient_OptimizeWithCustomDto()
{
    var client = ConfigureStandardClient();

    var propertySets = string.Join(",", new[] { "Minimum", "AddressList" });

    return (await client
        .For<Mailbox>("Mailbox")
        .Select(m => new { m.UserPrincipalName, m.RecipientType, m.RecipientTypeDetails, m.Alias })
        .QueryOptions($"PropertySet={propertySets}")
        .GetAllAsync())
        .Value;
}

async Task Scenario_MsODataClientRaw()
{
    // https://learn.microsoft.com/en-us/odata/client/query-options
    var context = new ExO.Container(new Uri($"https://outlook.office.com/adminApi/beta/{tenantId}"));
    context.BuildingRequest += (sender, eventArgs) => eventArgs.Headers.Add("Authorization", "Bearer " + authResult.AccessToken);

    DataServiceQuery<ExO.Mailbox> mailboxQuery = context.Mailbox;
    await AsyncGetEntitySet();
    // SyncGetMailboxes();

    // https://learn.microsoft.com/en-us/odata/client/async-operations
    async Task AsyncGetEntitySet()
    {
        var response = await mailboxQuery.ExecuteAsync();
        foreach (var m in (response as QueryOperationResponse<ExO.Mailbox>))
        {
            Console.WriteLine(m.UserPrincipalName);
        }
    }

    void SyncGetMailboxes()
    {
        foreach (var m in mailboxQuery)
        {
            Console.WriteLine(m.UserPrincipalName);
        }
    }
}

async Task Scenario_PDODataClient_VariousQueries()
{
    var client = ConfigureStandardClient();

    var resultsDynDGroup = await GetCollection<ExO.DynamicDistributionGroup>();
    foreach (var r in resultsDynDGroup) Console.WriteLine(r.Identity);

    var resultsDGroup = await GetCollection<ExO.EligibleDistributionGroup>();
    foreach (var d in resultsDGroup) Console.WriteLine(d.Identity);

    var resultsUnifiedGroup = await GetCollection<ExO.UnifiedGroup>();
    foreach (var d in resultsUnifiedGroup) Console.WriteLine(d.Identity);

    Console.WriteLine($"dyndg {resultsDynDGroup.Count} dg {resultsDGroup.Count} unifiedg {resultsUnifiedGroup.Count}");

    async Task<List<T>> GetCollection<T>() where T : class
    {
        var coll = (await client
            .For<T>()
            .GetAllAsync())
            .Value;

        return coll;
    }
}

async Task Scenario_PDODataClient_MaxPageSize_LocalMetadataDoc()
{
    var client = new ODataClient(new ODataClientOptions
    {
        BaseUrl = $"https://outlook.office.com/adminApi/beta/{tenantId}",
        ConfigureRequest = request =>
        {
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", authResult.AccessToken);
            request.Headers.Add("Prefer", $"odata.maxpagesize=1000;");
        },
        Logger = logger,
        IgnoreResourceNotFoundException = true, // null instead of 404 on retrieval
    });

    // Set up scenario by picking out first mailbox (yes, potentially slow because of maxpagesize=1000)
    var firstMailboxFound = (await client
        .For<ExO.Mailbox>()
        .GetFirstOrDefaultAsync());

    string identity = firstMailboxFound.Identity;

    // Find exactly one Mailbox by Key (repetitive, but shows simple top-level collection usage of Key)
    var propertySets = string.Join(",", new[] { "Delivery" });
    var theMailbox = await client
        .For<ExO.Mailbox>()
        .Key(identity)
        .QueryOptions($"PropertySet={propertySets}")
        .GetFirstOrDefaultAsync();

    // Find permissions for Mailbox (drill into dependent collection)
    // https://github.com/panoramicdata/PanoramicData.OData.Client/issues/12#issuecomment-4484593181
    var permissionsForMailbox = (await client
        .For<ExO.Mailbox>()
        .Key(identity)
        .NavigateTo(x => x.MailboxPermission)
        .As<ExO.MailboxPermission>()
        .FindEntriesAsync())
        .ToList();
}

async Task Scenario_PDODataClient_MailboxStatistics()
{
    var client = ConfigureStandardClient();

    string identity = "SharedMBX8727602@lillich.onmicrosoft.com";
    var propertySets = string.Join(",", new[] { "Quota", "StatisticsSeed", "Minimum" });

    var result = (await client
       .For<ExO.Mailbox>()
       .Key(identity)
       .QueryOptions($"PropertySet={propertySets}")
       .GetFirstOrDefaultAsync());

    string receiveQuota = result.ProhibitSendReceiveQuota;
    string sendQuota = result.ProhibitSendQuota;
    string warningQuota = result.IssueWarningQuota;

    var function = client
       .For<ExO.Mailbox>()
       .Key(identity)
       .Function("Exchange.GetMailboxStatistics");

    var stats = await client.CallFunctionAsync<ExO.Mailbox, ExO.MailboxStatistics>(function);

    var tis = stats.TotalItemSize;
}