﻿using KhanDotNet.Library.Contracts;
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

        Task<List<UserExercise>> GetUserExercisesAsync();
        Task<List<UserExercise>> GetUserExercisesAsync(CancellationToken cancellationToken);

        Task<UserExercise> GetUserExerciseAsync(string exerciseName);
        Task<UserExercise> GetUserExerciseAsync(string exerciseName, CancellationToken cancellationToken);

        Task<List<ProblemLog>> GetUserExerciseProblemLogsAsync(string exerciseName);
        Task<List<ProblemLog>> GetUserExerciseProblemLogsAsync(string exerciseName, CancellationToken cancellationToken);

        Task<List<ProgressChange>> GetUserProgressChangesAsync();
        Task<List<ProgressChange>> GetUserProgressChangesAsync(CancellationToken cancellationToken);

        Task<List<UserVideo>> GetUserVideoInteractionsAsync();
        Task<List<UserVideo>> GetUserVideoInteractionsAsync(CancellationToken cancellationToken);

        Task<UserVideo> GetUserVideoInteractionsByIdAsync(string youTubeId);
        Task<UserVideo> GetUserVideoInteractionsByIdAsync(string youTubeId, CancellationToken cancellationToken);

        Task<List<VideoLog>> GetUserVideoLogAsync(string youTubeId);
        Task<List<VideoLog>> GetUserVideoLogAsync(string youTubeId, CancellationToken cancellationToken);
    }
}
