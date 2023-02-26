using AdminApiClient.For.ExchangeOnline;
using Microsoft.Extensions.Configuration;
using Microsoft.OData.Client;
using Simple.OData.Client;
using System;
using System.Net.Http.Headers;
using System.Security.Principal;
using ExO = AdminApiClient.For.ExchangeOnline.OData;

var builder = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .AddJsonFile("appsettings.Development.json", optional: true, reloadOnChange: true);

IConfigurationRoot configuration = builder.Build();

// PICK either app or interactive authentication
var authTokenService = ExOAppAuthorization.Create(configuration["AppId"], configuration["Organization"], configuration["PfxPath"]);
// var authTokenService = ExOInteractiveAuthorization.Create();
var (tenantId, authResult) = await authTokenService.AcquireFirstTokenParseTenantId();

//string mailboxesAsString = await Scenario_PlainHttpAndJson();
//Console.WriteLine(mailboxesAsString);

//var mailboxesAsEnumberable = await Scenario_SimpleODataClient_CustomDto();
//var mailboxes = mailboxesAsEnumberable.ToList();
//mailboxesAsEnumberable.ToList().ForEach(x => Console.WriteLine(x.UserPrincipalName + ", " + x.RecipientType));
//Console.WriteLine(mailboxes.Count);

//await Scenario_MsODataClientRaw();

//var allMailboxes = await Scenario_SimpleODataClient_GeneratedDto(followNextPageLinks: false);
//Console.WriteLine(allMailboxes.Count);

// var firstHundred = await Scenario_SimpleODataClient_OptimizeWithCustomDto();

// await Scenario_SimpleODataClient_VariousQueries();
await Scenario_SimpleODataClient_MaxPageSize_LocalMetadataDoc();

Console.ReadKey();

async Task<string> Scenario_PlainHttpAndJson()
{
    using var client = new HttpClient();
    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authResult.AccessToken);

    string metadataDoc = await client.GetStringAsync($"https://outlook.office.com/adminApi/beta/{tenantId}/$metadata");
    await File.WriteAllTextAsync("metadata.xml", metadataDoc);

    return await client.GetStringAsync($"https://outlook.office.com/adminApi/beta/{tenantId}/Mailbox");
}

async Task<IEnumerable<Mailbox>> Scenario_SimpleODataClient_CustomDto()
{
    var client = new ODataClient(new ODataClientSettings(new Uri($"https://outlook.office.com/adminApi/beta/{tenantId}"))
    {
        OnTrace = (x, y) => Console.WriteLine(string.Format(x, y)),
        BeforeRequest = (message) => message.Headers.Authorization = new AuthenticationHeaderValue("Bearer", authResult.AccessToken)
    });

    return await client.For<Mailbox>().FindEntriesAsync();
}

async Task<List<ExO.Mailbox>> Scenario_SimpleODataClient_GeneratedDto(bool followNextPageLinks)
{
    var client = new ODataClient(new ODataClientSettings(new Uri($"https://outlook.office.com/adminApi/beta/{tenantId}"))
    {
        OnTrace = (x, y) => Console.WriteLine(string.Format(x, y)),
        BeforeRequestAsync = async (message) =>
        {
            var ar = await authTokenService.AcquireToken();
            message.Headers.Authorization = new AuthenticationHeaderValue("Bearer", ar.AccessToken);
            message.Headers.Add("Prefer", $"odata.maxpagesize=1000;"); // Default page size without this is 100
        }
    });

    var propertySets = string.Join(",", new[] { "Minimum", "AddressList" });

    var annotations = new ODataFeedAnnotations();
    var mailboxes = (await client
        .For<ExO.Mailbox>()
        .Select(m => new { m.UserPrincipalName, m.Alias })
        .QueryOptions($"PropertySet={propertySets}") // does NOT work with Dictionary overload because enclosed in ''
        .Filter(m => m.RecipientTypeDetails == "SharedMailbox")
        .FindEntriesAsync(annotations))
        .ToList();

    if (!followNextPageLinks) return mailboxes;

    while (annotations.NextPageLink != null)
    {
        mailboxes.AddRange(await client.For<ExO.Mailbox>().FindEntriesAsync(annotations.NextPageLink, annotations));
    }
    return mailboxes;
}

