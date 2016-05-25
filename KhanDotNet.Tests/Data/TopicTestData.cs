using KhanDotNet.Library.Contract;
using System;
using System.Collections.Generic;

namespace KhanDotNet.Tests.Data
{
    public static class TopicTestData
    {
        public const string SampleTopicJson = "{\"icon_src\": \"\",\"domain_slug\": \"talks-and-interviews\",\"relative_url\": \"/talks-and-interviews\",\"creation_date\": \"2015-02-25T17:37:36Z\",\"web_url\": \"\",\"ka_url\": \"http://www.khanacademy.org/talks-and-interviews\",\"translated_standalone_title\": \"Khan Academy-related talks and interviews\",\"translated_title\": \"Talks and interviews\",\"has_user_authored_content_types\": false,\"standalone_title\": \"Khan Academy-related talks and interviews\",\"author_key\": \"ag5zfmtoYW4tYWNhZGVteXJPCxIIVXNlckRhdGEiQXVzZXJfaWRfa2V5X2h0dHA6Ly9nb29nbGVpZC5raGFuYWNhZGVteS5vcmcvMTAxMzE1ODk3OTgxODAxMTQwMzY5DA\",\"gplus_url\": \"\",\"id\": \"xd1039e22\",\"old_key_name\": \"0d3veoeP3Nho6OWSepxBQ0Z79-tSyjMS-Ck2em7N\",\"hide\": false,\"do_not_publish\": false,\"child_data\": [{\"kind\": \"Topic\",\"id\": \"xb90c573f\"},{\"kind\": \"Topic\",\"id\": \"x293eb078\"}],\"user_authored_content_types_info\": [],\"children\": [{\"description\": \"\",\"internal_id\": \"x71564d11\",\"node_slug\": \"conversations-with-sal\",\"translated_standalone_title\": \"Conversations with Sal: Talks and presentations\",\"key\": \"ag5zfmtoYW4tYWNhZGVteXIUCxIFVG9waWMiCXg3MTU2NGQxMQw\",\"translated_title\": \"Conversations with Sal: Talks and presentations\",\"id\": \"conversations-with-sal\",\"kind\": \"Topic\",\"hide\": false,\"title\": \"Conversations with Sal: Talks and presentations\",\"url\": \"http://www.khanacademy.org/talks-and-interviews/conversations-with-sal\",\"edit_slug\": \"\",\"translated_description\": \"\",\"standalone_title\": \"Conversations with Sal: Talks and presentations\"}],\"twitter_url\": \"\",\"translated_description\": \"Collection of interviews with and presentations by Salman Khan.  Also a few other mentions of Khan Academy at other talks.\n\",\"version\": null,\"alternate_slugs\": [],\"user_authored_content_types\": [],\"deleted_mod_time\": \"2013-07-13T00:03:08Z\",\"logo_image_url\": \"\",\"in_knowledge_map\": false,\"description\": \"Collection of interviews with and presentations by Salman Khan.  Also a few other mentions of Khan Academy at other talks.\n\",\"x_pos\": 0.0,\"node_slug\": \"talks-and-interviews\",\"deleted\": false,\"listed_locales\": [\"en\", \"bg\", \"es-ES\", \"pl\", \"tr\"],\"facebook_url\": \"\",\"backup_timestamp\": \"2013-08-30T17:52:23Z\",\"render_type\": \"Subject\",\"background_image_url\": \"\",\"background_image_caption\": \"\",\"has_peer_reviewed_projects\": false,\"topic_page_url\": \"/talks-and-interviews\",\"extended_slug\": \"talks-and-interviews\",\"slug\": \"talks-and-interviews\",\"tags\": [],\"translated_curation\": null,\"kind\": \"Topic\",\"date_modified\": \"2016-03-26T04:46:10Z\",\"in_topic_browser\": true,\"curation\": {},\"title\": \"Talks and interviews\",\"sha\": \"a8844b9092c16ef39ab640958a7b8aa2100b1416\",\"branding_image_url\": \"\",\"y_pos\": 0.0,\"current_revision_key\": \"a8844b9092c16ef39ab640958a7b8aa2100b1416\",\"content_id\": \"xd1039e22\",\"content_kind\": \"Topic\",\"curriculum_key\": \"\"}";

        // TODO: verify contract - Khan API returns empty list for all topics
        public const string SampleTopicExercisesJson = "[]";

