using EnsureThat;
using KhanDotNet.Library.Authentication;
using KhanDotNet.Library.Contracts;
using KhanDotNet.Library.Utilities;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace KhanDotNet.Library
{
    public class UserClient : BaseClient, IUserClient
    {
        private IAuthenticator Authenticator { get; set; }

        public UserClient(IHttpClient httpClient, IAuthenticator authenticator)
            : base(httpClient)
        {
            Ensure.That(authenticator, nameof(authenticator)).IsNotNull();

            Authenticator = authenticator;
        }

        public async Task<User> GetUserAsync()
        {
            return await GetUserAsync(CancellationToken.None);
        }

        public async Task<User> GetUserAsync(CancellationToken cancellationToken)
        {
            // TODO 2: move endpoint to constants file
            var path = await Authenticator.CreateAuthenticatedRequestPath("https://www.khanacademy.org/api/v1/user", cancellationToken);
            using (var response = await _httpClient.GetAsync(path, cancellationToken))
            {
                return await response.Content.ReadAsAsync<User>(cancellationToken);
            }
        }

        public async Task<List<UserExercise>> GetUserExercisesAsync()
        {
            return await GetUserExercisesAsync(CancellationToken.None);
        }

        public async Task<List<UserExercise>> GetUserExercisesAsync(CancellationToken cancellationToken)
        {
            var path = await Authenticator.CreateAuthenticatedRequestPath("https://www.khanacademy.org/api/v1/user/exercises", cancellationToken);
            using (var response = await _httpClient.GetAsync(path, cancellationToken))
            {
                return await response.Content.ReadAsAsync<List<UserExercise>>(cancellationToken);
            }
        }

        public async Task<UserExercise> GetUserExerciseAsync(string exerciseName)
        {
            return await GetUserExerciseAsync(exerciseName, CancellationToken.None);
        }

        public async Task<UserExercise> GetUserExerciseAsync(string exerciseName, CancellationToken cancellationToken)
        {
            Ensure.That(exerciseName, nameof(exerciseName)).IsNotNullOrWhiteSpace();

            var path = await Authenticator.CreateAuthenticatedRequestPath("https://www.khanacademy.org/api/v1/user/exercises/{0}".FUrlEncoded(exerciseName), cancellationToken);
            using (var response = await _httpClient.GetAsync(path, cancellationToken))
            {
                return await response.Content.ReadAsAsync<UserExercise>(cancellationToken);
            }
        }

        public async Task<List<ProblemLog>> GetUserExerciseProblemLogsAsync(string exerciseName)
        {
            return await GetUserExerciseProblemLogsAsync(exerciseName, CancellationToken.None);
        }

        public async Task<List<ProblemLog>> GetUserExerciseProblemLogsAsync(string exerciseName, CancellationToken cancellationToken)
        {
            Ensure.That(exerciseName, nameof(exerciseName)).IsNotNullOrWhiteSpace();

            var path = await Authenticator.CreateAuthenticatedRequestPath("https://www.khanacademy.org/api/v1/user/exercises/{0}/log".FUrlEncoded(exerciseName), cancellationToken);
            using (var response = await _httpClient.GetAsync(path, cancellationToken))
            {
                return await response.Content.ReadAsAsync<List<ProblemLog>>(cancellationToken);
            }
        }

        public async Task<List<ProgressChange>> GetUserProgressChangesAsync()
        {
            return await GetUserProgressChangesAsync(CancellationToken.None);
        }

        public async Task<List<ProgressChange>> GetUserProgressChangesAsync(CancellationToken cancellationToken)
        {
            var path = await Authenticator.CreateAuthenticatedRequestPath("https://www.khanacademy.org/api/v1/user/exercises/progress_changes", cancellationToken);
            using (var response = await _httpClient.GetAsync(path, cancellationToken))
            {
                return await response.Content.ReadAsAsync<List<ProgressChange>>(cancellationToken);
            }
        }

        public async Task<List<UserVideo>> GetUserVideoInteractionsAsync()
        {
            return await GetUserVideoInteractionsAsync(CancellationToken.None);
        }

        public async Task<List<UserVideo>> GetUserVideoInteractionsAsync(CancellationToken cancellationToken)
        {
            var path = await Authenticator.CreateAuthenticatedRequestPath("https://www.khanacademy.org/api/v1/user/videos", cancellationToken);
            using (var response = await _httpClient.GetAsync(path, cancellationToken))
            {
                return await response.Content.ReadAsAsync<List<UserVideo>>(cancellationToken);
            }
        }
    }
}