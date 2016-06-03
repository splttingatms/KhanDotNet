using System.Threading;
using System.Threading.Tasks;

namespace KhanDotNet.Library.Authentication
{
    public class StaticAccessTokenRetriever : IAccessTokenRetriever
    {
        public OAuthToken AccessToken { get; set; }

        public StaticAccessTokenRetriever(string accessToken, string accessTokenSecret)
        {
            AccessToken = new OAuthToken(accessToken, accessTokenSecret);
        }

        public Task<OAuthToken> GetAccessTokenAsync(CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            return Task.FromResult(AccessToken);
        }
    }
}
