using System.Threading;
using System.Threading.Tasks;

namespace KhanDotNet.Library
{
    public interface IAccessTokenRetriever
    {
        Task<OAuthToken> GetAccessTokenAsync(CancellationToken cancellationToken);
    }
}
