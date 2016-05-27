using KhanDotNet.Library.Contracts;
using KhanDotNet.Library.Utilities;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Linq;

namespace KhanDotNet.Library
{
    public class BadgeClient : BaseClient, IBadgeClient
    {
        public BadgeClient(IHttpClient httpClient)
            : base(httpClient)
        {
        }

        public async Task<List<BadgeCategory>> GetBadgeCategoriesAsync()
        {
            using (var response = await _httpClient.GetAsync("http://khanacademy.org/api/v1/badges/categories"))
            {
                return await response.Content.ReadAsAsync<List<BadgeCategory>>();
            }
        }

        public async Task<List<Badge>> GetBadgesAsync()
        {
            using (var response = await _httpClient.GetAsync("http://www.khanacademy.org/api/v1/badges"))
            {
                return await response.Content.ReadAsAsync<List<Badge>>();
            }
        }

        public async Task<BadgeCategory> GetBadgeCategoryAsync(Category category)
        {
            var path = "http://www.khanacademy.org/api/v1/badges/categories/{0}".F((int)category);

            using (var response = await _httpClient.GetAsync(path))
            {
                // API returns a list even though it contains only one element
                var categories = await response.Content.ReadAsAsync<List<BadgeCategory>>();
                return categories.First();
            }
        }
    }
}
