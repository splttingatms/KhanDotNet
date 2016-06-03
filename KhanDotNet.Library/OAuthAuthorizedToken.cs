using Newtonsoft.Json;

namespace KhanDotNet.Library
{
    public class OAuthAuthorizedToken : OAuthToken
    {
        public string Verifier { get; set; }

        public OAuthAuthorizedToken(string token, string secret, string verifier)
            : base(token, secret)
        {
            Verifier = verifier;
        }

        public override string ToString()
        {
            // TODO 1: remove secret from being exposed in logs
            return JsonConvert.SerializeObject(this);
        }
    }
}
