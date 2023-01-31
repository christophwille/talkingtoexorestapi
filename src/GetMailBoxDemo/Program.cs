using Microsoft.Extensions.Configuration;
using Microsoft.Identity.Client;
using Simple.OData.Client;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

var builder = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .AddJsonFile("appsettings.Development.json", optional: true, reloadOnChange: true);

IConfigurationRoot configuration = builder.Build();

byte[] pfxBytes = File.ReadAllBytes(configuration["PfxPath"]);
var certificate = new X509Certificate2(pfxBytes);

string[] scopes = new string[1] { "https://outlook.office365.com/.default" };

var cca = ConfidentialClientApplicationBuilder.Create(configuration["AppId"])
    .WithCertificate(certificate)
    .WithTenantId(configuration["Organization"])
    .Build();

var authResult = await cca.AcquireTokenForClient(scopes).WithForceRefresh(forceRefresh: true).ExecuteAsync();

var token = new JwtSecurityToken(authResult.AccessToken);
string tenantId = token.Claims.First(c => c.Type == "tid").Value;

//string mailboxesAsString = await TalkingHttp();
//Console.WriteLine(mailboxesAsString);

//var mailboxesAsEnumberable = await TalkingOData();
//var mailboxes = mailboxesAsEnumberable.ToList();
//mailboxesAsEnumberable.ToList().ForEach(x => Console.WriteLine(x.UserPrincipalName + ", " + x.RecipientType));
//Console.WriteLine(mailboxes.Count);

// var allMailboxes = await AdvancedOData(followNextPageLinks: false);
// Console.WriteLine(allMailboxes.Count);

var firstHundred = await CustomObjectForCollectionOData();

Console.ReadKey();

async Task<string> TalkingHttp()
{
    using var client = new HttpClient();
    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authResult.AccessToken);

    string metadataDoc = await client.GetStringAsync($"https://outlook.office.com/adminApi/beta/{tenantId}/$metadata");
    await File.WriteAllTextAsync("metadata.xml", metadataDoc);

    return await client.GetStringAsync($"https://outlook.office.com/adminApi/beta/{tenantId}/Mailbox");
}

async Task<IEnumerable<Mailbox>> TalkingOData()
{
    var client = new ODataClient(new ODataClientSettings(new Uri($"https://outlook.office.com/adminApi/beta/{tenantId}"))
    {
        OnTrace = (x, y) => Console.WriteLine(string.Format(x, y)),
        BeforeRequest = (message) => message.Headers.Authorization = new AuthenticationHeaderValue("Bearer", authResult.AccessToken)
    });

    return await client.For<Mailbox>().FindEntriesAsync();
}

async Task<List<Exchange.Mailbox>> AdvancedOData(bool followNextPageLinks)
{
    var client = new ODataClient(new ODataClientSettings(new Uri($"https://outlook.office.com/adminApi/beta/{tenantId}"))
    {
        OnTrace = (x, y) => Console.WriteLine(string.Format(x, y)),
        BeforeRequestAsync = async (message) =>
        {
            var ar = await cca.AcquireTokenForClient(scopes).ExecuteAsync();
            message.Headers.Authorization = new AuthenticationHeaderValue("Bearer", ar.AccessToken);
        }
    });

    var propertySets = string.Join(",", new[] { "Minimum", "AddressList" });

    var annotations = new ODataFeedAnnotations();
    var mailboxes = (await client
        .For<Exchange.Mailbox>()
        .Select(m => new { m.UserPrincipalName, m.Alias })
        .QueryOptions($"PropertySet={propertySets}") // does NOT work with Dictionary overload because enclosed in ''
        .Filter(m => m.RecipientTypeDetails == "SharedMailbox")
        .FindEntriesAsync(annotations))
        .ToList();

    if (!followNextPageLinks) return mailboxes;

    while (annotations.NextPageLink != null)
    {
        mailboxes.AddRange(await client.For<Exchange.Mailbox>().FindEntriesAsync(annotations.NextPageLink, annotations));
    }
    return mailboxes;
}

// Exchange.Mailbox is a huge object. Cut it down to a custom result object, need to specify collection name in For<>
async Task<List<Mailbox>> CustomObjectForCollectionOData()
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