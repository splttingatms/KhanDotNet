using KhanDotNet.Library.Utilities;
using System;

namespace KhanDotNet.Library
{
    public class KhanClient : IKhanClient
    {
        public KhanClient()
            : this(authenticator: null, credentials: null)
        {
        }

        public KhanClient(IAuthentication authenticator, ConsumerCredentials credentials)
        {
            // TODO 2: create HttpClientFactory but for IHttpClient
            var innerClient = DisposableUtilities.SafeCreate<HttpClientWithValidator>();
            Initialize(
                new BadgeClient(innerClient),
                new ExerciseClient(innerClient),
                new TopicClient(innerClient),
                new TopicTreeClient(innerClient),
                new UserClient(innerClient, authenticator, credentials));
        }

        public KhanClient(
            IBadgeClient badgeClient, IExerciseClient exerciseClient, 
            ITopicClient topicClient, ITopicTreeClient topicTreeClient,
            IUserClient userClient)
        {
            Initialize(badgeClient, exerciseClient, topicClient, topicTreeClient, userClient);
        }

        public IBadgeClient Badges { get; private set; }

        public IExerciseClient Exercises { get; private set; }

        public ITopicClient Topics { get; private set; }

        public ITopicTreeClient TopicTree { get; private set; }

        public IUserClient Users { get; private set; }

        private void Initialize(
            IBadgeClient badgeClient, IExerciseClient exerciseClient, 
            ITopicClient topicClient, ITopicTreeClient topicTreeClient,
            IUserClient userClient)
        {
            Badges = badgeClient;
            Exercises = exerciseClient;
            Topics = topicClient;
            TopicTree = topicTreeClient;
            Users = userClient;
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

                Users?.Dispose();
                Users = null;
            }
        }
    }
}