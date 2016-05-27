using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace KhanDotNet.Library.Contracts
{
    public class Topic
    {
        [JsonProperty("icon_src")]
        public Uri IconSrc { get; set; }

        [JsonProperty("domain_slug")]
        public string DomainSlug { get; set; }

        [JsonProperty("relative_url")]
        public Uri RelativeUrl { get; set; }

        [JsonProperty("creation_date")]
        public DateTime CreationDate { get; set; }

        [JsonProperty("web_url")]
        public Uri web_url { get; set; }

        [JsonProperty("ka_url")]
        public Uri KaUrl { get; set; }

        [JsonProperty("translated_standalone_title")]
        public string TranslatedStandaloneTitle { get; set; }

        [JsonProperty("translated_title")]
        public string TranslatedTitle { get; set; }

        [JsonProperty("has_user_authored_content_types")]
        public bool HasUserAuthoredContentTypes { get; set; }

        [JsonProperty("standalone_title")]
        public string StandaloneTitle { get; set; }

        [JsonProperty("author_key")]
        public string AuthorKey { get; set; }

        [JsonProperty("gplus_url")]
        public Uri GPlusUrl { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("old_key_name")]
        public string OldKeyName { get; set; }

        [JsonProperty("hide")]
        public bool Hide { get; set; }

        [JsonProperty("do_not_publish")]
        public bool DoNotPublish { get; set; }

        [JsonProperty("child_data")]
        public List<ChildData> ChildData { get; set; }

        // TODO 3: verify contract
        [JsonProperty("user_authored_content_types_info")]
        public List<object> UserAuthoredContentTypesInfo { get; set; }

        [JsonProperty("children")]
        public List<Child> Children { get; set; }

        [JsonProperty("twitter_url")]
        public Uri TwitterUrl { get; set; }

        [JsonProperty("translated_description")]
        public string TranslatedDescription { get; set; }

        [JsonProperty("version")]
        public object Version { get; set; }

        [JsonProperty("alternate_slugs")]
        public List<object> AlternateSlugs { get; set; }

        [JsonProperty("user_authored_content_types")]
        public List<object> UserAuthoredContentTypes { get; set; }

        [JsonProperty("deleted_mod_time")]
        public DateTime DeletedModTime { get; set; }

        [JsonProperty("logo_image_url")]
        public Uri LogoImageUrl { get; set; }

        [JsonProperty("in_knowledge_map")]
        public bool InKnowledgeMap { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("x_pos ")]
        public double XPos { get; set; }

        [JsonProperty("node_slug")]
        public string NodeSlug { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("listed_locales")]
        public List<string> ListedLocales { get; set; }

        [JsonProperty("facebook_url")]
        public Uri FacebookUrl { get; set; }

        [JsonProperty("backup_timestamp")]
        public DateTime BackupTimestamp { get; set; }

        [JsonProperty("render_type")]
        public string RenderType { get; set; }

        [JsonProperty("background_image_url")]
        public Uri BackgroundImageUrl { get; set; }

        [JsonProperty("background_image_caption")]
        public string BackgroundImageCaption { get; set; }

        [JsonProperty("has_peer_reviewed_projects")]
        public bool HasPeerReviewedProjects { get; set; }

        [JsonProperty("topic_page_url")]
        public Uri TopicPageUrl { get; set; }

        [JsonProperty("extended_slug")]
        public string ExtendedSlug { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("tags")]
        public List<object> Tags { get; set; }

        [JsonProperty("translated_curation")]
        public object TranslatedCuration { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }

        [JsonProperty("in_topic_browser")]
        public bool InTopicBrowser { get; set; }

        [JsonProperty("curation")]
        public Curation Curation { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("sha")]
        public string Sha { get; set; }

        [JsonProperty("branding_image_url")]
        public Uri BrandingImageUrl { get; set; }

        [JsonProperty("y_pos")]
        public double YPos { get; set; }

        [JsonProperty("current_revision_key")]
        public string CurrentRevisionKey { get; set; }

        [JsonProperty("content_id")]
        public string ContentId { get; set; }

        [JsonProperty("content_kind")]
        public string ContentKind { get; set; }

        [JsonProperty("curriculum_key")]
        public string CurriculumKey { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }

}
