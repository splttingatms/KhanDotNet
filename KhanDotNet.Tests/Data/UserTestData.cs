using KhanDotNet.Library.Contracts;
using System;
using System.Collections.Generic;

namespace KhanDotNet.Tests.Data
{
    static class UserTestData
    {
        public const string SampleUserJson = "{\"spawned_by\": null,\"total_seconds_watched\": 1000,\"can_record_tutorial\": false,\"is_demo\": false,\"is_parent\": false,\"creator\": false,\"spawned_by_kaid\": null,\"tos_accepted\": 20130321,\"joined\": \"2016-01-01T00:00:00Z\",\"hide_visual\": false,\"key_email\": \"http://nouserid.khanacademy.org/dd3d25359ba55b34e2eaa20f4bc776f9\",\"has_changed_avatar\": false,\"google_plus_id\": null,\"is_pre_phantom\": false,\"developer\": false,\"first_visit\": null,\"user_id\": \"http://googleid.khanacademy.org/113933792523419662883\",\"may_be_child\": false,\"title\": \"\",\"all_proficient_exercises\": [],\"students_count\": 0,\"student_summary\": {\"username\": \"\",\"nickname\": \"testuser\",\"email\": \"testuser@gmail.com\",\"key\": \"ag5zfmtoYW4tYWNhZGVteXJaCxIIVXNlckRhdGEiTHVzZXJfaWRfa2V5X2h0dHA6Ly9ub3VzZXJpZC5raGFuYWNhZGVteS5vcmcvZGQzZDI1MzU5YmE1NWIzNGUyZWFhMjBmNGJjNzc2ZjMY\"},\"url_segment\": \"kaid_78807109740671675685108\",\"capabilities\": [],\"UNKNOWN_CLASSROOM_STATUS\": 2,\"profile_root\": \"/profile/kaid_78807109740671675685108/\",\"avatar_url\": \"https://fastly.kastatic.org/images/avatars/leaf-green.png\",\"coworkers\": [],\"follow_requires_approval\": true,\"discussion_banned\": false,\"CLASSROOM_USER\": 1,\"homepage\": \"learner\",\"email\": \"testuser@gmail.com\",\"username\": \"\",\"last_badge_review\": \"2016-02-01T00:00:00Z\",\"is_midsignup_phantom\": false,\"auth_emails\": [\"raw:testuser@gmail.com\",\"norm:testuser@gmail.com\"],\"registration_date\": null,\"points\": 38360,\"coaches\": [],\"last_modified_as_mapreduce_epoch\": 5188,\"is_child_account\": false,\"user_language\": null,\"phantom_creation_date\": null,\"uservideocss_version\": 36,\"start_consecutive_activity_date\": \"2016-03-01T00:00:00Z\",\"nickname\": \"testuser\",\"teacher\": false,\"is_inferred_teacher\": false,\"user_homepage\": \"\",\"publisher\": false,\"kind\": \"UserData\",\"is_inferred_parent\": false,\"unverified_registration_date\": null,\"is_moderator_or_developer\": false,\"last_activity\": \"2016-05-01T00:00:00Z\",\"is_phantom\": false,\"proficient_exercises\": [],\"curator\": false,\"restricted_domain\": null,\"gae_bingo_identity\": \"_gae_bingo_random:bXAq8onB9avaMxSETomZeDXgG6Vz6cbG9B0KMdLV\",\"homepage_url\": \"/\",\"classroom_user_status\": 0,\"NOT_CLASSROOM_USER\": 0,\"featured_scratchpads\": [],\"userprogresscache_version\": 83,\"kaid\": \"kaid_78807109740671675685109\",\"badge_counts\": {\"0\": 22,\"1\": 3,\"2\": 0,\"3\": 0,\"4\": 0,\"5\": 0}}";

