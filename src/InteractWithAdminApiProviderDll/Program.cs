using Microsoft.Exchange.Management.AdminApiProvider;
using Microsoft.Extensions.Configuration;
using Microsoft.Identity.Client;
using Microsoft.OData.Client;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Cryptography.X509Certificates;

#region ConfigAndAuthzTokenRetrieval
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
#endregion

// https://learn.microsoft.com/en-us/odata/client/query-options
// Context & Mailbox come from Microsoft.Exchange.Management.AdminApiProvider
var context = new Container(new Uri($"https://outlook.office.com/adminApi/beta/{tenantId}"));
context.BuildingRequest += (sender, eventArgs) =>
{
    if (!eventArgs.Headers.ContainsKey("Authorization"))
    {
        eventArgs.Headers.Add("Authorization", "Bearer " + authResult.AccessToken);
    }
};

DataServiceQuery<Mailbox> mailboxQuery = context.Mailbox;
await AsyncGetEntitySet();
// SyncGetMailboxes();

// https://learn.microsoft.com/en-us/odata/client/async-operations
async Task AsyncGetEntitySet()
{
    var response = await mailboxQuery.ExecuteAsync();
    foreach (var m in (response as QueryOperationResponse<Mailbox>))
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