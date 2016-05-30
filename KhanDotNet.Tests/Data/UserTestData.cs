using KhanDotNet.Library.Contracts;
using System;
using System.Collections.Generic;

namespace KhanDotNet.Tests.Data
{
    static class UserTestData
    {
        public const string SampleUserJson = "{\"spawned_by\": null,\"total_seconds_watched\": 1000,\"can_record_tutorial\": false,\"is_demo\": false,\"is_parent\": false,\"creator\": false,\"spawned_by_kaid\": null,\"tos_accepted\": 20130321,\"joined\": \"2016-01-01T00:00:00Z\",\"hide_visual\": false,\"key_email\": \"http://nouserid.khanacademy.org/dd3d25359ba55b34e2eaa20f4bc776f9\",\"has_changed_avatar\": false,\"google_plus_id\": null,\"is_pre_phantom\": false,\"developer\": false,\"first_visit\": null,\"user_id\": \"http://googleid.khanacademy.org/113933792523419662883\",\"may_be_child\": false,\"title\": \"\",\"all_proficient_exercises\": [],\"students_count\": 0,\"student_summary\": {\"username\": \"\",\"nickname\": \"testuser\",\"email\": \"testuser@gmail.com\",\"key\": \"ag5zfmtoYW4tYWNhZGVteXJaCxIIVXNlckRhdGEiTHVzZXJfaWRfa2V5X2h0dHA6Ly9ub3VzZXJpZC5raGFuYWNhZGVteS5vcmcvZGQzZDI1MzU5YmE1NWIzNGUyZWFhMjBmNGJjNzc2ZjMY\"},\"url_segment\": \"kaid_78807109740671675685108\",\"capabilities\": [],\"UNKNOWN_CLASSROOM_STATUS\": 2,\"profile_root\": \"/profile/kaid_78807109740671675685108/\",\"avatar_url\": \"https://fastly.kastatic.org/images/avatars/leaf-green.png\",\"coworkers\": [],\"follow_requires_approval\": true,\"discussion_banned\": false,\"CLASSROOM_USER\": 1,\"homepage\": \"learner\",\"email\": \"testuser@gmail.com\",\"username\": \"\",\"last_badge_review\": \"2016-02-01T00:00:00Z\",\"is_midsignup_phantom\": false,\"auth_emails\": [\"raw:testuser@gmail.com\",\"norm:testuser@gmail.com\"],\"registration_date\": null,\"points\": 38360,\"coaches\": [],\"last_modified_as_mapreduce_epoch\": 5188,\"is_child_account\": false,\"user_language\": null,\"phantom_creation_date\": null,\"uservideocss_version\": 36,\"start_consecutive_activity_date\": \"2016-03-01T00:00:00Z\",\"nickname\": \"testuser\",\"teacher\": false,\"is_inferred_teacher\": false,\"user_homepage\": \"\",\"publisher\": false,\"kind\": \"UserData\",\"is_inferred_parent\": false,\"unverified_registration_date\": null,\"is_moderator_or_developer\": false,\"last_activity\": \"2016-05-01T00:00:00Z\",\"is_phantom\": false,\"proficient_exercises\": [],\"curator\": false,\"restricted_domain\": null,\"gae_bingo_identity\": \"_gae_bingo_random:bXAq8onB9avaMxSETomZeDXgG6Vz6cbG9B0KMdLV\",\"homepage_url\": \"/\",\"classroom_user_status\": 0,\"NOT_CLASSROOM_USER\": 0,\"featured_scratchpads\": [],\"userprogresscache_version\": 83,\"kaid\": \"kaid_78807109740671675685109\",\"badge_counts\": {\"0\": 22,\"1\": 3,\"2\": 0,\"3\": 0,\"4\": 0,\"5\": 0}}";

