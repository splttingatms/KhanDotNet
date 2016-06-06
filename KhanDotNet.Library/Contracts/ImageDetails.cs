using KhanDotNet.Library.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace KhanDotNet.Library.Contracts
{
    public class ImageDetails
    {
        [JsonProperty("thumb_src")]
        public Uri ThumbSrc { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("image_path")]
        public Uri ImagePath { get; set; }

        [JsonProperty("reward_triggers")]
        public string RewardTriggers { get; set; }

        [JsonProperty("thumb_path")]
        public Uri ThumbPath { get; set; }

        [JsonProperty("translated_requirements")]
        public List<object> TranslatedRequirements { get; set; }

        [JsonProperty("part_type")]
        public string PartType { get; set; }

        [JsonProperty("thumbnail_path")]
        public Uri ThumbnailPath { get; set; }

        [JsonProperty("thumbnail_src")]
        public Uri ThumbnailSrc { get; set; }

        [JsonProperty("reward_type")]
        public string RewardType { get; set; }

        [JsonProperty("translated_display_name")]
        public string TranslatedDisplayName { get; set; }

        [JsonProperty("image_src")]
        public Uri ImageSrc { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        public override string ToString()
        {
            return SensitiveSerializer.Serialize(this);
        }
    }
}