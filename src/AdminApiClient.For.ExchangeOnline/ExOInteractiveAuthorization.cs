using Microsoft.Identity.Client;

namespace AdminApiClient.For.ExchangeOnline
{
    public class ExOInteractiveAuthorization : ExOAuthorizationBase, IExOAuthorization
    {
        private static readonly string ClientId = "fb78d390-0c51-40cd-8e17-fdbfab77341b";
        private readonly IPublicClientApplication _pca;

        private ExOInteractiveAuthorization(IPublicClientApplication pca)
        {
            _pca = pca;
        }

        public static IExOAuthorization Create()
        {
            var pca = PublicClientApplicationBuilder.Create(ClientId)
                .WithDefaultRedirectUri()
                .Build();

            return new ExOInteractiveAuthorization(pca);
        }

        public async Task<InitialAuthResult> AcquireFirstTokenParseTenantId()
        {
            var authResult = await _pca.AcquireTokenInteractive(IExOAuthorization.Scopes)
                .ExecuteAsync();

            string tenantId = GetTenantId(authResult.AccessToken);
            return new(tenantId, authResult);
        }

        public async Task<AuthenticationResult?> AcquireToken()
        {
            var account = (await _pca.GetAccountsAsync()).FirstOrDefault();

            AuthenticationResult result = null;
            try
            {
                result = await _pca.AcquireTokenSilent(IExOAuthorization.Scopes, account).ExecuteAsync();
            }
            catch (MsalUiRequiredException ex)
            {
                try
                {
                    result = await _pca.AcquireTokenInteractive(IExOAuthorization.Scopes).ExecuteAsync();
                }
                catch (MsalException msalex)
                {
                    // TODO: log
                }
            }
            catch (Exception ex)
            {
                // TODO: log
            }

            return result;
        }
    }
}
