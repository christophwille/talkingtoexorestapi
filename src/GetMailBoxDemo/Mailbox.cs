public class Mailbox
{
    public string UserPrincipalName { get; set; }
    public string RecipientType { get; set; }

    // non-default response property
    public string Alias { get; set; }
}

/*
 * SAMPLE DEFAULT RESPONSE
 
 {
   "@odata.id":"https://outlook.office.com/adminApi/beta/tenantId/Mailbox('mailboxId')",
   "@odata.editLink":"https://outlook.office.com/adminApi/beta/tenantId/Mailbox('mailboxId')",
   "ObjectKey":"mailboxId",
   "ExternalDirectoryObjectId":"mailboxId",
   "UserPrincipalName":"THEMAILBOX@yourm365tenant.onmicrosoft.com",
   "Alias":"THEMAILBOX",
   "DisplayName":"THEMAILBOX",
   "EmailAddresses":[
      "SMTP:THEMAILBOX@yourm365tenant.onmicrosoft.com"
   ],
   "PrimarySmtpAddress":"THEMAILBOX@yourm365tenant.onmicrosoft.com",
   "RecipientType":"UserMailbox",
   "RecipientTypeDetails":"SharedMailbox",
   "Identity":"THEMAILBOX",
   "Id":"THEMAILBOX",
   "ExchangeVersion":"0.20 (15.0.0.0)",
   "Name":"THEMAILBOX",
   "DistinguishedName":"CN=THEMAILBOX,OU=yourm365tenant.onmicrosoft.com,OU=Microsoft Exchange Hosted Organizations,DC=EURPR03A008,DC=prod,DC=outlook,DC=com",
   "OrganizationId":"EURPR03A008.prod.outlook.com/Microsoft Exchange Hosted Organizations/yourm365tenant.onmicrosoft.com - EURPR03A008.prod.outlook.com/ConfigurationUnits/yourm365tenant.onmicrosoft.com/Configuration",
   "Guid":"73129125-e51e-4fbf-8d97-49755dcf0706"
 }
 */