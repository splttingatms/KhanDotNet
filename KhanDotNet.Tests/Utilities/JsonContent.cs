using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace KhanDotNet.Tests.Utilities
{
    class JsonContent : StringContent
    {
        public JsonContent(object contentToSerialize)
            : this(JsonConvert.SerializeObject(contentToSerialize))
        {
        }

        public JsonContent(string json)
            : base(json, Encoding.UTF8, "application/json")
        {
        }
    }
}
