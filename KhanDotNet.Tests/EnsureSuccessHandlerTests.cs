using KhanDotNet.Library.Utilities;
using KhanDotNet.Tests.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Moq.Protected;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace KhanDotNet.Tests
{
    [TestClass]
    public class EnsureSuccessHandlerTests
    {
        private HttpResponseMessage _fakeResponse;

        private HttpMessageInvoker _invoker;

        [TestInitialize]
        public void Initialize()
        {
            // must specify content for validation to pass
            _fakeResponse = new HttpResponseMessage(HttpStatusCode.OK) { Content = new StringContent(string.Empty) };

            var mockHandler = new Mock<HttpMessageHandler>();
            mockHandler.Protected()
                .Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.IsAny<HttpRequestMessage>(), ItExpr.IsAny<CancellationToken>())
                .ReturnsAsync(_fakeResponse);

            var handler = new EnsureSuccessHandler() { InnerHandler = mockHandler.Object };

            _invoker = new HttpMessageInvoker(handler);
        }

        [TestCleanup]
        public void Cleanup()
        {
            _fakeResponse?.Dispose();
            _fakeResponse = null;

            _invoker?.Dispose();
            _invoker = null;
        }

        [TestMethod]
        public async Task EnsureSuccessHandlerShouldReturnIfStatusCodeSuccessful()
        {
            _fakeResponse.StatusCode = HttpStatusCode.OK;
            var request = new HttpRequestMessage();

            var response = await _invoker.SendAsync(request, CancellationToken.None);

            Assert.IsNotNull(response);
        }

        [TestMethod]
        [ExpectedExceptionWithSubstring(typeof(HttpRequestException), "response was null")]
        public async Task EnsureSuccessHandlerShouldThrowIfNullResponseRecieved()
        {
            var mockHandler = new Mock<HttpMessageHandler>();
            mockHandler.Protected()
                .Setup<Task<HttpResponseMessage>>("SendAsync", ItExpr.IsAny<HttpRequestMessage>(), ItExpr.IsAny<CancellationToken>())
                .ReturnsAsync(null);
            var handler = new EnsureSuccessHandler() { InnerHandler = mockHandler.Object };
            _invoker = new HttpMessageInvoker(handler);
            var request = new HttpRequestMessage();

            await _invoker.SendAsync(request, CancellationToken.None);
        }

        [TestMethod]
        [ExpectedExceptionWithSubstring(typeof(NonSuccessStatusCodeException), "StatusCode: (400) BadRequest")]
        public async Task EnsureSuccessHandlerShouldThrowIfNonSuccessResponseReceived()
        {
            _fakeResponse.StatusCode = HttpStatusCode.BadRequest;
            var request = new HttpRequestMessage();

            await _invoker.SendAsync(request, CancellationToken.None);
        }

        [TestMethod]
        [ExpectedExceptionWithSubstring(typeof(HttpRequestException), "content was null")]
        public async Task EnsureSuccessHandlerShouldThrowIfNullContent()
        {
            _fakeResponse.Content = null;
            var request = new HttpRequestMessage();

            await _invoker.SendAsync(request, CancellationToken.None);
        }
    }
}
