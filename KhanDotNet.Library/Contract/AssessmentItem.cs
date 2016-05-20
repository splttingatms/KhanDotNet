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

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
