using System.Threading.Tasks;

namespace KhanDotNet.Library
{
    public interface IAuthentication
    {
        // TODO 1: add cancellation token
        Task<OAuthToken> GetAccessTokenAsync();
    }
}
