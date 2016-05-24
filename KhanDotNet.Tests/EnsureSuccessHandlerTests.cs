using KhanDotNet.Library.Utilities;
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
            _fakeResponse = new HttpResponseMessage(HttpStatusCode.OK);

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
        [ExpectedException(typeof(HttpRequestException))]
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
        [ExpectedException(typeof(HttpRequestException))]
        public async Task EnsureSuccessHandlerShouldThrowIfNonSuccessResponseReceived()
        {
            _fakeResponse.StatusCode = HttpStatusCode.BadRequest;
            var request = new HttpRequestMessage();

            await _invoker.SendAsync(request, CancellationToken.None);
        }
    }
}
