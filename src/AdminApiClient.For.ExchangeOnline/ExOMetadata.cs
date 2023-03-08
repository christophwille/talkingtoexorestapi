using System.Reflection;
using System.Text;

namespace AdminApiClient.For.ExchangeOnline
{
    public static class ExOMetadata
    {
        private static readonly string ResourceName = "AdminApiClient.For.ExchangeOnline.Resource.metadata.xml";

        public static async Task<string> LoadFromResourceAsync()
        {
            var assembly = typeof(ExOMetadata).GetTypeInfo().Assembly;
            var resourceStream = assembly.GetManifestResourceStream(ResourceName);

            using (var reader = new StreamReader(resourceStream, Encoding.UTF8))
            {
                return await reader.ReadToEndAsync();
            }
        }


        private static string? metadataDocument = null;
        public static string LoadFromResourceCached()
        {
            if (null != metadataDocument) return metadataDocument;

            var assembly = typeof(ExOMetadata).GetTypeInfo().Assembly;
            var resourceStream = assembly.GetManifestResourceStream(ResourceName);

            using (var reader = new StreamReader(resourceStream, Encoding.UTF8))
            {
                metadataDocument = reader.ReadToEnd();
            }

            return metadataDocument;
        }
    }
}
