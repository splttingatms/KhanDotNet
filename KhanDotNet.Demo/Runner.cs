using KhanDotNet.Demo;
using System.Diagnostics;

namespace KhanDotNet
{
    class Runner
    {
        static void Main(string[] args)
        {
            Trace.Listeners.Add(new ConsoleTraceListener());

            using (var demo = new KhanDotNetDemo())
            {
                demo.Run();
            }
        }
    }
}
