using System.IdentityModel.Tokens.Jwt;
using System.Text.Json;

namespace AdminApiClient.For.ExchangeOnline
{
    public abstract class ExOAuthorizationBase
    {
        protected string GetTenantId(string accessToken)
        {
            var token = new JwtSecurityToken(accessToken);
            return token.Claims.First(c => c.Type == "tid").Value;
        }

        // Option B when OAuth tokens are encrypted
        // https://learn.microsoft.com/en-us/entra/identity-platform/v2-protocols-oidc#find-your-apps-openid-configuration-document-uri

        public static async Task<string> GetTenantIdFromOpenIdConfiguration(string organization)
        {
            string url = $"https://login.microsoftonline.com/{organization}/v2.0/.well-known/openid-configuration";

            var response = await wkClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();

            /* Beginning of document
             {
               "token_endpoint":"https://login.microsoftonline.com/1fbd33dc-2eec-4309-887a-0bc160998d05/oauth2/v2.0/token",
               "token_endpoint_auth_methods_supported":[
                  "client_secret_post",
                  "private_key_jwt",
                  "client_secret_basic"
               ],
             */
            JsonDocument doc = JsonDocument.Parse(json);
            string tokenEndpoint = doc.RootElement.GetProperty("token_endpoint").GetString();
            Uri uri = new Uri(tokenEndpoint);

            return uri.Segments[1].TrimEnd('/');
        }

        // https://learn.microsoft.com/en-us/dotnet/fundamentals/networking/http/httpclient-guidelines#recommended-use
        private static HttpClient wkClient = new(new SocketsHttpHandler
        {
            PooledConnectionLifetime = TimeSpan.FromMinutes(2)
        });
    }
}
