﻿using KhanDotNet.Library.Contracts;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KhanDotNet.Library
{
    public interface ITopicClient : IDisposable
    {
        Task<Topic> GetTopicAsync(string slug);
        Task<Topic> GetTopicAsync(string slug, CancellationToken cancellationToken);

        Task<List<Exercise>> GetTopicExercisesAsync(string slug);
        Task<List<Exercise>> GetTopicExercisesAsync(string slug, CancellationToken cancellationToken);

        Task<List<Video>> GetTopicVideosAsync(string slug);
        Task<List<Video>> GetTopicVideosAsync(string slug, CancellationToken cancellationToken);
    }
}
