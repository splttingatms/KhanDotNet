using EasyConsole;
using KhanDotNet.Demo.Utilities;
using KhanDotNet.Library;

namespace KhanDotNet.Demo.Pages
{
    class ExercisePage : MenuPage
    {
        private IKhanClient _client;

        public ExercisePage(Program program, IKhanClient client)
            : base("Exercises", program)
        {
            Menu.Add("Get exercises", GetExercisesCallback);
            Menu.Add("Get exercise", GetExerciseCallback);
            Menu.Add("Get follow-up exercises", GetFollowUpExercisesCallback);
            Menu.Add("Get exercise videos", GetExerciseVideosCallback);

            _client = client;
        }

        private void GetExercisesCallback()
        {
            var exercises = _client.Exercises.GetExercisesAsync().Result;
            OutputHelper.Success(exercises);
        }

        private void GetExerciseCallback()
        {
            var input = Input.ReadString("Enter exercise name:");

            var exercise = _client.Exercises.GetExerciseAsync(input).Result;
            OutputHelper.Success(exercise);
        }

        private void GetFollowUpExercisesCallback()
        {
            var input = Input.ReadString("Enter exercise name:");

            var exercises = _client.Exercises.GetFollowUpExercisesAsync(input).Result;
            OutputHelper.Success(exercises);
        }

        private void GetExerciseVideosCallback()
        {
            var input = Input.ReadString("Enter exercise name:");

            var videos = _client.Exercises.GetExerciseVideosAsync(input).Result;
            OutputHelper.Success(videos);
        }
    }
}
