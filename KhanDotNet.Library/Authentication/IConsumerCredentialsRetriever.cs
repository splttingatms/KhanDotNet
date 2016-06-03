using KhanDotNet.Library.Authentication;
using System.Threading;
using System.Threading.Tasks;

namespace KhanDotNet.Library.Authentication
{
    public interface IConsumerCredentialsRetriever
    {
        Task<ConsumerCredentials> GetConsumerCredentialsAsync(CancellationToken cancellationToken);
    }
}
