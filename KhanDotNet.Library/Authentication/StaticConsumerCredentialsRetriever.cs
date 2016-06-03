using System.Threading;
using System.Threading.Tasks;

namespace KhanDotNet.Library.Authentication
{
    public class StaticConsumerCredentialsRetriever : IConsumerCredentialsRetriever
    {
        private ConsumerCredentials Credentials { get; set; }

        public StaticConsumerCredentialsRetriever(string consumerKey, string consumerSecret)
        {
            Credentials = new ConsumerCredentials(consumerKey, consumerSecret);
        }

        public Task<ConsumerCredentials> GetConsumerCredentialsAsync(CancellationToken cancellationToken)
        {
            return Task.FromResult(Credentials);
        }
    }
}
