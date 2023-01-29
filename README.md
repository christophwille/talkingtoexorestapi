# Exchange Online OData API Experiments

Talking directly to the Exchange Online PowerShell (OData) REST API

You need: an application (id + certificate) in your tenant just like for using the Exchange Online PowerShell cmdlets.

* src/ExchangeOnlineRestApiClients.sln: calling the Exchange Online Mailbox REST API directly via HttpClient (simple JSON) as well as Simple.OData.Client (with a minimal custom Mailbox class, note that records won't work)
* src/InteractWithAdminApiProviderDll.sln: this references DLLs from https://www.powershellgallery.com/packages/ExchangeOnlineManagement/ (simply do a manual download, change extension to zip & extract - do not forget to Unblock zip first!) and then uses the public classes Container and Mailbox to send a DataServiceQuery to the REST endpoint.
