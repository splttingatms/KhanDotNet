using EasyConsole;
using KhanDotNet.Demo.Utilities;
using KhanDotNet.Library;

namespace KhanDotNet.Demo.Pages
{
    class UserPage : MenuPage
    {
        private IKhanClient _client;

        public UserPage(Program program, IKhanClient client)
            : base("Badges", program)
        {
            Menu.Add("Get user (authenticated)", GetUserCallback);
            Menu.Add("Get user exercises (authenticated)", GetUserExercisesCallback);
            Menu.Add("Get user exercise (authenticated)", GetUserExerciseCallback);

            _client = client;
        }

        private void GetUserCallback()
        {
            var user = _client.Users.GetUserAsync().Result;
            OutputHelper.Success(user);
        }

        private void GetUserExercisesCallback()
        {
            var exercises = _client.Users.GetUserExercisesAsync().Result;
            OutputHelper.Success(exercises);
        }

        private void GetUserExerciseCallback()
        {
            var name = Input.ReadString("Enter exercise name:");
            var exercise = _client.Users.GetUserExerciseAsync(name).Result;
            OutputHelper.Success(exercise);
        }
    }
}