        public const string SampleUserExercisesJson = "[{\"streak\": 6,\"is_skill_check\": false,\"mastery_points\": 0,\"snooze_time\": null,\"maximum_exercise_progress_dt\": \"2014-10-24T08:05:11Z\",\"last_count_hints\": 0,\"exercise_model\": {\"is_skill_check\": false,\"uses_worked_examples\": false,\"v_position\": 3,\"relative_url\": \"/exercise/counting-out-1-20-objects\",\"has_custom_thumbnail\": true,\"file_name\": null,\"related_video_readable_ids\": [\"counting-with-small-numbers\"],\"author_name\": \"Gail Hargrave\",\"creation_date\": \"2016-03-01T19:29:20Z\",\"translated_short_display_name\": \"Count with \",\"uses_assessment_items\": true,\"ka_url\": \"http://www.khanacademy.org/exercise/counting-out-1-20-objects\",\"short_display_name\": \"Count with \",\"translated_title\": \"Count with small numbers\",\"author_key\": \"ag5zfmtoYW4tYWNhZGVteXJaCxIIVXNlckRhdGEiTHVzZXJfaWRfa2V5X2h0dHA6Ly9ub3VzZXJpZC5raGFuYWNhZGVteS5vcmcvNjZmOTNhODE4YjU2ZWUxZTliOTM1MGI2OTc2OGQ4ZTMM\",\"translated_description_html\": \"Practice counting up to 10 objects.\",\"id\": \"x4debd8a3\",\"concept_tags\": [\"Tag:x731f236a6d33f0ff\",\"Tag:xf444fba1e72e5158\"],\"is_quiz\": false,\"display_name\": \"Count with small numbers\",\"tracking_document_url\": null,\"description_html\": \"Practice counting up to 10 objects.\",\"do_not_publish\": false,\"tags\": [],\"translated_problem_types\": [{\"items\": [{\"sha\": \"c2074685910760669c855d628b7a44ef8d828be9\",\"live\": true,\"id\": \"xde8147b8edb82294\"},{\"sha\": \"76c7fd55c20dfe0f4f938745b73e1e7d0c4757ac\",\"live\": true,\"id\": \"xa5c8d62485b6bf16\"},{\"sha\": \"a4318a5630a8766f55dc6830527dbaffc7fb917b\",\"live\": true,\"id\": \"x2313c50d4dfd4a0a\"},{\"sha\": \"b350b21cf286a64c0e7869a6429fc6c5fd139c1f\",\"live\": true,\"id\": \"xcd7ba1c0c381fadb\"},{\"sha\": \"e8ba59f1f99433fbd0360332f999cde76ab8976b\",\"live\": true,\"id\": \"x4cb56360820eece5\"},{\"sha\": \"954fcd5885c36b841a22bc5bf89207bced27b8be\",\"live\": true,\"id\": \"xcc39b61282c884be\"},{\"sha\": \"15070fc64826e1cd00665c38e2e42e5834ed359a\",\"live\": true,\"id\": \"x9c6c9733676e5240\"},{\"sha\": \"89d992ba940c4ecaa7687d7a84ce632ead085882\",\"live\": true,\"id\": \"x8ae458b86dfe440b\"},{\"sha\": \"54f92d19cabbd7647cd5d21d4678e8711431e9fb\",\"live\": true,\"id\": \"x8e7fd4a4b5b002c1\"},{\"sha\": \"8d00285eae0fab5210dcfb325be7741e48c75681\",\"live\": true,\"id\": \"xeee62e178c0cfe6f\"},{\"sha\": \"4453b349bad32a1e416e7e74af64e09e2c5810f8\",\"live\": true,\"id\": \"xdee0840c85c0add5\"},{\"sha\": \"bb340ca13b104a9b9d1065b74a2fdfa423f817d1\",\"live\": true,\"id\": \"xa756d02df7435e1a\"},{\"sha\": \"f65a9c4a6a8df260021fe424d562e8ff6d1741bd\",\"live\": true,\"id\": \"x6b9db70231ff254d\"},{\"sha\": \"00808cbc066910be1220235faa7d93a9126f6a57\",\"live\": true,\"id\": \"x1855395b96b1e34f\"},{\"sha\": \"90db973ee0fd319c596410e215a76a651601901d\",\"live\": true,\"id\": \"x477b6212a24d08da\"},{\"sha\": \"f6cf4d0675de30afee8cab929b97000e2c41fbc8\",\"live\": true,\"id\": \"xfc8946e7c80f2800\"},{\"sha\": \"4f522fb965ab3805f56250db187fefadb281edd2\",\"live\": true,\"id\": \"x14784d8f428fa949\"},{\"sha\": \"849c88aa2122ea5a40bb39540acf551d3ac67728\",\"live\": true,\"id\": \"x3f2d3b6cb53f67a4\"},{\"sha\": \"a9197ffb73ad014d477c7eb1eed41f9ea025774b\",\"live\": true,\"id\": \"xb6e923d2f396f5ab\"},{\"sha\": \"446eef76c02fc29049012312c704c12b4b54ba8d\",\"live\": true,\"id\": \"x9ef4ca7e914c87ec\"}],\"related_videos\": [],\"name\": \"A\"}],\"progress_key\": \"ex4debd8a3\",\"suggested_completion_criteria\": \"num_correct_in_a_row_5\",\"edit_slug\": \"edit/e/x4debd8a3\",\"summative\": false,\"live\": true,\"translated_description\": \"Practice counting up to 10 objects.\",\"pretty_display_name\": \"Count with small numbers\",\"deleted_mod_time\": null,\"thumbnail_data\": {\"url\": \"\",\"skip_filter\": false,\"title_text\": \"\",\"gcs_name\": \"/ka_thumbnails/counting-out-1-20-objects.png\"},\"all_assessment_items\": [{\"sha\": \"c2074685910760669c855d628b7a44ef8d828be9\",\"live\": true,\"id\": \"xde8147b8edb82294\"},{\"sha\": \"76c7fd55c20dfe0f4f938745b73e1e7d0c4757ac\",\"live\": true,\"id\": \"xa5c8d62485b6bf16\"},{\"sha\": \"a4318a5630a8766f55dc6830527dbaffc7fb917b\",\"live\": true,\"id\": \"x2313c50d4dfd4a0a\"},{\"sha\": \"b350b21cf286a64c0e7869a6429fc6c5fd139c1f\",\"live\": true,\"id\": \"xcd7ba1c0c381fadb\"},{\"sha\": \"e8ba59f1f99433fbd0360332f999cde76ab8976b\",\"live\": true,\"id\": \"x4cb56360820eece5\"},{\"sha\": \"954fcd5885c36b841a22bc5bf89207bced27b8be\",\"live\": true,\"id\": \"xcc39b61282c884be\"},{\"sha\": \"15070fc64826e1cd00665c38e2e42e5834ed359a\",\"live\": true,\"id\": \"x9c6c9733676e5240\"},{\"sha\": \"89d992ba940c4ecaa7687d7a84ce632ead085882\",\"live\": true,\"id\": \"x8ae458b86dfe440b\"},{\"sha\": \"54f92d19cabbd7647cd5d21d4678e8711431e9fb\",\"live\": true,\"id\": \"x8e7fd4a4b5b002c1\"},{\"sha\": \"8d00285eae0fab5210dcfb325be7741e48c75681\",\"live\": true,\"id\": \"xeee62e178c0cfe6f\"},{\"sha\": \"4453b349bad32a1e416e7e74af64e09e2c5810f8\",\"live\": true,\"id\": \"xdee0840c85c0add5\"},{\"sha\": \"bb340ca13b104a9b9d1065b74a2fdfa423f817d1\",\"live\": true,\"id\": \"xa756d02df7435e1a\"},{\"sha\": \"f65a9c4a6a8df260021fe424d562e8ff6d1741bd\",\"live\": true,\"id\": \"x6b9db70231ff254d\"},{\"sha\": \"00808cbc066910be1220235faa7d93a9126f6a57\",\"live\": true,\"id\": \"x1855395b96b1e34f\"},{\"sha\": \"90db973ee0fd319c596410e215a76a651601901d\",\"live\": true,\"id\": \"x477b6212a24d08da\"},{\"sha\": \"f6cf4d0675de30afee8cab929b97000e2c41fbc8\",\"live\": true,\"id\": \"xfc8946e7c80f2800\"},{\"sha\": \"4f522fb965ab3805f56250db187fefadb281edd2\",\"live\": true,\"id\": \"x14784d8f428fa949\"},{\"sha\": \"849c88aa2122ea5a40bb39540acf551d3ac67728\",\"live\": true,\"id\": \"x3f2d3b6cb53f67a4\"},{\"sha\": \"a9197ffb73ad014d477c7eb1eed41f9ea025774b\",\"live\": true,\"id\": \"xb6e923d2f396f5ab\"},{\"sha\": \"446eef76c02fc29049012312c704c12b4b54ba8d\",\"live\": true,\"id\": \"x9ef4ca7e914c87ec\"}],\"description\": \"Practice counting up to 10 objects.\",\"translated_pretty_display_name\": \"Count with small numbers\",\"node_slug\": \"e/counting-out-1-20-objects\",\"deleted\": false,\"backup_timestamp\": null,\"concept_tags_info\": [{\"display_name\": \"Counting\",\"id\": \"Tag:x731f236a6d33f0ff\",\"slug\": \"counting\"},{\"display_name\": \"Counting objects\",\"id\": \"Tag:xf444fba1e72e5158\",\"slug\": \"counting-objects\"}],\"problem_types\": [{\"items\": [{\"sha\": \"c2074685910760669c855d628b7a44ef8d828be9\",\"live\": true,\"id\": \"xde8147b8edb82294\"},{\"sha\": \"76c7fd55c20dfe0f4f938745b73e1e7d0c4757ac\",\"live\": true,\"id\": \"xa5c8d62485b6bf16\"},{\"sha\": \"a4318a5630a8766f55dc6830527dbaffc7fb917b\",\"live\": true,\"id\": \"x2313c50d4dfd4a0a\"},{\"sha\": \"b350b21cf286a64c0e7869a6429fc6c5fd139c1f\",\"live\": true,\"id\": \"xcd7ba1c0c381fadb\"},{\"sha\": \"e8ba59f1f99433fbd0360332f999cde76ab8976b\",\"live\": true,\"id\": \"x4cb56360820eece5\"},{\"sha\": \"954fcd5885c36b841a22bc5bf89207bced27b8be\",\"live\": true,\"id\": \"xcc39b61282c884be\"},{\"sha\": \"15070fc64826e1cd00665c38e2e42e5834ed359a\",\"live\": true,\"id\": \"x9c6c9733676e5240\"},{\"sha\": \"89d992ba940c4ecaa7687d7a84ce632ead085882\",\"live\": true,\"id\": \"x8ae458b86dfe440b\"},{\"sha\": \"54f92d19cabbd7647cd5d21d4678e8711431e9fb\",\"live\": true,\"id\": \"x8e7fd4a4b5b002c1\"},{\"sha\": \"8d00285eae0fab5210dcfb325be7741e48c75681\",\"live\": true,\"id\": \"xeee62e178c0cfe6f\"},{\"sha\": \"4453b349bad32a1e416e7e74af64e09e2c5810f8\",\"live\": true,\"id\": \"xdee0840c85c0add5\"},{\"sha\": \"bb340ca13b104a9b9d1065b74a2fdfa423f817d1\",\"live\": true,\"id\": \"xa756d02df7435e1a\"},{\"sha\": \"f65a9c4a6a8df260021fe424d562e8ff6d1741bd\",\"live\": true,\"id\": \"x6b9db70231ff254d\"},{\"sha\": \"00808cbc066910be1220235faa7d93a9126f6a57\",\"live\": true,\"id\": \"x1855395b96b1e34f\"},{\"sha\": \"90db973ee0fd319c596410e215a76a651601901d\",\"live\": true,\"id\": \"x477b6212a24d08da\"},{\"sha\": \"f6cf4d0675de30afee8cab929b97000e2c41fbc8\",\"live\": true,\"id\": \"xfc8946e7c80f2800\"},{\"sha\": \"4f522fb965ab3805f56250db187fefadb281edd2\",\"live\": true,\"id\": \"x14784d8f428fa949\"},{\"sha\": \"849c88aa2122ea5a40bb39540acf551d3ac67728\",\"live\": true,\"id\": \"x3f2d3b6cb53f67a4\"},{\"sha\": \"a9197ffb73ad014d477c7eb1eed41f9ea025774b\",\"live\": true,\"id\": \"xb6e923d2f396f5ab\"},{\"sha\": \"446eef76c02fc29049012312c704c12b4b54ba8d\",\"live\": true,\"id\": \"x9ef4ca7e914c87ec\"}],\"related_videos\": [],\"name\": \"A\"}],\"curated_related_videos\": [\"x9b4a5e7a\"],\"covers\": [],\"h_position\": -40,\"translated_display_name\": \"Count with small numbers\",\"kind\": \"Exercise\",\"sha1\": \"c6dfa454b415736e95f50981cb3a17f428424162\",\"name\": \"counting-out-1-20-objects\",\"date_modified\": \"2016-05-05T20:05:26Z\",\"prerequisites\": [],\"assessment_item_tags\": [\"ag5zfmtoYW4tYWNhZGVteXI2CxIRQXNzZXNzbWVudEl0ZW1UYWciATAMCxIRQXNzZXNzbWVudEl0ZW1UYWcYgICAwIKTqAoM\",\"ag5zfmtoYW4tYWNhZGVteXI2CxIRQXNzZXNzbWVudEl0ZW1UYWciATAMCxIRQXNzZXNzbWVudEl0ZW1UYWcYgICAgKqcsgoM\"],\"title\": \"Count with small numbers\",\"global_id\": \"ex4debd8a3\",\"seconds_per_fast_problem\": 4.0,\"sha\": \"7bc7ef1a01cb89d73239a4387ed06ecc63ba962f\",\"image_url\": \"https://fastly.kastatic.org/ka-exercise-screenshots/counting-out-1-20-objects.png\",\"tutorial_only\": false,\"current_revision_key\": \"7bc7ef1a01cb89d73239a4387ed06ecc63ba962f\",\"image_url_256\": \"https://fastly.kastatic.org/ka-exercise-screenshots/counting-out-1-20-objects_256.png\",\"content_id\": \"x4debd8a3\",\"content_kind\": \"Exercise\"},\"MASTERY_CARD_SUPERPROMOTE_THRESHOLD\": 0.84999999999999998,\"exercise_progress\": {\"practiced\": true,\"mastered\": false,\"level\": \"practiced\"},\"practiced_date\": null,\"exercise\": \"permutations_1\",\"clear_struggling_indicators\": null,\"total_done\": 6,\"exercise_states\": {\"struggling\": false,\"proficient\": true,\"practiced\": true,\"mastered\": false},\"backup_timestamp\": null,\"total_correct\": 6,\"user\": \"http://nouserid.khanacademy.org/dd3d25359ba55b34e2eaa20f4bc776f7\",\"kind\": \"UserExercise\",\"practiced\": false,\"seconds_per_fast_problem\": 4.0,\"last_done\": \"2014-10-24T08:06:49Z\",\"last_mastery_update\": \"2014-10-24T08:05:10Z\",\"maximum_exercise_progress\": {\"practiced\": true,\"mastered\": false,\"level\": \"practiced\"},\"mastered\": false,\"longest_streak\": 6,\"kaid\": \"kaid_78807109740671675685108\",\"content_kind\": \"UserExercise\",\"last_attempt_number\": 0,\"proficient_date\": null}]";

