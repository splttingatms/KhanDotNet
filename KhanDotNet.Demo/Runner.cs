using KhanDotNet.Library;
using Newtonsoft.Json;
using System;

namespace KhanDotNet
{
    class Runner
    {
        static void Main(string[] args)
        {
            try
            {
                using (var client = new KhanClient())
                {
                    var badges = client.Badges.GetBadgesAsync().Result;
                    Console.WriteLine(JsonConvert.SerializeObject(badges, Formatting.Indented));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.ReadLine();
        }
    }
}
