using KhanDotNet.Library.Contracts;
using KhanDotNet.Library.Utilities;
using System.Net.Http;
using System.Threading;
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
            return await GetTopicTreeAsync(CancellationToken.None);
        }

        public async Task<Topic> GetTopicTreeAsync(CancellationToken cancellationToken)
        {
            var path = "http://www.khanacademy.com/api/v1/topictree";
            using (var response = await _httpClient.GetAsync(path, cancellationToken))
            {
                return await response.Content.ReadAsAsync<Topic>(cancellationToken);
            }
        }
    }
}
