using KhanDotNet.Library.Utilities;
using System;

namespace KhanDotNet.Library
{
    public class KhanClient : IKhanClient
    {
        public KhanClient()
        {
            var innerClient = DisposableUtilities.SafeCreate<HttpClientWithValidator>();
            Initialize(
                new BadgeClient(innerClient),
                new ExerciseClient(innerClient),
                new TopicClient(innerClient),
                new TopicTreeClient(innerClient));
        }

        public KhanClient(IBadgeClient badgeClient, IExerciseClient exerciseClient, ITopicClient topicClient, ITopicTreeClient topicTreeClient)
        {
            Initialize(badgeClient, exerciseClient, topicClient, topicTreeClient);
        }

        public IBadgeClient Badges { get; private set; }

        public IExerciseClient Exercises { get; private set; }

        public ITopicClient Topics { get; private set; }

        public ITopicTreeClient TopicTree { get; private set; }

        private void Initialize(IBadgeClient badgeClient, IExerciseClient exerciseClient, ITopicClient topicClient, ITopicTreeClient topicTreeClient)
        {
            Badges = badgeClient;
            Exercises = exerciseClient;
            Topics = topicClient;
            TopicTree = topicTreeClient;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                Badges?.Dispose();
                Badges = null;

                Exercises?.Dispose();
                Exercises = null;

                Topics?.Dispose();
                Topics = null;

                TopicTree?.Dispose();
                TopicTree = null;
            }
        }
    }
}