using System.Net.Http;

namespace KhanDotNet.Library.Utilities
{
    public class NonSuccessStatusCodeException : HttpRequestException
    {
        public HttpResponseMessage Response { get; private set; }

        public NonSuccessStatusCodeException(HttpResponseMessage response)
            : base("reponse contains non-success status code ({0}) {1}".F((int)response.StatusCode, response.StatusCode))
        {
            Response = response;
        }
    }
}
