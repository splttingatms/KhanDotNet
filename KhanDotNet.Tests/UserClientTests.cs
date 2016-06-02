﻿using KhanDotNet.Library;
using KhanDotNet.Library.Utilities;
using KhanDotNet.Tests.Data;
using KhanDotNet.Tests.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Net;
using System.Net.Http;
using System.Threading;
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
                .Setup(c => c.GetAsync(It.IsAny<string>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(_khanResponse);

            _accessToken = new OAuthToken("fakeToken", "fakeSecret");

            _authenticator = new Mock<IAuthentication>();
            _authenticator
                .Setup(c => c.GetAccessTokenAsync(It.IsAny<CancellationToken>()))
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

        [TestMethod]
        [ExpectedExceptionWithMessage(typeof(InvalidOperationException), "Authenticated APIs require an authenticator", match: false, ignoreCase: true)]
        public async Task GetUserShouldThrowIfNoAuthenticatorWasGiven()
        {
            _client = new UserClient(_httpClientMock.Object, null, _credentials);
            await _client.GetUserAsync();
        }

        [TestMethod]
        [ExpectedExceptionWithMessage(typeof(InvalidOperationException), "Authenticated APIs require consumer credentials", match: false, ignoreCase: true)]
        public async Task GetUserShouldThrowIfNoConsumerCredentialsWereGiven()
        {
            _client = new UserClient(_httpClientMock.Object, _authenticator.Object, null);
            await _client.GetUserAsync();
        }

        [TestMethod]
        public async Task GetUserShouldRequestAccessToken()
        {
            await _client.GetUserAsync();
            _authenticator.Verify(a => a.GetAccessTokenAsync(It.IsAny<CancellationToken>()), Times.Once);
        }

        [TestMethod]
        public async Task GetUserShouldTargetCorrectPath()
        {
            await _client.GetUserAsync();

            _httpClientMock.Verify(c => c.GetAsync(
                It.Is<string>(url => url.ContainsIgnoreCase("/api/v1/user")),
                It.IsAny<CancellationToken>()));
        }

        [TestMethod]
        public async Task GetUserShouldPassAuthenticationParameters()
        {
            await _client.GetUserAsync();

            // request must contains parameters specified in documentation
            // https://github.com/Khan/khan-api/wiki/Khan-Academy-API-Authentication#4-make-an-authenticated-api-call
            // NOTE: "oauth_token" is not actually required!
            _httpClientMock.Verify(c => c.GetAsync(
                It.Is<string>(url =>
                    url.ContainsIgnoreCase("oauth_consumer_key") &&
                    url.ContainsIgnoreCase("oauth_nonce") &&
                    url.ContainsIgnoreCase("oauth_version") &&
                    url.ContainsIgnoreCase("oauth_signature") &&
                    url.ContainsIgnoreCase("oauth_signature_method") &&
                    url.ContainsIgnoreCase("oauth_timestamp")),
                It.IsAny<CancellationToken>()));
        }
        
        [TestMethod]
        public async Task GetUserShouldReturnDeserializedResult()
        {
            var expected = UserTestData.SampleUser;
            _khanResponse.Content = new JsonContent(UserTestData.SampleUserJson);

            var actual = await _client.GetUserAsync();

            expected.AssertDeepEqual(actual);
        }

        [TestMethod]
        public async Task GetUserShouldPassThroughTokenToHttpClient()
        {
            var expectedToken = new CancellationToken(true);

            await _client.GetUserAsync(expectedToken);

            _httpClientMock.Verify(c =>
                c.GetAsync(
                    It.IsAny<string>(),
                    It.Is<CancellationToken>(actualToken => actualToken.Equals(expectedToken))));
        }

        [TestMethod]
        public async Task GetUserShouldPassEmptyTokenToHttpClient()
        {
            var expectedToken = CancellationToken.None;

            await _client.GetUserAsync();

            _httpClientMock.Verify(c =>
                c.GetAsync(
                    It.IsAny<string>(),
                    It.Is<CancellationToken>(actualToken => actualToken.Equals(expectedToken))));
        }

        #endregion

        #region GetUserExercises

        [TestMethod]
        [ExpectedExceptionWithMessage(typeof(InvalidOperationException), "Authenticated APIs require an authenticator", match: false, ignoreCase: true)]
        public async Task GetUserExercisesShouldThrowIfNoAuthenticatorWasGiven()
        {
            _client = new UserClient(_httpClientMock.Object, null, _credentials);
            await _client.GetUserExercisesAsync();
        }

        [TestMethod]
        [ExpectedExceptionWithMessage(typeof(InvalidOperationException), "Authenticated APIs require consumer credentials", match: false, ignoreCase: true)]
        public async Task GetUserExercisesShouldThrowIfNoConsumerCredentialsWereGiven()
        {
            _client = new UserClient(_httpClientMock.Object, _authenticator.Object, null);
            await _client.GetUserExercisesAsync();
        }

        [TestMethod]
        public async Task GetUserExercisesShouldRequestAccessToken()
        {
            await _client.GetUserExercisesAsync();
            _authenticator.Verify(a => a.GetAccessTokenAsync(It.IsAny<CancellationToken>()), Times.Once);
        }

        [TestMethod]
        public async Task GetUserExercisesShouldTargetCorrectPath()
        {
            await _client.GetUserExercisesAsync();

            _httpClientMock.Verify(c => c.GetAsync(
                It.Is<string>(url => url.ContainsIgnoreCase("/api/v1/user/exercises")),
                It.IsAny<CancellationToken>()));
        }

        [TestMethod]
        public async Task GetUserExercisesShouldPassAuthenticationParameters()
        {
            await _client.GetUserExercisesAsync();

            // request must contains parameters specified in documentation
            // https://github.com/Khan/khan-api/wiki/Khan-Academy-API-Authentication#4-make-an-authenticated-api-call
            // NOTE: "oauth_token" is not actually required!
            _httpClientMock.Verify(c => c.GetAsync(
                It.Is<string>(url =>
                    url.ContainsIgnoreCase("oauth_consumer_key") &&
                    url.ContainsIgnoreCase("oauth_nonce") &&
                    url.ContainsIgnoreCase("oauth_version") &&
                    url.ContainsIgnoreCase("oauth_signature") &&
                    url.ContainsIgnoreCase("oauth_signature_method") &&
                    url.ContainsIgnoreCase("oauth_timestamp")),
                It.IsAny<CancellationToken>()));
        }

        [TestMethod]
        public async Task GetUserExercisesShouldReturnDeserializedResult()
        {
            var expected = UserTestData.SampleUserExercises;
            _khanResponse.Content = new JsonContent(UserTestData.SampleUserExercisesJson);

            var actual = await _client.GetUserExercisesAsync();

            expected.AssertDeepEqual(actual);
        }

        [TestMethod]
        public async Task GetUserExercisesShouldPassThroughTokenToHttpClient()
        {
            var expectedToken = new CancellationToken(true);

            await _client.GetUserExercisesAsync(expectedToken);

            _httpClientMock.Verify(c =>
                c.GetAsync(
                    It.IsAny<string>(),
                    It.Is<CancellationToken>(actualToken => actualToken.Equals(expectedToken))));
        }

        [TestMethod]
        public async Task GetUserExercisesShouldPassEmptyTokenToHttpClient()
        {
            var expectedToken = CancellationToken.None;

            await _client.GetUserExercisesAsync();

            _httpClientMock.Verify(c =>
                c.GetAsync(
                    It.IsAny<string>(),
                    It.Is<CancellationToken>(actualToken => actualToken.Equals(expectedToken))));
        }

        #endregion

        #region GetUserExercise

        [TestMethod]
        [ExpectedExceptionWithMessage(typeof(InvalidOperationException), "Authenticated APIs require an authenticator", match: false, ignoreCase: true)]
        public async Task GetUserExerciseShouldThrowIfNoAuthenticatorWasGiven()
        {
            _client = new UserClient(_httpClientMock.Object, null, _credentials);
            await _client.GetUserExerciseAsync("permutations_1");
        }

        [TestMethod]
        [ExpectedExceptionWithMessage(typeof(InvalidOperationException), "Authenticated APIs require consumer credentials", match: false, ignoreCase: true)]
        public async Task GetUserExerciseShouldThrowIfNoConsumerCredentialsWereGiven()
        {
            _client = new UserClient(_httpClientMock.Object, _authenticator.Object, null);
            await _client.GetUserExerciseAsync("permutations_1");
        }

        [TestMethod]
        public async Task GetUserExerciseShouldRequestAccessToken()
        {
            await _client.GetUserExerciseAsync("permutations_1");
            _authenticator.Verify(a => a.GetAccessTokenAsync(It.IsAny<CancellationToken>()), Times.Once);
        }

        [TestMethod]
        [ExpectedExceptionWithMessage(typeof(ArgumentException), "exerciseName", match: false, ignoreCase: true)]
        public async Task GetUserExerciseShouldThrowIfNullNameGiven()
        {
            await _client.GetUserExerciseAsync(exerciseName: null);
        }

        [TestMethod]
        public async Task GetUserExerciseShouldEncodeInput()
        {
            var input = "^foo&bar$";
            var encodedInput = "%5Efoo%26bar%24";

            await _client.GetUserExerciseAsync(input);

            _httpClientMock.Verify(c => c.GetAsync(
                It.Is<string>(url => url.ContainsIgnoreCase(encodedInput)),
                It.IsAny<CancellationToken>()));
        }

        [TestMethod]
        public async Task GetUserExerciseShouldTargetCorrectPath()
        {
            await _client.GetUserExerciseAsync("permutations_1");

            _httpClientMock.Verify(c => c.GetAsync(
                It.Is<string>(url => url.ContainsIgnoreCase("/api/v1/user/exercises/permutations_1")),
                It.IsAny<CancellationToken>()));
        }

        [TestMethod]
        public async Task GetUserExerciseShouldReturnDeserializedResult()
        {
            var expected = UserTestData.SampleUserExercise;
            _khanResponse.Content = new JsonContent(UserTestData.SampleUserExerciseJson);

            var actual = await _client.GetUserExerciseAsync("permutations_1");

            expected.AssertDeepEqual(actual);
        }

        [TestMethod]
        public async Task GetUserExerciseShouldPassAuthenticationParameters()
        {
            await _client.GetUserExerciseAsync("permutations_1");

            // request must contains parameters specified in documentation
            // https://github.com/Khan/khan-api/wiki/Khan-Academy-API-Authentication#4-make-an-authenticated-api-call
            // NOTE: "oauth_token" is not actually required!
            _httpClientMock.Verify(c => c.GetAsync(
                It.Is<string>(url =>
                    url.ContainsIgnoreCase("oauth_consumer_key") &&
                    url.ContainsIgnoreCase("oauth_nonce") &&
                    url.ContainsIgnoreCase("oauth_version") &&
                    url.ContainsIgnoreCase("oauth_signature") &&
                    url.ContainsIgnoreCase("oauth_signature_method") &&
                    url.ContainsIgnoreCase("oauth_timestamp")),
                It.IsAny<CancellationToken>()));
        }

        [TestMethod]
        public async Task GetUserExerciseShouldPassThroughTokenToHttpClient()
        {
            var expectedToken = new CancellationToken(true);

            await _client.GetUserExerciseAsync("permutations_1", expectedToken);

            _httpClientMock.Verify(c => c.GetAsync(
                    It.IsAny<string>(),
                    It.Is<CancellationToken>(actualToken => actualToken.Equals(expectedToken))));
        }

        [TestMethod]
        public async Task GetUserExerciseShouldPassEmptyTokenToHttpClient()
        {
            var expectedToken = CancellationToken.None;

            await _client.GetUserExerciseAsync("permutations_1");

            _httpClientMock.Verify(c => c.GetAsync(
                    It.IsAny<string>(),
                    It.Is<CancellationToken>(actualToken => actualToken.Equals(expectedToken))));
        }

        #endregion

        #region GetUserExerciseProblemLogs

        // TODO 1: create attribute that does not match exactly and ignores case
        [TestMethod]
        [ExpectedExceptionWithMessage(typeof(InvalidOperationException), "Authenticated APIs require an authenticator", match: false, ignoreCase: true)]
        public async Task GetUserExerciseProblemLogsShouldThrowIfNoAuthenticatorWasGiven()
        {
            _client = new UserClient(_httpClientMock.Object, null, _credentials);
            await _client.GetUserExerciseProblemLogsAsync("permutations_1");
        }

        [TestMethod]
        [ExpectedExceptionWithMessage(typeof(InvalidOperationException), "Authenticated APIs require consumer credentials", match: false, ignoreCase: true)]
        public async Task GetUserExerciseProblemLogsShouldThrowIfNoConsumerCredentialsWereGiven()
        {
            _client = new UserClient(_httpClientMock.Object, _authenticator.Object, null);
            await _client.GetUserExerciseProblemLogsAsync("permutations_1");
        }

        [TestMethod]
        public async Task GetUserExerciseProblemLogsShouldRequestAccessToken()
        {
            await _client.GetUserExerciseProblemLogsAsync("permutations_1");
            _authenticator.Verify(a => a.GetAccessTokenAsync(It.IsAny<CancellationToken>()), Times.Once);
        }

        [TestMethod]
        [ExpectedExceptionWithMessage(typeof(ArgumentException), "exerciseName", match: false, ignoreCase: true)]
        public async Task GetUserExerciseProblemLogsShouldThrowIfNullNameGiven()
        {
            await _client.GetUserExerciseProblemLogsAsync(exerciseName: null);
        }

        [TestMethod]
        public async Task GetUserExerciseProblemLogsShouldEncodeInput()
        {
            var input = "^foo&bar$";
            var encodedInput = "%5Efoo%26bar%24";

            await _client.GetUserExerciseProblemLogsAsync(input);

            _httpClientMock.Verify(c => c.GetAsync(
                It.Is<string>(url => url.ContainsIgnoreCase(encodedInput)),
                It.IsAny<CancellationToken>()));
        }

        [TestMethod]
        public async Task GetUserExerciseProblemLogsShouldTargetCorrectPath()
        {
            await _client.GetUserExerciseProblemLogsAsync("permutations_1");

            _httpClientMock.Verify(c => c.GetAsync(
                It.Is<string>(url => url.ContainsIgnoreCase("/api/v1/user/exercises/permutations_1/log")),
                It.IsAny<CancellationToken>()));
        }

        [TestMethod]
        public async Task GetUserProblemLogsShouldReturnDeserializedResult()
        {
            var expected = UserTestData.SampleUserExerciseProblemLogs;
            _khanResponse.Content = new JsonContent(UserTestData.SampleUserExerciseProblemLogsJson);

            var actual = await _client.GetUserExerciseProblemLogsAsync("permutations_1");

            expected.AssertDeepEqual(actual);
        }

        [TestMethod]
        public async Task GetUserExerciseProblemLogsShouldPassAuthenticationParameters()
        {
            await _client.GetUserExerciseProblemLogsAsync("permutations_1");

            // request must contains parameters specified in documentation
            // https://github.com/Khan/khan-api/wiki/Khan-Academy-API-Authentication#4-make-an-authenticated-api-call
            // NOTE: "oauth_token" is not actually required!
            _httpClientMock.Verify(c => c.GetAsync(
                It.Is<string>(url =>
                    url.ContainsIgnoreCase("oauth_consumer_key") &&
                    url.ContainsIgnoreCase("oauth_nonce") &&
                    url.ContainsIgnoreCase("oauth_version") &&
                    url.ContainsIgnoreCase("oauth_signature") &&
                    url.ContainsIgnoreCase("oauth_signature_method") &&
                    url.ContainsIgnoreCase("oauth_timestamp")),
                It.IsAny<CancellationToken>()));
        }

        [TestMethod]
        public async Task GetUserExerciseProblemLogsShouldPassThroughTokenToHttpClient()
        {
            var expectedToken = new CancellationToken(true);

            await _client.GetUserExerciseProblemLogsAsync("permutations_1", expectedToken);

            _httpClientMock.Verify(c => c.GetAsync(
                    It.IsAny<string>(),
                    It.Is<CancellationToken>(actualToken => actualToken.Equals(expectedToken))));
        }

        [TestMethod]
        public async Task GetUserExerciseProblemLogsShouldPassEmptyTokenToHttpClient()
        {
            var expectedToken = CancellationToken.None;

            await _client.GetUserExerciseProblemLogsAsync("permutations_1");

            _httpClientMock.Verify(c => c.GetAsync(
                    It.IsAny<string>(),
                    It.Is<CancellationToken>(actualToken => actualToken.Equals(expectedToken))));
        }

        #endregion
    }
}
