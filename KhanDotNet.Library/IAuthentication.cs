using System.Threading.Tasks;

namespace KhanDotNet.Library
{
    public interface IAuthentication
    {
        Task<OAuthToken> GetAccessTokenAsync();
    }
}
