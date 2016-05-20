using KhanDotNet.Library.Utilities;
using System;

namespace KhanDotNet.Library
{
    public class KhanClient : IKhanClient
    {
        // TODO: reuse the same HTTP client
        public KhanClient()
            : this(
                  new BadgeClient(DisposableUtilities.SafeCreate<HttpClientWrapper>()),
                  new ExerciseClient(DisposableUtilities.SafeCreate<HttpClientWrapper>()))
        {
        }

        public KhanClient(IBadgeClient badgeClient, IExerciseClient exerciseClient)
        {
            Badges = badgeClient;
            Exercises = exerciseClient;
        }

        public IBadgeClient Badges { get; private set; }

        public IExerciseClient Exercises { get; private set; }

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