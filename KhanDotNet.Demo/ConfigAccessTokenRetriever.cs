using KhanDotNet.Library;
using KhanDotNet.Library.Authentication;
using System.Configuration;
using System.Threading;
using System.Threading.Tasks;

namespace KhanDotNet.Demo
{
    class ConfigAccessTokenRetriever : IAccessTokenRetriever
    {
        private string TokenConfigName { get; set; }

        private string SecretConfigName { get; set; }

        public ConfigAccessTokenRetriever(string tokenConfigName, string secretConfigName)
        {
            TokenConfigName = tokenConfigName;
            SecretConfigName = secretConfigName;
        }

        public Task<OAuthToken> GetAccessTokenAsync(CancellationToken cancellationToken)
        {
            var token = ConfigurationManager.AppSettings[TokenConfigName];
            var secret = ConfigurationManager.AppSettings[SecretConfigName];
            return Task.FromResult(new OAuthToken(token, secret));
        }
    }
}
