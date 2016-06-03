using KhanDotNet.Library.Utilities;

namespace KhanDotNet.Library.Authentication
{
    public class OAuthToken
    {
        [Sensitive]
        public string Secret { get; private set; }

        [Sensitive]
        public string Token { get; private set; }

        public OAuthToken(string token, string secret)
        {
            Token = token;
            Secret = secret;
        }

        public override string ToString()
        {
            return SensitiveSerializer.Serialize(this);
        }
    }
}
