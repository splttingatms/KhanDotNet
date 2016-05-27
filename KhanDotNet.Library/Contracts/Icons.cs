using Newtonsoft.Json;
using System;

namespace KhanDotNet.Library.Contracts
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

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
