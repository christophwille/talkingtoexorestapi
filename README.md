# Exchange Online OData API Experiments

Talking directly to the Exchange Online PowerShell (OData) REST API

You need either 

* an application (id + certificate) in your tenant just like for using the Exchange Online PowerShell cmdlets
* or a user account that has administrative rights for Exchange Online

Projects in this repository:

* src/ExchangeOnlineRestApiClients.sln: calling the Exchange Online Mailbox REST API directly via HttpClient (simple JSON), Microsoft OData Client as well as 
Simple.OData.Client. Note that AdminApiClient.For.ExchangeOnline.csproj supports both types of clients as can be seen in the various examples in GetMailBoxDemo.csproj.
I personally prefer Simple.OData.Client, that is why there are more samples of that.
* src/Spikes: old code that was used to try various things. Could be fun to look at though.
