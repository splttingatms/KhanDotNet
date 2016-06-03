using KhanDotNet.Library.Contracts;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KhanDotNet.Library
{
    public interface IUserClient : IDisposable
    {
        Task<User> GetUserAsync();
        Task<User> GetUserAsync(CancellationToken cancellationToken);

        Task<List<ExerciseInteraction>> GetUserExercisesAsync();
        Task<List<ExerciseInteraction>> GetUserExercisesAsync(CancellationToken cancellationToken);

        Task<ExerciseInteraction> GetUserExerciseAsync(string exerciseName);
        Task<ExerciseInteraction> GetUserExerciseAsync(string exerciseName, CancellationToken cancellationToken);

        Task<List<ProblemLog>> GetUserExerciseProblemLogsAsync(string exerciseName);
        Task<List<ProblemLog>> GetUserExerciseProblemLogsAsync(string exerciseName, CancellationToken cancellationToken);

        Task<List<ProgressChange>> GetUserProgressChangesAsync();
        Task<List<ProgressChange>> GetUserProgressChangesAsync(CancellationToken cancellationToken);

        Task<List<UserVideo>> GetUserWatchedVideosAsync();
        Task<List<UserVideo>> GetUserWatchedVideosAsync(CancellationToken cancellationToken);
    }
}
