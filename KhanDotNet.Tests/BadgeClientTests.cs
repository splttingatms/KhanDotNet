using KhanDotNet.Library;
using KhanDotNet.Library.Contracts;
using KhanDotNet.Library.Utilities;
using KhanDotNet.Tests.Data;
using KhanDotNet.Tests.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace KhanDotNet.Tests
{
    [TestClass]
    public class BadgeClientTests
    {
        private HttpResponseMessage _khanResponse;

        private Mock<IHttpClient> _httpClientMock;

        private IBadgeClient _client;

        [TestInitialize]
        public void Initialize()
        {
            _khanResponse = new HttpResponseMessage()
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent("") // empty content prevents ReadAsAsync from throwing when token cancelled
            };

            _httpClientMock = new Mock<IHttpClient>();

            _httpClientMock
                .Setup(c => c.GetAsync(It.IsAny<string>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(_khanResponse);

            _client = new BadgeClient(_httpClientMock.Object);
        }

        [TestCleanup]
        public void Cleanup()
        {
            _khanResponse?.Dispose();
            _client?.Dispose();
        }

        #region GetBadges

        [TestMethod]
        public async Task GetBadgesShouldMakeAGetRequest()
        {
            await _client.GetBadgesAsync();
            _httpClientMock.Verify(c => c.GetAsync(
                It.IsAny<string>(),
                It.IsAny<CancellationToken>()), Times.Once);
        }

        [TestMethod]
        public async Task GetBadgesShouldTargetCorrectPath()
        {
            await _client.GetBadgesAsync();
            _httpClientMock.Verify(c => c.GetAsync(
                It.Is<string>(url => url == "http://www.khanacademy.org/api/v1/badges"),
                It.IsAny<CancellationToken>()));
        }

        [TestMethod]
        public async Task GetBadgesShouldReturnDeserializedBadges()
        {
            _khanResponse.Content = new JsonContent(BadgeTestData.SampleBadgesJson);

            var expected = BadgeTestData.SampleBadges;
            var actual = await _client.GetBadgesAsync();

            expected.AssertDeepEqual(actual);
        }

        [TestMethod]
        public async Task GetBadgesShouldPassThroughTokenToHttpClient()
        {
            var expectedToken = new CancellationToken(true);

            await _client.GetBadgesAsync(expectedToken);

            _httpClientMock.Verify(c => c.GetAsync(
                    It.IsAny<string>(),
                    It.Is<CancellationToken>(actualToken => actualToken.Equals(expectedToken))));
        }

        [TestMethod]
        public async Task GetBadgesShouldPassEmptyToken()
        {
            await _client.GetBadgesAsync();

            _httpClientMock.Verify(c => c.GetAsync(
                It.IsAny<string>(),
                It.Is<CancellationToken>(actualToken => actualToken.Equals(CancellationToken.None))));
        }

        #endregion

        // TODO 1: add test to verify targets correct API path
        #region GetBadgeCategories

        [TestMethod]
        public async Task GetBadgeCategoriesShouldReturnDeserializedCategories()
        {
            _khanResponse.Content = new JsonContent(BadgeTestData.SampleBadgeCategoriesJson);

            var expected = BadgeTestData.SampleBadgeCategories;
            var actual = await _client.GetBadgeCategoriesAsync();

            expected.AssertDeepEqual(actual);
        }

        [TestMethod]
        public async Task GetBadgeCategoriesShouldPassThroughTokenToHttpClient()
        {
            var expectedToken = new CancellationToken(true);

            await _client.GetBadgeCategoriesAsync(expectedToken);

            _httpClientMock.Verify(c => c.GetAsync(
                    It.IsAny<string>(),
                    It.Is<CancellationToken>(actualToken => actualToken.Equals(expectedToken))));
        }

        [TestMethod]
        public async Task GetBadgeCategoriesShouldPassEmptyToken()
        {
            await _client.GetBadgeCategoriesAsync();

            _httpClientMock.Verify(c => c.GetAsync(
                It.IsAny<string>(),
                It.Is<CancellationToken>(actualToken => actualToken.Equals(CancellationToken.None))));
        }

        #endregion

        #region GetBadgeCategory

        [TestMethod]
        public async Task GetBadgeCategoryShouldTargetCorrectPath()
        {
            var expectedPath = "api/v1/badges/categories/0"; // API takes category as int
            _khanResponse.Content = new JsonContent(BadgeTestData.SampleBadgeCategories);

            await _client.GetBadgeCategoryAsync(Category.Meteorite);

            _httpClientMock.Verify(c => c.GetAsync(
                It.Is<string>(url => url.ContainsIgnoreCase(expectedPath)),
                It.IsAny<CancellationToken>()));
        }

        [TestMethod]
        public async Task GetBadgeCategoryShouldReturnDeserializedCategory()
        {
            var expected = BadgeTestData.MeteoriteBadgeCategory;
            _khanResponse.Content = new JsonContent(BadgeTestData.SampleBadgeCategoryJson);

            var actual = await _client.GetBadgeCategoryAsync(Category.Meteorite);

            expected.AssertDeepEqual(actual);
        }

        [TestMethod]
        public async Task GetBadgeCategoryShouldPassThroughTokenToHttpClient()
        {
            var expectedToken = new CancellationToken();
            _khanResponse.Content = new JsonContent(BadgeTestData.SampleBadgeCategoryJson);

            await _client.GetBadgeCategoryAsync(Category.Meteorite, expectedToken);

            _httpClientMock.Verify(c => c.GetAsync(
                    It.IsAny<string>(),
                    It.Is<CancellationToken>(actualToken => actualToken.Equals(expectedToken))));
        }

        [TestMethod]
        public async Task GetBadgeCategoryShouldPassEmptyToken()
        {
            _khanResponse.Content = new JsonContent(BadgeTestData.SampleBadgeCategoryJson);

            await _client.GetBadgeCategoryAsync(Category.Meteorite);

            _httpClientMock.Verify(c => c.GetAsync(
                It.IsAny<string>(),
                It.Is<CancellationToken>(actualToken => actualToken.Equals(CancellationToken.None))));
        }

        #endregion
    }
}