        public const string SampleUserExercisesJson = "[{\"streak\": 6,\"is_skill_check\": false,\"mastery_points\": 0,\"snooze_time\": null,\"maximum_exercise_progress_dt\": \"2014-10-24T08:05:11Z\",\"last_count_hints\": 0,\"exercise_model\": {\"is_skill_check\": false,\"uses_worked_examples\": false,\"v_position\": 3,\"relative_url\": \"/exercise/counting-out-1-20-objects\",\"has_custom_thumbnail\": true,\"file_name\": null,\"related_video_readable_ids\": [\"counting-with-small-numbers\"],\"author_name\": \"Gail Hargrave\",\"creation_date\": \"2016-03-01T19:29:20Z\",\"translated_short_display_name\": \"Count with \",\"uses_assessment_items\": true,\"ka_url\": \"http://www.khanacademy.org/exercise/counting-out-1-20-objects\",\"short_display_name\": \"Count with \",\"translated_title\": \"Count with small numbers\",\"author_key\": \"ag5zfmtoYW4tYWNhZGVteXJaCxIIVXNlckRhdGEiTHVzZXJfaWRfa2V5X2h0dHA6Ly9ub3VzZXJpZC5raGFuYWNhZGVteS5vcmcvNjZmOTNhODE4YjU2ZWUxZTliOTM1MGI2OTc2OGQ4ZTMM\",\"translated_description_html\": \"Practice counting up to 10 objects.\",\"id\": \"x4debd8a3\",\"concept_tags\": [\"Tag:x731f236a6d33f0ff\",\"Tag:xf444fba1e72e5158\"],\"is_quiz\": false,\"display_name\": \"Count with small numbers\",\"tracking_document_url\": null,\"description_html\": \"Practice counting up to 10 objects.\",\"do_not_publish\": false,\"tags\": [],\"translated_problem_types\": [{\"items\": [{\"sha\": \"c2074685910760669c855d628b7a44ef8d828be9\",\"live\": true,\"id\": \"xde8147b8edb82294\"},{\"sha\": \"76c7fd55c20dfe0f4f938745b73e1e7d0c4757ac\",\"live\": true,\"id\": \"xa5c8d62485b6bf16\"},{\"sha\": \"a4318a5630a8766f55dc6830527dbaffc7fb917b\",\"live\": true,\"id\": \"x2313c50d4dfd4a0a\"},{\"sha\": \"b350b21cf286a64c0e7869a6429fc6c5fd139c1f\",\"live\": true,\"id\": \"xcd7ba1c0c381fadb\"},{\"sha\": \"e8ba59f1f99433fbd0360332f999cde76ab8976b\",\"live\": true,\"id\": \"x4cb56360820eece5\"},{\"sha\": \"954fcd5885c36b841a22bc5bf89207bced27b8be\",\"live\": true,\"id\": \"xcc39b61282c884be\"},{\"sha\": \"15070fc64826e1cd00665c38e2e42e5834ed359a\",\"live\": true,\"id\": \"x9c6c9733676e5240\"},{\"sha\": \"89d992ba940c4ecaa7687d7a84ce632ead085882\",\"live\": true,\"id\": \"x8ae458b86dfe440b\"},{\"sha\": \"54f92d19cabbd7647cd5d21d4678e8711431e9fb\",\"live\": true,\"id\": \"x8e7fd4a4b5b002c1\"},{\"sha\": \"8d00285eae0fab5210dcfb325be7741e48c75681\",\"live\": true,\"id\": \"xeee62e178c0cfe6f\"},{\"sha\": \"4453b349bad32a1e416e7e74af64e09e2c5810f8\",\"live\": true,\"id\": \"xdee0840c85c0add5\"},{\"sha\": \"bb340ca13b104a9b9d1065b74a2fdfa423f817d1\",\"live\": true,\"id\": \"xa756d02df7435e1a\"},{\"sha\": \"f65a9c4a6a8df260021fe424d562e8ff6d1741bd\",\"live\": true,\"id\": \"x6b9db70231ff254d\"},{\"sha\": \"00808cbc066910be1220235faa7d93a9126f6a57\",\"live\": true,\"id\": \"x1855395b96b1e34f\"},{\"sha\": \"90db973ee0fd319c596410e215a76a651601901d\",\"live\": true,\"id\": \"x477b6212a24d08da\"},{\"sha\": \"f6cf4d0675de30afee8cab929b97000e2c41fbc8\",\"live\": true,\"id\": \"xfc8946e7c80f2800\"},{\"sha\": \"4f522fb965ab3805f56250db187fefadb281edd2\",\"live\": true,\"id\": \"x14784d8f428fa949\"},{\"sha\": \"849c88aa2122ea5a40bb39540acf551d3ac67728\",\"live\": true,\"id\": \"x3f2d3b6cb53f67a4\"},{\"sha\": \"a9197ffb73ad014d477c7eb1eed41f9ea025774b\",\"live\": true,\"id\": \"xb6e923d2f396f5ab\"},{\"sha\": \"446eef76c02fc29049012312c704c12b4b54ba8d\",\"live\": true,\"id\": \"x9ef4ca7e914c87ec\"}],\"related_videos\": [],\"name\": \"A\"}],\"progress_key\": \"ex4debd8a3\",\"suggested_completion_criteria\": \"num_correct_in_a_row_5\",\"edit_slug\": \"edit/e/x4debd8a3\",\"summative\": false,\"live\": true,\"translated_description\": \"Practice counting up to 10 objects.\",\"pretty_display_name\": \"Count with small numbers\",\"deleted_mod_time\": null,\"thumbnail_data\": {\"url\": \"\",\"skip_filter\": false,\"title_text\": \"\",\"gcs_name\": \"/ka_thumbnails/counting-out-1-20-objects.png\"},\"all_assessment_items\": [{\"sha\": \"c2074685910760669c855d628b7a44ef8d828be9\",\"live\": true,\"id\": \"xde8147b8edb82294\"},{\"sha\": \"76c7fd55c20dfe0f4f938745b73e1e7d0c4757ac\",\"live\": true,\"id\": \"xa5c8d62485b6bf16\"},{\"sha\": \"a4318a5630a8766f55dc6830527dbaffc7fb917b\",\"live\": true,\"id\": \"x2313c50d4dfd4a0a\"},{\"sha\": \"b350b21cf286a64c0e7869a6429fc6c5fd139c1f\",\"live\": true,\"id\": \"xcd7ba1c0c381fadb\"},{\"sha\": \"e8ba59f1f99433fbd0360332f999cde76ab8976b\",\"live\": true,\"id\": \"x4cb56360820eece5\"},{\"sha\": \"954fcd5885c36b841a22bc5bf89207bced27b8be\",\"live\": true,\"id\": \"xcc39b61282c884be\"},{\"sha\": \"15070fc64826e1cd00665c38e2e42e5834ed359a\",\"live\": true,\"id\": \"x9c6c9733676e5240\"},{\"sha\": \"89d992ba940c4ecaa7687d7a84ce632ead085882\",\"live\": true,\"id\": \"x8ae458b86dfe440b\"},{\"sha\": \"54f92d19cabbd7647cd5d21d4678e8711431e9fb\",\"live\": true,\"id\": \"x8e7fd4a4b5b002c1\"},{\"sha\": \"8d00285eae0fab5210dcfb325be7741e48c75681\",\"live\": true,\"id\": \"xeee62e178c0cfe6f\"},{\"sha\": \"4453b349bad32a1e416e7e74af64e09e2c5810f8\",\"live\": true,\"id\": \"xdee0840c85c0add5\"},{\"sha\": \"bb340ca13b104a9b9d1065b74a2fdfa423f817d1\",\"live\": true,\"id\": \"xa756d02df7435e1a\"},{\"sha\": \"f65a9c4a6a8df260021fe424d562e8ff6d1741bd\",\"live\": true,\"id\": \"x6b9db70231ff254d\"},{\"sha\": \"00808cbc066910be1220235faa7d93a9126f6a57\",\"live\": true,\"id\": \"x1855395b96b1e34f\"},{\"sha\": \"90db973ee0fd319c596410e215a76a651601901d\",\"live\": true,\"id\": \"x477b6212a24d08da\"},{\"sha\": \"f6cf4d0675de30afee8cab929b97000e2c41fbc8\",\"live\": true,\"id\": \"xfc8946e7c80f2800\"},{\"sha\": \"4f522fb965ab3805f56250db187fefadb281edd2\",\"live\": true,\"id\": \"x14784d8f428fa949\"},{\"sha\": \"849c88aa2122ea5a40bb39540acf551d3ac67728\",\"live\": true,\"id\": \"x3f2d3b6cb53f67a4\"},{\"sha\": \"a9197ffb73ad014d477c7eb1eed41f9ea025774b\",\"live\": true,\"id\": \"xb6e923d2f396f5ab\"},{\"sha\": \"446eef76c02fc29049012312c704c12b4b54ba8d\",\"live\": true,\"id\": \"x9ef4ca7e914c87ec\"}],\"description\": \"Practice counting up to 10 objects.\",\"translated_pretty_display_name\": \"Count with small numbers\",\"node_slug\": \"e/counting-out-1-20-objects\",\"deleted\": false,\"backup_timestamp\": null,\"concept_tags_info\": [{\"display_name\": \"Counting\",\"id\": \"Tag:x731f236a6d33f0ff\",\"slug\": \"counting\"},{\"display_name\": \"Counting objects\",\"id\": \"Tag:xf444fba1e72e5158\",\"slug\": \"counting-objects\"}],\"problem_types\": [{\"items\": [{\"sha\": \"c2074685910760669c855d628b7a44ef8d828be9\",\"live\": true,\"id\": \"xde8147b8edb82294\"},{\"sha\": \"76c7fd55c20dfe0f4f938745b73e1e7d0c4757ac\",\"live\": true,\"id\": \"xa5c8d62485b6bf16\"},{\"sha\": \"a4318a5630a8766f55dc6830527dbaffc7fb917b\",\"live\": true,\"id\": \"x2313c50d4dfd4a0a\"},{\"sha\": \"b350b21cf286a64c0e7869a6429fc6c5fd139c1f\",\"live\": true,\"id\": \"xcd7ba1c0c381fadb\"},{\"sha\": \"e8ba59f1f99433fbd0360332f999cde76ab8976b\",\"live\": true,\"id\": \"x4cb56360820eece5\"},{\"sha\": \"954fcd5885c36b841a22bc5bf89207bced27b8be\",\"live\": true,\"id\": \"xcc39b61282c884be\"},{\"sha\": \"15070fc64826e1cd00665c38e2e42e5834ed359a\",\"live\": true,\"id\": \"x9c6c9733676e5240\"},{\"sha\": \"89d992ba940c4ecaa7687d7a84ce632ead085882\",\"live\": true,\"id\": \"x8ae458b86dfe440b\"},{\"sha\": \"54f92d19cabbd7647cd5d21d4678e8711431e9fb\",\"live\": true,\"id\": \"x8e7fd4a4b5b002c1\"},{\"sha\": \"8d00285eae0fab5210dcfb325be7741e48c75681\",\"live\": true,\"id\": \"xeee62e178c0cfe6f\"},{\"sha\": \"4453b349bad32a1e416e7e74af64e09e2c5810f8\",\"live\": true,\"id\": \"xdee0840c85c0add5\"},{\"sha\": \"bb340ca13b104a9b9d1065b74a2fdfa423f817d1\",\"live\": true,\"id\": \"xa756d02df7435e1a\"},{\"sha\": \"f65a9c4a6a8df260021fe424d562e8ff6d1741bd\",\"live\": true,\"id\": \"x6b9db70231ff254d\"},{\"sha\": \"00808cbc066910be1220235faa7d93a9126f6a57\",\"live\": true,\"id\": \"x1855395b96b1e34f\"},{\"sha\": \"90db973ee0fd319c596410e215a76a651601901d\",\"live\": true,\"id\": \"x477b6212a24d08da\"},{\"sha\": \"f6cf4d0675de30afee8cab929b97000e2c41fbc8\",\"live\": true,\"id\": \"xfc8946e7c80f2800\"},{\"sha\": \"4f522fb965ab3805f56250db187fefadb281edd2\",\"live\": true,\"id\": \"x14784d8f428fa949\"},{\"sha\": \"849c88aa2122ea5a40bb39540acf551d3ac67728\",\"live\": true,\"id\": \"x3f2d3b6cb53f67a4\"},{\"sha\": \"a9197ffb73ad014d477c7eb1eed41f9ea025774b\",\"live\": true,\"id\": \"xb6e923d2f396f5ab\"},{\"sha\": \"446eef76c02fc29049012312c704c12b4b54ba8d\",\"live\": true,\"id\": \"x9ef4ca7e914c87ec\"}],\"related_videos\": [],\"name\": \"A\"}],\"curated_related_videos\": [\"x9b4a5e7a\"],\"covers\": [],\"h_position\": -40,\"translated_display_name\": \"Count with small numbers\",\"kind\": \"Exercise\",\"sha1\": \"c6dfa454b415736e95f50981cb3a17f428424162\",\"name\": \"counting-out-1-20-objects\",\"date_modified\": \"2016-05-05T20:05:26Z\",\"prerequisites\": [],\"assessment_item_tags\": [\"ag5zfmtoYW4tYWNhZGVteXI2CxIRQXNzZXNzbWVudEl0ZW1UYWciATAMCxIRQXNzZXNzbWVudEl0ZW1UYWcYgICAwIKTqAoM\",\"ag5zfmtoYW4tYWNhZGVteXI2CxIRQXNzZXNzbWVudEl0ZW1UYWciATAMCxIRQXNzZXNzbWVudEl0ZW1UYWcYgICAgKqcsgoM\"],\"title\": \"Count with small numbers\",\"global_id\": \"ex4debd8a3\",\"seconds_per_fast_problem\": 4.0,\"sha\": \"7bc7ef1a01cb89d73239a4387ed06ecc63ba962f\",\"image_url\": \"https://fastly.kastatic.org/ka-exercise-screenshots/counting-out-1-20-objects.png\",\"tutorial_only\": false,\"current_revision_key\": \"7bc7ef1a01cb89d73239a4387ed06ecc63ba962f\",\"image_url_256\": \"https://fastly.kastatic.org/ka-exercise-screenshots/counting-out-1-20-objects_256.png\",\"content_id\": \"x4debd8a3\",\"content_kind\": \"Exercise\"},\"MASTERY_CARD_SUPERPROMOTE_THRESHOLD\": 0.84999999999999998,\"exercise_progress\": {\"practiced\": true,\"mastered\": false,\"level\": \"practiced\"},\"practiced_date\": null,\"exercise\": \"permutations_1\",\"clear_struggling_indicators\": null,\"total_done\": 6,\"exercise_states\": {\"struggling\": false,\"proficient\": true,\"practiced\": true,\"mastered\": false},\"backup_timestamp\": null,\"total_correct\": 6,\"user\": \"http://nouserid.khanacademy.org/dd3d25359ba55b34e2eaa20f4bc776f7\",\"kind\": \"UserExercise\",\"practiced\": false,\"seconds_per_fast_problem\": 4.0,\"last_done\": \"2014-10-24T08:06:49Z\",\"last_mastery_update\": \"2014-10-24T08:05:10Z\",\"maximum_exercise_progress\": {\"practiced\": true,\"mastered\": false,\"level\": \"practiced\"},\"mastered\": false,\"longest_streak\": 6,\"kaid\": \"kaid_78807109740671675685108\",\"content_kind\": \"UserExercise\",\"last_attempt_number\": 0,\"proficient_date\": null}]";

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


