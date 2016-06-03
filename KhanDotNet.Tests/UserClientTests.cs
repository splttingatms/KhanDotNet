﻿using KhanDotNet.Library;
using KhanDotNet.Library.Authentication;
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

        private Mock<IAuthenticator> _authenticator;

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

            _authenticator = new Mock<IAuthenticator>();
            _authenticator
                .Setup(c => c.CreateAuthenticatedRequestPath(It.IsAny<string>(), It.IsAny<CancellationToken>()))
                .Returns<string, CancellationToken>((url, token) => Task.FromResult(url)); // Mirror input path to output value

            _client = new UserClient(_httpClientMock.Object, _authenticator.Object);
        }

        [TestCleanup]
        public void Cleanup()
        {
            _khanResponse?.Dispose();
            _khanResponse = null;

            _client?.Dispose();
            _client = null;
        }

        #region Constructor

        [TestMethod]
        [ExpectedExceptionWithSubstring(typeof(ArgumentNullException), "authenticator")]
        public void UserClientConstructorShouldThrowIfNoAuthenticatorIsGiven()
        {
            _client = new UserClient(_httpClientMock.Object, authenticator: null);
        }

        #endregion

        #region GetUser

        [TestMethod]
        public async Task GetUserShouldAuthenticatePath()
        {
            // TODO 1: verify path matches target API
            await _client.GetUserAsync();
            _authenticator.Verify(a => a.CreateAuthenticatedRequestPath(It.IsAny<string>(), It.IsAny<CancellationToken>()), Times.Once);
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
        public async Task GetUserShouldReturnDeserializedResult()
        {
            var expected = UserTestData.SampleUser;
            _khanResponse.Content = new JsonContent(UserTestData.SampleUserJson);

            var actual = await _client.GetUserAsync();

            expected.AssertDeepEqual(actual);
        }

        [TestMethod]
        public async Task GetUserShouldPassTokenThroughToHttpClient()
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
        public async Task GetUserExercisesShouldAuthenticatePath()
        {
            await _client.GetUserExercisesAsync();
            _authenticator.Verify(a => a.CreateAuthenticatedRequestPath(It.IsAny<string>(), It.IsAny<CancellationToken>()), Times.Once);
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
        public async Task GetUserExerciseShouldAuthenticatePath()
        {
            await _client.GetUserExerciseAsync("permutations_1");
            _authenticator.Verify(a => a.CreateAuthenticatedRequestPath(It.IsAny<string>(), It.IsAny<CancellationToken>()), Times.Once);
        }

        [TestMethod]
        [ExpectedExceptionWithSubstring(typeof(ArgumentException), "exerciseName")]
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

        [TestMethod]
        public async Task GetUserExerciseProblemLogsShouldAuthenticatePath()
        {
            await _client.GetUserExerciseProblemLogsAsync("permutations_1");
            _authenticator.Verify(a => a.CreateAuthenticatedRequestPath(
                It.IsAny<string>(), It.IsAny<CancellationToken>()), Times.Once);
        }

        [TestMethod]
        [ExpectedExceptionWithSubstring(typeof(ArgumentException), "exerciseName")]
        public async Task GetUserExerciseProblemLogsShouldThrowIfNullNameGiven()
        {
            await _client.GetUserExerciseProblemLogsAsync(exerciseName: null);
        }

        [TestMethod]
        public async Task GetUserExerciseProblemLogsShouldEncodeInput()
        {
            await _client.GetUserExerciseProblemLogsAsync("^foo&bar$");

            _httpClientMock.Verify(c => c.GetAsync(
                It.Is<string>(url => url.ContainsIgnoreCase("%5Efoo%26bar%24")),
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

        #region GetUserProgressChanges

        [TestMethod]
        public async Task GetUserProgressShouldAuthenticate()
        {
            await _client.GetUserProgressChangesAsync();

            _authenticator.Verify(a => a.CreateAuthenticatedRequestPath(
                It.IsAny<string>(), It.IsAny<CancellationToken>()), Times.Once);
        }

        [TestMethod]
        public async Task GetUserProgressShouldTargetCorrectPath()
        {
            await _client.GetUserProgressChangesAsync();

            _httpClientMock.Verify(c => c.GetAsync(
                It.Is<string>(url => url.ContainsIgnoreCase("/api/v1/user/exercises/progress_changes")),
                It.IsAny<CancellationToken>()));
        }

        [TestMethod]
        public async Task GetUserProgressShouldReturnDeserializedResult()
        {
            var expected = UserTestData.SampleUserProgressChanges;
            _khanResponse.Content = new JsonContent(UserTestData.SampleUserProgressChangesJson);

            var actual = await _client.GetUserProgressChangesAsync();

            expected.AssertDeepEqual(actual);
        }

        [TestMethod]
        public async Task GetUserProgressShouldPassThroughTokenToHttpClient()
        {
            var expectedToken = new CancellationToken(true);

            await _client.GetUserProgressChangesAsync(expectedToken);

            _httpClientMock.Verify(c => c.GetAsync(
                    It.IsAny<string>(),
                    It.Is<CancellationToken>(actualToken => actualToken.Equals(expectedToken))));
        }

        [TestMethod]
        public async Task GetUserProgressShouldPassEmptyTokenToHttpClient()
        {
            var expectedToken = CancellationToken.None;

            await _client.GetUserProgressChangesAsync();

            _httpClientMock.Verify(c => c.GetAsync(
                    It.IsAny<string>(),
                    It.Is<CancellationToken>(actualToken => actualToken.Equals(expectedToken))));
        }

        #endregion

        #region GetUserWatchedVideos

        [TestMethod]
        public async Task GetWatchedVideosShouldTargetCorrectPath()
        {
            await _client.GetUserWatchedVideosAsync();

            _httpClientMock.Verify(c => c.GetAsync(
                It.Is<string>(url => url.ContainsIgnoreCase("/api/v1/user/videos")),
                It.IsAny<CancellationToken>()));
        }

        [TestMethod]
        public async Task GetWatchedVideosShouldAuthenticate()
        {
            await _client.GetUserWatchedVideosAsync();

            _authenticator.Verify(a =>
                a.CreateAuthenticatedRequestPath(
                    It.IsAny<string>(),
                    It.IsAny<CancellationToken>()),
                Times.Once);
        }

        [TestMethod]
        public async Task GetWatchedVideosShouldReturnDeserializedResult()
        {
            var expected = UserTestData.SampleUserWatchedVideos;
            _khanResponse.Content = new JsonContent(UserTestData.SampleUserWatchedVideosJson);

            var actual = await _client.GetUserWatchedVideosAsync();

            expected.AssertDeepEqual(actual);
        }

        [TestMethod]
        public async Task GetWatchedVideosShouldPassThroughTokenToHttpClient()
        {
            var expectedToken = new CancellationToken(true);

            await _client.GetUserWatchedVideosAsync(expectedToken);

            _httpClientMock.Verify(c => c.GetAsync(
                    It.IsAny<string>(),
                    It.Is<CancellationToken>(actualToken => actualToken.Equals(expectedToken))));
        }

        [TestMethod]
        public async Task GetWatchedVideosShouldPassEmptyTokenToHttpClient()
        {
            var expectedToken = CancellationToken.None;

            await _client.GetUserWatchedVideosAsync();

            _httpClientMock.Verify(c => c.GetAsync(
                    It.IsAny<string>(),
                    It.Is<CancellationToken>(actualToken => actualToken.Equals(expectedToken))));
        }

        #endregion
    }
}
