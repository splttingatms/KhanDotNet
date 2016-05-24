using Newtonsoft.Json;

namespace KhanDotNet.Library.Contract
{
    public class AssessmentItem
    {
        [JsonProperty("sha")]
        public string Sha { get; set; }

        [JsonProperty("live")]
        public bool Live { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("perseus_api_major_version")]
        public string PerseusApiMajorVersion { get; set; }

        [JsonProperty("requires_screen_or_mouse")]
        public bool RequiresScreenOrMouse { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
