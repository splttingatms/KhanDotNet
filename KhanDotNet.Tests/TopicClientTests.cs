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
                .Setup(c => c.GetAsync(It.IsAny<string>()))
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
        [ExpectedException(typeof(ArgumentException))]
        public async Task GetTopicShouldThrowIfInputNull()
        {
            await _client.GetTopicAsync(null);
        }

        [TestMethod]
        public async Task GetTopicShouldTargetCorrectPath()
        {
            await _client.GetTopicAsync("talks-and-interviews");

            _httpClientMock.Verify(c =>
                c.GetAsync(It.Is<string>(url => url.ContainsIgnoreCase("/api/v1/topic/talks-and-interviews"))));
        }
        
        [TestMethod]
        public async Task GetTopicShouldEncodeInput()
        {
            var input = "^foo&bar$";
            var encodedInput = "%5Efoo%26bar%24";

            await _client.GetTopicAsync(input);
            _httpClientMock.Verify(c => c.GetAsync(It.Is<string>(url => url.ContainsIgnoreCase(encodedInput))));
        }

        [TestMethod]
        public async Task GetTopicShouldReturnDeserializedResponse()
        {
            var expected = TopicTestData.SampleTopic;
            _khanResponse.Content = new JsonContent(TopicTestData.SampleTopicJson);

            var actual = await _client.GetTopicAsync("talks-and-interviews");

            expected.AssertDeepEqual(actual);
        }

        #endregion
    }
}
