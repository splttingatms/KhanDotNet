using EnsureThat;
using KhanDotNet.Library.Contracts;
using KhanDotNet.Library.Utilities;
using OAuth;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

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
            return await GetUserAsync(CancellationToken.None);
        }

        public async Task<User> GetUserAsync(CancellationToken cancellationToken)
        {
            if (Authenticator == null) throw new InvalidOperationException("Authenticated APIs require an authenticator");
            if (Credentials == null) throw new InvalidOperationException("Authenticated APIs require consumer credentials");

            var accessToken = await Authenticator.GetAccessTokenAsync(cancellationToken);

            // TODO 2: move endpoint to constants file
            var req = OAuthRequest.ForProtectedResource("GET", Credentials.Key, Credentials.Secret, accessToken.Token, accessToken.Secret);
            req.RequestUrl = "https://www.khanacademy.org/api/v1/user";

            var path = "https://www.khanacademy.org/api/v1/user" + "?" + req.GetAuthorizationQuery();
            using (var response = await _httpClient.GetAsync(path, cancellationToken))
            {
                return await response.Content.ReadAsAsync<User>(cancellationToken);
            }
        }

        public async Task<List<ExerciseInteraction>> GetUserExercisesAsync()
        {
            return await GetUserExercisesAsync(CancellationToken.None);
        }

        public async Task<List<ExerciseInteraction>> GetUserExercisesAsync(CancellationToken cancellationToken)
        {
            if (Authenticator == null) throw new InvalidOperationException("Authenticated APIs require an authenticator");
            if (Credentials == null) throw new InvalidOperationException("Authenticated APIs require consumer credentials");

            var accessToken = await Authenticator.GetAccessTokenAsync(cancellationToken);

            var req = OAuthRequest.ForProtectedResource("GET", Credentials.Key, Credentials.Secret, accessToken.Token, accessToken.Secret);
            req.RequestUrl = "https://www.khanacademy.org/api/v1/user/exercises";

            var path = "https://www.khanacademy.org/api/v1/user/exercises" + "?" + req.GetAuthorizationQuery();
            using (var response = await _httpClient.GetAsync(path, cancellationToken))
            {
                System.IO.File.WriteAllText("user_exercises.json", await response.Content.ReadAsStringAsync());
                return await response.Content.ReadAsAsync<List<ExerciseInteraction>>(cancellationToken);
            }
        }

        public async Task<ExerciseInteraction> GetUserExerciseAsync(string exerciseName)
        {
            return await GetUserExerciseAsync(exerciseName, CancellationToken.None);
        }

        public async Task<ExerciseInteraction> GetUserExerciseAsync(string exerciseName, CancellationToken cancellationToken)
        {
            Ensure.That(exerciseName, nameof(exerciseName)).IsNotNullOrWhiteSpace();
            if (Authenticator == null) throw new InvalidOperationException("Authenticated APIs require an authenticator");
            if (Credentials == null) throw new InvalidOperationException("Authenticated APIs require consumer credentials");

            var accessToken = await Authenticator.GetAccessTokenAsync(cancellationToken);

            exerciseName = HttpUtility.UrlEncode(exerciseName);

            var req = OAuthRequest.ForProtectedResource("GET", Credentials.Key, Credentials.Secret, accessToken.Token, accessToken.Secret);
            req.RequestUrl = "https://www.khanacademy.org/api/v1/user/exercises/{0}".F(exerciseName);

            var path = "{0}?{1}".F(req.RequestUrl, req.GetAuthorizationQuery());
            using (var response = await _httpClient.GetAsync(path, cancellationToken))
            {
                return await response.Content.ReadAsAsync<ExerciseInteraction>(cancellationToken);
            }
        }
    }
}
