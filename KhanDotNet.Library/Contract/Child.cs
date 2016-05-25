using Newtonsoft.Json;
using System;

namespace KhanDotNet.Library.Contract
{
    public class Child
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("internal_id")]
        public string InternalId { get; set; }

        [JsonProperty("node_slug")]
        public string NodeSlug { get; set; }

        [JsonProperty("translated_standalone_title")]
        public string TranslatedStandaloneTitle { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("translated_title")]
        public string TranslatedTitle { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("hide")]
        public bool Hide { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("edit_slug")]
        public string EditSlug { get; set; }

        [JsonProperty("translated_description")]
        public string TranslatedDescription { get; set; }

        [JsonProperty("standalone_title")]
        public string StandaloneTitle { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
