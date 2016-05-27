using System.Threading;
using System.Threading.Tasks;

namespace KhanDotNet.Library
{
    public class StaticAuthentication : IAuthentication
    {
        public OAuthToken AccessToken { get; set; }

        public StaticAuthentication(string accessToken, string accessTokenSecret)
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
