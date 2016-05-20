﻿using KhanDotNet.Library.Contract;
using KhanDotNet.Library.Utilities;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

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
            using (var response = await _httpClient.GetAsync("http://www.khanacademy.org/api/v1/badges"))
            {
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsAsync<List<Badge>>();
            }
        }
    }
}