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

var allMailboxes = await AdvancedOData(followNextPageLinks: false);
Console.WriteLine(allMailboxes.Count);

Console.ReadKey();

async Task<string> TalkingHttp()
{
    using var client = new HttpClient();
    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authResult.AccessToken);

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

async Task<List<Mailbox>> AdvancedOData(bool followNextPageLinks)
{
    var client = new ODataClient(new ODataClientSettings(new Uri($"https://outlook.office.com/adminApi/beta/{tenantId}"))
    {
        OnTrace = (x, y) => Console.WriteLine(string.Format(x, y)),
        BeforeRequest = (message) => message.Headers.Authorization = new AuthenticationHeaderValue("Bearer", authResult.AccessToken)
    });

    var propertySets = string.Join(",", new[] { "Minimum", "AddressList" });

    var annotations = new ODataFeedAnnotations();
    var mailboxes = (await client
        .For<Mailbox>()
        .Select(m => new { m.UserPrincipalName, m.Alias })
        .QueryOptions($"PropertySet={propertySets}") // does NOT work with Dictionary overload because enclosed in ''
        // .Filter(m => m.UserPrincipalName.StartsWith("S"))
        .FindEntriesAsync(annotations))
        .ToList();

    if (!followNextPageLinks) return mailboxes;

    while (annotations.NextPageLink != null)
    {
        mailboxes.AddRange(await client.For<Mailbox>().FindEntriesAsync(annotations.NextPageLink, annotations));
    }
    return mailboxes;
}
