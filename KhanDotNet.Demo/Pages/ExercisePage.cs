using EasyConsole;
using KhanDotNet.Library;
using KhanDotNet.Demo.Utilities;

namespace KhanDotNet.Demo.Pages
{
    class ExercisePage : MenuPage
    {
        private IKhanClient _client;

        public ExercisePage(Program program, IKhanClient client)
            : base("Exercises", program)
        {
            Menu.Add("Get exercise", GetExercisesCallback);

            _client = client;
        }

        private void GetExercisesCallback()
        {
            var input = Input.ReadString("Enter exercise name:");

            var exercise = _client.Exercises.GetExerciseAsync(input).Result;
            OutputHelper.Success(exercise);
        }
    }
}
