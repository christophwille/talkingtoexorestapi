using Microsoft.Extensions.Configuration;
using Microsoft.Identity.Client;
using System.IdentityModel.Tokens.Jwt;
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

using var client = new HttpClient();
client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authResult.AccessToken);

var result = await client.GetStringAsync($"https://outlook.office.com/adminApi/beta/{tenantId}/Mailbox");

Console.WriteLine(result);
Console.ReadKey();
