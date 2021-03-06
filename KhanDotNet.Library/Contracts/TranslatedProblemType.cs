﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace KhanDotNet.Library.Contracts
{
    public class TranslatedProblemType
    {
        [JsonProperty("items")]
        public List<Item> Items { get; set; }

        [JsonProperty("related_videos")]
        public List<string> RelatedVideos { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
