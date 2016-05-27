using KhanDotNet.Library.Contracts;
using KhanDotNet.Library.Utilities;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Linq;
using System.Threading;

namespace KhanDotNet.Library
{
    public class BadgeClient : BaseClient, IBadgeClient
    {
        public BadgeClient(IHttpClient httpClient)
            : base(httpClient)
        {
        }

        public async Task<List<Badge>> GetBadgesAsync()
        {
            return await GetBadgesAsync(CancellationToken.None);
        }

        public async Task<List<Badge>> GetBadgesAsync(CancellationToken cancellationToken)
        {
            var path = "http://www.khanacademy.org/api/v1/badges";
            using (var response = await _httpClient.GetAsync(path, cancellationToken))
            {
                return await response.Content.ReadAsAsync<List<Badge>>(cancellationToken);
            }
        }

        public async Task<List<BadgeCategory>> GetBadgeCategoriesAsync()
        {
            return await GetBadgeCategoriesAsync(CancellationToken.None);
        }

        public async Task<List<BadgeCategory>> GetBadgeCategoriesAsync(CancellationToken cancellationToken)
        {
            var path = "http://khanacademy.org/api/v1/badges/categories";
            using (var response = await _httpClient.GetAsync(path, cancellationToken))
            {
                return await response.Content.ReadAsAsync<List<BadgeCategory>>(cancellationToken);
            }
        }

        public async Task<BadgeCategory> GetBadgeCategoryAsync(Category category)
        {
            return await GetBadgeCategoryAsync(category, CancellationToken.None);
        }

        public async Task<BadgeCategory> GetBadgeCategoryAsync(Category category, CancellationToken cancellationToken)
        {
            var path = "http://www.khanacademy.org/api/v1/badges/categories/{0}".F((int)category);
            using (var response = await _httpClient.GetAsync(path, cancellationToken))
            {
                // API returns a list even though it contains only one element
                var categories = await response.Content.ReadAsAsync<List<BadgeCategory>>(cancellationToken);
                return categories.First();
            }
        }
    }
}
