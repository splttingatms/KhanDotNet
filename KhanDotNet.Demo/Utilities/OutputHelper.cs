using EasyConsole;
using Newtonsoft.Json;
using System;

namespace KhanDotNet.Demo.Utilities
{
    public static class OutputHelper
    {
        public static void Success(object resultToSerialize)
        {
            var serialized = JsonConvert.SerializeObject(resultToSerialize, Formatting.Indented);
            Output.WriteLine(ConsoleColor.Green, serialized);
        }

        public static void Warning(string message)
        {
            Output.WriteLine(ConsoleColor.Yellow, message);
        }
    }
}
