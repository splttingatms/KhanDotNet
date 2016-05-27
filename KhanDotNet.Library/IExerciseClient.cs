using KhanDotNet.Library.Contracts;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KhanDotNet.Library
{
    public interface IExerciseClient : IDisposable
    {
        Task<List<Exercise>> GetExercisesAsync();
        Task<List<Exercise>> GetExercisesAsync(CancellationToken cancellationToken);

        Task<Exercise> GetExerciseAsync(string name);
        Task<Exercise> GetExerciseAsync(string name, CancellationToken cancellationToken);

        Task<List<Exercise>> GetFollowUpExercisesAsync(string name);
        Task<List<Exercise>> GetFollowUpExercisesAsync(string name, CancellationToken cancellationToken);

        Task<List<Video>> GetExerciseVideosAsync(string name);
        Task<List<Video>> GetExerciseVideosAsync(string name, CancellationToken cancellationToken);

        Task<List<PerseusExercise>> GetPerseusExercisesAsync();
        Task<List<PerseusExercise>> GetPerseusExercisesAsync(CancellationToken cancellationToken);
    }
}
