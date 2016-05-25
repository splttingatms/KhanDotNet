using System;

namespace KhanDotNet.Library
{
    public interface IKhanClient : IDisposable
    {
        IBadgeClient Badges { get; }

        IExerciseClient Exercises { get; }

        ITopicClient Topics { get; }
    }
}