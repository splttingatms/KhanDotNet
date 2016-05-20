using KhanDotNet.Library.Contract;
using KhanDotNet.Library.Utilities;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace KhanDotNet.Library
{
    public class BadgeClient : IBadgeClient
    {
        private IHttpClient _httpClient;

        public BadgeClient(IHttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _httpClient?.Dispose();
                _httpClient = null;
            }
        }

        public async Task<List<Badge>> GetBadges()
        {
            using (var response = await _httpClient.GetAsync("http://www.khanacademy.org/api/v1/badges"))
            {
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsAsync<List<Badge>>();
            }
        }
    }
}
