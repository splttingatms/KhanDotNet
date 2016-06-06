using KhanDotNet.Library.Utilities;
using Newtonsoft.Json;

namespace KhanDotNet.Library.Contracts
{
    public class CompletionCriteria
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        public override string ToString()
        {
            return SensitiveSerializer.Serialize(this);
        }
    }
}