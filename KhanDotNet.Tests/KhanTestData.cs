using KhanDotNet.Library.Contract;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace KhanDotNet.Tests
{
    public static class KhanTestData
    {
        public static Badges Badges
        {
            get
            {
                return new Badges();
            }
        }

        public static Exercises Exercises
        {
            get
            {
                return new Exercises();
            }
        }
    }

    public class Exercises
    {
        public Exercise CountingExercise
        {
            get
            {
                return new Exercise()
                {
                    IsSkillCheck = false,
                    UsesWorkedExamples = false,
                    VPosition = 3,
                    RelativeUrl = new Uri("/exercise/counting-out-1-20-objects", UriKind.Relative),
                    HasCustomThumbnail = true,
                    FileName = null,
                    RelatedVideoReadableIds = new List<string>() { "counting-with-small-numbers" },
                    AuthorName = "Gail Hargrave",
                    CreationDate = DateTime.Parse("2016-03-01T19:29:20Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind),
                    translated_short_display_name = "Count with ",
                    uses_assessment_items = true,
                    ka_url = "http://www.khanacademy.org/exercise/counting-out-1-20-objects",
                    short_display_name = "Count with ",
                    translated_title = "Count with small numbers",
                    author_key = "ag5zfmtoYW4tYWNhZGVteXJaCxIIVXNlckRhdGEiTHVzZXJfaWRfa2V5X2h0dHA6Ly9ub3VzZXJpZC5raGFuYWNhZGVteS5vcmcvNjZmOTNhODE4YjU2ZWUxZTliOTM1MGI2OTc2OGQ4ZTMM",
                    translated_description_html = "Practice counting up to 10 objects.",
                    id = "x4debd8a3",
                    concept_tags = new List<string>() { "Tag:x731f236a6d33f0ff", "Tag:xf444fba1e72e5158" },
                    is_quiz = false,
                    display_name = "Count with small numbers",
                    tracking_document_url = null,
                    description_html = "Practice counting up to 10 objects.",
                    do_not_publish = false,
                    tags = new List<object>(),
                    translated_problem_types = new List<TranslatedProblemType>()
            {
                new TranslatedProblemType()
                {
                    items = new List<Item>()
                    {
                        new Item()
                        {
                            sha = "c2074685910760669c855d628b7a44ef8d828be9",
                            live = true,
                            id = "xde8147b8edb82294"
                        },
                        new Item()
                        {
                            sha = "76c7fd55c20dfe0f4f938745b73e1e7d0c4757ac",
                            live = true,
                            id = "xa5c8d62485b6bf16"
                        },
                        new Item()
                        {
                            sha = "a4318a5630a8766f55dc6830527dbaffc7fb917b",
                            live = true,
                            id = "x2313c50d4dfd4a0a"
                        },
                        new Item()
                        {
                            sha = "b350b21cf286a64c0e7869a6429fc6c5fd139c1f",
                            live = true,
                            id = "xcd7ba1c0c381fadb"
                        },
                        new Item()
                        {
                            sha = "e8ba59f1f99433fbd0360332f999cde76ab8976b",
                            live = true,
                            id = "x4cb56360820eece5"
                        },
                        new Item()
                        {
                            sha = "954fcd5885c36b841a22bc5bf89207bced27b8be",
                            live = true,
                            id = "xcc39b61282c884be"
                        },
                        new Item()
                        {
                            sha = "15070fc64826e1cd00665c38e2e42e5834ed359a",
                            live = true,
                            id = "x9c6c9733676e5240"
                        },
                        new Item()
                        {
                            sha = "89d992ba940c4ecaa7687d7a84ce632ead085882",
                            live = true,
                            id = "x8ae458b86dfe440b"
                        },
                        new Item()
                        {
                            sha = "54f92d19cabbd7647cd5d21d4678e8711431e9fb",
                            live = true,
                            id = "x8e7fd4a4b5b002c1"
                        },
                        new Item()
                        {
                            sha = "8d00285eae0fab5210dcfb325be7741e48c75681",
                            live = true,
                            id = "xeee62e178c0cfe6f"
                        },
                        new Item()
                        {
                            sha = "4453b349bad32a1e416e7e74af64e09e2c5810f8",
                            live = true,
                            id = "xdee0840c85c0add5"
                        },
                        new Item()
                        {
                            sha = "bb340ca13b104a9b9d1065b74a2fdfa423f817d1",
                            live = true,
                            id = "xa756d02df7435e1a"
                        },
                        new Item()
                        {
                            sha = "f65a9c4a6a8df260021fe424d562e8ff6d1741bd",
                            live = true,
                            id = "x6b9db70231ff254d"
                        },
                        new Item()
                        {
                            sha = "00808cbc066910be1220235faa7d93a9126f6a57",
                            live = true,
                            id = "x1855395b96b1e34f"
                        },
                        new Item()
                        {
                            sha = "90db973ee0fd319c596410e215a76a651601901d",
                            live = true,
                            id = "x477b6212a24d08da"
                        },
                        new Item()
                        {
                            sha = "f6cf4d0675de30afee8cab929b97000e2c41fbc8",
                            live = true,
                            id = "xfc8946e7c80f2800"
                        },
                        new Item()
                        {
                            sha = "4f522fb965ab3805f56250db187fefadb281edd2",
                            live = true,
                            id = "x14784d8f428fa949"
                        },
                        new Item()
                        {
                            sha = "849c88aa2122ea5a40bb39540acf551d3ac67728",
                            live = true,
                            id = "x3f2d3b6cb53f67a4"
                        },
                        new Item()
                        {
                            sha = "a9197ffb73ad014d477c7eb1eed41f9ea025774b",
                            live = true,
                            id = "xb6e923d2f396f5ab"
                        },
                        new Item()
                        {
                            sha = "446eef76c02fc29049012312c704c12b4b54ba8d",
                            live = true,
                            id = "x9ef4ca7e914c87ec"
                        }
                    },
                    related_videos = new List<object>(),
                    name = "A"
                }
            },
                    progress_key = "ex4debd8a3",
                    suggested_completion_criteria = "num_correct_in_a_row_5",
                    edit_slug = "edit/e/x4debd8a3",
                    summative = false,
                    live = true,
                    translated_description = "Practice counting up to 10 objects.",
                    pretty_display_name = "Count with small numbers",
                    deleted_mod_time = null,
                    thumbnail_data = new ThumbnailData()
                    {
                        url = "",
                        skip_filter = false,
                        title_text = "",
                        gcs_name = "/ka_thumbnails/counting-out-1-20-objects.png"
                    },
                    all_assessment_items = new List<AllAssessmentItem>()
            {
                new AllAssessmentItem()
                {
                    sha = "c2074685910760669c855d628b7a44ef8d828be9",
                    live = true,
                    id = "xde8147b8edb82294"
                },
                new AllAssessmentItem()
                {
                    sha = "76c7fd55c20dfe0f4f938745b73e1e7d0c4757ac",
                    live = true,
                    id = "xa5c8d62485b6bf16"
                },
                new AllAssessmentItem()
                {
                    sha = "a4318a5630a8766f55dc6830527dbaffc7fb917b",
                    live = true,
                    id = "x2313c50d4dfd4a0a"
                },
                new AllAssessmentItem()
                {
                    sha = "b350b21cf286a64c0e7869a6429fc6c5fd139c1f",
                    live = true,
                    id = "xcd7ba1c0c381fadb"
                },
                new AllAssessmentItem()
                {
                    sha = "e8ba59f1f99433fbd0360332f999cde76ab8976b",
                    live = true,
                    id = "x4cb56360820eece5"
                },
                new AllAssessmentItem()
                {
                    sha = "954fcd5885c36b841a22bc5bf89207bced27b8be",
                    live = true,
                    id = "xcc39b61282c884be"
                },
                new AllAssessmentItem()
                {
                    sha = "15070fc64826e1cd00665c38e2e42e5834ed359a",
                    live = true,
                    id = "x9c6c9733676e5240"
                },
                new AllAssessmentItem()
                {
                    sha = "89d992ba940c4ecaa7687d7a84ce632ead085882",
                    live = true,
                    id = "x8ae458b86dfe440b"
                },
                new AllAssessmentItem()
                {
                    sha = "54f92d19cabbd7647cd5d21d4678e8711431e9fb",
                    live = true,
                    id = "x8e7fd4a4b5b002c1"
                },
                new AllAssessmentItem()
                {
                    sha = "8d00285eae0fab5210dcfb325be7741e48c75681",
                    live = true,
                    id = "xeee62e178c0cfe6f"
                },
                new AllAssessmentItem()
                {
                    sha = "4453b349bad32a1e416e7e74af64e09e2c5810f8",
                    live = true,
                    id = "xdee0840c85c0add5"
                },
                new AllAssessmentItem()
                {
                    sha = "bb340ca13b104a9b9d1065b74a2fdfa423f817d1",
                    live = true,
                    id = "xa756d02df7435e1a"
                },
                new AllAssessmentItem()
                {
                    sha = "f65a9c4a6a8df260021fe424d562e8ff6d1741bd",
                    live = true,
                    id = "x6b9db70231ff254d"
                },
                new AllAssessmentItem()
                {
                    sha = "00808cbc066910be1220235faa7d93a9126f6a57",
                    live = true,
                    id = "x1855395b96b1e34f"
                },
                new AllAssessmentItem()
                {
                    sha = "90db973ee0fd319c596410e215a76a651601901d",
                    live = true,
                    id = "x477b6212a24d08da"
                },
                new AllAssessmentItem()
                {
                    sha = "f6cf4d0675de30afee8cab929b97000e2c41fbc8",
                    live = true,
                    id = "xfc8946e7c80f2800"
                },
                new AllAssessmentItem()
                {
                    sha = "4f522fb965ab3805f56250db187fefadb281edd2",
                    live = true,
                    id = "x14784d8f428fa949"
                },
                new AllAssessmentItem()
                {
                    sha = "849c88aa2122ea5a40bb39540acf551d3ac67728",
                    live = true,
                    id = "x3f2d3b6cb53f67a4"
                },
                new AllAssessmentItem()
                {
                    sha = "a9197ffb73ad014d477c7eb1eed41f9ea025774b",
                    live = true,
                    id = "xb6e923d2f396f5ab"
                },
                new AllAssessmentItem()
                {
                    sha = "446eef76c02fc29049012312c704c12b4b54ba8d",
                    live = true,
                    id = "x9ef4ca7e914c87ec"
                }
            },
                    description = "Practice counting up to 10 objects.",
                    translated_pretty_display_name = "Count with small numbers",
                    node_slug = "e/counting-out-1-20-objects",
                    deleted = false,
                    backup_timestamp = null,
                    concept_tags_info = new List<ConceptTagsInfo>()
            {
                new ConceptTagsInfo()
                {
                    display_name = "Counting",
                    id = "Tag:x731f236a6d33f0ff",
                    slug = "counting"
                },
                new ConceptTagsInfo()
                {
                    display_name = "Counting objects",
                    id = "Tag:xf444fba1e72e5158",
                    slug = "counting-objects"
                }
            },
                    problem_types = new List<ProblemType>()
            {
                new ProblemType()
                {
                    items = new List<Item2>()
                    {
                        new Item2()
                        {
                            sha = "c2074685910760669c855d628b7a44ef8d828be9",
                            live = true,
                            id = "xde8147b8edb82294"
                        },
                        new Item2()
                        {
                            sha = "76c7fd55c20dfe0f4f938745b73e1e7d0c4757ac",
                            live = true,
                            id = "xa5c8d62485b6bf16"
                        },
                        new Item2()
                        {
                            sha = "a4318a5630a8766f55dc6830527dbaffc7fb917b",
                            live = true,
                            id = "x2313c50d4dfd4a0a"
                        },
                        new Item2()
                        {
                            sha = "b350b21cf286a64c0e7869a6429fc6c5fd139c1f",
                            live = true,
                            id = "xcd7ba1c0c381fadb"
                        },
                        new Item2()
                        {
                            sha = "e8ba59f1f99433fbd0360332f999cde76ab8976b",
                            live = true,
                            id = "x4cb56360820eece5"
                        },
                        new Item2()
                        {
                            sha = "954fcd5885c36b841a22bc5bf89207bced27b8be",
                            live = true,
                            id = "xcc39b61282c884be"
                        },
                        new Item2()
                        {
                            sha = "15070fc64826e1cd00665c38e2e42e5834ed359a",
                            live = true,
                            id = "x9c6c9733676e5240"
                        },
                        new Item2()
                        {
                            sha = "89d992ba940c4ecaa7687d7a84ce632ead085882",
                            live = true,
                            id = "x8ae458b86dfe440b"
                        },
                        new Item2()
                        {
                            sha = "54f92d19cabbd7647cd5d21d4678e8711431e9fb",
                            live = true,
                            id = "x8e7fd4a4b5b002c1"
                        },
                        new Item2()
                        {
                            sha = "8d00285eae0fab5210dcfb325be7741e48c75681",
                            live = true,
                            id = "xeee62e178c0cfe6f"
                        },
                        new Item2()
                        {
                            sha = "4453b349bad32a1e416e7e74af64e09e2c5810f8",
                            live = true,
                            id = "xdee0840c85c0add5"
                        },
                        new Item2()
                        {
                            sha = "bb340ca13b104a9b9d1065b74a2fdfa423f817d1",
                            live = true,
                            id = "xa756d02df7435e1a"
                        },
                        new Item2()
                        {
                            sha = "f65a9c4a6a8df260021fe424d562e8ff6d1741bd",
                            live = true,
                            id = "x6b9db70231ff254d"
                        },
                        new Item2()
                        {
                            sha = "00808cbc066910be1220235faa7d93a9126f6a57",
                            live = true,
                            id = "x1855395b96b1e34f"
                        },
                        new Item2()
                        {
                            sha = "90db973ee0fd319c596410e215a76a651601901d",
                            live = true,
                            id = "x477b6212a24d08da"
                        },
                        new Item2()
                        {
                            sha = "f6cf4d0675de30afee8cab929b97000e2c41fbc8",
                            live = true,
                            id = "xfc8946e7c80f2800"
                        },
                        new Item2()
                        {
                            sha = "4f522fb965ab3805f56250db187fefadb281edd2",
                            live = true,
                            id = "x14784d8f428fa949"
                        },
                        new Item2()
                        {
                            sha = "849c88aa2122ea5a40bb39540acf551d3ac67728",
                            live = true,
                            id = "x3f2d3b6cb53f67a4"
                        },
                        new Item2()
                        {
                            sha = "a9197ffb73ad014d477c7eb1eed41f9ea025774b",
                            live = true,
                            id = "xb6e923d2f396f5ab"
                        },
                        new Item2()
                        {
                            sha = "446eef76c02fc29049012312c704c12b4b54ba8d",
                            live = true,
                            id = "x9ef4ca7e914c87ec"
                        }
                    },
                    related_videos = new List<object>(),
                    name = "A"
                }
            },
                    curated_related_videos = new List<string>() { "x9b4a5e7a" },
                    covers = new List<object>(),
                    h_position = -40,
                    translated_display_name = "Count with small numbers",
                    kind = "Exercise",
                    sha1 = "c6dfa454b415736e95f50981cb3a17f428424162",
                    name = "counting-out-1-20-objects",
                    date_modified = "2016-05-05T20:05:26Z",
                    prerequisites = new List<object>(),
                    assessment_item_tags = new List<string>()
            {
                "ag5zfmtoYW4tYWNhZGVteXI2CxIRQXNzZXNzbWVudEl0ZW1UYWciATAMCxIRQXNzZXNzbWVudEl0ZW1UYWcYgICAwIKTqAoM",
                "ag5zfmtoYW4tYWNhZGVteXI2CxIRQXNzZXNzbWVudEl0ZW1UYWciATAMCxIRQXNzZXNzbWVudEl0ZW1UYWcYgICAgKqcsgoM"
            },
                    title = "Count with small numbers",
                    global_id = "ex4debd8a3",
                    seconds_per_fast_problem = 4.0,
                    sha = "7bc7ef1a01cb89d73239a4387ed06ecc63ba962f",
                    image_url = "https://fastly.kastatic.org/ka-exercise-screenshots/counting-out-1-20-objects.png",
                    tutorial_only = false,
                    current_revision_key = "7bc7ef1a01cb89d73239a4387ed06ecc63ba962f",
                    image_url_256 = "https://fastly.kastatic.org/ka-exercise-screenshots/counting-out-1-20-objects_256.png",
                    content_id = "x4debd8a3",
                    content_kind = "Exercise"
                };
            }
        }

        public string CountingExerciseJson
        {
            get
            {
                return @"{
	""is_skill_check"": false,
	""uses_worked_examples"": false,
	""v_position"": 3,
	""relative_url"": ""/exercise/counting-out-1-20-objects"",
	""has_custom_thumbnail"": true,
	""file_name"": null,
	""related_video_readable_ids"": [""counting-with-small-numbers""],
	""author_name"": ""Gail Hargrave"",
	""creation_date"": ""2016-03-01T19:29:20Z"",
	""translated_short_display_name"": ""Count with "",
	""uses_assessment_items"": true,
	""ka_url"": ""http://www.khanacademy.org/exercise/counting-out-1-20-objects"",
	""short_display_name"": ""Count with "",
	""translated_title"": ""Count with small numbers"",
	""author_key"": ""ag5zfmtoYW4tYWNhZGVteXJaCxIIVXNlckRhdGEiTHVzZXJfaWRfa2V5X2h0dHA6Ly9ub3VzZXJpZC5raGFuYWNhZGVteS5vcmcvNjZmOTNhODE4YjU2ZWUxZTliOTM1MGI2OTc2OGQ4ZTMM"",
	""translated_description_html"": ""Practice counting up to 10 objects."",
	""id"": ""x4debd8a3"",
	""concept_tags"": [""Tag:x731f236a6d33f0ff"", ""Tag:xf444fba1e72e5158""],
	""is_quiz"": false,
	""display_name"": ""Count with small numbers"",
	""tracking_document_url"": null,
	""description_html"": ""Practice counting up to 10 objects."",
	""do_not_publish"": false,
	""tags"": [],
	""translated_problem_types"": [{
		""items"": [{
			""sha"": ""c2074685910760669c855d628b7a44ef8d828be9"",
			""live"": true,
			""id"": ""xde8147b8edb82294""
		},
		{
			""sha"": ""76c7fd55c20dfe0f4f938745b73e1e7d0c4757ac"",
			""live"": true,
			""id"": ""xa5c8d62485b6bf16""
		},
		{
			""sha"": ""a4318a5630a8766f55dc6830527dbaffc7fb917b"",
			""live"": true,
			""id"": ""x2313c50d4dfd4a0a""
		},
		{
			""sha"": ""b350b21cf286a64c0e7869a6429fc6c5fd139c1f"",
			""live"": true,
			""id"": ""xcd7ba1c0c381fadb""
		},
		{
			""sha"": ""e8ba59f1f99433fbd0360332f999cde76ab8976b"",
			""live"": true,
			""id"": ""x4cb56360820eece5""
		},
		{
			""sha"": ""954fcd5885c36b841a22bc5bf89207bced27b8be"",
			""live"": true,
			""id"": ""xcc39b61282c884be""
		},
		{
			""sha"": ""15070fc64826e1cd00665c38e2e42e5834ed359a"",
			""live"": true,
			""id"": ""x9c6c9733676e5240""
		},
		{
			""sha"": ""89d992ba940c4ecaa7687d7a84ce632ead085882"",
			""live"": true,
			""id"": ""x8ae458b86dfe440b""
		},
		{
			""sha"": ""54f92d19cabbd7647cd5d21d4678e8711431e9fb"",
			""live"": true,
			""id"": ""x8e7fd4a4b5b002c1""
		},
		{
			""sha"": ""8d00285eae0fab5210dcfb325be7741e48c75681"",
			""live"": true,
			""id"": ""xeee62e178c0cfe6f""
		},
		{
			""sha"": ""4453b349bad32a1e416e7e74af64e09e2c5810f8"",
			""live"": true,
			""id"": ""xdee0840c85c0add5""
		},
		{
			""sha"": ""bb340ca13b104a9b9d1065b74a2fdfa423f817d1"",
			""live"": true,
			""id"": ""xa756d02df7435e1a""
		},
		{
			""sha"": ""f65a9c4a6a8df260021fe424d562e8ff6d1741bd"",
			""live"": true,
			""id"": ""x6b9db70231ff254d""
		},
		{
			""sha"": ""00808cbc066910be1220235faa7d93a9126f6a57"",
			""live"": true,
			""id"": ""x1855395b96b1e34f""
		},
		{
			""sha"": ""90db973ee0fd319c596410e215a76a651601901d"",
			""live"": true,
			""id"": ""x477b6212a24d08da""
		},
		{
			""sha"": ""f6cf4d0675de30afee8cab929b97000e2c41fbc8"",
			""live"": true,
			""id"": ""xfc8946e7c80f2800""
		},
		{
			""sha"": ""4f522fb965ab3805f56250db187fefadb281edd2"",
			""live"": true,
			""id"": ""x14784d8f428fa949""
		},
		{
			""sha"": ""849c88aa2122ea5a40bb39540acf551d3ac67728"",
			""live"": true,
			""id"": ""x3f2d3b6cb53f67a4""
		},
		{
			""sha"": ""a9197ffb73ad014d477c7eb1eed41f9ea025774b"",
			""live"": true,
			""id"": ""xb6e923d2f396f5ab""
		},
		{
			""sha"": ""446eef76c02fc29049012312c704c12b4b54ba8d"",
			""live"": true,
			""id"": ""x9ef4ca7e914c87ec""
		}],
		""related_videos"": [],
		""name"": ""A""
	}],
	""progress_key"": ""ex4debd8a3"",
	""suggested_completion_criteria"": ""num_correct_in_a_row_5"",
	""edit_slug"": ""edit/e/x4debd8a3"",
	""summative"": false,
	""live"": true,
	""translated_description"": ""Practice counting up to 10 objects."",
	""pretty_display_name"": ""Count with small numbers"",
	""deleted_mod_time"": null,
	""thumbnail_data"": {
		""url"": """",
		""skip_filter"": false,
		""title_text"": """",
		""gcs_name"": ""/ka_thumbnails/counting-out-1-20-objects.png""
	},
	""all_assessment_items"": [{
		""sha"": ""c2074685910760669c855d628b7a44ef8d828be9"",
		""live"": true,
		""id"": ""xde8147b8edb82294""
	},
	{
		""sha"": ""76c7fd55c20dfe0f4f938745b73e1e7d0c4757ac"",
		""live"": true,
		""id"": ""xa5c8d62485b6bf16""
	},
	{
		""sha"": ""a4318a5630a8766f55dc6830527dbaffc7fb917b"",
		""live"": true,
		""id"": ""x2313c50d4dfd4a0a""
	},
	{
		""sha"": ""b350b21cf286a64c0e7869a6429fc6c5fd139c1f"",
		""live"": true,
		""id"": ""xcd7ba1c0c381fadb""
	},
	{
		""sha"": ""e8ba59f1f99433fbd0360332f999cde76ab8976b"",
		""live"": true,
		""id"": ""x4cb56360820eece5""
	},
	{
		""sha"": ""954fcd5885c36b841a22bc5bf89207bced27b8be"",
		""live"": true,
		""id"": ""xcc39b61282c884be""
	},
	{
		""sha"": ""15070fc64826e1cd00665c38e2e42e5834ed359a"",
		""live"": true,
		""id"": ""x9c6c9733676e5240""
	},
	{
		""sha"": ""89d992ba940c4ecaa7687d7a84ce632ead085882"",
		""live"": true,
		""id"": ""x8ae458b86dfe440b""
	},
	{
		""sha"": ""54f92d19cabbd7647cd5d21d4678e8711431e9fb"",
		""live"": true,
		""id"": ""x8e7fd4a4b5b002c1""
	},
	{
		""sha"": ""8d00285eae0fab5210dcfb325be7741e48c75681"",
		""live"": true,
		""id"": ""xeee62e178c0cfe6f""
	},
	{
		""sha"": ""4453b349bad32a1e416e7e74af64e09e2c5810f8"",
		""live"": true,
		""id"": ""xdee0840c85c0add5""
	},
	{
		""sha"": ""bb340ca13b104a9b9d1065b74a2fdfa423f817d1"",
		""live"": true,
		""id"": ""xa756d02df7435e1a""
	},
	{
		""sha"": ""f65a9c4a6a8df260021fe424d562e8ff6d1741bd"",
		""live"": true,
		""id"": ""x6b9db70231ff254d""
	},
	{
		""sha"": ""00808cbc066910be1220235faa7d93a9126f6a57"",
		""live"": true,
		""id"": ""x1855395b96b1e34f""
	},
	{
		""sha"": ""90db973ee0fd319c596410e215a76a651601901d"",
		""live"": true,
		""id"": ""x477b6212a24d08da""
	},
	{
		""sha"": ""f6cf4d0675de30afee8cab929b97000e2c41fbc8"",
		""live"": true,
		""id"": ""xfc8946e7c80f2800""
	},
	{
		""sha"": ""4f522fb965ab3805f56250db187fefadb281edd2"",
		""live"": true,
		""id"": ""x14784d8f428fa949""
	},
	{
		""sha"": ""849c88aa2122ea5a40bb39540acf551d3ac67728"",
		""live"": true,
		""id"": ""x3f2d3b6cb53f67a4""
	},
	{
		""sha"": ""a9197ffb73ad014d477c7eb1eed41f9ea025774b"",
		""live"": true,
		""id"": ""xb6e923d2f396f5ab""
	},
	{
		""sha"": ""446eef76c02fc29049012312c704c12b4b54ba8d"",
		""live"": true,
		""id"": ""x9ef4ca7e914c87ec""
	}],
	""description"": ""Practice counting up to 10 objects."",
	""translated_pretty_display_name"": ""Count with small numbers"",
	""node_slug"": ""e/counting-out-1-20-objects"",
	""deleted"": false,
	""backup_timestamp"": null,
	""concept_tags_info"": [{
		""display_name"": ""Counting"",
		""id"": ""Tag:x731f236a6d33f0ff"",
		""slug"": ""counting""
	},
	{
		""display_name"": ""Counting objects"",
		""id"": ""Tag:xf444fba1e72e5158"",
		""slug"": ""counting-objects""
	}],
	""problem_types"": [{
		""items"": [{
			""sha"": ""c2074685910760669c855d628b7a44ef8d828be9"",
			""live"": true,
			""id"": ""xde8147b8edb82294""
		},
		{
			""sha"": ""76c7fd55c20dfe0f4f938745b73e1e7d0c4757ac"",
			""live"": true,
			""id"": ""xa5c8d62485b6bf16""
		},
		{
			""sha"": ""a4318a5630a8766f55dc6830527dbaffc7fb917b"",
			""live"": true,
			""id"": ""x2313c50d4dfd4a0a""
		},
		{
			""sha"": ""b350b21cf286a64c0e7869a6429fc6c5fd139c1f"",
			""live"": true,
			""id"": ""xcd7ba1c0c381fadb""
		},
		{
			""sha"": ""e8ba59f1f99433fbd0360332f999cde76ab8976b"",
			""live"": true,
			""id"": ""x4cb56360820eece5""
		},
		{
			""sha"": ""954fcd5885c36b841a22bc5bf89207bced27b8be"",
			""live"": true,
			""id"": ""xcc39b61282c884be""
		},
		{
			""sha"": ""15070fc64826e1cd00665c38e2e42e5834ed359a"",
			""live"": true,
			""id"": ""x9c6c9733676e5240""
		},
		{
			""sha"": ""89d992ba940c4ecaa7687d7a84ce632ead085882"",
			""live"": true,
			""id"": ""x8ae458b86dfe440b""
		},
		{
			""sha"": ""54f92d19cabbd7647cd5d21d4678e8711431e9fb"",
			""live"": true,
			""id"": ""x8e7fd4a4b5b002c1""
		},
		{
			""sha"": ""8d00285eae0fab5210dcfb325be7741e48c75681"",
			""live"": true,
			""id"": ""xeee62e178c0cfe6f""
		},
		{
			""sha"": ""4453b349bad32a1e416e7e74af64e09e2c5810f8"",
			""live"": true,
			""id"": ""xdee0840c85c0add5""
		},
		{
			""sha"": ""bb340ca13b104a9b9d1065b74a2fdfa423f817d1"",
			""live"": true,
			""id"": ""xa756d02df7435e1a""
		},
		{
			""sha"": ""f65a9c4a6a8df260021fe424d562e8ff6d1741bd"",
			""live"": true,
			""id"": ""x6b9db70231ff254d""
		},
		{
			""sha"": ""00808cbc066910be1220235faa7d93a9126f6a57"",
			""live"": true,
			""id"": ""x1855395b96b1e34f""
		},
		{
			""sha"": ""90db973ee0fd319c596410e215a76a651601901d"",
			""live"": true,
			""id"": ""x477b6212a24d08da""
		},
		{
			""sha"": ""f6cf4d0675de30afee8cab929b97000e2c41fbc8"",
			""live"": true,
			""id"": ""xfc8946e7c80f2800""
		},
		{
			""sha"": ""4f522fb965ab3805f56250db187fefadb281edd2"",
			""live"": true,
			""id"": ""x14784d8f428fa949""
		},
		{
			""sha"": ""849c88aa2122ea5a40bb39540acf551d3ac67728"",
			""live"": true,
			""id"": ""x3f2d3b6cb53f67a4""
		},
		{
			""sha"": ""a9197ffb73ad014d477c7eb1eed41f9ea025774b"",
			""live"": true,
			""id"": ""xb6e923d2f396f5ab""
		},
		{
			""sha"": ""446eef76c02fc29049012312c704c12b4b54ba8d"",
			""live"": true,
			""id"": ""x9ef4ca7e914c87ec""
		}],
		""related_videos"": [],
		""name"": ""A""
	}],
	""curated_related_videos"": [""x9b4a5e7a""],
	""covers"": [],
	""h_position"": -40,
	""translated_display_name"": ""Count with small numbers"",
	""kind"": ""Exercise"",
	""sha1"": ""c6dfa454b415736e95f50981cb3a17f428424162"",
	""name"": ""counting-out-1-20-objects"",
	""date_modified"": ""2016-05-05T20:05:26Z"",
	""prerequisites"": [],
	""assessment_item_tags"": [""ag5zfmtoYW4tYWNhZGVteXI2CxIRQXNzZXNzbWVudEl0ZW1UYWciATAMCxIRQXNzZXNzbWVudEl0ZW1UYWcYgICAwIKTqAoM"",
	""ag5zfmtoYW4tYWNhZGVteXI2CxIRQXNzZXNzbWVudEl0ZW1UYWciATAMCxIRQXNzZXNzbWVudEl0ZW1UYWcYgICAgKqcsgoM""],
	""title"": ""Count with small numbers"",
	""global_id"": ""ex4debd8a3"",
	""seconds_per_fast_problem"": 4.0,
	""sha"": ""7bc7ef1a01cb89d73239a4387ed06ecc63ba962f"",
	""image_url"": ""https://fastly.kastatic.org/ka-exercise-screenshots/counting-out-1-20-objects.png"",
	""tutorial_only"": false,
	""current_revision_key"": ""7bc7ef1a01cb89d73239a4387ed06ecc63ba962f"",
	""image_url_256"": ""https://fastly.kastatic.org/ka-exercise-screenshots/counting-out-1-20-objects_256.png"",
	""content_id"": ""x4debd8a3"",
	""content_kind"": ""Exercise""
}";
            }
        }
    }

    public class Badges
    {
        public Badge FactChecker
        {
            get
            {
                return new Badge()
                {
                    IconSource = new Uri("https://fastly.kastatic.org/images/badges/moon/fact-checker-40x40.png"),
                    HideContext = false,
                    Description = "Fact Checker",
                    RelativeUrl = new Uri("/badges/fact-checker", UriKind.Relative),
                    Icons = new Icons()
                    {
                        Small = new Uri("https://fastly.kastatic.org/images/badges/moon/fact-checker-40x40.png"),
                        Compact = new Uri("https://fastly.kastatic.org/images/badges/moon/fact-checker-60x60.png"),
                        Large = new Uri("https://fastly.kastatic.org/images/badges/moon/fact-checker-512x512.png"),
                        Email = new Uri("https://fastly.kastatic.org/images/badges/moon/fact-checker-70x70.png")
                    },
                    AbsoluteUrl = new Uri("http://www.khanacademy.org/badges/fact-checker"),
                    UserBadges = null,
                    DescriptionExtendedTranslatedSafe = "Have a clarification officially accepted",
                    DescriptionTranslated = "Fact Checker",
                    IsOwned = false,
                    Category = 1,
                    Points = 0,
                    IsRetired = false,
                    DescriptionExtendedSafe = "Have a clarification officially accepted",
                    Slug = "fact-checker",
                    Name = "acceptclarificationbadge"
                };
            }
        }

        public Badge ActOneSceneOne
        {
            get
            {
                return new Badge()
                {
                    IconSource = new Uri("https://fastly.kastatic.org/images/badges/meteorite/act-1-scene-1-40x40.png"),
                    HideContext = false,
                    Description = "Act I Scene I",
                    RelativeUrl = new Uri("/badges/act-i-scene-i", UriKind.Relative),
                    Icons = new Icons()
                    {
                        Small = new Uri("https://fastly.kastatic.org/images/badges/meteorite/act-1-scene-1-40x40.png"),
                        Compact = new Uri("https://fastly.kastatic.org/images/badges/meteorite/act-1-scene-1-60x60.png"),
                        Large = new Uri("https://fastly.kastatic.org/images/badges/meteorite/act-1-scene-1-512x512.png"),
                        Email = new Uri("https://fastly.kastatic.org/images/badges/meteorite/act-1-scene-1-70x70.png")
                    },
                    AbsoluteUrl = new Uri("http://www.khanacademy.org/badges/act-i-scene-i"),
                    UserBadges = null,
                    DescriptionExtendedTranslatedSafe = "Watch 20 minutes of video",
                    DescriptionTranslated = "Act I Scene I",
                    IsOwned = false,
                    Category = 0,
                    Points = 0,
                    IsRetired = false,
                    DescriptionExtendedSafe = "Watch 20 minutes of video",
                    Slug = "act-i-scene-i",
                    Name = "actonesceneonebadge"
                };
            }
        }

        public List<Badge> SampleBadges
        {
            get
            {
                return new List<Badge>()
                {
                    KhanTestData.Badges.FactChecker,
                    KhanTestData.Badges.ActOneSceneOne
                };
            }
        }

        public string SampleJson
        {
            get
            {
                return @"[{
	                ""icon_src"": ""https://fastly.kastatic.org/images/badges/moon/fact-checker-40x40.png"",
	                ""hide_context"": false,
	                ""description"": ""Fact Checker"",
	                ""relative_url"": ""/badges/fact-checker"",
	                ""icons"": {
		                ""small"": ""https://fastly.kastatic.org/images/badges/moon/fact-checker-40x40.png"",
		                ""compact"": ""https://fastly.kastatic.org/images/badges/moon/fact-checker-60x60.png"",
		                ""large"": ""https://fastly.kastatic.org/images/badges/moon/fact-checker-512x512.png"",
		                ""email"": ""https://fastly.kastatic.org/images/badges/moon/fact-checker-70x70.png""
	                },
	                ""absolute_url"": ""http://www.khanacademy.org/badges/fact-checker"",
	                ""user_badges"": null,
	                ""translated_safe_extended_description"": ""Have a clarification officially accepted"",
	                ""translated_description"": ""Fact Checker"",
	                ""is_owned"": false,
	                ""badge_category"": 1,
	                ""points"": 0,
	                ""is_retired"": false,
	                ""safe_extended_description"": ""Have a clarification officially accepted"",
	                ""slug"": ""fact-checker"",
	                ""name"": ""acceptclarificationbadge""
                },
                {
	                ""icon_src"": ""https://fastly.kastatic.org/images/badges/meteorite/act-1-scene-1-40x40.png"",
	                ""hide_context"": false,
	                ""description"": ""Act I Scene I"",
	                ""relative_url"": ""/badges/act-i-scene-i"",
	                ""icons"": {
		                ""small"": ""https://fastly.kastatic.org/images/badges/meteorite/act-1-scene-1-40x40.png"",
		                ""compact"": ""https://fastly.kastatic.org/images/badges/meteorite/act-1-scene-1-60x60.png"",
		                ""large"": ""https://fastly.kastatic.org/images/badges/meteorite/act-1-scene-1-512x512.png"",
		                ""email"": ""https://fastly.kastatic.org/images/badges/meteorite/act-1-scene-1-70x70.png""
	                },
	                ""absolute_url"": ""http://www.khanacademy.org/badges/act-i-scene-i"",
	                ""user_badges"": null,
	                ""translated_safe_extended_description"": ""Watch 20 minutes of video"",
	                ""translated_description"": ""Act I Scene I"",
	                ""is_owned"": false,
	                ""badge_category"": 0,
	                ""points"": 0,
	                ""is_retired"": false,
	                ""safe_extended_description"": ""Watch 20 minutes of video"",
	                ""slug"": ""act-i-scene-i"",
	                ""name"": ""actonesceneonebadge""
                }]";
            }
        }
    }
}
