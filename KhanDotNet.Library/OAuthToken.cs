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
            // TODO 1: remove tostring to reduce risk of leaking credentials in logs
            return JsonConvert.SerializeObject(this);
        }
    }
}
