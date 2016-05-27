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
    public class TopicClientTests
    {
        private HttpResponseMessage _khanResponse;

        private Mock<IHttpClient> _httpClientMock;

        private ITopicClient _client;

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

            _client = new TopicClient(_httpClientMock.Object);
        }

        [TestCleanup]
        public void Cleanup()
        {
            _khanResponse?.Dispose();
            _client?.Dispose();
        }

        #region GetTopic

        [TestMethod]
        [ExpectedExceptionWithMessage(typeof(ArgumentException), "slug", match: false, ignoreCase: true)]
        public async Task GetTopicShouldThrowIfInputNull()
        {
            await _client.GetTopicAsync(slug: null);
        }

        [TestMethod]
        public async Task GetTopicShouldTargetCorrectPath()
        {
            await _client.GetTopicAsync("talks-and-interviews");

            _httpClientMock.Verify(c =>
                c.GetAsync(
                    It.Is<string>(url => url.ContainsIgnoreCase("/api/v1/topic/talks-and-interviews")),
                    It.IsAny<CancellationToken>()));
        }
        
        [TestMethod]
        public async Task GetTopicShouldEncodeInput()
        {
            var input = "^foo&bar$";
            var encodedInput = "%5Efoo%26bar%24";

            await _client.GetTopicAsync(input);

            _httpClientMock.Verify(c => 
                c.GetAsync(
                        It.Is<string>(url => url.ContainsIgnoreCase(encodedInput)),
                        It.IsAny<CancellationToken>()));
        }

        [TestMethod]
        public async Task GetTopicShouldReturnDeserializedResponse()
        {
            var expected = TopicTestData.SampleTopic;
            _khanResponse.Content = new JsonContent(TopicTestData.SampleTopicJson);

            var actual = await _client.GetTopicAsync("talks-and-interviews");

            expected.AssertDeepEqual(actual);
        }

        [TestMethod]
        public async Task GetTopicShouldPassThroughCancellationTokenToHttpClient()
        {
            var expectedToken = new CancellationToken(true);

            await _client.GetTopicAsync("root", expectedToken);

            _httpClientMock.Verify(c =>
                c.GetAsync(
                    It.IsAny<string>(),
                    It.Is<CancellationToken>(actualToken => actualToken.Equals(expectedToken))));
        }

        [TestMethod]
        public async Task GetTopicShouldPassEmptyCancellationTokenToHttpClient()
        {
            var expectedToken = CancellationToken.None;

            await _client.GetTopicAsync("root");

            _httpClientMock.Verify(c =>
                c.GetAsync(
                    It.IsAny<string>(),
                    It.Is<CancellationToken>(actualToken => actualToken.Equals(expectedToken))));
        }

        #endregion

        #region GetTopicExercises

        [TestMethod]
        [ExpectedExceptionWithMessage(typeof(ArgumentException), "slug", match: false, ignoreCase: true)]
        public async Task GetTopicExercisesShouldThrowIfNullInput()
        {
            await _client.GetTopicExercisesAsync(slug: null);
        }

        [TestMethod]
        public async Task GetTopicExercisesShouldTargetCorrectPath()
        {

            await _client.GetTopicExercisesAsync("foo");

            _httpClientMock.Verify(c =>
                c.GetAsync(
                    It.Is<string>(url => url.ContainsIgnoreCase("/api/v1/topic/foo/exercises")),
                    It.IsAny<CancellationToken>()));
        }

        [TestMethod]
        public async Task GetTopicExercisesShouldUrlEncodeInput()
        {
            var input = "^foo&bar$";
            var encodedInput = "%5Efoo%26bar%24";

            await _client.GetTopicExercisesAsync(input);

            _httpClientMock.Verify(c =>
                c.GetAsync(
                    It.Is<string>(url => url.ContainsIgnoreCase(encodedInput)),
                    It.IsAny<CancellationToken>()));
        }

        [TestMethod]
        public async Task GetTopicExercisesShouldReturnDeserializedResponse()
        {
            var expected = TopicTestData.SampleTopicExercises;
            _khanResponse.Content = new JsonContent(TopicTestData.SampleTopicExercisesJson);

            var actual = await _client.GetTopicExercisesAsync("talks-and-interviews");

            expected.AssertDeepEqual(actual);
        }

        [TestMethod]
        public async Task GetTopicExercisesShouldPassThroughCancellationTokenToHttpClient()
        {
            var expectedToken = new CancellationToken(true);

            await _client.GetTopicExercisesAsync("root", expectedToken);

            _httpClientMock.Verify(c =>
                c.GetAsync(
                    It.IsAny<string>(),
                    It.Is<CancellationToken>(actualToken => actualToken.Equals(expectedToken))));
        }

        [TestMethod]
        public async Task GetTopicExercisesShouldPassEmptyCancellationTokenToHttpClient()
        {
            var expectedToken = CancellationToken.None;

            await _client.GetTopicExercisesAsync("root");

            _httpClientMock.Verify(c =>
                c.GetAsync(
                    It.IsAny<string>(),
                    It.Is<CancellationToken>(actualToken => actualToken.Equals(expectedToken))));
        }

        #endregion

        #region GetTopicVideos

        [TestMethod]
        [ExpectedExceptionWithMessage(typeof(ArgumentException), "slug", match: false, ignoreCase: true)]
        public async Task GetTopicVideosShouldThrowIfNullInput()
        {
            await _client.GetTopicVideosAsync(slug: null);
        }

        [TestMethod]
        public async Task GetTopicVideosShouldTargetCorrectPath()
        {
            await _client.GetTopicVideosAsync("root");
            _httpClientMock.Verify(c =>
                c.GetAsync(
                    It.Is<string>(url => url.ContainsIgnoreCase("/api/v1/topic/root/videos")),
                    It.IsAny<CancellationToken>()));
        }

        [TestMethod]
        public async Task GetTopicVideosShouldUrlEncodeInput()
        {
            var input = "^foo&bar$";
            var encodedInput = "%5Efoo%26bar%24";

            await _client.GetTopicVideosAsync(input);

            _httpClientMock.Verify(c => 
                c.GetAsync(
                    It.Is<string>(url => url.ContainsIgnoreCase(encodedInput)),
                    It.IsAny<CancellationToken>()));
        }

        [TestMethod]
        public async Task GetTopicVideosShouldReturnDeserializedResponse()
        {
            var expected = TopicTestData.SampleTopicVideos;
            _khanResponse.Content = new JsonContent(TopicTestData.SampleTopicVideosJson);

            var actual = await _client.GetTopicVideosAsync("root");

            expected.AssertDeepEqual(actual);
        }

        [TestMethod]
        public async Task GetTopicVideosShouldPassThroughCancellationTokenToHttpClient()
        {
            var expectedToken = new CancellationToken(true);

            await _client.GetTopicVideosAsync("root", expectedToken);

            _httpClientMock.Verify(c =>
                c.GetAsync(
                    It.IsAny<string>(),
                    It.Is<CancellationToken>(actualToken => actualToken.Equals(expectedToken))));
        }

        [TestMethod]
        public async Task GetTopicVideosShouldPassEmptyCancellationTokenToHttpClient()
        {
            var expectedToken = CancellationToken.None;

            await _client.GetTopicVideosAsync("root");

            _httpClientMock.Verify(c =>
                c.GetAsync(
                    It.IsAny<string>(),
                    It.Is<CancellationToken>(actualToken => actualToken.Equals(expectedToken))));
        }

        #endregion
    }
}
