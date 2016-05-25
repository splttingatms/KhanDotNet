using KhanDotNet.Library.Contract;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KhanDotNet.Library
{
    public interface IExerciseClient : IDisposable
    {
        Task<List<Exercise>> GetExercisesAsync();

        Task<Exercise> GetExerciseAsync(string name);

        Task<List<Exercise>> GetFollowUpExercisesAsync(string name);

        Task<List<Video>> GetExerciseVideosAsync(string name);
    }
}
