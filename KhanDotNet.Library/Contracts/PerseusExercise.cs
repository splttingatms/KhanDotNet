﻿using Newtonsoft.Json;

namespace KhanDotNet.Library.Contracts
{
    public class PerseusExercise
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
