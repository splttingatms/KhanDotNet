using KhanDotNet.Library.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace KhanDotNet.Library.Contracts
{
    public class VideoLog
    {
        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("seconds_watched")]
        public int SecondsWatched { get; set; }

        [JsonProperty("translated_video_title")]
        public string TranslatedVideoTitle { get; set; }

        [JsonProperty("time_watched")]
        public DateTime TimeWatched { get; set; }

        [JsonProperty("backup_timestamp")]
        public DateTime BackupTimestamp { get; set; }

        [JsonProperty("points_earned")]
        public int PointsEarned { get; set; }

        [JsonProperty("playlist_titles")]
        public List<string> PlaylistTitles { get; set; }

        [JsonProperty("last_second_watched")]
        public int LastSecondWatched { get; set; }

        [JsonProperty("is_video_completed")]
        public bool IsVideoCompleted { get; set; }

        [JsonProperty("fallback_player")]
        public bool FallbackPlayer { get; set; }

        [JsonProperty("youtube_id")]
        public string YouTubeId { get; set; }

        [JsonProperty("captions_locale")]
        public object CaptionsLocale { get; set; }

        [JsonProperty("translated_playlist_titles")]
        public List<string> TranslatedPlaylistTitles { get; set; }

        [JsonProperty("kaid")]
        public string KaId { get; set; }

        [JsonProperty("ip_address")]
        public object IpAddress { get; set; }

        [JsonProperty("video_title")]
        public string VideoTitle { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        public override string ToString()
        {
            return SensitiveSerializer.Serialize(this);
        }
    }
}
