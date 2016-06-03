using Newtonsoft.Json;

namespace KhanDotNet.Library.Contracts
{
    public class Progress
    {
        [JsonProperty("practiced")]
        public bool Practiced { get; set; }

        [JsonProperty("mastered")]
        public bool Mastered { get; set; }

        [JsonProperty("level")]
        public string Level { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
