using Newtonsoft.Json;
using System.Collections.Generic;

namespace KhanDotNet.Library.Contract
{
    public class BadgeCategory
    {
        [JsonProperty("category")]
        public Category Category { get; set; }

        [JsonProperty("icon_src")]
        public string IconSrc { get; set; }

        [JsonProperty("type_label")]
        public string TypeLabel { get; set; }

        [JsonProperty("email_icon_src")]
        public string EmailIconSrc { get; set; }

        [JsonProperty("large_icon_src")]
        public string LargeIconSrc { get; set; }

        [JsonProperty("compact_icon_src")]
        public string ComapctIconSrc { get; set; }

        [JsonProperty("translated_description")]
        public string TranslatedDescription { get; set; }

        [JsonProperty("chart_icon_src")]
        public string ChartIconSrc { get; set; }

        [JsonProperty("medium_icon_src")]
        public string MediumIconSrc { get; set; }

        [JsonProperty("CATEGORIES")]
        public List<Category> Categories { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
