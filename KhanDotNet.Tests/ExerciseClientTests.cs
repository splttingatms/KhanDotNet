using KhanDotNet.Library;
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
    public class ExerciseClientTests
    {
        private HttpResponseMessage _khanResponse;

        private Mock<IHttpClient> _httpClientMock;

        private IExerciseClient _client;

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

            _client = new ExerciseClient(_httpClientMock.Object);
        }

        [TestCleanup]
        public void Cleanup()
        {
            _khanResponse?.Dispose();
            _client?.Dispose();
        }

        #region GetExercises

        [TestMethod]
        public async Task GetExercisesShouldTargetCorrectApiPath()
        {
            var expectedPath = "api/v1/exercises";

            await _client.GetExercisesAsync();

            _httpClientMock.Verify(c => c.GetAsync(
                It.Is<string>(url => url.ContainsIgnoreCase(expectedPath)),
                It.IsAny<CancellationToken>()));
        }

        [TestMethod]
        public async Task GetExercisesShouldReturnDeserializedExercises()
        {
            _khanResponse.Content = new JsonContent(ExerciseTestData.SampleExercisesJson);

            var expected = ExerciseTestData.SampleExercises;
            var actual = await _client.GetExercisesAsync();

            expected.AssertDeepEqual(actual);
        }

        [TestMethod]
        public async Task GetExercisesShouldPassThroughTokenToHttpClient()
        {
            var expectedToken = new CancellationToken(true);

            await _client.GetExercisesAsync(expectedToken);

            _httpClientMock.Verify(c =>
                c.GetAsync(
                    It.IsAny<string>(),
                    It.Is<CancellationToken>(actualToken => actualToken.Equals(expectedToken))));
        }

        [TestMethod]
        public async Task GetExercisesShouldPassEmptyTokenToHttpClient()
        {
            var expectedToken = CancellationToken.None;

            await _client.GetExercisesAsync();

            _httpClientMock.Verify(c =>
                c.GetAsync(
                    It.IsAny<string>(),
                    It.Is<CancellationToken>(actualToken => actualToken.Equals(expectedToken))));
        }

        #endregion

        #region GetExercise

        [TestMethod]
        public async Task GetExerciseShouldMakeGetRequest()
        {
            await _client.GetExerciseAsync("foo");
            _httpClientMock.Verify(c => c.GetAsync(
                It.IsAny<string>(),
                It.IsAny<CancellationToken>()), Times.Once);
        }

        [TestMethod]
        public async Task GetExerciseShouldReturnDeserializedExercise()
        {
            _khanResponse.Content = new JsonContent(ExerciseTestData.CountingExerciseJson);

            var expected = ExerciseTestData.CountingExercise;
            var actual = await _client.GetExerciseAsync("counting-out-1-20-objects");

            expected.AssertDeepEqual(actual);
        }

        [TestMethod]
        public async Task GetExerciseShouldUrlEncodeInput()
        {
            var input = "^foo&bar$";
            var encodedInput = "%5Efoo%26bar%24";

            await _client.GetExerciseAsync(input);
            _httpClientMock.Verify(c => c.GetAsync(
                It.Is<string>(url => url.ContainsIgnoreCase(encodedInput)),
                It.IsAny<CancellationToken>()));
        }

        [TestMethod]
        [ExpectedExceptionWithSubstring(typeof(ArgumentException), "name")]
        public async Task GetExerciseShouldThrowIfNullInput()
        {
            await _client.GetExerciseAsync(name: null);
        }

        [TestMethod]
        [ExpectedExceptionWithSubstring(typeof(ArgumentException), "name")]
        public async Task GetExerciseShouldThrowIfEmptyInput()
        {
            await _client.GetExerciseAsync(name: string.Empty);
        }

        [TestMethod]
        [ExpectedExceptionWithSubstring(typeof(ArgumentException), "name")]
        public async Task GetExerciseShouldThrowIfWhitespaceInput()
        {
            await _client.GetExerciseAsync("   ");
        }

        [TestMethod]
        public async Task GetExerciseShouldPassThroughTokenToHttpClient()
        {
            var expectedToken = new CancellationToken(true);

            await _client.GetExerciseAsync("root", expectedToken);

            _httpClientMock.Verify(c =>
                c.GetAsync(
                    It.IsAny<string>(),
                    It.Is<CancellationToken>(actualToken => actualToken.Equals(expectedToken))));
        }

        [TestMethod]
        public async Task GetExerciseShouldPassEmptyTokenToHttpClient()
        {
            var expectedToken = CancellationToken.None;

            await _client.GetExerciseAsync("root");

            _httpClientMock.Verify(c =>
                c.GetAsync(
                    It.IsAny<string>(),
                    It.Is<CancellationToken>(actualToken => actualToken.Equals(expectedToken))));
        }
        #endregion

        #region GetFollowUpExercises

        [TestMethod]
        [ExpectedExceptionWithSubstring(typeof(ArgumentException), "name")]
        public async Task GetFollowUpExercisesShouldThrowIfNullInput()
        {
            await _client.GetFollowUpExercisesAsync(name: null);
        }

        [TestMethod]
        [ExpectedExceptionWithSubstring(typeof(ArgumentException), "name")]
        public async Task GetFollowUpExercisesShouldThrowIfEmptyInput()
        {
            await _client.GetFollowUpExercisesAsync(name: string.Empty);
        }

        [TestMethod]
        public async Task GetFollowUpExercisesShouldTargetCorrectPath()
        {
            var expectedPath = "api/v1/exercises/foo/followup_exercises";

            await _client.GetFollowUpExercisesAsync("foo");

            _httpClientMock.Verify(c => c.GetAsync(
                It.Is<string>(url => url.ContainsIgnoreCase(expectedPath)),
                It.IsAny<CancellationToken>()));
        }

        [TestMethod]
        public async Task GetFollowUpExercisesShouldEncodeInput()
        {
            var input = "^foo&bar$";
            var encodedInput = "%5Efoo%26bar%24";

            await _client.GetFollowUpExercisesAsync(input);

            _httpClientMock.Verify(c => c.GetAsync(
                It.Is<string>(url => url.ContainsIgnoreCase(encodedInput)),
                It.IsAny<CancellationToken>()));
        }

        [TestMethod]
        public async Task GetFollowUpExercisesShouldDeserializeResponse()
        {
            var expected = ExerciseTestData.SampleExercises;
            _khanResponse.Content = new JsonContent(ExerciseTestData.SampleExercisesJson);

            var actual = await _client.GetFollowUpExercisesAsync("logarithms_1");

            expected.AssertDeepEqual(actual);
        }

        [TestMethod]
        public async Task GetFollowUpExercisesShouldPassThroughTokenToHttpClient()
        {
            var expectedToken = new CancellationToken(true);

            await _client.GetFollowUpExercisesAsync("root", expectedToken);

            _httpClientMock.Verify(c =>
                c.GetAsync(
                    It.IsAny<string>(),
                    It.Is<CancellationToken>(actualToken => actualToken.Equals(expectedToken))));
        }

        [TestMethod]
        public async Task GetFollowUpExercisesShouldPassEmptyTokenToHttpClient()
        {
            var expectedToken = CancellationToken.None;

            await _client.GetFollowUpExercisesAsync("root");

            _httpClientMock.Verify(c =>
                c.GetAsync(
                    It.IsAny<string>(),
                    It.Is<CancellationToken>(actualToken => actualToken.Equals(expectedToken))));
        }

        #endregion

        #region GetExerciseVideos

        [TestMethod]
        [ExpectedExceptionWithSubstring(typeof(ArgumentException), "name")]
        public async Task GetExerciseVideosShouldThrowIfNullInput()
        {
            await _client.GetExerciseVideosAsync(name: null);
        }

        [TestMethod]
        public async Task GetExerciseVideosShouldEncodeInput()
        {
            var input = "^foo&bar$";
            var encodedInput = "%5Efoo%26bar%24";

            await _client.GetExerciseVideosAsync(input);

            _httpClientMock.Verify(c => c.GetAsync(
                It.Is<string>(url => url.ContainsIgnoreCase(encodedInput)),
                It.IsAny<CancellationToken>()));
        }

        [TestMethod]
        public async Task GetExerciseVideosShouldTargetCorrectPath()
        {
            await _client.GetExerciseVideosAsync("foo");

            _httpClientMock.Verify(c => c.GetAsync(
                It.Is<string>(url => url.ContainsIgnoreCase("/api/v1/exercises/foo/videos")),
                It.IsAny<CancellationToken>()));
        }

        [TestMethod]
        public async Task GetExerciseVideosShouldDeserializeResponse()
        {
            var expected = ExerciseTestData.SampleVideos;
            _khanResponse.Content = new JsonContent(ExerciseTestData.SampleVideosJson);

            var actual = await _client.GetExerciseVideosAsync("logarithms-1");

            expected.AssertDeepEqual(actual);
        }

        [TestMethod]
        public async Task GetExerciseVideosShouldPassThroughTokenToHttpClient()
        {
            var expectedToken = new CancellationToken(true);

            await _client.GetExerciseVideosAsync("root", expectedToken);

            _httpClientMock.Verify(c =>
                c.GetAsync(
                    It.IsAny<string>(),
                    It.Is<CancellationToken>(actualToken => actualToken.Equals(expectedToken))));
        }

        [TestMethod]
        public async Task GetExerciseVideosShouldPassEmptyTokenToHttpClient()
        {
            var expectedToken = CancellationToken.None;

            await _client.GetExerciseVideosAsync("root");

            _httpClientMock.Verify(c =>
                c.GetAsync(
                    It.IsAny<string>(),
                    It.Is<CancellationToken>(actualToken => actualToken.Equals(expectedToken))));
        }

        #endregion

        #region GetPerseusExercises

        [TestMethod]
        public async Task GetPerseusExercisesShouldTargetCorrectPath()
        {
            await _client.GetPerseusExercisesAsync();

            _httpClientMock.Verify(c => c.GetAsync(
                It.Is<string>(url => url.ContainsIgnoreCase("/api/v1/exercises/perseus_autocomplete")),
                It.IsAny<CancellationToken>()));
        }

        [TestMethod]
        public async Task GetPerseusExercisesShouldReturnDeserializedResponse()
        {
            var expected = ExerciseTestData.SamplePerseusExercsises;
            _khanResponse.Content = new JsonContent(ExerciseTestData.SamplePerseusExercisesJson);

            var actual = await _client.GetPerseusExercisesAsync();

            expected.AssertDeepEqual(actual);
        }

        [TestMethod]
        public async Task GetPerseusExercisesShouldPassThroughTokenToHttpClient()
        {
            var expectedToken = new CancellationToken(true);

            await _client.GetPerseusExercisesAsync(expectedToken);

            _httpClientMock.Verify(c =>
                c.GetAsync(
                    It.IsAny<string>(),
                    It.Is<CancellationToken>(actualToken => actualToken.Equals(expectedToken))));
        }

        [TestMethod]
        public async Task GetPerseusExercisesShouldPassEmptyTokenToHttpClient()
        {
            var expectedToken = CancellationToken.None;

            await _client.GetPerseusExercisesAsync();

            _httpClientMock.Verify(c =>
                c.GetAsync(
                    It.IsAny<string>(),
                    It.Is<CancellationToken>(actualToken => actualToken.Equals(expectedToken))));
        }

        #endregion
    }
}
