using System.Net.Http;

namespace KhanDotNet.Library.Utilities
{
    // TODO 2: verify visiblity of utility classes
    public class NonSuccessStatusCodeException : HttpRequestException
    {
        public HttpResponseMessage Response { get; private set; }

        public NonSuccessStatusCodeException(HttpResponseMessage response)
            : base("reponse contains non-success status code. StatusCode: ({0}) {1}, Content: {2}".F((int)response.StatusCode, response.StatusCode, response.Content?.ReadAsStringAsync().Result))
        {
            Response = response;
        }
    }
}