// Exchange.Mailbox is a huge object. Cut it down to a custom result object, need to specify collection name in For<>
async Task<List<Mailbox>> Scenario_SimpleODataClient_OptimizeWithCustomDto()
{
    var client = new ODataClient(new ODataClientSettings(new Uri($"https://outlook.office.com/adminApi/beta/{tenantId}"))
    {
        OnTrace = (x, y) => Console.WriteLine(string.Format(x, y)),
        BeforeRequest = (message) => message.Headers.Authorization = new AuthenticationHeaderValue("Bearer", authResult.AccessToken)
    });

    var propertySets = string.Join(",", new[] { "Minimum", "AddressList" });

    var annotations = new ODataFeedAnnotations();
    return (await client
        .For<Mailbox>("Mailbox")
        .Select(m => new { m.UserPrincipalName, m.RecipientType, m.RecipientTypeDetails, m.Alias })
        .QueryOptions($"PropertySet={propertySets}")
        .FindEntriesAsync(annotations))
        .ToList();
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

async Task Scenario_SimpleODataClient_VariousQueries()
{
    var client = new ODataClient(new ODataClientSettings(new Uri($"https://outlook.office.com/adminApi/beta/{tenantId}"))
    {
        OnTrace = (x, y) => Console.WriteLine(string.Format(x, y)),
        BeforeRequest = (message) => message.Headers.Authorization = new AuthenticationHeaderValue("Bearer", authResult.AccessToken)
    });

    var resultsDynDGroup = await GetCollection<ExO.DynamicDistributionGroup>();
    foreach (var r in resultsDynDGroup) Console.WriteLine(r.Identity);

    var resultsDGroup = await GetCollection<ExO.EligibleDistributionGroup>();
    foreach (var d in resultsDGroup) Console.WriteLine(d.Identity);

    var resultsUnifiedGroup = await GetCollection<ExO.UnifiedGroup>();
    foreach (var d in resultsUnifiedGroup) Console.WriteLine(d.Identity);

    Console.WriteLine($"dyndg {resultsDynDGroup.Count} dg {resultsDGroup.Count} unifiedg {resultsUnifiedGroup.Count}");

    async Task<List<T>> GetCollection<T>() where T : class
    {
        var annotations = new ODataFeedAnnotations();
        var coll = (await client
            .For<T>()
            .FindEntriesAsync(annotations))
            .ToList();

        while (annotations.NextPageLink != null)
        {
            coll.AddRange(await client.For<T>().FindEntriesAsync(annotations.NextPageLink, annotations));
        }
        return coll;
    }
}

async Task Scenario_SimpleODataClient_MaxPageSize_LocalMetadataDoc()
{
    string localMetadata = await File.ReadAllTextAsync("../../../../../docs/metadata-asof-20230131.xml");

    var client = new ODataClient(new ODataClientSettings(new Uri($"https://outlook.office.com/adminApi/beta/{tenantId}"))
    {
        OnTrace = (x, y) => Console.WriteLine(string.Format(x, y)),
        BeforeRequest = (message) =>
        {
            message.Headers.Authorization = new AuthenticationHeaderValue("Bearer", authResult.AccessToken);
            message.Headers.Add("Prefer", $"odata.maxpagesize=1000;");
        },
        IgnoreResourceNotFoundException = true, // null instead of 404 on retrieval
        MetadataDocument = localMetadata        // save one recurring roundtrip to the server for $metadata endpoint

    });

    // Set up scenario by picking out first mailbox (yes, potentially slow because of maxpagesize=1000)
    var firstMailboxFound = (await client
        .For<ExO.Mailbox>()
        .FindEntriesAsync())
        .FirstOrDefault();
    string identity = firstMailboxFound.Identity;

    // Find exactly one Mailbox by Key (repetitive, but shows simple top-level collection usage of Key)
    var propertySets = string.Join(",", new[] { "Delivery" });
    var theMailbox = await client
        .For<ExO.Mailbox>()
        .Key(identity)
        .QueryOptions($"PropertySet={propertySets}")
        .FindEntryAsync();

    // Find permissions for Mailbox (drill into dependent collection)
    var permissionsForMailbox = (await client
        .For<ExO.Mailbox>()
        .Key(identity)
        .NavigateTo(x => x.MailboxPermission)
        .As<ExO.MailboxPermission>()
        .FindEntriesAsync())
        .ToList();
}