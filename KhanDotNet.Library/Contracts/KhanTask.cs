using KhanDotNet.Library.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace KhanDotNet.Library.Contracts
{
    public class KhanTask
    {
        [JsonProperty("completion_criteria")]
        public CompletionCriteria CompletionCriteria { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("task_type")]
        public string TaskType { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("badges_awarded")]
        public List<object> BadgesAwarded { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("seconds_watched")]
        public int SecondsWatched { get; set; }

        [JsonProperty("language_tag")]
        public string LanguageTag { get; set; }

        [JsonProperty("points_earned")]
        public int PointsEarned { get; set; }

        [JsonProperty("direct_link")]
        public Uri DirectLink { get; set; }

        [JsonProperty("last_second_watched")]
        public int LastSecondWatched { get; set; }

        [JsonProperty("content")]
        public Video Content { get; set; }

        [JsonProperty("translated_description")]
        public string TranslatedDescription { get; set; }

        [JsonProperty("point_bounty")]
        public int PointBounty { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("versions")]
        public Versions Versions { get; set; }

        [JsonProperty("translated_title")]
        public string TranslatedTitle { get; set; }

        [JsonProperty("translated_description_html")]
        public string TranslatedDescriptionHtml { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("avatar_parts_awarded")]
        public List<object> AvatarPartsAwarded { get; set; }

        public override string ToString()
        {
            return SensitiveSerializer.Serialize(this);
        }
    }
}