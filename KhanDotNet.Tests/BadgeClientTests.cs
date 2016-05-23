﻿using KhanDotNet.Library;
using KhanDotNet.Library.Utilities;
using KhanDotNet.Library.Contract;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
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
                Content = new JsonContent("")
            };

            _httpClientMock = new Mock<IHttpClient>();

            _httpClientMock
                .Setup(c => c.GetAsync(It.IsAny<string>()))
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
            _httpClientMock.Verify(c => c.GetAsync(It.IsAny<string>()), Times.Once);
        }

        [TestMethod]
        public async Task GetBadgesShouldTargetCorrectPath()
        {
            await _client.GetBadgesAsync();
            _httpClientMock.Verify(c => c.GetAsync(It.Is<string>(url => url == "http://www.khanacademy.org/api/v1/badges")));
        }

        [TestMethod]
        public async Task GetBadgesShouldReturnDeserializedBadges()
        {
            _khanResponse.Content = new JsonContent(BadgeTestData.SampleBadgesJson);

            var expected = BadgeTestData.SampleBadges;
            var actual = await _client.GetBadgesAsync();

            expected.AssertDeepEqual(actual);
        }

        // TODO: either change exception thrown or remove test
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public async Task GetBadgesShouldThrowIfNullResponseReturned()
        {
            _httpClientMock.Setup(c => c.GetAsync(It.IsAny<string>())).ReturnsAsync(null);
            await _client.GetBadgesAsync();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public async Task GetBadgesShouldThrowIfNullContentReturned()
        {
            _khanResponse.Content = null;
            await _client.GetBadgesAsync();
        }

        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public async Task GetBadgesShouldThrowIfNonSuccessStatusCodeReturned()
        {
            _khanResponse.StatusCode = HttpStatusCode.BadRequest;
            await _client.GetBadgesAsync();
        }

        [TestMethod]
        [ExpectedException(typeof(JsonReaderException))]
        public async Task GetBadgesShouldThrowIfInvalidJsonReturned()
        {
            _khanResponse.Content = new JsonContent("invalid_json");
            await _client.GetBadgesAsync();
        }

        #endregion

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
        [ExpectedException(typeof(HttpRequestException))]
        public async Task GetBadgeCategoriesShouldThrowIfNonSuccessStatusCode()
        {
            _khanResponse.StatusCode = HttpStatusCode.BadRequest;
            await _client.GetBadgeCategoriesAsync();
        }

        #endregion

        #region GetBadgeCategory

        [TestMethod]
        public async Task GetBadgeCategoryShouldTargetCorrectPath()
        {
            var expectedPath = "api/v1/badges/categories/0"; // API takes category as int

            await _client.GetBadgeCategoryAsync(Category.Meteorite);

            _httpClientMock.Verify(c => c.GetAsync(It.Is<string>(url => url.ContainsIgnoreCase(expectedPath))));
        }

        [TestMethod]
        public async Task GetBadgeCategoryShouldReturnDeserializedCategory()
        {
            var expected = BadgeTestData.MeteoriteBadgeCategory;
            _khanResponse.Content = new JsonContent(expected);

            var actual = await _client.GetBadgeCategoryAsync(Category.Meteorite);

            expected.AssertDeepEqual(actual);
        }

        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public async Task GetBadgeCategoryShouldThrowIfNonSuccessStatusCode()
        {
            _khanResponse.StatusCode = HttpStatusCode.BadRequest;
            await _client.GetBadgeCategoryAsync(Category.Meteorite);
        }

        #endregion
    }
}
