using EnsureThat;
using KhanDotNet.Library.Contracts;
using KhanDotNet.Library.Utilities;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
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
            return await GetTopicAsync(slug, CancellationToken.None);
        }

        public async Task<Topic> GetTopicAsync(string slug, CancellationToken cancellationToken)
        {
            Ensure.That(slug, nameof(slug)).IsNotNullOrWhiteSpace();

            slug = HttpUtility.UrlEncode(slug);
            var path = "http://www.khanacademy.com/api/v1/topic/{0}".F(slug);

            using (var response = await _httpClient.GetAsync(path, cancellationToken))
            {
                return await response.Content.ReadAsAsync<Topic>(cancellationToken);
            }
        }

        public async Task<List<Exercise>> GetTopicExercisesAsync(string slug)
        {
            return await GetTopicExercisesAsync(slug, CancellationToken.None);
        }

        public async Task<List<Exercise>> GetTopicExercisesAsync(string slug, CancellationToken cancellationToken)
        {
            Ensure.That(slug, nameof(slug)).IsNotNullOrWhiteSpace();

            slug = HttpUtility.UrlEncode(slug);
            var path = "http://www.khanacademy.com/api/v1/topic/{0}/exercises".F(slug);

            using (var response = await _httpClient.GetAsync(path, cancellationToken))
            {
                return await response.Content.ReadAsAsync<List<Exercise>>(cancellationToken);
            }
        }

        public async Task<List<Video>> GetTopicVideosAsync(string slug)
        {
            return await GetTopicVideosAsync(slug, CancellationToken.None);
        }

        public async Task<List<Video>> GetTopicVideosAsync(string slug, CancellationToken cancellationToken)
        {
            Ensure.That(slug, nameof(slug)).IsNotNullOrWhiteSpace();

            slug = HttpUtility.UrlEncode(slug);
            var path = "http://www.khanacademy.com/api/v1/topic/{0}/videos".F(slug);

            using (var response = await _httpClient.GetAsync(path, cancellationToken))
            {
                return await response.Content.ReadAsAsync<List<Video>>(cancellationToken);
            }
        }
    }
}
