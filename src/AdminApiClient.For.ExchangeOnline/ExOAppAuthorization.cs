﻿using Microsoft.Identity.Client;
using System.Security.Cryptography.X509Certificates;

namespace AdminApiClient.For.ExchangeOnline
{
    public class ExOAppAuthorization : ExOAuthorizationBase, IExOAuthorization
    {
        private readonly IConfidentialClientApplication _cca;

        private ExOAppAuthorization(IConfidentialClientApplication cca)
        {
            _cca = cca;
        }

        public static IExOAuthorization Create(string appId, string organization, string pathToPfx)
        {
            byte[] pfxBytes = File.ReadAllBytes(pathToPfx);
            var certificate = new X509Certificate2(pfxBytes, "", X509KeyStorageFlags.MachineKeySet | X509KeyStorageFlags.EphemeralKeySet);
            CertificateCleaner.RegisterForDisposalDuringFinalization(certificate);

            return Create(appId, organization, certificate);
        }

        public static IExOAuthorization Create(string appId, string organization, X509Certificate2 certificate)
        {
            var cca = ConfidentialClientApplicationBuilder.Create(appId)
                .WithCertificate(certificate)
                .WithTenantId(organization)
                .Build();

            return new ExOAppAuthorization(cca);
        }

        public async Task<InitialAuthResult> AcquireFirstTokenParseTenantId()
        {
            var authResult = await _cca.AcquireTokenForClient(IExOAuthorization.Scopes)
                .WithForceRefresh(forceRefresh: true)
                .ExecuteAsync()
                .ConfigureAwait(false);

            string tenantId = GetTenantId(authResult.AccessToken);
            return new(tenantId, authResult);
        }

        public Task<AuthenticationResult?> AcquireToken()
        {
            return _cca.AcquireTokenForClient(IExOAuthorization.Scopes).ExecuteAsync();
        }
    }
}
