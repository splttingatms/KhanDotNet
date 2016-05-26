using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace KhanDotNet.Library.Contract
{
    public class Video
    {
        [JsonProperty("translated_youtube_id")]
        public string TranslatedYouTubeId { get; set; }

        [JsonProperty("relative_url")]
        public Uri RelativeUrl { get; set; }

        [JsonProperty("has_custom_thumbnail")]
        public bool HasCustomThumbnail { get; set; }

        [JsonProperty("has_questions")]
        public bool HasQuestions { get; set; }

        [JsonProperty("creation_date")]
        public DateTime CreationDate { get; set; }

        [JsonProperty("download_urls")]
        public DownloadUrls DownloadUrls { get; set; }

        [JsonProperty("ka_url")]
        public Uri KaUrl { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("translated_title")]
        public string TranslatedTitle { get; set; }

        [JsonProperty("author_key")]
        public string AuthorKey { get; set; }

        [JsonProperty("translated_description_html")]
        public string TranslatedDescriptionHtml { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("concept_tags")]
        public List<string> ConceptTags { get; set; }

        [JsonProperty("download_size")]
        public double DownloadSize { get; set; }

        [JsonProperty("description_html")]
        public string DescriptionHtml { get; set; }

        [JsonProperty("do_not_publish")]
        public bool DoNotPublish { get; set; }

        [JsonProperty("license_logo_url")]
        public Uri LicenseLogoUrl { get; set; }

        [JsonProperty("progress_key")]
        public string ProgressKey { get; set; }

        [JsonProperty("edit_slug")]
        public string EditSlug { get; set; }

        [JsonProperty("author_names")]
        public List<string> AuthorNames { get; set; }

        [JsonProperty("license_full_name")]
        public string LicenseFullName { get; set; }

        [JsonProperty("license_url")]
        public Uri LicenseUrl { get; set; }

        [JsonProperty("deleted_mod_time")]
        public DateTime DeletedModTime { get; set; }

        [JsonProperty("thumbnail_data")]
        public ThumbnailData ThumbnailData { get; set; }

        [JsonProperty("related_exercise_url")]
        public Uri RelatedExerciseUrl { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        // TODO 3: find what contract this follows
        [JsonProperty("extra_properties")]
        public object ExtraProperties { get; set; }

        [JsonProperty("node_slug")]
        public string NodeSlug { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("license_name")]
        public string LicenseName { get; set; }

        [JsonProperty("backup_timestamp")]
        public DateTime BackupTimestamp { get; set; }

        [JsonProperty("concept_tags_info")]
        public List<ConceptTag> ConceptTagsInfo { get; set; }

        [JsonProperty("date_added")]
        public DateTime DateAdded { get; set; }

        [JsonProperty("translated_youtube_lang")]
        public string TranslatedYouTubeLang { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("date_modified")]
        public DateTime DateModified { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("clarifications_enabled")]
        public bool ClarificationsEnabled { get; set; }

        [JsonProperty("ka_user_license")]
        public string KaUserLicense { get; set; }

        [JsonProperty("global_id")]
        public string GlobalId { get; set; }

        [JsonProperty("sha")]
        public string Sha { get; set; }

        [JsonProperty("translated_description")]
        public string TranslatedDescription { get; set; }

        [JsonProperty("image_url")]
        public Uri ImageUrl { get; set; }

        // TODO 3: verify this is not an array
        [JsonProperty("keywords")]
        public string keywords { get; set; }

        [JsonProperty("youtube_id")]
        public string YouTubeId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("content_id")]
        public string ContentId { get; set; }

        [JsonProperty("content_kind")]
        public string ContentKind { get; set; }

        [JsonProperty("readable_id")]
        public string ReadableId { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}

