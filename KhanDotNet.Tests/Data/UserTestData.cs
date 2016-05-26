using KhanDotNet.Library.Contract;
using System;
using System.Collections.Generic;

namespace KhanDotNet.Tests.Data
{
    static class UserTestData
    {
        public const string SampleUserJson = "{\"spawned_by\": null,\"total_seconds_watched\": 1000,\"can_record_tutorial\": false,\"is_demo\": false,\"is_parent\": false,\"creator\": false,\"spawned_by_kaid\": null,\"tos_accepted\": 20130321,\"joined\": \"2016-01-01T00:00:00Z\",\"hide_visual\": false,\"key_email\": \"http://nouserid.khanacademy.org/dd3d25359ba55b34e2eaa20f4bc776f9\",\"has_changed_avatar\": false,\"google_plus_id\": null,\"is_pre_phantom\": false,\"developer\": false,\"first_visit\": null,\"user_id\": \"http://googleid.khanacademy.org/113933792523419662883\",\"may_be_child\": false,\"title\": \"\",\"all_proficient_exercises\": [],\"students_count\": 0,\"student_summary\": {\"username\": \"\",\"nickname\": \"testuser\",\"email\": \"testuser@gmail.com\",\"key\": \"ag5zfmtoYW4tYWNhZGVteXJaCxIIVXNlckRhdGEiTHVzZXJfaWRfa2V5X2h0dHA6Ly9ub3VzZXJpZC5raGFuYWNhZGVteS5vcmcvZGQzZDI1MzU5YmE1NWIzNGUyZWFhMjBmNGJjNzc2ZjMY\"},\"url_segment\": \"kaid_78807109740671675685108\",\"capabilities\": [],\"UNKNOWN_CLASSROOM_STATUS\": 2,\"profile_root\": \"/profile/kaid_78807109740671675685108/\",\"avatar_url\": \"https://fastly.kastatic.org/images/avatars/leaf-green.png\",\"coworkers\": [],\"follow_requires_approval\": true,\"discussion_banned\": false,\"CLASSROOM_USER\": 1,\"homepage\": \"learner\",\"email\": \"testuser@gmail.com\",\"username\": \"\",\"last_badge_review\": \"2016-02-01T00:00:00Z\",\"is_midsignup_phantom\": false,\"auth_emails\": [\"raw:testuser@gmail.com\",\"norm:testuser@gmail.com\"],\"registration_date\": null,\"points\": 38360,\"coaches\": [],\"last_modified_as_mapreduce_epoch\": 5188,\"is_child_account\": false,\"user_language\": null,\"phantom_creation_date\": null,\"uservideocss_version\": 36,\"start_consecutive_activity_date\": \"2016-03-01T00:00:00Z\",\"nickname\": \"testuser\",\"teacher\": false,\"is_inferred_teacher\": false,\"user_homepage\": \"\",\"publisher\": false,\"kind\": \"UserData\",\"is_inferred_parent\": false,\"unverified_registration_date\": null,\"is_moderator_or_developer\": false,\"last_activity\": \"2016-05-01T00:00:00Z\",\"is_phantom\": false,\"proficient_exercises\": [],\"curator\": false,\"restricted_domain\": null,\"gae_bingo_identity\": \"_gae_bingo_random:bXAq8onB9avaMxSETomZeDXgG6Vz6cbG9B0KMdLV\",\"homepage_url\": \"/\",\"classroom_user_status\": 0,\"NOT_CLASSROOM_USER\": 0,\"featured_scratchpads\": [],\"userprogresscache_version\": 83,\"kaid\": \"kaid_78807109740671675685109\",\"badge_counts\": {\"0\": 22,\"1\": 3,\"2\": 0,\"3\": 0,\"4\": 0,\"5\": 0}}";

        public static readonly User SampleUser = new User()
        {
            SpawnedBy = null,
            TotalSecondsWatched = 1000,
            CanRecordTutorial = false,
            IsDemo = false,
            IsParent = false,
            Creator = false,
            SpawnedByKaId = null,
            TosAccepted = "20130321",
            Joined = new DateTime(2016, 01, 01, 00, 00, 00),
            HideVisual = false,
            KeyEmail = "http://nouserid.khanacademy.org/dd3d25359ba55b34e2eaa20f4bc776f9",
            HasChangedAvatar = false,
            GooglePlusId = null,
            IsPrePhantom = false,
            Developer = false,
            FirstVisit = null,
            UserId = "http://googleid.khanacademy.org/113933792523419662883",
            MayBeChild = false,
            Title = "",
            AllProficientExercises = new List<object>(),
            StudentsCount = 0,
            StudentSummary = new Student()
            {
                Username = "",
                Nickname = "testuser",
                Email = "testuser@gmail.com",
                Key = "ag5zfmtoYW4tYWNhZGVteXJaCxIIVXNlckRhdGEiTHVzZXJfaWRfa2V5X2h0dHA6Ly9ub3VzZXJpZC5raGFuYWNhZGVteS5vcmcvZGQzZDI1MzU5YmE1NWIzNGUyZWFhMjBmNGJjNzc2ZjMY"
            },
            UrlSegment = "kaid_78807109740671675685108",
            Capabilities = new List<object>(),
            UnknownClassroomStatus = 2,
            ProfileRoot = new Uri("/profile/kaid_78807109740671675685108/", UriKind.Relative),
            AvatarUrl = new Uri("https://fastly.kastatic.org/images/avatars/leaf-green.png"),
            Coworkers = new List<object>(),
            FollowRequiresApproval = true,
            DiscussionBanned = false,
            ClassroomUser = 1,
            Homepage = "learner",
            Email = "testuser@gmail.com",
            Username = "",
            LastBadgeReview = new DateTime(2016, 02, 01, 00, 00, 00),
            IsMidsignupPhantom = false,
            AuthEmails = new List<string>()
            {
                "raw:testuser@gmail.com",
                "norm:testuser@gmail.com"
            },
            RegistrationDate = null,
            Points = 38360,
            Coaches = new List<object>(),
            LastModifiedAsMapreduceEpoch = 5188,
            IsChildAccount = false,
            UserLanguage = null,
            PhantomCreationDate = null,
            UserVideoCssVersion = 36,
            StartConsecutiveActivityDate = new DateTime(2016, 03, 01, 00, 00, 00),
            Nickname = "testuser",
            Teacher = false,
            IsInferredTeacher = false,
            UserHomepage = null,
            Publisher = false,
            Kind = "UserData",
            IsInferredParent = false,
            UnverifiedRegistrationDate = null,
            IsModeratorOrDeveloper = false,
            LastActivity = new DateTime(2016, 05, 01, 00, 00, 00),
            IsPhantom = false,
            ProficientExercises = new List<object>(),
            Curator = false,
            RestrictedDomain = null,
            GaeBingoIdentity = "_gae_bingo_random:bXAq8onB9avaMxSETomZeDXgG6Vz6cbG9B0KMdLV",
            HomepageUrl = new Uri("/", UriKind.Relative),
            ClassroomUserStatus = 0,
            NotClassroomUser = 0,
            FeaturedScratchpads = new List<object>(),
            UserProgressCacheVersion = 83,
            KaId = "kaid_78807109740671675685109",
            BadgeCounts = new Dictionary<Category, int>()
            {
                { Category.Meteorite, 22 },
                { Category.Moon, 3 },
                { Category.Earth, 0 },
                { Category.Sun, 0 },
                { Category.BlackHole, 0 },
                { Category.ChallengePatch, 0 }
            }
        };
    }
}
