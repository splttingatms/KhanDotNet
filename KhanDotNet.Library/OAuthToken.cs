using Newtonsoft.Json;

namespace KhanDotNet.Library
{
    public class OAuthToken
    {
        public string Secret { get; set; }

        public string Token { get; set; }

        public OAuthToken(string token, string secret)
        {
            Token = token;
            Secret = secret;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
