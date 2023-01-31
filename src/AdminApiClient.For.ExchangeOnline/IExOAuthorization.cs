using Microsoft.Identity.Client;

namespace AdminApiClient.For.ExchangeOnline
{
    public record InitialAuthResult(string TenantId, AuthenticationResult AuthResult);

    public interface IExOAuthorization
    {
        public static string[] Scopes = new string[1] { "https://outlook.office365.com/.default" };

        Task<InitialAuthResult> AcquireFirstTokenParseTenantId();
        Task<AuthenticationResult?> AcquireToken();
    }
}
