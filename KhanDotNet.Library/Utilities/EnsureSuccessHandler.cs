using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace KhanDotNet.Library.Utilities
{
    public class EnsureSuccessHandler : DelegatingHandler
    {
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var response = await base.SendAsync(request, cancellationToken);
            ValidateResponse(response);
            return response;
        }

        private void ValidateResponse(HttpResponseMessage response)
        {
            if (response == null)
            {
                throw new HttpRequestException("response was null");
            }

            response.EnsureSuccessStatusCode();
        }
    }
}
