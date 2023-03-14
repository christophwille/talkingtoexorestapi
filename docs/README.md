## OData Metadata Document

Metadata document downloaded via following code fragment in GetMailBoxDemo project:

``` csharp
    string metadataDoc = await client.GetStringAsync($"https://outlook.office.com/adminApi/beta/{tenantId}/$metadata");
    await File.WriteAllTextAsync("metadata.xml", metadataDoc);
```

Formatted using https://jsonformatter.org/xml-formatter for easier diffing

## ExO PS Decompilation

See `decompile.bat`. Run in `unpackedexomoduledirectory\netCore`, eg `3.2.0-preview1\netCore`
