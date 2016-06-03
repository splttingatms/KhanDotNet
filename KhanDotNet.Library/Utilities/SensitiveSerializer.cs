using Newtonsoft.Json;

namespace KhanDotNet.Library.Utilities
{
    static class SensitiveSerializer
    {
        public static string Serialize<T>(T value) where T : class
        {
            return JsonConvert.SerializeObject(value, new SensitiveConverter<T>());
        }
    }
}
