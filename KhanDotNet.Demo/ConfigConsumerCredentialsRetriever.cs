using KhanDotNet.Library;
using KhanDotNet.Library.Authentication;
using System.Configuration;
using System.Threading;
using System.Threading.Tasks;

namespace KhanDotNet.Demo
{
    class ConfigConsumerCredentialsRetriever : IConsumerCredentialsRetriever
    {
        private string KeyConfigName { get; set; }

        private string SecretConfigName { get; set; }

        public ConfigConsumerCredentialsRetriever(string keyConfigName, string secretConfigName)
        {
            KeyConfigName = keyConfigName;
            SecretConfigName = secretConfigName;
        }

        public Task<ConsumerCredentials> GetConsumerCredentialsAsync(CancellationToken cancellationToken)
        {
            var key = ConfigurationManager.AppSettings[KeyConfigName];
            var secret = ConfigurationManager.AppSettings[SecretConfigName];
            return Task.FromResult(new ConsumerCredentials(key, secret));
        }
    }
}
