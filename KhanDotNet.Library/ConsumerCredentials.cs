using Newtonsoft.Json;

namespace KhanDotNet.Library
{
    public class ConsumerCredentials
    {
        public string Key { get; private set; }

        public string Secret { get; private set; }

        public ConsumerCredentials(string consumerKey, string consumerSecret)
        {
            Key = consumerKey;
            Secret = consumerSecret;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