        public static readonly Topic SampleTopic = new Topic()
        {
            IconSrc = null,
            DomainSlug = "talks-and-interviews",
            RelativeUrl = new Uri("/talks-and-interviews", UriKind.Relative),
            CreationDate = new DateTime(2015, 02, 25, 17, 37, 36),
            web_url = null,
            KaUrl = new Uri("http://www.khanacademy.org/talks-and-interviews"),
            TranslatedStandaloneTitle = "Khan Academy-related talks and interviews",
            TranslatedTitle = "Talks and interviews",
            HasUserAuthoredContentTypes = false,
            StandaloneTitle = "Khan Academy-related talks and interviews",
            AuthorKey = "ag5zfmtoYW4tYWNhZGVteXJPCxIIVXNlckRhdGEiQXVzZXJfaWRfa2V5X2h0dHA6Ly9nb29nbGVpZC5raGFuYWNhZGVteS5vcmcvMTAxMzE1ODk3OTgxODAxMTQwMzY5DA",
            GPlusUrl = null,
            Id = "xd1039e22",
            OldKeyName = "0d3veoeP3Nho6OWSepxBQ0Z79-tSyjMS-Ck2em7N",
            Hide = false,
            DoNotPublish = false,
            ChildData = new List<ChildData>()
            {
                new ChildData()
                {
                    Kind = "Topic",
                    Id = "xb90c573f"
                },
                new ChildData()
                {
                    Kind = "Topic",
                    Id = "x293eb078"
                }
            },
            UserAuthoredContentTypes = new List<object>(),
            Children = new List<Child>()
            {
                new Child()
                {
                    Description = "",
                    InternalId = "x71564d11",
                    NodeSlug = "conversations-with-sal",
                    TranslatedStandaloneTitle = "Conversations with Sal: Talks and presentations",
                    Key = "ag5zfmtoYW4tYWNhZGVteXIUCxIFVG9waWMiCXg3MTU2NGQxMQw",
                    TranslatedTitle = "Conversations with Sal: Talks and presentations",
                    Id = "conversations-with-sal",
                    Kind = "Topic",
                    Hide = false,
                    Title = "Conversations with Sal: Talks and presentations",
                    Url = new Uri("http://www.khanacademy.org/talks-and-interviews/conversations-with-sal"),
                    EditSlug = "",
                    TranslatedDescription = "",
                    StandaloneTitle = "Conversations with Sal: Talks and presentations"
                }
            },
            TwitterUrl = null,
            TranslatedDescription = "Collection of interviews with and presentations by Salman Khan.  Also a few other mentions of Khan Academy at other talks.\n",
            Version = null,
            AlternateSlugs = new List<object>(),
            UserAuthoredContentTypesInfo = new List<object>(),
            DeletedModTime = new DateTime(2013, 07, 13, 00, 03, 08),
            LogoImageUrl = null,
            InKnowledgeMap = false,
            Description = "Collection of interviews with and presentations by Salman Khan.  Also a few other mentions of Khan Academy at other talks.\n",
            XPos = 0.0,
            NodeSlug = "talks-and-interviews",
            Deleted = false,
            ListedLocales = new List<string>() { "en", "bg", "es-ES", "pl", "tr" },
            FacebookUrl = null,
            BackupTimestamp = new DateTime(2013, 08, 30, 17, 52, 23),
            RenderType = "Subject",
            BackgroundImageUrl = null,
            BackgroundImageCaption = "",
            HasPeerReviewedProjects = false,
            TopicPageUrl = new Uri("/talks-and-interviews", UriKind.Relative),
            ExtendedSlug = "talks-and-interviews",
            Slug = "talks-and-interviews",
            Tags = new List<object>(),
            TranslatedCuration = null,
            Kind = "Topic",
            DateModified = "2016-03-26T04:46:10Z",
            InTopicBrowser = true,
            Curation = new Curation(),
            Title = "Talks and interviews",
            Sha = "a8844b9092c16ef39ab640958a7b8aa2100b1416",
            BrandingImageUrl = null,
            YPos = 0.0,
            CurrentRevisionKey = "a8844b9092c16ef39ab640958a7b8aa2100b1416",
            ContentId = "xd1039e22",
            ContentKind = "Topic",
            CurriculumKey = ""
        };

        public static readonly List<Exercise> SampleTopicExercises = new List<Exercise>();
    }
}
