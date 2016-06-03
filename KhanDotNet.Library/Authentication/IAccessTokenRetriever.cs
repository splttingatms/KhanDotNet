using System.Threading;
using System.Threading.Tasks;

namespace KhanDotNet.Library.Authentication
{
    public interface IAccessTokenRetriever
    {
        Task<OAuthToken> GetAccessTokenAsync(CancellationToken cancellationToken);
    }
}
