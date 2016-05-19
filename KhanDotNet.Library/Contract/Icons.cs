using KhanDotNet.Library.Utilities;
using Newtonsoft.Json;
using System;

namespace KhanDotNet.Library.Contract
{
    public class Icons
    {
        [JsonProperty("small")]
        public Uri Small { get; set; }

        [JsonProperty("compact")]
        public Uri Compact { get; set; }

        [JsonProperty("large")]
        public Uri Large { get; set; }

        [JsonProperty("email")]
        public Uri Email { get; set; }

        public override int GetHashCode()
        {
            return Small.SafeGetHashCode() ^
                Compact.SafeGetHashCode() ^
                Large.SafeGetHashCode() ^
                Email.SafeGetHashCode();
        }

        public override bool Equals(object obj)
        {
            var other = obj as Icons;

            if (other == null)
            {
                return false;
            }

            return Small.SafeEquals(other.Small) &&
                Compact.SafeEquals(other.Compact) &&
                Large.SafeEquals(other.Large) &&
                Email.SafeEquals(other.Email);
        }
    }
}
