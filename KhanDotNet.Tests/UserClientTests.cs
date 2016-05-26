using KhanDotNet.Library;
using KhanDotNet.Library.Utilities;
using KhanDotNet.Tests.Data;
using KhanDotNet.Tests.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace KhanDotNet.Tests
{
    [TestClass]
    public class UserClientTests
    {
        private HttpResponseMessage _khanResponse;

        private Mock<IHttpClient> _httpClientMock;

        private OAuthToken _accessToken;

        private Mock<IAuthentication> _authenticator;

        private ConsumerCredentials _credentials;

        private IUserClient _client;

        // TODO 3: move common test code to base test class
        [TestInitialize]
        public void Initialize()
        {
            _khanResponse = new HttpResponseMessage()
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent("")
            };

            _httpClientMock = new Mock<IHttpClient>();
            _httpClientMock
                .Setup(c => c.GetAsync(It.IsAny<string>()))
                .ReturnsAsync(_khanResponse);

            _accessToken = new OAuthToken("fakeToken", "fakeSecret");

            _authenticator = new Mock<IAuthentication>();
            _authenticator
                .Setup(c => c.GetAccessTokenAsync())
                .ReturnsAsync(_accessToken);

            _credentials = new ConsumerCredentials("fakeKey", "fakeSecret");

            _client = new UserClient(_httpClientMock.Object, _authenticator.Object, _credentials);
        }

        [TestCleanup]
        public void Cleanup()
        {
            _khanResponse?.Dispose();
            _khanResponse = null;

            _client?.Dispose();
            _client = null;
        }

        #region GetUser

        // TODO 2: verify message contains param name
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public async Task GetUserShouldThrowIfNoAuthenticatorWasGiven()
        {
            _client = new UserClient(_httpClientMock.Object, null, _credentials);
            await _client.GetUserAsync();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public async Task GetUserShouldThrowIfNoConsumerCredentialsWereGiven()
        {
            _client = new UserClient(_httpClientMock.Object, _authenticator.Object, null);
            await _client.GetUserAsync();
        }

        [TestMethod]
        public async Task GetUserShouldRequestAccessToken()
        {
            await _client.GetUserAsync();
            _authenticator.Verify(a => a.GetAccessTokenAsync(), Times.Once);
        }

        [TestMethod]
        public async Task GetUserShouldTargetCorrectPath()
        {
            await _client.GetUserAsync();

            _httpClientMock.Verify(c =>
                c.GetAsync(It.Is<string>(url => url.ContainsIgnoreCase("/api/v1/user"))));
        }

        [TestMethod]
        public async Task GetUserShouldPassAuthenticationParameters()
        {
            await _client.GetUserAsync();

            // request must contains parameters specified in documentation
            // https://github.com/Khan/khan-api/wiki/Khan-Academy-API-Authentication#4-make-an-authenticated-api-call
            // NOTE: "oauth_token" is not actually required!
            _httpClientMock.Verify(c =>
                c.GetAsync(It.Is<string>(url =>
                    url.ContainsIgnoreCase("oauth_consumer_key") &&
                    url.ContainsIgnoreCase("oauth_nonce") &&
                    url.ContainsIgnoreCase("oauth_version") &&
                    url.ContainsIgnoreCase("oauth_signature") &&
                    url.ContainsIgnoreCase("oauth_signature_method") &&
                    url.ContainsIgnoreCase("oauth_timestamp"))));
        }
        
        [TestMethod]
        public async Task GetUserShouldReturnDeserializedResult()
        {
            var expected = UserTestData.SampleUser;
            _khanResponse.Content = new JsonContent(UserTestData.SampleUserJson);

            var actual = await _client.GetUserAsync();

            expected.AssertDeepEqual(actual);
        }

        #endregion
    }
}