        public const string SampleUserExerciseJson = "{\"streak\":6,\"is_skill_check\":false,\"mastery_points\":0,\"snooze_time\":null,\"maximum_exercise_progress_dt\":\"2014-10-24T08:05:11Z\",\"last_count_hints\":0,\"exercise_model\":{\"is_skill_check\":false,\"uses_worked_examples\":false,\"v_position\":75,\"relative_url\":\"/exercise/permutations_1\",\"has_custom_thumbnail\":true,\"file_name\":\"\",\"related_videos\":[{\"translated_youtube_id\":\"oQpKtm5TtxU\",\"relative_url\":\"/video/permutations-and-combinations-1\",\"has_custom_thumbnail\":true,\"has_questions\":false,\"creation_date\":\"2016-03-03T20:54:26Z\",\"download_urls\":{\"mp4\":\"https://cdn.kastatic.org/KA-youtube-converted/oQpKtm5TtxU.mp4/oQpKtm5TtxU.mp4\",\"m3u8\":\"https://cdn.kastatic.org/KA-youtube-converted/oQpKtm5TtxU.m3u8/oQpKtm5TtxU.m3u8\",\"png\":\"https://cdn.kastatic.org/KA-youtube-converted/oQpKtm5TtxU.mp4/oQpKtm5TtxU.png\",\"mp4-low\":\"https://cdn.kastatic.org/KA-youtube-converted/oQpKtm5TtxU.mp4-low/oQpKtm5TtxU-low.mp4\"},\"ka_url\":\"https://www.khanacademy.org/video/permutations-and-combinations-1\",\"duration\":225,\"translated_title\":\"Ways to arrange colors\",\"author_key\":\"ag5zfmtoYW4tYWNhZGVteXJaCxIIVXNlckRhdGEiTHVzZXJfaWRfa2V5X2h0dHA6Ly9ub3VzZXJpZC5raGFuYWNhZGVteS5vcmcvMDdiZmY3YTQyYzA5OThiOGYyNjkzMTE1MmNiZWE2MTcM\",\"translated_description_html\":\"Thinking about how many ways you can pick four colors from a group of 6\",\"id\":\"27097\",\"concept_tags\":[\"Tag:xf18765aeb9250ab7\"],\"download_size\":4112823.0,\"description_html\":\"Thinking about how many ways you can pick four colors from a group of 6\",\"do_not_publish\":false,\"license_logo_url\":\"/images/license-logos/by-nc-sa.png\",\"progress_key\":\"v27097\",\"edit_slug\":\"edit/v/27097\",\"author_names\":[\"Sal Khan\",\"Monterey Institute for Technology and Education\"],\"license_full_name\":\"Creative Commons Attribution/Non-Commercial/Share-Alike\",\"license_url\":\"http://creativecommons.org/licenses/by-nc-sa/3.0\",\"deleted_mod_time\":\"2013-07-13T00:03:08Z\",\"thumbnail_data\":{\"url\":\"\",\"skip_filter\":false,\"title_text\":\"Ex: Ways to\narrange colors\",\"gcs_name\":\"/ka_thumbnails/oQpKtm5TtxU.jpg\"},\"related_exercise_url\":\"/exercise/permutations_1\",\"description\":\"Thinking about how many ways you can pick four colors from a group of 6\",\"extra_properties\":null,\"node_slug\":\"v/permutations-and-combinations-1\",\"deleted\":false,\"license_name\":\"CC BY-NC-SA (KA default)\",\"backup_timestamp\":\"2013-10-03T02:33:29Z\",\"concept_tags_info\":[{\"display_name\":\"Permutations (math)\",\"id\":\"Tag:xf18765aeb9250ab7\",\"slug\":\"permutations-math\"}],\"date_added\":\"2011-02-20T16:30:01Z\",\"translated_youtube_lang\":\"en\",\"kind\":\"Video\",\"date_modified\":\"2016-03-15T17:44:57Z\",\"url\":\"http://www.youtube.com/watch?v=oQpKtm5TtxU&feature=youtube_gdata_player\",\"clarifications_enabled\":true,\"ka_user_license\":\"cc-by-nc-sa\",\"global_id\":\"v27097\",\"sha\":\"5724896211e72ed0e541e9fefa9b0d66c003eeaf\",\"translated_description\":\"Thinking about how many ways you can pick four colors from a group of 6\",\"image_url\":\"https://cdn.kastatic.org/googleusercontent/L9bqo-HYdFDVwlERLP4mEZlCfJq_PsJSEWWNDejf8pC8bTON5nZf53UmAohI_zb-zpJfAZCk-Cm_VDKwMi6hI5M\",\"keywords\":\"U12_L2_T3_we1, Permutations, and, Combinations\",\"youtube_id\":\"oQpKtm5TtxU\",\"title\":\"Ways to arrange colors\",\"content_id\":\"27097\",\"content_kind\":\"Video\",\"readable_id\":\"permutations-and-combinations-1\"}],\"author_name\":\"Mark Wittels\",\"creation_date\":\"2016-05-30T10:11:56Z\",\"translated_short_display_name\":\"Permutation\",\"uses_assessment_items\":true,\"ka_url\":\"https://www.khanacademy.org/exercise/permutations_1\",\"short_display_name\":\"Permutation\",\"translated_title\":\"Permutations\",\"author_key\":\"ag5zfmtoYW4tYWNhZGVteXIXCxIIVXNlckRhdGEiCVRvbWVyIEdhbAw\",\"translated_description_html\":\"Introductory permutation problems.\",\"id\":\"917305998\",\"concept_tags\":[\"Tag:xf18765aeb9250ab7\"],\"is_quiz\":false,\"display_name\":\"Permutations\",\"tracking_document_url\":\"\",\"description_html\":\"Introductory permutation problems.\",\"do_not_publish\":false,\"tags\":[],\"translated_problem_types\":[{\"items\":[{\"sha\":\"19e2e8edfa26517912e61148f72fcb8b362c25a3\",\"live\":true,\"id\":\"x0b7102ad6f783a4f\"}],\"related_videos\":[],\"name\":\"problem-type-0\"}],\"progress_key\":\"e917305998\",\"suggested_completion_criteria\":\"num_correct_in_a_row_3\",\"edit_slug\":\"edit/e/917305998\",\"summative\":false,\"live\":true,\"translated_description\":\"Introductory permutation problems.\",\"pretty_display_name\":\"Permutations\",\"deleted_mod_time\":\"2013-07-13T00:03:07Z\",\"thumbnail_data\":{\"url\":\"\",\"skip_filter\":false,\"title_text\":\"\",\"gcs_name\":\"/ka_thumbnails/permutations_1.png\"},\"all_assessment_items\":[{\"sha\":\"19e2e8edfa26517912e61148f72fcb8b362c25a3\",\"live\":true,\"id\":\"x0b7102ad6f783a4f\"}],\"description\":\"Introductory permutation problems.\",\"translated_pretty_display_name\":\"Permutations\",\"node_slug\":\"e/permutations_1\",\"deleted\":false,\"backup_timestamp\":\"2013-10-03T02:33:29Z\",\"concept_tags_info\":[{\"display_name\":\"Permutations (math)\",\"id\":\"Tag:xf18765aeb9250ab7\",\"slug\":\"permutations-math\"}],\"problem_types\":[{\"items\":[{\"sha\":\"19e2e8edfa26517912e61148f72fcb8b362c25a3\",\"live\":true,\"id\":\"x0b7102ad6f783a4f\"}],\"related_videos\":[],\"name\":\"problem-type-0\"}],\"curated_related_videos\":[\"25802\",\"27097\",\"27098\"],\"covers\":[],\"h_position\":67,\"translated_display_name\":\"Permutations\",\"kind\":\"Exercise\",\"sha1\":\"9b7ab7dabff7ce6d1155f550ae808e5de1d7a91e\",\"name\":\"permutations_1\",\"date_modified\":\"2016-05-30T10:28:37Z\",\"prerequisites\":[\"counting_2\"],\"assessment_item_tags\":[\"ag5zfmtoYW4tYWNhZGVteXI2CxIRQXNzZXNzbWVudEl0ZW1UYWciATAMCxIRQXNzZXNzbWVudEl0ZW1UYWcYgICAwIKTqAoM\",\"ag5zfmtoYW4tYWNhZGVteXIxCxIRQXNzZXNzbWVudEl0ZW1UYWciATAMCxIRQXNzZXNzbWVudEl0ZW1UYWcYmeUvDA\"],\"title\":\"Permutations\",\"global_id\":\"e917305998\",\"seconds_per_fast_problem\":7.0,\"sha\":\"2d4f7bc5ff3b876eba4c0d41e20c1137286ed463\",\"image_url\":\"https://cdn.kastatic.org/ka-exercise-screenshots/permutations_1.png\",\"tutorial_only\":false,\"current_revision_key\":\"2d4f7bc5ff3b876eba4c0d41e20c1137286ed463\",\"image_url_256\":\"https://cdn.kastatic.org/ka-exercise-screenshots/permutations_1_256.png\",\"content_id\":\"917305998\",\"content_kind\":\"Exercise\"},\"MASTERY_CARD_SUPERPROMOTE_THRESHOLD\":0.84999999999999998,\"exercise_progress\":{\"practiced\":true,\"mastered\":false,\"level\":\"practiced\"},\"practiced_date\":\"2014-10-24T08:05:10Z\",\"exercise\":\"permutations_1\",\"clear_struggling_indicators\":true,\"total_done\":6,\"exercise_states\":{\"struggling\":false,\"proficient\":true,\"practiced\":true,\"mastered\":false},\"backup_timestamp\":\"2014-10-24T08:06:50Z\",\"total_correct\":6,\"user\":\"http://nouserid.khanacademy.org/dd3d25359ba55b34e2eaa20f4bc776f7\",\"kind\":\"UserExercise\",\"practiced\":true,\"seconds_per_fast_problem\":7.0,\"last_done\":\"2014-10-24T08:06:49Z\",\"last_mastery_update\":\"2014-10-24T08:05:10Z\",\"maximum_exercise_progress\":{\"practiced\":true,\"mastered\":false,\"level\":\"practiced\"},\"mastered\":false,\"longest_streak\":6,\"kaid\":\"kaid_78807109740671675685109\",\"content_kind\":\"UserExercise\",\"last_attempt_number\":0,\"proficient_date\":null}";

