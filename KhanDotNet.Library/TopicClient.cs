using EnsureThat;
using KhanDotNet.Library.Contract;
using KhanDotNet.Library.Utilities;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace KhanDotNet.Library
{
    public class TopicClient : BaseClient, ITopicClient
    {
        public TopicClient(IHttpClient innerClient)
            : base(innerClient)
        {
        }

        public async Task<Topic> GetTopicAsync(string name)
        {
            Ensure.That(name, nameof(name)).IsNotNullOrWhiteSpace();

            name = HttpUtility.UrlEncode(name);
            var path = "http://www.khanacademy.com/api/v1/topic/{0}".F(name);

            // TODO: use cancellation token for long running operations
            using (var response = await _httpClient.GetAsync(path))
            {
                return await response.Content.ReadAsAsync<Topic>();
            }
        }
    }
}
