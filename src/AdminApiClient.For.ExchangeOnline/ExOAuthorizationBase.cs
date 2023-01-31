using System;
using System.IdentityModel.Tokens.Jwt;

namespace AdminApiClient.For.ExchangeOnline
{
    public abstract class ExOAuthorizationBase
    {
        protected string GetTenantId(string accessToken)
        {
            var token = new JwtSecurityToken(accessToken);
            return token.Claims.First(c => c.Type == "tid").Value;
        }
    }
}
