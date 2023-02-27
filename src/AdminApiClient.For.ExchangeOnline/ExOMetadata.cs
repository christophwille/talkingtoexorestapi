using System;
using System.Reflection;
using System.Text;

namespace AdminApiClient.For.ExchangeOnline
{
    public static class ExOMetadata
    {
        public static async Task<string> LoadFromResourceAsync()
        {
            var assembly = typeof(ExOMetadata).GetTypeInfo().Assembly;
            var resourceStream = assembly.GetManifestResourceStream("AdminApiClient.For.ExchangeOnline.Resource.metadata.xml");

            using (var reader = new StreamReader(resourceStream, Encoding.UTF8))
            {
                return await reader.ReadToEndAsync();
            }
        }
    }
}