        public const string SampleUserExerciseProblemLogsJson = "[{\"relative_url\":\"/exercise/permutations_1?problem_number=1\",\"mission\":null,\"pre_attempt_prediction\":0.44683653285651542,\"attempts\":[\"\\\"6\\\"\"],\"seed\":\"19\",\"ka_url\":\"https://www.khanacademy.org/exercise/permutations_1?problem_number=1\",\"problem_type\":\"letters\",\"count_hints\":0,\"task_type\":\"practice.tutorial\",\"user_id\":\"http://googleid.khanacademy.org/113933792523419662884\",\"time_taken\":103,\"review_mode\":false,\"post_attempt_prediction\":0.81350811575055282,\"hint_used\":false,\"time_taken_attempts\":[103],\"correct\":true,\"exercise\":\"permutations_1\",\"skipped\":false,\"hint_time_taken_list\":[],\"backup_timestamp\":\"2014-10-24T08:05:11Z\",\"earned_proficiency\":false,\"user\":\"http://nouserid.khanacademy.org/dd3d25359ba55b34e2eaa20f4bc776f7\",\"outgoing_level\":\"practiced\",\"ip_address\":\"127.0.0.1\",\"problem_number\":1,\"kind\":\"ProblemLog\",\"sha1\":\"778c5cb08ef70e9f6b4b067d8bc6b36cc5885382\",\"count_attempts\":1,\"task_id\":\"5898544860102656\",\"points_earned\":175,\"practiced_prereqs\":true,\"date_done_str\":\"2014-10-24\",\"prediction_version\":null,\"time_done\":\"2014-10-24T08:05:10Z\",\"random_float\":0.17358451528696217,\"kaid\":null,\"incoming_level\":\"unstarted\",\"hint_after_attempt_list\":[]}]";

        public const string SampleUserProgressChangesJson = "[{\"date\": \"2014-10-24T06:43:34Z\",\"exercise_name\": \"counting_2\",\"to_progress\": {\"practiced\": true,\"mastered\": false,\"level\": \"practiced\"},\"from_progress\": {\"practiced\": false,\"mastered\": false,\"level\": \"unstarted\"}},{\"date\": \"2014-10-24T08:05:11Z\",\"exercise_name\": \"permutations_1\",\"to_progress\": {\"practiced\": true,\"mastered\": false,\"level\": \"practiced\"},\"from_progress\": {\"practiced\": false,\"mastered\": false,\"level\": \"unstarted\"}}]";

        public const string SampleUserWatchedVideosJson = "[{\"kind\": \"UserVideo\",\"seconds_watched\": 1306,\"last_watched\": \"2012-05-15T01:41:09Z\",\"completed\": true,\"backup_timestamp\": \"2012-05-15T01:41:09Z\",\"last_second_watched\": 638,\"points\": 750,\"video\": null,\"user\": \"http://nouserid.khanacademy.org/dd3d25359ba55b34e2eaa20f4bc776f7\",\"duration\": 686,\"progress\": 1.0,\"kaid\": null  }]";

