using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;

namespace AdminApiClient.For.ExchangeOnline
{
    //
    // Verbatim from https://ravendb.net/articles/managing-the-most-dangerous-constructor-ever
    // Read more at: https://snede.net/the-most-dangerous-constructor-in-net/ and https://paulstovell.com/x509certificate2/
    //
    public class CertificateCleaner : CriticalFinalizerObject
    {
        private X509Certificate2 _certificate;
        private static ConditionalWeakTable<X509Certificate2, CertificateCleaner> _associateLifetimes = new();

        public static void RegisterForDisposalDuringFinalization(X509Certificate2 cert)
        {
            var cleaner = _associateLifetimes.GetOrCreateValue(cert);
            cleaner!._certificate = cert;
        }

        ~CertificateCleaner() => _certificate?.Reset();
    }
}
