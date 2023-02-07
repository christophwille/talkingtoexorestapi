using AdminApiClient.For.ExchangeOnline;
using Microsoft.Extensions.Configuration;
using Simple.OData.Client;
using System.Net.Http.Headers;

var builder = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .AddJsonFile("appsettings.Development.json", optional: true, reloadOnChange: true);

IConfigurationRoot configuration = builder.Build();

var authTokenService = ExOAppAuthorization.Create(configuration["AppId"], configuration["Organization"], configuration["PfxPath"]);
var (tenantId, authResult) = await authTokenService.AcquireFirstTokenParseTenantId();

var sw = new System.Diagnostics.Stopwatch();
sw.Start();

var foundObjects = await LoadSharedMailboxes();

sw.Stop();
Console.WriteLine("Time " + sw.Elapsed.ToString());
Console.WriteLine("Objects " + foundObjects.Count.ToString());
Console.ReadKey();

async Task<List<OptimizedMailbox>> LoadSharedMailboxes()
{
    var client = new ODataClient(new ODataClientSettings(new Uri($"https://outlook.office.com/adminApi/beta/{tenantId}"))
    {
        OnTrace = (x, y) => Console.WriteLine(string.Format(x, y)),
        BeforeRequestAsync = async (message) =>
        {
            var ar = await authTokenService.AcquireToken();
            message.Headers.Authorization = new AuthenticationHeaderValue("Bearer", ar.AccessToken);
            message.Headers.Add("Prefer", $"odata.maxpagesize=1000;");
        }
    });

    var propertySets = string.Join(",", new[] { "Minimum", "Custom" });
    var annotations = new ODataFeedAnnotations();

    var mailboxes = (await client
        .For<OptimizedMailbox>("Mailbox")
        .QueryOptions($"PropertySet={propertySets}")
        .Filter("RecipientTypeDetails eq 'SharedMailbox'") // intentionally not => because we don't need RecipientTypeDetails in the results repeated over and over again
        .FindEntriesAsync(annotations))
        .ToList();

    int page = 1;

    while (annotations.NextPageLink != null)
    {
        mailboxes.AddRange(await client.For<OptimizedMailbox>().FindEntriesAsync(annotations.NextPageLink, annotations));
        Console.WriteLine("Additional page " + page++);
    }

    return mailboxes;
}

public class OptimizedMailbox
{
    public string Name { get; set; }
    public string Guid { get; set; }
    public string Identity { get; set; }
    public string DisplayName { get; set; }
    public string Alias { get; set; }
    public string PrimarySmtpAddress { get; set; }
    public string ExternalDirectoryObjectId { get; set; }

    public string CustomAttribute1 { get; set; }
    public string CustomAttribute2 { get; set; }
    public string CustomAttribute3 { get; set; }
    public string CustomAttribute4 { get; set; }
    public string CustomAttribute5 { get; set; }
    public string CustomAttribute6 { get; set; }
    public string CustomAttribute7 { get; set; }
    public string CustomAttribute8 { get; set; }
    public string CustomAttribute9 { get; set; }
    public string CustomAttribute10 { get; set; }
    public string CustomAttribute11 { get; set; }
    public string CustomAttribute12 { get; set; }
    public string CustomAttribute13 { get; set; }
    public string CustomAttribute14 { get; set; }
    public string CustomAttribute15 { get; set; }
}