        public const string SampleUserVideoInteractionsByIdJson = "{\"kind\": \"UserVideo\",\"seconds_watched\": 1306,\"last_watched\": \"2012-05-15T01:41:09Z\",\"completed\": true,\"backup_timestamp\": \"2012-05-15T01:41:09Z\",\"ka_locale\": \"en\",\"last_second_watched\": 638,\"points\": 750,\"video\": null,\"user\": \"http://nouserid.khanacademy.org/dd3d25359ba55b34e2eaa20f4bc776f7\",\"duration\": 686,\"progress\": 1.0,\"action_results\": {\"notifications_added\": {\"urgent\": [],\"readable\": [],\"continue_url\": null},\"new_task_json\": {\"task_json\": {\"completion_criteria\": {\"name\": \"finish_video\"},\"slug\": \"hypothesis-testing-and-p-values\",\"task_type\": \"video\",\"description\": \"Sal walks through an example about a neurologist testing the effect of a drug to discuss hypothesis testing and p-values.\",\"badges_awarded\": [],\"title\": \"Hypothesis testing and p-values\",\"seconds_watched\": 0,\"language_tag\": \"en\",\"points_earned\": 0,\"direct_link\": \"/math/probability/statistics-inferential/hypothesis-testing/v/hypothesis-testing-and-p-values\",\"last_second_watched\": 0,\"content\": null,\"translated_description\": \"Sal walks through an example about a neurologist testing the effect of a drug to discuss hypothesis testing and p-values.\",\"point_bounty\": 100,\"key\": \"ag5zfmtoYW4tYWNhZGVteXJtCxIJVXNlclZpZGVvIkxodHRwOi8vbm91c2VyaWQua2hhbmFjYWRlbXkub3JnL2RkM2QyNTM1OWJhNTViMzRlMmVhYTIwZjRiYzc3NmY2Oi1GdGxINHN2cXg0DAsSDExlYXJuaW5nVGFzaxgBDX\",\"versions\": {\"LearningTask\": 4,\"VideoTask\": 3},\"translated_title\": \"Hypothesis testing and p-values\",\"translated_description_html\": \"Sal walks through an example about a neurologist testing the effect of a drug to discuss hypothesis testing and p-values.\",\"id\": \"1\",\"avatar_parts_awarded\": []}},\"badge_counts\": {\"0\": 22,\"1\": 3,\"2\": 0,\"3\": 0,\"4\": 0,\"5\": 0},\"user_profile\": {\"is_moderator\": false,\"streak_length\": 0,\"can_record_tutorial\": false,\"is_demo\": false,\"allowed_by_parent_to_add_any_coach\": true,\"user_key\": \"ag5zfmtoYW4tYWNhZGVteXJaCxIIVXNlckRhdGEiTHVzZXJfaWRfa2V5X2h0dHA6Ly9ub3VzZXJpZC5raGFuYWNhZGVteS5vcmcvZGQzZDI1MzU5YmE1NWIzNGUyZWFhMjBmNGJjNzc2ZjYX\",\"count_brand_new_notifications\": 0,\"has_changed_avatar\": false,\"avatar_name\": \"greenleaf\",\"moderator_level\": 0,\"is_activity_accessible\": true,\"has_child_students\": false,\"is_parent_of_logged_in_user\": false,\"date_joined\": \"2011-11-09T00:22:12Z\",\"user_id\": \"http://googleid.khanacademy.org/113933792523419662885\",\"affiliations\": [],\"user_location\": null,\"can_create_official_clarifications\": false,\"child_page_root\": \"/parent/child/kaid_78807109740671675685110/\",\"background_name\": \"blue\",\"profile_root\": \"/profile/kaid_78807109740671675685110/\",\"is_data_collectible\": true,\"streak_last_extended\": \"1900-01-01\",\"follow_requires_approval\": true,\"can_message_users\": false,\"is_phantom\": false,\"email\": \"fake@gmail.com\",\"global_permissions\": [],\"username\": \"\",\"bio\": \"\",\"hide_visual\": false,\"is_midsignup_phantom\": false,\"can_modify_coaches\": true,\"can_eval_cs_projects\": false,\"can_hellban\": false,\"public_badges\": [],\"is_child_account\": false,\"signed_up_as_teacher\": false,\"background\": {\"thumb_src\": \"https://cdn.kastatic.org/images/profile/backgrounds/bg-blue-preview.png\",\"display_name\": \"Blue\",\"image_path\": \"/images/profile/backgrounds/bg-blue.jpg\",\"reward_triggers\": \"set([])\",\"thumb_path\": \"/images/profile/backgrounds/bg-blue-preview.png\",\"translated_requirements\": [],\"thumbnail_path\": \"\",\"thumbnail_src\": \"https://cdn.kastatic.org/images/profile/backgrounds/bg-blue.jpg\",\"reward_type\": \"profile_background\",\"translated_display_name\": \"Blue\",\"image_src\": \"https://cdn.kastatic.org/images/profile/backgrounds/bg-blue.jpg\",\"name\": \"blue\"},\"is_creator\": false,\"count_videos_completed\": 34,\"is_public\": false,\"avatar_src\": \"https://cdn.kastatic.org/images/avatars/leaf-green.png\",\"sound_on\": true,\"nickname\": \"fake\",\"includes_user_data_info\": true,\"has_coach_homepage\": false,\"background_src\": \"https://cdn.kastatic.org/images/profile/backgrounds/bg-blue.jpg\",\"is_developer\": false,\"is_publisher\": false,\"is_curator\": false,\"restricted_domain\": null,\"has_parent_homepage\": false,\"homepage_url\": \"/\",\"points\": 38360,\"is_coaching_logged_in_user\": true,\"avatar\": {\"display_name\": \"Green Leaf\",\"image_path\": \"/images/avatars/leaf-green.png\",\"reward_triggers\": \"set([])\",\"translated_requirements\": [],\"part_type\": \"model\",\"thumbnail_path\": \"\",\"thumbnail_src\": \"https://cdn.kastatic.org/images/avatars/leaf-green.png\",\"reward_type\": \"avatar_reward\",\"translated_display_name\": \"Green Leaf\",\"image_src\": \"https://cdn.kastatic.org/images/avatars/leaf-green.png\",\"name\": \"greenleaf\"},\"is_self\": true,\"streak_last_length\": 0,\"is_orphan\": false,\"kaid\": \"kaid_78807109740671675685110\",\"badge_counts\": {\"0\": 22,\"1\": 3,\"2\": 0,\"3\": 0,\"4\": 0,\"5\": 0},\"has_students\": false}},\"kaid\": \"kaid_78807109740671675685110\"}";

        public const string SampleUserVideoLogsJson = "[{\"kind\": \"VideoLog\", \"seconds_watched\": 78, \"translated_video_title\": \"Hypothesis Testing and P-values\", \"time_watched\": \"2012-05-14T08:49:31Z\", \"backup_timestamp\": \"2012-05-14T08:49:31Z\", \"points_earned\": 86, \"playlist_titles\": [   \"Statistics\" ], \"last_second_watched\": 78, \"is_video_completed\": false, \"fallback_player\": false, \"youtube_id\": \"-FtlH4svqx4\", \"captions_locale\": null, \"translated_playlist_titles\": [   \"Statistics\" ], \"kaid\": \"kaid_78807109740671675685110\", \"ip_address\": null, \"video_title\": \"Hypothesis Testing and P-values\", \"user\": \"http://nouserid.khanacademy.org/dd3d25359ba55b34e2eaa20f4bc776f7\"}]";

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


