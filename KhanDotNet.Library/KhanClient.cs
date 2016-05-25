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
                new TopicClient(innerClient));
        }

        public KhanClient(IBadgeClient badgeClient, IExerciseClient exerciseClient, ITopicClient topicClient)
        {
            Initialize(badgeClient, exerciseClient, topicClient);
        }

        public IBadgeClient Badges { get; private set; }

        public IExerciseClient Exercises { get; private set; }

        public ITopicClient Topics { get; private set; }

        private void Initialize(IBadgeClient badgeClient, IExerciseClient exerciseClient, ITopicClient topicClient)
        {
            Badges = badgeClient;
            Exercises = exerciseClient;
            Topics = topicClient;
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
            }
        }
    }
}