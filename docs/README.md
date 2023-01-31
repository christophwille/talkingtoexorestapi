Metadata document downloaded via following code fragment in GetMailBoxDemo project:

``` csharp
    string metadataDoc = await client.GetStringAsync($"https://outlook.office.com/adminApi/beta/{tenantId}/$metadata");
    await File.WriteAllTextAsync("metadata.xml", metadataDoc);
```