        public static readonly List<UserExercise> SampleUserExercises = new List<UserExercise>()
        {
            new UserExercise()
            {
                Streak = 6,
                IsSkillCheck = false,
                MasteryPoints = 0,
                SnoozeTime = null,
                MaximumExerciseProgressDt = new DateTime(2014, 10, 24, 08, 05, 11),
                LastCountHints = 0,
                ExerciseModel = ExerciseTestData.CountingExercise,
                MasteryCardSuperPromoteThreshold = 0.84999999999999998,
                ExerciseProgress = new ExerciseProgress()
                {
                    Practiced = true,
                    Mastered = false,
                    Level = "practiced"
                },
                PracticedDate = null,
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
                LastDone = new DateTime(2014, 10, 24, 08, 06, 49),
                LastMasteryUpdate = new DateTime(2014, 10, 24, 08, 05, 10),
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

        public static readonly UserExercise SampleUserExercise = new UserExercise()
        {
            Streak = 6,
            IsSkillCheck = false,
            MasteryPoints = 0,
            SnoozeTime = null,
            MaximumExerciseProgressDt = new DateTime(2014, 10, 24, 08, 05, 11),
            LastCountHints = 0,
            ExerciseModel = new Exercise()
            {
                IsSkillCheck = false,
                UsesWorkedExamples = false,
                VPosition = 75,
                RelativeUrl = new Uri("/exercise/permutations_1", UriKind.Relative),
                HasCustomThumbnail = true,
                FileName = "",
                RelatedVideos = new List<Video>()
                {
                    new Video()
                    {
                        TranslatedYouTubeId = "oQpKtm5TtxU",
                        RelativeUrl = new Uri("/video/permutations-and-combinations-1", UriKind.Relative),
                        HasCustomThumbnail = true,
                        HasQuestions = false,
                        CreationDate = new DateTime(2016, 03, 03, 20, 54, 26),
                        DownloadUrls = new DownloadUrls()
                        {
                            Mp4 = new Uri("https://cdn.kastatic.org/KA-youtube-converted/oQpKtm5TtxU.mp4/oQpKtm5TtxU.mp4"),
                            M3U8 = new Uri("https://cdn.kastatic.org/KA-youtube-converted/oQpKtm5TtxU.m3u8/oQpKtm5TtxU.m3u8"),
                            Png = new Uri("https://cdn.kastatic.org/KA-youtube-converted/oQpKtm5TtxU.mp4/oQpKtm5TtxU.png"),
                            Mp4Low = new Uri("https://cdn.kastatic.org/KA-youtube-converted/oQpKtm5TtxU.mp4-low/oQpKtm5TtxU-low.mp4")
                        },
                        KaUrl = new Uri("https://www.khanacademy.org/video/permutations-and-combinations-1"),
                        Duration = 225,
                        TranslatedTitle = "Ways to arrange colors",
                        AuthorKey = "ag5zfmtoYW4tYWNhZGVteXJaCxIIVXNlckRhdGEiTHVzZXJfaWRfa2V5X2h0dHA6Ly9ub3VzZXJpZC5raGFuYWNhZGVteS5vcmcvMDdiZmY3YTQyYzA5OThiOGYyNjkzMTE1MmNiZWE2MTcM",
                        TranslatedDescriptionHtml = "Thinking about how many ways you can pick four colors from a group of 6",
                        Id = "27097",
                        ConceptTags = new List<string>()
                        {
                            "Tag:xf18765aeb9250ab7"
                        },
                        DownloadSize = 4112823.0,
                        DescriptionHtml = "Thinking about how many ways you can pick four colors from a group of 6",
                        DoNotPublish = false,
                        LicenseLogoUrl = new Uri("/images/license-logos/by-nc-sa.png", UriKind.Relative),
                        ProgressKey = "v27097",
                        EditSlug = "edit/v/27097",
                        AuthorNames = new List<string>()
                        {
                            "Sal Khan",
                            "Monterey Institute for Technology and Education"
                        },
                        LicenseFullName = "Creative Commons Attribution/Non-Commercial/Share-Alike",
                        LicenseUrl = new Uri("http://creativecommons.org/licenses/by-nc-sa/3.0"),
                        DeletedModTime = new DateTime(2013, 07, 13, 00, 03, 08),
                        ThumbnailData = new ThumbnailData()
                        {
                            Url = null,
                            SkipFilter = false,
                            TitleText = "Ex: Ways to\narrange colors",
                            GcsName = "/ka_thumbnails/oQpKtm5TtxU.jpg"
                        },
                        RelatedExerciseUrl = new Uri("/exercise/permutations_1", UriKind.Relative),
                        Description = "Thinking about how many ways you can pick four colors from a group of 6",
                        ExtraProperties = null,
                        NodeSlug = "v/permutations-and-combinations-1",
                        Deleted = false,
                        LicenseName = "CC BY-NC-SA (KA default)",
                        BackupTimestamp = new DateTime(2013, 10, 03, 02, 33, 29),
                        ConceptTagsInfo = new List<ConceptTag>()
                        {
                            new ConceptTag()
                            {
                                DisplayName = "Permutations (math)",
                                Id = "Tag:xf18765aeb9250ab7",
                                Slug = "permutations-math"
                            }
                        },
                        DateAdded = new DateTime(2011, 02, 20, 16, 30, 01),
                        TranslatedYouTubeLang = "en",
                        Kind = "Video",
                        DateModified = new DateTime(2016, 03, 15, 17, 44, 57),
                        Url = new Uri("http://www.youtube.com/watch?v=oQpKtm5TtxU&feature=youtube_gdata_player"),
                        ClarificationsEnabled = true,
                        KaUserLicense = "cc-by-nc-sa",
                        GlobalId = "v27097",
                        Sha = "5724896211e72ed0e541e9fefa9b0d66c003eeaf",
                        TranslatedDescription = "Thinking about how many ways you can pick four colors from a group of 6",
                        ImageUrl = new Uri("https://cdn.kastatic.org/googleusercontent/L9bqo-HYdFDVwlERLP4mEZlCfJq_PsJSEWWNDejf8pC8bTON5nZf53UmAohI_zb-zpJfAZCk-Cm_VDKwMi6hI5M"),
                        keywords = "U12_L2_T3_we1, Permutations, and, Combinations",
                        YouTubeId = "oQpKtm5TtxU",
                        Title = "Ways to arrange colors",
                        ContentId = "27097",
                        ContentKind = "Video",
                        ReadableId = "permutations-and-combinations-1"
                    }
                },
                AuthorName = "Mark Wittels",
                CreationDate = new DateTime(2016, 05, 30, 10, 11, 56),
                TranslatedShortDisplayName = "Permutation",
                UsesAssessmentItems = true,
                KaUrl = new Uri("https://www.khanacademy.org/exercise/permutations_1"),
                ShortDisplayName = "Permutation",
                TranslatedTitle = "Permutations",
                AuthorKey = "ag5zfmtoYW4tYWNhZGVteXIXCxIIVXNlckRhdGEiCVRvbWVyIEdhbAw",
                TranslatedDescriptionHtml = "Introductory permutation problems.",
                Id = "917305998",
                ConceptTags = new List<string>()
                {
                    "Tag:xf18765aeb9250ab7"
                },
                IsQuiz = false,
                DisplayName = "Permutations",
                TrackingDocumentUrl = null,
                DescriptionHtml = "Introductory permutation problems.",
                DoNotPublish = false,
                Tags = new List<string>(),
                TranslatedProblemTypes = new List<TranslatedProblemType>()
                {
                    new TranslatedProblemType()
                    {
                        Items = new List<Item>()
                        {
                            new Item()
                            {
                                Sha = "19e2e8edfa26517912e61148f72fcb8b362c25a3",
                                Live = true,
                                Id = "x0b7102ad6f783a4f"
                            }
                        },
                        RelatedVideos = new List<string>(),
                        Name = "problem-type-0"
                    }
                },
                ProgressKey = "e917305998",
                SuggestedCompletionCriteria = "num_correct_in_a_row_3",
                EditSlug = "edit/e/917305998",
                Summative = false,
                Live = true,
                TranslatedDescription = "Introductory permutation problems.",
                PrettyDisplayName = "Permutations",
                DeletedModTime = new DateTime(2013, 07, 13, 00, 03, 07),
                ThumbnailData = new ThumbnailData()
                {
                    Url = null,
                    SkipFilter = false,
                    TitleText = "",
                    GcsName = "/ka_thumbnails/permutations_1.png"
                },
                AllAssessmentItems = new List<Item>()
                {
                    new Item()
                    {
                        Sha = "19e2e8edfa26517912e61148f72fcb8b362c25a3",
                        Live = true,
                        Id = "x0b7102ad6f783a4f"
                    }
                },
                Description = "Introductory permutation problems.",
                TranslatedPrettyDisplayName = "Permutations",
                NodeSlug = "e/permutations_1",
                Deleted = false,
                BackupTimestamp = new DateTime(2013, 10, 03, 02, 33, 29),
                ConceptTagsInfo = new List<ConceptTag>()
                {
                    new ConceptTag()
                    {
                        DisplayName = "Permutations (math)",
                        Id = "Tag:xf18765aeb9250ab7",
                        Slug = "permutations-math"
                    }
                },
                ProblemTypes = new List<ProblemType>()
                {
                    new ProblemType()
                    {
                        Items = new List<Item>()
                        {
                            new Item()
                            {
                                Sha = "19e2e8edfa26517912e61148f72fcb8b362c25a3",
                                Live = true,
                                Id = "x0b7102ad6f783a4f"
                            }
                        },
                        RelatedVideos = new List<string>(),
                        Name = "problem-type-0"
                    }
                },
                CuratedRelatedVideos = new List<string>()
                {
                    "25802",
                    "27097",
                    "27098"
                },
                Covers = new List<string>(),
                HPosition = 67,
                TranslatedDisplayName = "Permutations",
                Kind = "Exercise",
                Sha1 = "9b7ab7dabff7ce6d1155f550ae808e5de1d7a91e",
                Name = "permutations_1",
                DateModified = new DateTime(2016, 05, 30, 10, 28, 37),
                Prerequisites = new List<string>()
                {
                    "counting_2"
                },
                AssessmentItemTags = new List<string>()
                {
                    "ag5zfmtoYW4tYWNhZGVteXI2CxIRQXNzZXNzbWVudEl0ZW1UYWciATAMCxIRQXNzZXNzbWVudEl0ZW1UYWcYgICAwIKTqAoM",
                    "ag5zfmtoYW4tYWNhZGVteXIxCxIRQXNzZXNzbWVudEl0ZW1UYWciATAMCxIRQXNzZXNzbWVudEl0ZW1UYWcYmeUvDA"
                },
                Title = "Permutations",
                GlobalId = "e917305998",
                SecondsPerFastProblem = 7.0,
                Sha = "2d4f7bc5ff3b876eba4c0d41e20c1137286ed463",
                ImageUrl = new Uri("https://cdn.kastatic.org/ka-exercise-screenshots/permutations_1.png"),
                TutorialOnly = false,
                CurrentRevisionKey = "2d4f7bc5ff3b876eba4c0d41e20c1137286ed463",
                ImageUrl256 = new Uri("https://cdn.kastatic.org/ka-exercise-screenshots/permutations_1_256.png"),
                ContentId = "917305998",
                ContentKind = "Exercise"
            },
            MasteryCardSuperPromoteThreshold = 0.84999999999999998,
            ExerciseProgress = new ExerciseProgress()
            {
                Practiced = true,
                Mastered = false,
                Level = "practiced"
            },
            PracticedDate = new DateTime(2014, 10, 24, 08, 05, 10),
            Exercise = "permutations_1",
            ClearStrugglingIndicators = true,
            TotalDone = 6,
            ExerciseStates = new ExerciseStates()
            {
                Struggling = false,
                Proficient = true,
                Practiced = true,
                Mastered = false
            },
            BackupTimestamp = new DateTime(2014, 10, 24, 08, 06, 50),
            TotalCorrect = 6,
            User = "http://nouserid.khanacademy.org/dd3d25359ba55b34e2eaa20f4bc776f7",
            Kind = "UserExercise",
            Practiced = true,
            SecondsPerFastProblem = 7.0,
            LastDone = new DateTime(2014, 10, 24, 08, 06, 49),
            LastMasteryUpdate = new DateTime(2014, 10, 24, 08, 05, 10),
            MaximumExerciseProgress = new ExerciseProgress()
            {
                Practiced = true,
                Mastered = false,
                Level = "practiced"
            },
            Mastered = false,
            LongestStreak = 6,
            KaId = "kaid_78807109740671675685109",
            ContentKind = "UserExercise",
            LastAttemptNumber = 0,
            ProficientDate = null
        };

        public static readonly List<ProblemLog> SampleUserExerciseProblemLogs = new List<ProblemLog>()
        {
            new ProblemLog()
            {
                RelativeUrl = new Uri("/exercise/permutations_1?problem_number=1", UriKind.Relative),
                Mission = null,
                PreAttemptPrediction = 0.44683653285651542,
                Attempts = new List<string>() { "\"6\"" },
                Seed = "19",
                KaUrl = new Uri("https://www.khanacademy.org/exercise/permutations_1?problem_number=1"),
                ProblemType = "letters",
                CountHints = 0,
                TaskType = "practice.tutorial",
                UserId = "http://googleid.khanacademy.org/113933792523419662884",
                TimeTaken = 103,
                ReviewMode = false,
                PostAttemptPrediction = 0.81350811575055282,
                HintUsed = false,
                TimeTakenAttempts = new List<int>() { 103 },
                Correct = true,
                Exercise = "permutations_1",
                Skipped = false,
                HintTimeTakenList = new List<object>(),
                BackupTimestamp = new DateTime(2014, 10, 24, 08, 05, 11),
                EarnedProficiency = false,
                User = "http://nouserid.khanacademy.org/dd3d25359ba55b34e2eaa20f4bc776f7",
                OutgoingLevel = "practiced",
                IpAddress = "127.0.0.1",
                ProblemNumber = 1,
                Kind = "ProblemLog",
                Sha1 = "778c5cb08ef70e9f6b4b067d8bc6b36cc5885382",
                CountAttempts = 1,
                TaskId = "5898544860102656",
                PointsEarned = 175,
                PracticedPrereqs = true,
                DateDoneStr = "2014-10-24",
                PredictionVersion = null,
                TimeDone = new DateTime(2014, 10, 24, 08, 05, 10),
                RandomFloat = 0.17358451528696217,
                KaId = null,
                IncomingLevel = "unstarted",
                HintAfterAttemptList = new List<object>()
            }
        };

        public static readonly List<ProgressChange> SampleUserProgressChanges = new List<ProgressChange>()
        {
            new ProgressChange()
            {
                Date = new DateTime(2014, 10, 24, 06, 43, 34),
                ExerciseName = "counting_2",
                ToProgress = new Progress()
                {
                    Practiced = true,
                    Mastered = false,
                    Level = "practiced"
                },
                FromProgress = new Progress()
                {
                    Practiced = false,
                    Mastered = false,
                    Level = "unstarted"
                }
            },
            new ProgressChange()
            {
                Date = new DateTime(2014, 10, 24, 08, 05, 11),
                ExerciseName = "permutations_1",
                ToProgress = new Progress()
                {
                    Practiced = true,
                    Mastered = false,
                    Level = "practiced"
                },
                FromProgress = new Progress()
                {
                    Practiced = false,
                    Mastered = false,
                    Level = "unstarted"
                }
            }
        };

        public static readonly List<UserVideo> SampleUserWatchedVideos = new List<UserVideo>()
        {
            new UserVideo()
            {
                Kind = "UserVideo",
                SecondsWatched = 1306,
                LastWatched = new DateTime(2012, 05, 15, 01, 41, 09),
                Completed = true,
                BackupTimestamp = new DateTime(2012, 05, 15, 01, 41, 09),
                LastSecondWatched = 638,
                Points = 750,
                Video = null,
                User = "http://nouserid.khanacademy.org/dd3d25359ba55b34e2eaa20f4bc776f7",
                Duration = 686,
                Progress = 1.0,
                KaId = null
            }
        };

        public static readonly UserVideo SampleUserVideoInteractionsById = new UserVideo()
        {
            Kind = "UserVideo",
            SecondsWatched = 1306,
            LastWatched = new DateTime(2012, 05, 15, 01, 41, 09),
            Completed = true,
            BackupTimestamp = new DateTime(2012, 05, 15, 01, 41, 09),
            KaLocale = "en",
            LastSecondWatched = 638,
            Points = 750,
            Video = null,
            User = "http://nouserid.khanacademy.org/dd3d25359ba55b34e2eaa20f4bc776f7",
            Duration = 686,
            Progress = 1.0,
            ActionResults = new ActionResults()
            {
                NotificationsAdded = new Notifications()
                {
                    Urgent = new List<object>(),
                    Readable = new List<object>(),
                    ContinueUrl = null
                },
                NewTask = new KhanTaskWrapper()
                {
                    Task = new KhanTask()
                    {
                        CompletionCriteria = new CompletionCriteria()
                        {
                            Name = "finish_video"
                        },
                        Slug = "hypothesis-testing-and-p-values",
                        TaskType = "video",
                        Description = "Sal walks through an example about a neurologist testing the effect of a drug to discuss hypothesis testing and p-values.",
                        BadgesAwarded = new List<object>(),
                        Title = "Hypothesis testing and p-values",
                        SecondsWatched = 0,
                        LanguageTag = "en",
                        PointsEarned = 0,
                        DirectLink = new Uri("/math/probability/statistics-inferential/hypothesis-testing/v/hypothesis-testing-and-p-values", UriKind.Relative),
                        LastSecondWatched = 0,
                        Content = null,
                        TranslatedDescription = "Sal walks through an example about a neurologist testing the effect of a drug to discuss hypothesis testing and p-values.",
                        PointBounty = 100,
                        Key = "ag5zfmtoYW4tYWNhZGVteXJtCxIJVXNlclZpZGVvIkxodHRwOi8vbm91c2VyaWQua2hhbmFjYWRlbXkub3JnL2RkM2QyNTM1OWJhNTViMzRlMmVhYTIwZjRiYzc3NmY2Oi1GdGxINHN2cXg0DAsSDExlYXJuaW5nVGFzaxgBDX",
                        Versions = new Versions()
                        {
                            LearningTask = 4,
                            VideoTask = 3
                        },
                        TranslatedTitle = "Hypothesis testing and p-values",
                        TranslatedDescriptionHtml = "Sal walks through an example about a neurologist testing the effect of a drug to discuss hypothesis testing and p-values.",
                        Id = "1",
                        AvatarPartsAwarded = new List<object>()
                    }
                },
                BadgeCounts = new Dictionary<Category, int>()
                {
                    { Category.Meteorite, 22 },
                    { Category.Moon, 3 },
                    { Category.Earth, 0 },
                    { Category.Sun, 0 },
                    { Category.BlackHole, 0 },
                    { Category.ChallengePatch, 0 }
                },
                UserProfile = new UserProfile()
                {
                    IsModerator = false,
                    StreakLength = 0,
                    CanRecordTutorial = false,
                    IsDemo = false,
                    AllowedByParentToAddAnyCoach = true,
                    UserKey = "ag5zfmtoYW4tYWNhZGVteXJaCxIIVXNlckRhdGEiTHVzZXJfaWRfa2V5X2h0dHA6Ly9ub3VzZXJpZC5raGFuYWNhZGVteS5vcmcvZGQzZDI1MzU5YmE1NWIzNGUyZWFhMjBmNGJjNzc2ZjYX",
                    CountBrandNewNotifications = 0,
                    HasChangedAvatar = false,
                    AvatarName = "greenleaf",
                    ModeratorLevel = 0,
                    IsActivityAccessible = true,
                    HasChildStudents = false,
                    IsParentOfLoggedInUser = false,
                    DateJoined = new DateTime(2011, 11, 09, 00, 22, 12),
                    UserId = "http://googleid.khanacademy.org/113933792523419662885",
                    Affiliations = new List<object>(),
                    UserLocation = null,
                    CanCreateOfficialClarifications = false,
                    ChildPageRoot = "/parent/child/kaid_78807109740671675685110/",
                    BackgroundName = "blue",
                    ProfileRoot = new Uri("/profile/kaid_78807109740671675685110/", UriKind.Relative),
                    IsDataCollectible = true,
                    StreakLastExtended = "1900-01-01",
                    FollowRequiresApproval = true,
                    CanMessageUsers = false,
                    IsPhantom = false,
                    Email = "fake@gmail.com",
                    GlobalPermissions = new List<object>(),
                    Username = "",
                    Bio = "",
                    HideVisual = false,
                    IsMidsignupPhantom = false,
                    CanModifyCoaches = true,
                    CanEvalCsProjects = false,
                    CanHellban = false,
                    PublicBadges = new List<object>(),
                    IsChildAccount = false,
                    SignedUpAsTeacher = false,
                    Background = new ImageDetails()
                    {
                        Name = "blue",
                        TranslatedDisplayName = "Blue",
                        DisplayName = "Blue",
                        ImagePath = new Uri("/images/profile/backgrounds/bg-blue.jpg", UriKind.Relative),
                        ImageSrc = new Uri("https://cdn.kastatic.org/images/profile/backgrounds/bg-blue.jpg"),
                        RewardTriggers = "set([])",
                        ThumbPath = new Uri("/images/profile/backgrounds/bg-blue-preview.png", UriKind.Relative),
                        ThumbSrc = new Uri("https://cdn.kastatic.org/images/profile/backgrounds/bg-blue-preview.png"),
                        TranslatedRequirements = new List<object>(),
                        ThumbnailPath = null,
                        ThumbnailSrc = new Uri("https://cdn.kastatic.org/images/profile/backgrounds/bg-blue.jpg"),
                        RewardType = "profile_background",
                    },
                    IsCreator = false,
                    CountVideosCompleted = 34,
                    IsPublic = false,
                    AvatarSrc = new Uri("https://cdn.kastatic.org/images/avatars/leaf-green.png"),
                    SoundOn = true,
                    Nickname = "fake",
                    IncludesUserDataInfo = true,
                    HasCoachHomepage = false,
                    BackgroundSrc = new Uri("https://cdn.kastatic.org/images/profile/backgrounds/bg-blue.jpg"),
                    IsDeveloper = false,
                    IsPublisher = false,
                    IsCurator = false,
                    RestrictedDomain = null,
                    HasParentHomepage = false,
                    HomepageUrl = new Uri("/", UriKind.Relative),
                    Points = 38360,
                    IsCoachingLoggedInuser = true,
                    Avatar = new ImageDetails()
                    {
                        DisplayName = "Green Leaf",
                        ImagePath = new Uri("/images/avatars/leaf-green.png", UriKind.Relative),
                        RewardTriggers = "set([])",
                        TranslatedRequirements = new List<object>(),
                        PartType = "model",
                        ThumbnailPath= null,
                        ThumbnailSrc = new Uri("https://cdn.kastatic.org/images/avatars/leaf-green.png"),
                        RewardType = "avatar_reward",
                        TranslatedDisplayName = "Green Leaf",
                        ImageSrc = new Uri("https://cdn.kastatic.org/images/avatars/leaf-green.png"),
                        Name = "greenleaf"
                    },
                    IsSelf = true,
                    StreakLastLength = 0,
                    IsOrphan = false,
                    KaId = "kaid_78807109740671675685110",
                    BadgeCounts = new Dictionary<Category, int>()
                    {
                        { Category.Meteorite, 22 },
                        { Category.Moon, 3 },
                        { Category.Earth, 0 },
                        { Category.Sun, 0 },
                        { Category.BlackHole, 0 },
                        { Category.ChallengePatch, 0 }
                    },
                    HasStudents = false
                }
            },
            KaId = "kaid_78807109740671675685110"
        };

        public static readonly List<VideoLog> SampleUserVideoLogs = new List<VideoLog>()
        {
            new VideoLog()
            {
                Kind = "VideoLog",
                SecondsWatched = 78,
                TranslatedVideoTitle = "Hypothesis Testing and P-values",
                TimeWatched = new DateTime(2012, 05, 14, 08, 49, 31),
                BackupTimestamp = new DateTime(2012, 05, 14, 08, 49, 31),
                PointsEarned = 86,
                PlaylistTitles = new List<string>() { "Statistics" },
                LastSecondWatched = 78,
                IsVideoCompleted = false,
                FallbackPlayer = false,
                YouTubeId = "-FtlH4svqx4",
                CaptionsLocale = null,
                TranslatedPlaylistTitles = new List<string>() { "Statistics" },
                KaId = "kaid_78807109740671675685110",
                IpAddress = null,
                VideoTitle = "Hypothesis Testing and P-values",
                User = "http://nouserid.khanacademy.org/dd3d25359ba55b34e2eaa20f4bc776f7"
            }
        };
    }
}
