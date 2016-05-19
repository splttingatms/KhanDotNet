using Newtonsoft.Json;
using System;

namespace KhanDotNet.Library.Contract
{
    public class Badge
    {
        [JsonProperty("icon_src")]
        public Uri IconSource { get; set; }

        [JsonProperty("hide_context")]
        public bool HideContext { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("relative_url")]
        public Uri RelativeUrl { get; set; }

        [JsonProperty("icons")]
        public Icons Icons { get; set; }

        [JsonProperty("absolute_url")]
        public Uri AbsoluteUrl { get; set; }

        [JsonProperty("user_badges")]
        public object UserBadges { get; set; }

        [JsonProperty("translated_safe_extended_description")]
        public string DescriptionExtendedTranslatedSafe { get; set; }

        [JsonProperty("translated_description")]
        public string DescriptionTranslated { get; set; }

        [JsonProperty("is_owned")]
        public bool IsOwned { get; set; }

        [JsonProperty("badge_category")]
        public int Category { get; set; }

        [JsonProperty("points")]
        public int Points { get; set; }

        [JsonProperty("is_retired")]
        public bool IsRetired { get; set; }

        [JsonProperty("safe_extended_description")]
        public string DescriptionExtendedSafe { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
