using KhanDotNet.Library.Utilities;
using System;

namespace KhanDotNet.Library
{
    public abstract class BaseClient : IDisposable
    {
        protected IHttpClient _httpClient;

        public BaseClient(IHttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public virtual void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _httpClient?.Dispose();
                _httpClient = null;
            }
        }
    }
}
