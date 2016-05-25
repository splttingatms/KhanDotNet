using KhanDotNet.Library;
using KhanDotNet.Library.Utilities;
using KhanDotNet.Tests.Data;
using KhanDotNet.Tests.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace KhanDotNet.Tests
{
    [TestClass]
    public class TopicTreeClientTests
    {
        private HttpResponseMessage _khanResponse;

        private Mock<IHttpClient> _httpClientMock;

        private ITopicTreeClient _client;

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

            _client = new TopicTreeClient(_httpClientMock.Object);
        }

        [TestCleanup]
        public void Cleanup()
        {
            _khanResponse?.Dispose();
            _client?.Dispose();
        }

        #region GetTopicTree

        [TestMethod]
        public async Task GetTopicTreeShouldTargetCorrectPath()
        {
            await _client.GetTopicTreeAsync();

            _httpClientMock.Verify(c =>
                c.GetAsync(It.Is<string>(url => url.ContainsIgnoreCase("/api/v1/topictree"))));
        }

        [TestMethod]
        public async Task GetTopicTreeShouldReturnDeserializedResponse()
        {
            var expected = TopicTreeTestData.SampleTopicTree;
            _khanResponse.Content = new JsonContent(TopicTreeTestData.SampleTopicTreeJson);

            var actual = await _client.GetTopicTreeAsync();

            expected.AssertDeepEqual(actual);
        }

        #endregion
    }
}
