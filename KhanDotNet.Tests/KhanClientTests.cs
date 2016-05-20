﻿using KhanDotNet.Library;
using KhanDotNet.Library.Utilities;
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
    public class KhanClientTests
    {
        private HttpResponseMessage _khanResponse;

        private Mock<IHttpClient> _httpClientMock;

        private IKhanClient _client;

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

            _client = new KhanClient(_httpClientMock.Object);
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
            await _client.GetBadges();
            _httpClientMock.Verify(c => c.GetAsync(It.IsAny<string>()), Times.Once);
        }

        [TestMethod]
        public async Task GetBadgesShouldTargetCorrectPath()
        {
            await _client.GetBadges();
            _httpClientMock.Verify(c => c.GetAsync(It.Is<string>(url => url == "http://www.khanacademy.org/api/v1/badges")));
        }

        [TestMethod]
        public async Task GetBadgesShouldReturnDeserializedBadges()
        {
            _khanResponse.Content = new JsonContent(KhanTestData.Badges.SampleJson);

            var expected = KhanTestData.Badges.SampleBadges;
            var actual = await _client.GetBadges();

            expected.AssertDeepEqual(actual);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public async Task GetBadgesShouldThrowIfNullResponseReturned()
        {
            _httpClientMock.Setup(c => c.GetAsync(It.IsAny<string>())).ReturnsAsync(null);
            await _client.GetBadges();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public async Task GetBadgesShouldThrowIfNullContentReturned()
        {
            _khanResponse.Content = null;
            await _client.GetBadges();
        }

        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public async Task GetBadgesShouldThrowIfNonSuccessStatusCodeReturned()
        {
            _khanResponse.StatusCode = HttpStatusCode.BadRequest;
            await _client.GetBadges();
        }

        [TestMethod]
        [ExpectedException(typeof(JsonReaderException))]
        public async Task GetBadgesShouldThrowIfInvalidJsonReturned()
        {
            _khanResponse.Content = new JsonContent("invalid_json");
            await _client.GetBadges();
        }

        #endregion

        #region GetExercise

        [TestMethod]
        public async Task GetExerciseShouldMakeGetRequest()
        {
            await _client.GetExercise("foo");
            _httpClientMock.Verify(c => c.GetAsync(It.IsAny<string>()), Times.Once);
        }

        [TestMethod]
        public async Task GetExerciseShouldReturnDeserializedExercise()
        {
            _khanResponse.Content = new JsonContent(KhanTestData.Exercises.CountingExerciseJson);

            var expected = KhanTestData.Exercises.CountingExercise;
            var actual = await _client.GetExercise("counting-out-1-20-objects");

            expected.AssertDeepEqual(actual);
        }

        [TestMethod]
        public async Task GetExerciseShouldUrlEncodeInput()
        {
            var input = "^foo&bar$";
            var encodedInput = "%5Efoo%26bar%24";

            await _client.GetExercise(input);
            _httpClientMock.Verify(c => c.GetAsync(It.Is<string>(url => url.ContainsIgnoreCase(encodedInput))));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public async Task GetExerciseShouldThrowIfNullInput()
        {
            await _client.GetExercise(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public async Task GetExerciseShouldThrowIfEmptyInput()
        {
            await _client.GetExercise(string.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public async Task GetExerciseShouldThrowIfWhitespaceInput()
        {
            await _client.GetExercise("   ");
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public async Task GetExerciseShouldThrowIfNullResponseReturned()
        {
            _httpClientMock.Setup(c => c.GetAsync(It.IsAny<string>())).ReturnsAsync(null);
            await _client.GetExercise("foo");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public async Task GetExerciseShouldThrowIfNullContentReturned()
        {
            _khanResponse.Content = null;
            await _client.GetExercise("foo");
        }

        [TestMethod]
        [ExpectedException(typeof(HttpRequestException))]
        public async Task GetExerciseShouldThrowIfNonSuccessStatusCodeReturned()
        {
            _khanResponse.StatusCode = HttpStatusCode.BadRequest;
            await _client.GetExercise("foo");
        }

        [TestMethod]
        [ExpectedException(typeof(JsonReaderException))]
        public async Task GetExerciseShouldThrowIfInvalidJsonReturned()
        {
            _khanResponse.Content = new JsonContent("invalid_json");
            await _client.GetExercise("foo");
        }

        #endregion
    }
}