        public static readonly List<ExerciseInteraction> SampleUserExercises = new List<ExerciseInteraction>()
        {
            new ExerciseInteraction()
            {
                Streak = 6,
                IsSkillCheck = false,
                MasteryPoints = 0,
                SnoozeTime = null,
                MaximumExerciseProgressDt = "2014-10-24T08:05:11Z",
                LastCountHints = 0,
                ExerciseModel = ExerciseTestData.CountingExercise,
                MasteryCardSuperPromoteThreshold = 0.84999999999999998,
                ExerciseProgress = new ExerciseProgress()
                {
                    Practiced = true,
                    Mastered = false,
                    Level = "practiced"
                },
                practiced_date = null,
                Exercise = "permutations_1",
                ClearStrugglingIndicators = null,
                TotalDone = 6,
                ExerciseStates = new ExerciseStates()
                {
                    Struggling = false,
                    Proficient = true,
                    Practiced = true,
                    Mastered = false
                },
                BackupTimestamp = null,
                TotalCorrect = 6,
                User = "http://nouserid.khanacademy.org/dd3d25359ba55b34e2eaa20f4bc776f7",
                Kind = "UserExercise",
                Practiced = false,
                SecondsPerFastProblem = 4.0,
                LastDone = "2014-10-24T08:06:49Z",
                LastMasteryUpdate = "2014-10-24T08:05:10Z",
                MaximumExerciseProgress = new ExerciseProgress()
                {
                    Practiced = true,
                    Mastered = false,
                    Level = "practiced"
                },
                Mastered = false,
                LongestStreak = 6,
                KaId = "kaid_78807109740671675685108",
                ContentKind = "UserExercise",
                LastAttemptNumber = 0,
                ProficientDate = null
            }
        };
    }
}
