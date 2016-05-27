﻿using KhanDotNet.Library;
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
                Content = new JsonContent("")
            };

            _httpClientMock = new Mock<IHttpClient>();

            _httpClientMock
                .Setup(c => c.GetAsync(It.IsAny<string>()))
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

            _httpClientMock.Verify(c => c.GetAsync(It.Is<string>(url => url.ContainsIgnoreCase(expectedPath))));
        }

        [TestMethod]
        public async Task GetExercisesShouldReturnDeserializedExercises()
        {
            _khanResponse.Content = new JsonContent(ExerciseTestData.SampleExercisesJson);

            var expected = ExerciseTestData.SampleExercises;
            var actual = await _client.GetExercisesAsync();

            expected.AssertDeepEqual(actual);
        }

        #endregion

        #region GetExercise

        [TestMethod]
        public async Task GetExerciseShouldMakeGetRequest()
        {
            await _client.GetExerciseAsync("foo");
            _httpClientMock.Verify(c => c.GetAsync(It.IsAny<string>()), Times.Once);
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
            _httpClientMock.Verify(c => c.GetAsync(It.Is<string>(url => url.ContainsIgnoreCase(encodedInput))));
        }

        [TestMethod]
        [ExpectedExceptionWithMessage(typeof(ArgumentException), "name", match: false, ignoreCase: true)]
        public async Task GetExerciseShouldThrowIfNullInput()
        {
            await _client.GetExerciseAsync(name: null);
        }

        [TestMethod]
        [ExpectedExceptionWithMessage(typeof(ArgumentException), "name", match: false, ignoreCase: true)]
        public async Task GetExerciseShouldThrowIfEmptyInput()
        {
            await _client.GetExerciseAsync(name: string.Empty);
        }

        [TestMethod]
        [ExpectedExceptionWithMessage(typeof(ArgumentException), "name", match: false, ignoreCase: true)]
        public async Task GetExerciseShouldThrowIfWhitespaceInput()
        {
            await _client.GetExerciseAsync("   ");
        }

        #endregion

        #region GetFollowUpExercises

        [TestMethod]
        [ExpectedExceptionWithMessage(typeof(ArgumentException), "name", match: false, ignoreCase: true)]
        public async Task GetFollowUpExercisesShouldThrowIfNullInput()
        {
            await _client.GetFollowUpExercisesAsync(name: null);
        }

        [TestMethod]
        [ExpectedExceptionWithMessage(typeof(ArgumentException), "name", match: false, ignoreCase: true)]
        public async Task GetFollowUpExercisesShouldThrowIfEmptyInput()
        {
            await _client.GetFollowUpExercisesAsync(name: string.Empty);
        }

        [TestMethod]
        public async Task GetFollowUpExercisesShouldTargetCorrectPath()
        {
            var expectedPath = "api/v1/exercises/foo/followup_exercises";

            await _client.GetFollowUpExercisesAsync("foo");

            _httpClientMock.Verify(c =>
                c.GetAsync(It.Is<string>(url => url.ContainsIgnoreCase(expectedPath))));
        }

        [TestMethod]
        public async Task GetFollowUpExercisesShouldEncodeInput()
        {
            var input = "^foo&bar$";
            var encodedInput = "%5Efoo%26bar%24";

            await _client.GetFollowUpExercisesAsync(input);

            _httpClientMock.Verify(c =>
                c.GetAsync(It.Is<string>(url => url.ContainsIgnoreCase(encodedInput))));
        }

        [TestMethod]
        public async Task GetFollowUpExercisesShouldDeserializeResponse()
        {
            var expected = ExerciseTestData.SampleExercises;
            _khanResponse.Content = new JsonContent(ExerciseTestData.SampleExercisesJson);

            var actual = await _client.GetFollowUpExercisesAsync("logarithms_1");

            expected.AssertDeepEqual(actual);
        }

        #endregion

        #region GetExerciseVideos

        [TestMethod]
        [ExpectedExceptionWithMessage(typeof(ArgumentException), "name", match: false, ignoreCase: true)]
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

            _httpClientMock.Verify(c =>
                c.GetAsync(It.Is<string>(url => url.ContainsIgnoreCase(encodedInput))));
        }

        [TestMethod]
        public async Task GetExerciseVideosShouldTargetCorrectPath()
        {
            await _client.GetExerciseVideosAsync("foo");

            _httpClientMock.Verify(c =>
                c.GetAsync(It.Is<string>(url => url.ContainsIgnoreCase("/api/v1/exercises/foo/videos"))));
        }

        [TestMethod]
        public async Task GetExerciseVideosShouldDeserializeResponse()
        {
            var expected = ExerciseTestData.SampleVideos;
            _khanResponse.Content = new JsonContent(ExerciseTestData.SampleVideosJson);

            var actual = await _client.GetExerciseVideosAsync("logarithms-1");

            expected.AssertDeepEqual(actual);
        }

        #endregion

        #region GetPerseusExercises

        [TestMethod]
        public async Task GetPerseusExercisesShouldTargetCorrectPath()
        {
            await _client.GetPerseusExercisesAsync();

            _httpClientMock.Verify(c =>
                c.GetAsync(It.Is<string>(url => url.ContainsIgnoreCase("/api/v1/exercises/perseus_autocomplete"))));
        }

        [TestMethod]
        public async Task GetPerseusExercisesShouldReturnDeserializedResponse()
        {
            var expected = ExerciseTestData.SamplePerseusExercsises;
            _khanResponse.Content = new JsonContent(ExerciseTestData.SamplePerseusExercisesJson);

            var actual = await _client.GetPerseusExercisesAsync();

            expected.AssertDeepEqual(actual);
        }

        #endregion
    }
}
