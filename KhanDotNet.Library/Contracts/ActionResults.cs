using KhanDotNet.Library.Utilities;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace KhanDotNet.Library.Contracts
{
    public class ActionResults
    {
        [JsonProperty("notifications_added")]
        public Notifications NotificationsAdded { get; set; }

        [JsonProperty("new_task_json")]
        public KhanTaskWrapper NewTask { get; set; }

        [JsonProperty("badge_counts")]
        public Dictionary<Category, int> BadgeCounts { get; set; }

        [JsonProperty("user_profile")]
        public UserProfile UserProfile { get; set; }

        public override string ToString()
        {
            return SensitiveSerializer.Serialize(this);
        }
    }
}
