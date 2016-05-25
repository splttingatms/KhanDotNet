using KhanDotNet.Library.Contract;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KhanDotNet.Library
{
    public interface ITopicClient : IDisposable
    {
        Task<Topic> GetTopicAsync(string slug);

        Task<List<Exercise>> GetTopicExercisesAsync(string slug);

        Task<List<Video>> GetTopicVideosAsync(string slug);
    }
}
