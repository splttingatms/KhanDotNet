using EnsureThat;
using KhanDotNet.Library.Contract;
using KhanDotNet.Library.Utilities;
using System.Collections.Generic;
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

        public async Task<Topic> GetTopicAsync(string slug)
        {
            Ensure.That(slug, nameof(slug)).IsNotNullOrWhiteSpace();

            slug = HttpUtility.UrlEncode(slug);
            var path = "http://www.khanacademy.com/api/v1/topic/{0}".F(slug);

            // TODO: use cancellation token for long running operations
            using (var response = await _httpClient.GetAsync(path))
            {
                return await response.Content.ReadAsAsync<Topic>();
            }
        }

        public async Task<List<Exercise>> GetTopicExercisesAsync(string slug)
        {
            Ensure.That(slug, nameof(slug)).IsNotNullOrWhiteSpace();

            slug = HttpUtility.UrlEncode(slug);
            var path = "http://www.khanacademy.com/api/v1/topic/{0}/exercises".F(slug);

            using (var response = await _httpClient.GetAsync(path))
            {
                return await response.Content.ReadAsAsync<List<Exercise>>();
            }
        }
    }
}
