using KhanDotNet.Library;
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
        [ExpectedException(typeof(ArgumentException))]
        public async Task GetExerciseShouldThrowIfNullInput()
        {
            await _client.GetExerciseAsync(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public async Task GetExerciseShouldThrowIfEmptyInput()
        {
            await _client.GetExerciseAsync(string.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public async Task GetExerciseShouldThrowIfWhitespaceInput()
        {
            await _client.GetExerciseAsync("   ");
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public async Task GetExerciseShouldThrowIfNullResponseReturned()
        {
            _httpClientMock.Setup(c => c.GetAsync(It.IsAny<string>())).ReturnsAsync(null);
            await _client.GetExerciseAsync("foo");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public async Task GetExerciseShouldThrowIfNullContentReturned()
        {
            _khanResponse.Content = null;
            await _client.GetExerciseAsync("foo");
        }

        [TestMethod]
        [ExpectedException(typeof(JsonReaderException))]
        public async Task GetExerciseShouldThrowIfInvalidJsonReturned()
        {
            _khanResponse.Content = new JsonContent("invalid_json");
            await _client.GetExerciseAsync("foo");
        }

        #endregion

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
    }
}
