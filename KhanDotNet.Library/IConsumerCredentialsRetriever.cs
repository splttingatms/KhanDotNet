using System.Threading;
using System.Threading.Tasks;

namespace KhanDotNet.Library
{
    public interface IConsumerCredentialsRetriever
    {
        Task<ConsumerCredentials> GetConsumerCredentialsAsync(CancellationToken cancellationToken);
    }
}
