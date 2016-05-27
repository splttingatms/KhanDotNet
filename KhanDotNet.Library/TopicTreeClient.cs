using KhanDotNet.Library.Contracts;
using KhanDotNet.Library.Utilities;
using System.Net.Http;
using System.Threading.Tasks;

namespace KhanDotNet.Library
{
    public class TopicTreeClient : BaseClient, ITopicTreeClient
    {
        public TopicTreeClient(IHttpClient httpClient)
            : base(httpClient)
        {
        }

        public async Task<Topic> GetTopicTreeAsync()
        {
            using (var response = await _httpClient.GetAsync("http://www.khanacademy.com/api/v1/topictree"))
            {
                return await response.Content.ReadAsAsync<Topic>();
            }
        }
    }
}
