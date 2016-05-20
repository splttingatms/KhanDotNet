using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace KhanDotNet.Library.Utilities
{
    public class HttpClientWrapper : IHttpClient
    {
        private HttpClient _client;

        public HttpClientWrapper()
        {
            _client = new HttpClient();
        }

        public HttpClientWrapper(HttpMessageHandler handler)
        {
            _client = new HttpClient(handler);
        }

        public HttpClientWrapper(HttpMessageHandler handler, bool disposeHandler)
        {
            _client = new HttpClient(handler, disposeHandler);
        }

        public Uri BaseAddress
        {
            get
            {
                return _client.BaseAddress;
            }
            set
            {
                _client.BaseAddress = value;
            }
        }

        public HttpRequestHeaders DefaultRequestHeaders
        {
            get
            {
                return _client.DefaultRequestHeaders;
            }
        }

        public long MaxResponseContentBufferSize
        {
            get
            {
                return _client.MaxResponseContentBufferSize;
            }

            set
            {
                _client.MaxResponseContentBufferSize = value;
            }
        }

        public TimeSpan Timeout
        {
            get
            {
                return _client.Timeout;
            }

            set
            {
                _client.Timeout = value;
            }
        }

        public void CancelPendingRequests()
        {
            _client.CancelPendingRequests();
        }

        public async Task<HttpResponseMessage> DeleteAsync(Uri requestUri)
        {
            return await _client.DeleteAsync(requestUri);
        }

        public async Task<HttpResponseMessage> DeleteAsync(string requestUri)
        {
            return await _client.DeleteAsync(requestUri);
        }

        public async Task<HttpResponseMessage> DeleteAsync(Uri requestUri, CancellationToken cancellationToken)
        {
            return await _client.DeleteAsync(requestUri, cancellationToken);
        }

        public async Task<HttpResponseMessage> DeleteAsync(string requestUri, CancellationToken cancellationToken)
        {
            return await _client.DeleteAsync(requestUri, cancellationToken);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _client?.Dispose();
                _client = null;
            }
        }

        public async Task<HttpResponseMessage> GetAsync(Uri requestUri)
        {
            return await _client.GetAsync(requestUri);
        }

        public async Task<HttpResponseMessage> GetAsync(string requestUri)
        {
            return await _client.GetAsync(requestUri);
        }

        public async Task<HttpResponseMessage> GetAsync(string requestUri, CancellationToken cancellationToken)
        {
            return await _client.GetAsync(requestUri, cancellationToken);
        }

        public async Task<HttpResponseMessage> GetAsync(Uri requestUri, CancellationToken cancellationToken)
        {
            return await _client.GetAsync(requestUri, cancellationToken);
        }

        public async Task<HttpResponseMessage> GetAsync(Uri requestUri, HttpCompletionOption completionOption)
        {
            return await _client.GetAsync(requestUri, completionOption);
        }

        public async Task<HttpResponseMessage> GetAsync(string requestUri, HttpCompletionOption completionOption)
        {
            return await _client.GetAsync(requestUri, completionOption);
        }

        public async Task<HttpResponseMessage> GetAsync(string requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken)
        {
            return await _client.GetAsync(requestUri, completionOption, cancellationToken);
        }

        public async Task<HttpResponseMessage> GetAsync(Uri requestUri, HttpCompletionOption completionOption, CancellationToken cancellationToken)
        {
            return await _client.GetAsync(requestUri, completionOption, cancellationToken);
        }

        public async Task<byte[]> GetByteArrayAsync(Uri requestUri)
        {
            return await _client.GetByteArrayAsync(requestUri);
        }

        public async Task<byte[]> GetByteArrayAsync(string requestUri)
        {
            return await _client.GetByteArrayAsync(requestUri);
        }

        public async Task<Stream> GetStreamAsync(string requestUri)
        {
            return await _client.GetStreamAsync(requestUri);
        }

        public async Task<Stream> GetStreamAsync(Uri requestUri)
        {
            return await _client.GetStreamAsync(requestUri);
        }

        public async Task<string> GetStringAsync(Uri requestUri)
        {
            return await _client.GetStringAsync(requestUri);
        }

        public async Task<string> GetStringAsync(string requestUri)
        {
            return await _client.GetStringAsync(requestUri);
        }

        public async Task<HttpResponseMessage> PostAsync(Uri requestUri, HttpContent content)
        {
            return await _client.PostAsync(requestUri, content);
        }

        public async Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content)
        {
            return await _client.PostAsync(requestUri, content);
        }

        public async Task<HttpResponseMessage> PostAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken)
        {
            return await _client.PostAsync(requestUri, content, cancellationToken);
        }

        public async Task<HttpResponseMessage> PostAsync(string requestUri, HttpContent content, CancellationToken cancellationToken)
        {
            return await _client.PostAsync(requestUri, content, cancellationToken);
        }

        public async Task<HttpResponseMessage> PutAsync(Uri requestUri, HttpContent content)
        {
            return await PutAsync(requestUri, content);
        }

        public async Task<HttpResponseMessage> PutAsync(string requestUri, HttpContent content)
        {
            return await _client.PutAsync(requestUri, content);
        }

        public async Task<HttpResponseMessage> PutAsync(Uri requestUri, HttpContent content, CancellationToken cancellationToken)
        {
            return await _client.PutAsync(requestUri, content, cancellationToken);
        }

        public async Task<HttpResponseMessage> PutAsync(string requestUri, HttpContent content, CancellationToken cancellationToken)
        {
            return await _client.PutAsync(requestUri, content, cancellationToken);
        }

        public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request)
        {
            return await _client.SendAsync(request);
        }

        public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption)
        {
            return await _client.SendAsync(request, completionOption);
        }

        public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            return await _client.SendAsync(request, cancellationToken);
        }

        public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, HttpCompletionOption completionOption, CancellationToken cancellationToken)
        {
            return await _client.SendAsync(request, completionOption, cancellationToken);
        }
    }
}
