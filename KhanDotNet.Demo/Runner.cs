using KhanDotNet.Demo;

namespace KhanDotNet
{
    class Runner
    {
        static void Main(string[] args)
        {
            using (var demo = new KhanDotNetDemo())
            {
                demo.Run();
            }
        }
    }
}
