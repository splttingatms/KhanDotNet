using KhanDotNet.Library;
using KhanDotNet.Library.Authentication;
using KhanDotNet.Tests.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace KhanDotNet.Tests
{
    [TestClass]
    public class AuthenticatorTests
    {
        private Mock<IConsumerCredentialsRetriever> _mockConsumerCredentialsRetriever;

        private Mock<IAccessTokenRetriever> _mockAccessTokenRetriever;

        private IAuthenticator _authenticator;

        [TestInitialize]
        public void TestInitialize()
        {
            _mockConsumerCredentialsRetriever = new Mock<IConsumerCredentialsRetriever>(MockBehavior.Strict);
            _mockConsumerCredentialsRetriever
                .Setup(r => r.GetConsumerCredentialsAsync(It.IsAny<CancellationToken>()))
                .ReturnsAsync(new ConsumerCredentials("key", "secret"));

            _mockAccessTokenRetriever = new Mock<IAccessTokenRetriever>(MockBehavior.Strict);
            _mockAccessTokenRetriever
                .Setup(r => r.GetAccessTokenAsync(It.IsAny<CancellationToken>()))
                .ReturnsAsync(new OAuthToken("token", "secret"));

            _authenticator = new Authenticator(_mockConsumerCredentialsRetriever.Object, _mockAccessTokenRetriever.Object);
        }

        #region constructor

        [TestMethod]
        [ExpectedExceptionWithSubstring(typeof(ArgumentNullException), "consumerCredentialsRetriever")]
        public void AuthenticatorConstructorShouldThrowIfConsumerCredentialsRetrieverIsNull()
        {
            new Authenticator(consumerCredentialsRetriever: null, accessTokenRetriever: _mockAccessTokenRetriever.Object);
        }

        [TestMethod]
        [ExpectedExceptionWithSubstring(typeof(ArgumentNullException), "accessTokenRetriever")]
        public void AuthenticatorConstructorShouldThrowIfAccessTokenRetrieverIsNull()
        {
            new Authenticator(_mockConsumerCredentialsRetriever.Object, accessTokenRetriever: null);
        }

        #endregion

        #region CreateAuthenticatedRequestPath

        [TestMethod]
        [ExpectedExceptionWithSubstring(typeof(ArgumentException), "url")]
        public async Task CreateAuthenticatedPathShouldThrowIfUrlNull()
        {
            await _authenticator.CreateAuthenticatedRequestPath(null, CancellationToken.None);
        }

        [TestMethod]
        public async Task CreateAuthenticatedPathShouldGetConsumerCredentials()
        {
            await _authenticator.CreateAuthenticatedRequestPath("http://khanacademy.org", CancellationToken.None);
            _mockConsumerCredentialsRetriever.Verify(r => r.GetConsumerCredentialsAsync(It.IsAny<CancellationToken>()), Times.Once);
        }

        [TestMethod]
        public async Task CreateAuthenticatedPathShouldGetAccessToken()
        {
            await _authenticator.CreateAuthenticatedRequestPath("http://khanacademy.org", CancellationToken.None);
            _mockAccessTokenRetriever.Verify(r => r.GetAccessTokenAsync(It.IsAny<CancellationToken>()), Times.Once);
        }

        [TestMethod]
        public async Task CreateAuthenticatedPathShouldAddAuthenticationParameters()
        {
            // request must contains parameters specified in documentation
            // https://github.com/Khan/khan-api/wiki/Khan-Academy-API-Authentication#4-make-an-authenticated-api-call
            // NOTE: "oauth_token" is not actually required!
            var actual = await _authenticator.CreateAuthenticatedRequestPath("http://khanacademy.org", CancellationToken.None);
            StringAssert.Contains(actual, "oauth_consumer_key");
            StringAssert.Contains(actual, "oauth_nonce");
            StringAssert.Contains(actual, "oauth_version");
            StringAssert.Contains(actual, "oauth_signature");
            StringAssert.Contains(actual, "oauth_signature_method");
            StringAssert.Contains(actual, "oauth_timestamp");
        }

        [TestMethod]
        public async Task CreateAuthenticatedPathShouldContainOriginalUrl()
        {
            var actual = await _authenticator.CreateAuthenticatedRequestPath("http://khanacademy.org", CancellationToken.None);
            StringAssert.Contains(actual, "http://khanacademy.org");
        }

        #endregion
    }
}
