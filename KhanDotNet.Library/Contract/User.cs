using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace KhanDotNet.Library.Contract
{
    public class User
    {
        [JsonProperty("spawned_by")]
        public object SpawnedBy { get; set; }

        [JsonProperty("total_seconds_watched")]
        public int TotalSecondsWatched { get; set; }

        [JsonProperty("can_record_tutorial")]
        public bool CanRecordTutorial { get; set; }

        [JsonProperty("is_demo")]
        public bool IsDemo { get; set; }

        [JsonProperty("is_parent")]
        public bool IsParent { get; set; }

        [JsonProperty("creator")]
        public bool Creator { get; set; }

        [JsonProperty("spawned_by_kaid")]
        public object SpawnedByKaId { get; set; }

        // TODO: map to custom datetime format
        [JsonProperty("tos_accepted")]
        public string TosAccepted { get; set; }

        [JsonProperty("joined")]
        public DateTime Joined { get; set; }

        [JsonProperty("hide_visual")]
        public bool HideVisual { get; set; }

        [JsonProperty("key_email")]
        public string KeyEmail { get; set; }

        [JsonProperty("has_changed_avatar")]
        public bool HasChangedAvatar { get; set; }

        [JsonProperty("google_plus_id")]
        public object GooglePlusId { get; set; }

        [JsonProperty("is_pre_phantom")]
        public bool IsPrePhantom { get; set; }

        [JsonProperty("developer")]
        public bool Developer { get; set; }

        [JsonProperty("first_visit")]
        public object FirstVisit { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("may_be_child")]
        public bool MayBeChild { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("all_proficient_exercises")]
        public List<object> AllProficientExercises { get; set; }

        [JsonProperty("students_count")]
        public int StudentsCount { get; set; }

        [JsonProperty("student_summary")]
        public Student StudentSummary { get; set; }

        [JsonProperty("url_segment")]
        public string UrlSegment { get; set; }

        [JsonProperty("capabilities")]
        public List<object> Capabilities { get; set; }

        [JsonProperty("UNKNOWN_CLASSROOM_STATUS")]
        public int UnknownClassroomStatus { get; set; }

        [JsonProperty("profile_root")]
        public Uri ProfileRoot { get; set; }

        [JsonProperty("avatar_url")]
        public Uri AvatarUrl { get; set; }

        [JsonProperty("coworkers")]
        public List<object> Coworkers { get; set; }

        [JsonProperty("follow_requires_approval")]
        public bool FollowRequiresApproval { get; set; }

        [JsonProperty("discussion_banned")]
        public bool DiscussionBanned { get; set; }

        [JsonProperty("CLASSROOM_USER")]
        public int ClassroomUser { get; set; }

        [JsonProperty("homepage")]
        public string Homepage { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("last_badge_review")]
        public DateTime LastBadgeReview { get; set; }

        [JsonProperty("is_midsignup_phantom")]
        public bool IsMidsignupPhantom { get; set; }

        [JsonProperty("auth_emails")]
        public List<string> AuthEmails { get; set; }

        [JsonProperty("registration_date")]
        public object RegistrationDate { get; set; }

        [JsonProperty("points")]
        public int Points { get; set; }

        [JsonProperty("coaches")]
        public List<object> Coaches { get; set; }

        [JsonProperty("last_modified_as_mapreduce_epoch")]
        public int LastModifiedAsMapreduceEpoch { get; set; }

        [JsonProperty("is_child_account")]
        public bool IsChildAccount { get; set; }

        [JsonProperty("user_language")]
        public object UserLanguage { get; set; }

        [JsonProperty("phantom_creation_date")]
        public DateTime? PhantomCreationDate { get; set; }

        [JsonProperty("uservideocss_version")]
        public int UserVideoCssVersion { get; set; }

        [JsonProperty("start_consecutive_activity_date")]
        public DateTime StartConsecutiveActivityDate { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        [JsonProperty("teacher")]
        public bool Teacher { get; set; }

        [JsonProperty("is_inferred_teacher")]
        public bool IsInferredTeacher { get; set; }

        [JsonProperty("user_homepage")]
        public Uri UserHomepage { get; set; }

        [JsonProperty("publisher")]
        public bool Publisher { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("is_inferred_parent")]
        public bool IsInferredParent { get; set; }

        [JsonProperty("unverified_registration_date")]
        public DateTime? UnverifiedRegistrationDate { get; set; }

        [JsonProperty("is_moderator_or_developer")]
        public bool IsModeratorOrDeveloper { get; set; }

        [JsonProperty("last_activity")]
        public DateTime LastActivity { get; set; }

        [JsonProperty("is_phantom")]
        public bool IsPhantom { get; set; }

        [JsonProperty("proficient_exercises")]
        public List<object> ProficientExercises { get; set; }

        [JsonProperty("curator")]
        public bool Curator { get; set; }

        [JsonProperty("restricted_domain")]
        public object RestrictedDomain { get; set; }

        [JsonProperty("gae_bingo_identity")]
        public string GaeBingoIdentity { get; set; }

        [JsonProperty("homepage_url")]
        public Uri HomepageUrl { get; set; }

        [JsonProperty("classroom_user_status")]
        public int ClassroomUserStatus { get; set; }

        [JsonProperty("NOT_CLASSROOM_USER")]
        public int NotClassroomUser { get; set; }

        [JsonProperty("featured_scratchpads")]
        public List<object> FeaturedScratchpads { get; set; }

        [JsonProperty("userprogresscache_version")]
        public int UserProgressCacheVersion { get; set; }

        [JsonProperty("kaid")]
        public string KaId { get; set; }

        [JsonProperty("badge_counts")]
        public Dictionary<Category, int> BadgeCounts { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
