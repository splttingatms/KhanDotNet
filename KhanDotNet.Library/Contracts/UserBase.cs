using KhanDotNet.Library.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace KhanDotNet.Library.Contracts
{
    public abstract class UserBase
    {
        [JsonProperty("can_record_tutorial")]
        public bool CanRecordTutorial { get; set; }

        [JsonProperty("is_demo")]
        public bool IsDemo { get; set; }

        [JsonProperty("has_changed_avatar")]
        public bool HasChangedAvatar { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("profile_root")]
        public Uri ProfileRoot { get; set; }

        [JsonProperty("follow_requires_approval")]
        public bool FollowRequiresApproval { get; set; }

        [JsonProperty("is_phantom")]
        public bool IsPhantom { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("hide_visual")]
        public bool HideVisual { get; set; }

        [JsonProperty("is_midsignup_phantom")]
        public bool IsMidsignupPhantom { get; set; }

        [JsonProperty("is_child_account")]
        public bool IsChildAccount { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        [JsonProperty("restricted_domain")]
        public object RestrictedDomain { get; set; }

        [JsonProperty("homepage_url")]
        public Uri HomepageUrl { get; set; }

        [JsonProperty("points")]
        public int Points { get; set; }

        [JsonProperty("kaid")]
        public string KaId { get; set; }

        [JsonProperty("badge_counts")]
        public Dictionary<Category, int> BadgeCounts { get; set; }

        public override string ToString()
        {
            return SensitiveSerializer.Serialize(this);
        }
    }
}