using Newtonsoft.Json;
using System;

namespace KhanDotNet.Library.Contracts
{
    public class ProgressChange
    {
        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("exercise_name")]
        public string ExerciseName { get; set; }

        [JsonProperty("to_progress")]
        public Progress ToProgress { get; set; }

        [JsonProperty("from_progress")]
        public Progress FromProgress { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
