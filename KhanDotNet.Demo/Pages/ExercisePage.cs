﻿using EasyConsole;
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
            // TODO: add GetExercises
            Menu.Add("Get exercise", GetExercisesCallback);
            Menu.Add("Get follow-up exercises", GetFollowUpExercisesCallback);

            _client = client;
        }

        private void GetExercisesCallback()
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
    }
}
