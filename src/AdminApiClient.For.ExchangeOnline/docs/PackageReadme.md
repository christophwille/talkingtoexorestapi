## About

Built and tested against Exchange Online PowerShell 3.1.0


## Features

* OData Client built from $metadata document
* Token provider for interactive and application login

## Usage

Recommended and tested is using this together with Simple.OData.Client (Note this sample only grabs the first page):

```csharp
var authTokenService = ExOInteractiveAuthorization.Create();
var (tenantId, authResult) = await authTokenService.AcquireFirstTokenParseTenantId();

var client = new ODataClient(new ODataClientSettings(new Uri($"https://outlook.office.com/adminApi/beta/{tenantId}"))
{
#if DEBUG
    OnTrace = (x, y) => Console.WriteLine(string.Format(x, y)),
#endif
    BeforeRequest = (message) => message.Headers.Authorization = new AuthenticationHeaderValue("Bearer", authResult.AccessToken)
});

return await client.For<Mailbox>().FindEntriesAsync();
```

Full-fledged sample including paging, selecting a subset of properties to be returned, filtering and dynamic handling of refresh tokens:

```csharp
async Task<List<ExO.Mailbox>> SelectFilterUsingPropertySets()
{
    var client = new ODataClient(new ODataClientSettings(new Uri($"https://outlook.office.com/adminApi/beta/{tenantId}"))
    {
        OnTrace = (x, y) => Console.WriteLine(string.Format(x, y)),
        BeforeRequestAsync = async (message) =>
        {
            var ar = await authTokenService.AcquireToken();
            message.Headers.Authorization = new AuthenticationHeaderValue("Bearer", ar.AccessToken);
        }
    });

    var propertySets = string.Join(",", new[] { "Minimum", "AddressList" });

    var annotations = new ODataFeedAnnotations();
    var mailboxes = (await client
        .For<ExO.Mailbox>()
        .Select(m => new { m.UserPrincipalName, m.Alias })
        .QueryOptions($"PropertySet={propertySets}")
        .Filter(m => m.RecipientTypeDetails == "SharedMailbox")
        .FindEntriesAsync(annotations))
        .ToList();

    while (annotations.NextPageLink != null)
    {
        mailboxes.AddRange(await client.For<ExO.Mailbox>().FindEntriesAsync(annotations.NextPageLink, annotations));
    }
    return mailboxes;
}
```