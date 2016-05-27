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
    public class ExerciseClient : BaseClient, IExerciseClient
    {
        public ExerciseClient(IHttpClient httpClient)
            : base(httpClient)
        {
        }

        public async Task<List<Exercise>> GetExercisesAsync()
        {
            return await GetExercisesAsync(CancellationToken.None);
        }

        public async Task<List<Exercise>> GetExercisesAsync(CancellationToken cancellationToken)
        {
            var path = "http://www.khanacademy.org/api/v1/exercises";
            using (var response = await _httpClient.GetAsync(path, cancellationToken))
            {
                return await response.Content.ReadAsAsync<List<Exercise>>(cancellationToken);
            }
        }

        public async Task<Exercise> GetExerciseAsync(string name)
        {
            return await GetExerciseAsync(name, CancellationToken.None);
        }

        public async Task<Exercise> GetExerciseAsync(string name, CancellationToken cancellationToken)
        {
            Ensure.That(name, nameof(name)).IsNotNullOrWhiteSpace();

            name = HttpUtility.UrlEncode(name);
            var path = "http://www.khanacademy.org/api/v1/exercises/{0}".F(name);

            using (var response = await _httpClient.GetAsync(path, cancellationToken))
            {
                return await response.Content.ReadAsAsync<Exercise>(cancellationToken);
            }
        }

        public async Task<List<Exercise>> GetFollowUpExercisesAsync(string name)
        {
            return await GetFollowUpExercisesAsync(name, CancellationToken.None);
        }

        public async Task<List<Exercise>> GetFollowUpExercisesAsync(string name, CancellationToken cancellationToken)
        {
            Ensure.That(name, nameof(name)).IsNotNullOrWhiteSpace();

            name = HttpUtility.UrlEncode(name);
            var path = "http://www.khanacademy.org/api/v1/exercises/{0}/followup_exercises".F(name);

            using (var response = await _httpClient.GetAsync(path, cancellationToken))
            {
                return await response.Content.ReadAsAsync<List<Exercise>>(cancellationToken);
            }
        }

        public async Task<List<Video>> GetExerciseVideosAsync(string name)
        {
            return await GetExerciseVideosAsync(name, CancellationToken.None);
        }

        public async Task<List<Video>> GetExerciseVideosAsync(string name, CancellationToken cancellationToken)
        {
            Ensure.That(name, nameof(name)).IsNotNullOrWhiteSpace();

            name = HttpUtility.UrlEncode(name);
            var path = "http://www.khanacademy.org/api/v1/exercises/{0}/videos".F(name);

            using (var response = await _httpClient.GetAsync(path, cancellationToken))
            {
                return await response.Content.ReadAsAsync<List<Video>>(cancellationToken);
            }
        }

        public async Task<List<PerseusExercise>> GetPerseusExercisesAsync()
        {
            return await GetPerseusExercisesAsync(CancellationToken.None);
        }

        public async Task<List<PerseusExercise>> GetPerseusExercisesAsync(CancellationToken cancellationToken)
        {
            var path = "http://www.khanacademy.org/api/v1/exercises/perseus_autocomplete";
            using (var response = await _httpClient.GetAsync(path, cancellationToken))
            {
                return await response.Content.ReadAsAsync<List<PerseusExercise>>(cancellationToken);
            }
        }
    }
}
