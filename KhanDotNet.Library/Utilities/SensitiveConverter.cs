using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KhanDotNet.Library.Utilities
{
    class SensitiveConverter<T> : JsonConverter where T : class
    {
        private const int DIGITS_TO_DISPLAY = 4;

        public override bool CanConvert(Type objectType)
        {
            return typeof(T) == objectType;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            List<string> memberNamesMarkedSensitive = new List<string>();

            memberNamesMarkedSensitive.AddRange(
                from prop in typeof(T).GetProperties()
                let attributes = prop.GetCustomAttributes(typeof(SensitiveAttribute), inherit: true)
                where attributes.Length > 0 && prop.PropertyType == typeof(string)
                select prop.Name);

            memberNamesMarkedSensitive.AddRange(
                from field in typeof(T).GetFields()
                let attributes = field.GetCustomAttributes(typeof(SensitiveAttribute), inherit: true)
                where attributes.Length > 0 && field.FieldType == typeof(string)
                select field.Name);

            var json = JToken.FromObject(value);
            foreach (var sensitiveMemberName in memberNamesMarkedSensitive)
                json[sensitiveMemberName] = json[sensitiveMemberName].ToString().MaskToLast(DIGITS_TO_DISPLAY);

            json.WriteTo(writer);
        }
    }
}
