using EnsureThat;
using KhanDotNet.Library.Contract;
using KhanDotNet.Library.Utilities;
using System.Collections.Generic;
using System.Net.Http;
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
            using (var response = await _httpClient.GetAsync("http://www.khanacademy.org/api/v1/exercises"))
            {
                return await response.Content.ReadAsAsync<List<Exercise>>();
            }
        }

        public async Task<Exercise> GetExerciseAsync(string name)
        {
            Ensure.That(name, nameof(name)).IsNotNullOrWhiteSpace();

            name = HttpUtility.UrlEncode(name);
            var path = "http://www.khanacademy.org/api/v1/exercises/{0}".F(name);

            using (var response = await _httpClient.GetAsync(path))
            {
                return await response.Content.ReadAsAsync<Exercise>();
            }
        }

        public async Task<List<Exercise>> GetFollowUpExercisesAsync(string name)
        {
            Ensure.That(name, nameof(name)).IsNotNullOrWhiteSpace();

            name = HttpUtility.UrlEncode(name);
            var path = "http://www.khanacademy.org/api/v1/exercises/{0}/followup_exercises".F(name);

            using (var response = await _httpClient.GetAsync(path))
            {
                return await response.Content.ReadAsAsync<List<Exercise>>();
            }
        }
    }
}
