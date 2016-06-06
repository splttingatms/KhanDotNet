using KhanDotNet.Library.Utilities;
using Newtonsoft.Json;

namespace KhanDotNet.Library.Contracts
{
    public class KhanTaskWrapper
    {
        [JsonProperty("task_json")]
        public KhanTask Task { get; set; }

        public override string ToString()
        {
            return SensitiveSerializer.Serialize(this);
        }
    }
}