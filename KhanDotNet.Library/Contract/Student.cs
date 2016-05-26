using Newtonsoft.Json;

// TODO 1: rename to plural "Contracts"
namespace KhanDotNet.Library.Contract
{
    public class Student
    {
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
