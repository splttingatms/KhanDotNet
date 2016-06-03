using EnsureThat;
using OAuth;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KhanDotNet.Library.Authentication
{
    public class WebAccessTokenRetriever : IAccessTokenRetriever
    {
        private IConsumerCredentialsRetriever CredentialsRetriever { get; set; }

        public WebAccessTokenRetriever(IConsumerCredentialsRetriever consumerCredentialsRetriever)
        {
            CredentialsRetriever = consumerCredentialsRetriever;
        }

        // TODO 1: add tests
        public async Task<OAuthToken> GetAccessTokenAsync(CancellationToken cancellationToken)
        {
            var requestToken = await GetRequestTokenAsync(cancellationToken);
            var authorizedRequestToken = await AuthorizeRequestToken(requestToken, cancellationToken);
            var accessToken = await ExchangeForAccessToken(authorizedRequestToken, cancellationToken);

            Trace.TraceInformation("Access Token: {0}", accessToken);

            return accessToken;
        }

        private async Task<OAuthToken> GetRequestTokenAsync(CancellationToken cancellationToken)
        {
            OAuthToken requestToken;

            var credentials = await CredentialsRetriever.GetConsumerCredentialsAsync(cancellationToken);

            // TODO 3: create a pull request to add RequestURL param to method, since it is required
            var oauthPreparer = OAuthRequest.ForRequestToken(
                credentials.Key, credentials.Secret, callbackUrl: "http://localhost:1895");
            oauthPreparer.RequestUrl = "https://www.khanacademy.org/api/auth2/request_token";

            using (var client = new HttpClient())
            {
                var path = "https://www.khanacademy.org/api/auth2/request_token" + "?" + oauthPreparer.GetAuthorizationQuery();
                using (var response = await client.GetAsync(path, cancellationToken))
                {
                    var body = (response.Content != null) ? await response.Content.ReadAsStringAsync() : "";
                    // TODO 2: This would be nice except for the fact that there is no easy way to customize the parameter binding name
                    //// find out how to do var value = response.Content.ReadAsAsync<OAuthResponseToken>();
                    //// var foo = new System.Net.Http.Formatting.FormDataCollection(body).ReadAs<OAuthResponseToken>();
                    var value = new FormDataCollection(body).ReadAsNameValueCollection();
                    requestToken = new OAuthToken(
                        value["oauth_token"],
                        value["oauth_token_secret"]);
                }
            }

            return requestToken;
        }

        private async Task<OAuthAuthorizedToken> AuthorizeRequestToken(OAuthToken requestToken, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            // TODO 3: pull request WithExtraMessageOf should take in a string
            var isElevated = new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
            Ensure.That(isElevated, nameof(isElevated))
                .WithExtraMessageOf(() => "Must run with administrator privileges to start server")
                .IsTrue();

            OAuthAuthorizedToken authorizedRequestToken;

            // open browser to allow user to accept access
            var urlToOpenInBrowser = "https://www.khanacademy.org/api/auth2/authorize?oauth_token=" + requestToken.Token;
            var proc = new Process();
            proc.StartInfo = new ProcessStartInfo(urlToOpenInBrowser);
            proc.Start();

            // start server to listen for callback when user accepts access
            using (var server = new HttpListener())
            {
                server.Prefixes.Add("http://*:1895/");
                server.Start();

                // Process request
                var context = server.GetContext();
                var request = context.Request;
                var response = context.Response;

                var value = new FormDataCollection(request.Url.Query.TrimStart('?')).ReadAsNameValueCollection();
                authorizedRequestToken = new OAuthAuthorizedToken(
                    value["oauth_token"],
                    value["oauth_token_secret"],
                    value["oauth_verifier"]);

                var buffer = Encoding.UTF8.GetBytes("done, you may now close the browser");
                response.OutputStream.Write(buffer, 0, buffer.Length);
                response.OutputStream.Close();

                // give time for server to respond to request before disposing
                await Task.Factory.StartNew(() => { Thread.Sleep(1000); });
            }

            return authorizedRequestToken;
        }

        private async Task<OAuthToken> ExchangeForAccessToken(OAuthAuthorizedToken authorizedRequestToken, CancellationToken cancellationToken)
        {
            OAuthToken accessToken;

            var credentials = await CredentialsRetriever.GetConsumerCredentialsAsync(cancellationToken);
            var accessTokenRequest = OAuthRequest.ForAccessToken(
                credentials.Key, credentials.Secret, authorizedRequestToken.Token, authorizedRequestToken.Secret, authorizedRequestToken.Verifier);
            accessTokenRequest.RequestUrl = "https://www.khanacademy.org/api/auth2/access_token";

            using (var client = new HttpClient())
            {
                var path = "https://www.khanacademy.org/api/auth2/access_token" + "?" + accessTokenRequest.GetAuthorizationQuery();
                using (var response = await client.GetAsync(path, cancellationToken))
                {
                    var body = await response.Content.ReadAsStringAsync();
                    var value = new FormDataCollection(body).ReadAsNameValueCollection();
                    accessToken = new OAuthToken(
                        value["oauth_token"],
                        value["oauth_token_secret"]);
                }
            }

            return accessToken;
        }
    }
}
