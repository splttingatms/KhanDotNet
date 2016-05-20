using Newtonsoft.Json;

namespace KhanDotNet.Library.Contract
{
    public class ThumbnailData
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("skip_filter")]
        public bool SkipFilter { get; set; }

        [JsonProperty("title_text")]
        public string TitleText { get; set; }

        [JsonProperty("gcs_name")]
        public string GcsName { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
