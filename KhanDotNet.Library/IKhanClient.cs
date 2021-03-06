﻿using System;

namespace KhanDotNet.Library
{
    public interface IKhanClient : IDisposable
    {
        IBadgeClient Badges { get; }

        IExerciseClient Exercises { get; }

        ITopicClient Topics { get; }

        ITopicTreeClient TopicTree { get; }

        IUserClient Users { get; }
    }
}