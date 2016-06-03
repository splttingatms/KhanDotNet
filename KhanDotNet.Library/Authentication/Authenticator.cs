using EnsureThat;
using OAuth;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace KhanDotNet.Library.Authentication
{
    public class Authenticator : IAuthenticator
    {
        private IConsumerCredentialsRetriever ConsumerCredentialsRetriever { get; set; }

        private IAccessTokenRetriever AccessTokenRetriever { get; set; }

        public Authenticator(IConsumerCredentialsRetriever consumerCredentialsRetriever, IAccessTokenRetriever accessTokenRetriever)
        {
            Ensure.That(consumerCredentialsRetriever, nameof(consumerCredentialsRetriever)).IsNotNull();
            Ensure.That(accessTokenRetriever, nameof(accessTokenRetriever)).IsNotNull();

            ConsumerCredentialsRetriever = consumerCredentialsRetriever;
            AccessTokenRetriever = accessTokenRetriever;
        }

        // TODO 2: consider returning URI instead
        public async Task<string> CreateAuthenticatedRequestPath(string url, CancellationToken cancellationToken)
        {
            Ensure.That(url, nameof(url)).IsNotNullOrEmpty();

            var credentials = await ConsumerCredentialsRetriever.GetConsumerCredentialsAsync(cancellationToken);
            var accessToken = await AccessTokenRetriever.GetAccessTokenAsync(cancellationToken);

            var req = OAuthRequest.ForProtectedResource("GET", credentials.Key, credentials.Secret, accessToken.Token, accessToken.Secret);
            req.RequestUrl = url;

            return new UriBuilder(url) { Query = req.GetAuthorizationQuery() }.ToString();
        }
    }
}
