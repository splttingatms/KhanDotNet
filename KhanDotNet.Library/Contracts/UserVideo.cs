using KhanDotNet.Library.Utilities;
using Newtonsoft.Json;
using System;

namespace KhanDotNet.Library.Contracts
{
    public class UserVideo
    {
        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("seconds_watched")]
        public int SecondsWatched { get; set; }

        [JsonProperty("last_watched")]
        public DateTime LastWatched { get; set; }

        [JsonProperty("completed")]
        public bool Completed { get; set; }

        [JsonProperty("backup_timestamp")]
        public DateTime BackupTimestamp { get; set; }

        [JsonProperty("last_second_watched")]
        public int LastSecondWatched { get; set; }

        [JsonProperty("points")]
        public int Points { get; set; }

        [JsonProperty("video")]
        public Video Video { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("progress")]
        public double Progress { get; set; }

        [JsonProperty("kaid")]
        public string KaId { get; set; }

        public override string ToString()
        {
            return SensitiveSerializer.Serialize(this);
        }
    }
}
