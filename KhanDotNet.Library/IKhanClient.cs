using KhanDotNet.Library.Contract;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KhanDotNet.Library
{
    public interface IKhanClient : IDisposable
    {
        Task<List<Badge>> GetBadges();

        Task<Exercise> GetExercise(string name);
    }
}