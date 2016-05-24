using System.Net.Http;

namespace KhanDotNet.Library.Utilities
{
    public class HttpClientWithValidator : HttpClientWrapper
    {
        private EnsureSuccessHandler _validator;

        public HttpClientWithValidator()
        {
            _validator = DisposableUtilities.SafeCreate<EnsureSuccessHandler>();
            _client = HttpClientFactory.Create(_validator);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _validator?.Dispose();
                _validator = null;
            }

            base.Dispose(disposing);
        }
    }
}
