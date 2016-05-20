using KhanDotNet.Library.Contract;
using System;
using System.Threading.Tasks;

namespace KhanDotNet.Library
{
    public interface IExerciseClient : IDisposable
    {
        Task<Exercise> GetExercise(string name);
    }
}
