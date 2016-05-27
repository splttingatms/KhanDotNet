﻿using KhanDotNet.Library.Contract;
using KhanDotNet.Library.Utilities;
using OAuth;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace KhanDotNet.Library
{
    public class UserClient : BaseClient, IUserClient
    {
        private IAuthentication Authenticator { get; set; }

        private ConsumerCredentials Credentials { get; set; }

        public UserClient(IHttpClient httpClient, IAuthentication authenticator, ConsumerCredentials credentials)
            : base(httpClient)
        {
            Authenticator = authenticator;
            Credentials = credentials;
        }

        public async Task<User> GetUserAsync()
        {
            if (Authenticator == null) throw new InvalidOperationException("Authenticated APIs require an authenticator");
            if (Credentials == null) throw new InvalidOperationException("Authenticated APIs require consumer credentials");

            var accessToken = await Authenticator.GetAccessTokenAsync();

            // TODO 2: move endpoint to constants file
            var req = OAuthRequest.ForProtectedResource("GET", Credentials.Key, Credentials.Secret, accessToken.Token, accessToken.Secret);
            req.RequestUrl = "https://www.khanacademy.org/api/v1/user";

            var path = "https://www.khanacademy.org/api/v1/user" + "?" + req.GetAuthorizationQuery();
            using (var response = await _httpClient.GetAsync(path))
            {
                return await response.Content.ReadAsAsync<User>();
            }
        }
    }
}
