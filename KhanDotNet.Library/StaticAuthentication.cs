using System.Threading.Tasks;

namespace KhanDotNet.Library
{
    public class StaticAuthentication : IAuthentication
    {
        public string AccessToken { get; set; }

        public string AccessTokenSecret { get; set; }

        public StaticAuthentication(string accessToken, string accessTokenSecret)
        {
            AccessToken = accessToken;
            AccessTokenSecret = accessTokenSecret;
        }

        public Task<OAuthToken> GetAccessTokenAsync()
        {
            var accessToken = new OAuthToken(AccessToken, AccessTokenSecret);

            return Task.FromResult(accessToken);
        }
    }
}
