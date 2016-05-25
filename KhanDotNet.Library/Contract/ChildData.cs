﻿using Newtonsoft.Json;

namespace KhanDotNet.Library.Contract
{
    public class ChildData
    {
        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
