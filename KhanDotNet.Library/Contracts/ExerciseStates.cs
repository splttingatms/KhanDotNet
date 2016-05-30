using Newtonsoft.Json;

namespace KhanDotNet.Library.Contracts
{
    public class ExerciseStates
    {
        [JsonProperty("struggling")]
        public bool Struggling { get; set; }

        [JsonProperty("proficient")]
        public bool Proficient { get; set; }

        [JsonProperty("practiced")]
        public bool Practiced { get; set; }

        [JsonProperty("mastered")]
        public bool Mastered { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
