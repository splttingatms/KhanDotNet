using EnsureThat;
using KhanDotNet.Library.Contracts;
using KhanDotNet.Library.Utilities;
using OAuth;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
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
            return await GetUserAsync(CancellationToken.None);
        }

        public async Task<User> GetUserAsync(CancellationToken cancellationToken)
        {
            // TODO 2: move endpoint to constants file
            // TODO 1: ensure cancellation token not null
            var path = await CreateAuthenticatedRequestPath("https://www.khanacademy.org/api/v1/user", cancellationToken);
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
            var path = await CreateAuthenticatedRequestPath("https://www.khanacademy.org/api/v1/user/exercises", cancellationToken);
            using (var response = await _httpClient.GetAsync(path, cancellationToken))
            {
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

            var path = await CreateAuthenticatedRequestPath("https://www.khanacademy.org/api/v1/user/exercises/{0}".FUrlEncoded(exerciseName), cancellationToken);
            using (var response = await _httpClient.GetAsync(path, cancellationToken))
            {
                return await response.Content.ReadAsAsync<ExerciseInteraction>(cancellationToken);
            }
        }

        public async Task<List<ProblemLog>> GetUserExerciseProblemLogsAsync(string exerciseName)
        {
            return await GetUserExerciseProblemLogsAsync(exerciseName, CancellationToken.None);
        }

        public async Task<List<ProblemLog>> GetUserExerciseProblemLogsAsync(string exerciseName, CancellationToken cancellationToken)
        {
            Ensure.That(exerciseName, nameof(exerciseName)).IsNotNullOrWhiteSpace();

            var path = await CreateAuthenticatedRequestPath("https://www.khanacademy.org/api/v1/user/exercises/{0}/log".FUrlEncoded(exerciseName), cancellationToken);
            using (var response = await _httpClient.GetAsync(path, cancellationToken))
            {
                return await response.Content.ReadAsAsync<List<ProblemLog>>(cancellationToken);
            }
        }

        private void EnsureClientSetupWithAuthentication()
        {
            Ensure.That(Authenticator, nameof(Authenticator))
                  .WithExtraMessageOf(() => "Authenticated APIs require an authenticator")
                  .IsNotNull(throws => throws.InvalidOperationException);

            Ensure.That(Credentials)
                  .WithExtraMessageOf(() => "Authenticated APIs require consumer credentials")
                  .IsNotNull(throws => throws.InvalidOperationException);
        }

        private async Task<string> CreateAuthenticatedRequestPath(string url, CancellationToken cancellationToken)
        {
            EnsureClientSetupWithAuthentication();

            var accessToken = await Authenticator.GetAccessTokenAsync(cancellationToken);

            var req = OAuthRequest.ForProtectedResource("GET", Credentials.Key, Credentials.Secret, accessToken.Token, accessToken.Secret);
            req.RequestUrl = url;

            return new UriBuilder(url) { Query = req.GetAuthorizationQuery() }.ToString();
        }
    }
}
