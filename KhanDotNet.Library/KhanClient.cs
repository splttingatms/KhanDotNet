using EnsureThat;
using KhanDotNet.Library.Contract;
using KhanDotNet.Library.Utilities;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace KhanDotNet.Library
{
    public class KhanClient : IKhanClient
    {
        private IHttpClient _httpClient;

        public KhanClient()
        {
            _httpClient = DisposableUtilities.SafeCreate<HttpClientWrapper>();
        }

        public KhanClient(IHttpClient client)
        {
            _httpClient = client;
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
                if (_httpClient != null)
                {
                    _httpClient.Dispose();
                    _httpClient = null;
                }
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

        public async Task<Exercise> GetExercise(string name)
        {
            Ensure.That(name, nameof(name)).IsNotNullOrWhiteSpace();

            name = HttpUtility.UrlEncode(name);
            var path = "http://www.khanacademy.org/api/v1/exercises/{0}".F(name);

            using (var response = await _httpClient.GetAsync(path))
            {
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsAsync<Exercise>();
            }
        }
    }
}