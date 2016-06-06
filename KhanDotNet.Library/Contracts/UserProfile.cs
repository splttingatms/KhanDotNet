using KhanDotNet.Library.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace KhanDotNet.Library.Contracts
{
    public class UserProfile : UserBase
    {
        [JsonProperty("is_moderator")]
        public bool IsModerator { get; set; }

        [JsonProperty("streak_length")]
        public int StreakLength { get; set; }

        [JsonProperty("allowed_by_parent_to_add_any_coach")]
        public bool AllowedByParentToAddAnyCoach { get; set; }

        [JsonProperty("user_key")]
        public string UserKey { get; set; }

        [JsonProperty("count_brand_new_notifications")]
        public int CountBrandNewNotifications { get; set; }

        [JsonProperty("avatar_name")]
        public string AvatarName { get; set; }

        [JsonProperty("moderator_level")]
        public int ModeratorLevel { get; set; }

        [JsonProperty("is_activity_accessible")]
        public bool IsActivityAccessible { get; set; }

        [JsonProperty("has_child_students")]
        public bool HasChildStudents { get; set; }

        [JsonProperty("is_parent_of_logged_in_user")]
        public bool IsParentOfLoggedInUser { get; set; }

        [JsonProperty("date_joined")]
        public DateTime DateJoined { get; set; }

        [JsonProperty("affiliations")]
        public List<object> Affiliations { get; set; }

        [JsonProperty("user_location")]
        public object UserLocation { get; set; }

        [JsonProperty("can_create_official_clarifications")]
        public bool CanCreateOfficialClarifications { get; set; }

        [JsonProperty("child_page_root")]
        public string ChildPageRoot { get; set; }

        [JsonProperty("background_name")]
        public string BackgroundName { get; set; }

        [JsonProperty("is_data_collectible")]
        public bool IsDataCollectible { get; set; }

        [JsonProperty("streak_last_extended")]
        public string StreakLastExtended { get; set; }

        [JsonProperty("can_message_users")]
        public bool CanMessageUsers { get; set; }

        [JsonProperty("global_permissions")]
        public List<object> GlobalPermissions { get; set; }

        [JsonProperty("bio")]
        public string Bio { get; set; }

        [JsonProperty("can_modify_coaches")]
        public bool CanModifyCoaches { get; set; }

        [JsonProperty("can_eval_cs_projects")]
        public bool CanEvalCsProjects { get; set; }

        [JsonProperty("can_hellban")]
        public bool CanHellban { get; set; }

        [JsonProperty("public_badges")]
        public List<object> PublicBadges { get; set; }

        [JsonProperty("signed_up_as_teacher")]
        public bool SignedUpAsTeacher { get; set; }

        [JsonProperty("background")]
        public ImageDetails Background { get; set; }

        [JsonProperty("is_creator")]
        public bool IsCreator { get; set; }

        [JsonProperty("count_videos_completed")]
        public int CountVideosCompleted { get; set; }

        [JsonProperty("is_public")]
        public bool IsPublic { get; set; }

        [JsonProperty("avatar_src")]
        public Uri AvatarSrc { get; set; }

        [JsonProperty("sound_on")]
        public bool SoundOn { get; set; }

        [JsonProperty("includes_user_data_info")]
        public bool IncludesUserDataInfo { get; set; }

        [JsonProperty("has_coach_homepage")]
        public bool HasCoachHomepage { get; set; }

        [JsonProperty("background_src")]
        public Uri BackgroundSrc { get; set; }

        [JsonProperty("is_developer")]
        public bool IsDeveloper { get; set; }

        [JsonProperty("is_publisher")]
        public bool IsPublisher { get; set; }

        [JsonProperty("is_curator")]
        public bool IsCurator { get; set; }

        [JsonProperty("has_parent_homepage")]
        public bool HasParentHomepage { get; set; }

        [JsonProperty("is_coaching_logged_in_user")]
        public bool IsCoachingLoggedInuser { get; set; }

        [JsonProperty("avatar")]
        public ImageDetails Avatar { get; set; }

        [JsonProperty("is_self")]
        public bool IsSelf { get; set; }

        [JsonProperty("streak_last_length")]
        public int StreakLastLength { get; set; }

        [JsonProperty("is_orphan")]
        public bool IsOrphan { get; set; }

        [JsonProperty("has_students")]
        public bool HasStudents { get; set; }

        public override string ToString()
        {
            return SensitiveSerializer.Serialize(this);
        }
    }
}