using KhanDotNet.Library.Utilities;

namespace KhanDotNet.Library.Authentication
{
    public class OAuthAuthorizedToken : OAuthToken
    {
        [Sensitive]
        public string Verifier { get; set; }

        public OAuthAuthorizedToken(string token, string secret, string verifier)
            : base(token, secret)
        {
            Verifier = verifier;
        }

        public override string ToString()
        {
            return SensitiveSerializer.Serialize(this);
        }
    }
}
