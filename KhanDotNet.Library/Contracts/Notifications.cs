using KhanDotNet.Library.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace KhanDotNet.Library.Contracts
{
    public class Notifications
    {
        [JsonProperty("urgent")]
        public List<object> Urgent { get; set; }

        [JsonProperty("readable")]
        public List<object> Readable { get; set; }

        [JsonProperty("continue_url")]
        public Uri ContinueUrl { get; set; }

        public override string ToString()
        {
            return SensitiveSerializer.Serialize(this);
        }
    }
}