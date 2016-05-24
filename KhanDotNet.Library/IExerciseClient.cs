using KhanDotNet.Library.Contract;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KhanDotNet.Library
{
    public interface IExerciseClient : IDisposable
    {
        Task<Exercise> GetExerciseAsync(string name);

        Task<List<Exercise>> GetExercisesAsync();
    }
}
