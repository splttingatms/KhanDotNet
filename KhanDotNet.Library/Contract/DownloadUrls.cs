using Newtonsoft.Json;
using System;

namespace KhanDotNet.Library.Contract
{
    public class DownloadUrls
    {
        [JsonProperty("mp4")]
        public Uri Mp4 { get; set; }

        [JsonProperty("m3u8")]
        public Uri M3U8 { get; set; }

        [JsonProperty("png")]
        public Uri Png { get; set; }

        [JsonProperty("mp4-low")]
        public Uri Mp4Low { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
