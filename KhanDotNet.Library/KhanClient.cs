using KhanDotNet.Library.Utilities;
using System;

namespace KhanDotNet.Library
{
    public class KhanClient : IKhanClient
    {
        public KhanClient()
        {
            var innerClient = DisposableUtilities.SafeCreate<HttpClientWrapper>();
            Initialize(
                new BadgeClient(innerClient),
                new ExerciseClient(innerClient));
        }

        public KhanClient(IBadgeClient badgeClient, IExerciseClient exerciseClient)
        {
            Initialize(badgeClient, exerciseClient);
        }

        public IBadgeClient Badges { get; private set; }

        public IExerciseClient Exercises { get; private set; }

        private void Initialize(IBadgeClient badgeClient, IExerciseClient exerciseClient)
        {
            Badges = badgeClient;
            Exercises = exerciseClient;
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