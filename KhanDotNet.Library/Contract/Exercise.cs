using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace KhanDotNet.Library.Contract
{
    public class Exercise
    {
        [JsonProperty("is_skill_check")]
        public bool IsSkillCheck { get; set; }

        [JsonProperty("uses_worked_examples")]
        public bool UsesWorkedExamples { get; set; }

        [JsonProperty("v_position")]
        public int VPosition { get; set; }

        [JsonProperty("relative_url")]
        public Uri RelativeUrl { get; set; }

        [JsonProperty("has_custom_thumbnail")]
        public bool HasCustomThumbnail { get; set; }

        [JsonProperty("file_name")]
        public string FileName { get; set; }

        [JsonProperty("related_video_readable_ids")]
        public List<string> RelatedVideoReadableIds { get; set; }

        [JsonProperty("author_name")]
        public string AuthorName { get; set; }

        [JsonProperty("creation_date")]
        public DateTime CreationDate { get; set; }

        [JsonProperty("translated_short_display_name")]
        public string TranslatedShortDisplayName { get; set; }

        [JsonProperty("uses_assessment_items")]
        public bool UsesAssessmentItems { get; set; }

        [JsonProperty("ka_url")]
        public Uri KaUrl { get; set; }

        [JsonProperty("short_display_name")]
        public string ShortDisplayName { get; set; }

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

        [JsonProperty("is_quiz")]
        public bool IsQuiz { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("tracking_document_url")]
        public Uri TrackingDocumentUrl { get; set; }

        [JsonProperty("description_html")]
        public string DescriptionHtml { get; set; }

        [JsonProperty("do_not_publish")]
        public bool DoNotPublish { get; set; }

        [JsonProperty("tags")]
        public List<string> Tags { get; set; }

        [JsonProperty("translated_problem_types")]
        public List<TranslatedProblemType> TranslatedProblemTypes { get; set; }

        [JsonProperty("progress_key")]
        public string ProgressKey { get; set; }

        [JsonProperty("suggested_completion_criteria")]
        public string SuggestedCompletionCriteria { get; set; }

        [JsonProperty("edit_slug")]
        public string EditSlug { get; set; }

        [JsonProperty("summative")]
        public bool Summative { get; set; }

        [JsonProperty("live")]
        public bool Live { get; set; }

        [JsonProperty("translated_description")]
        public string TranslatedDescription { get; set; }

        [JsonProperty("pretty_display_name")]
        public string PrettyDisplayName { get; set; }

        [JsonProperty("deleted_mod_time")]
        public DateTime? DeletedModTime { get; set; }

        [JsonProperty("thumbnail_data")]
        public ThumbnailData ThumbnailData { get; set; }

        [JsonProperty("all_assessment_items")]
        public List<Item> AllAssessmentItems { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("translated_pretty_display_name")]
        public string TranslatedPrettyDisplayName { get; set; }

        [JsonProperty("node_slug")]
        public string NodeSlug { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("backup_timestamp")]
        public DateTime? BackupTimestamp { get; set; }

        [JsonProperty("concept_tags_info")]
        public List<ConceptTagInfo> ConceptTagsInfo { get; set; }

        [JsonProperty("problem_types")]
        public List<ProblemType> ProblemTypes { get; set; }

        [JsonProperty("curated_related_videos")]
        public List<string> CuratedRelatedVideos { get; set; }

        [JsonProperty("covers")]
        public List<string> Covers { get; set; }

        [JsonProperty("h_position")]
        public int HPosition { get; set; }

        [JsonProperty("translated_display_name")]
        public string TranslatedDisplayName { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("sha1")]
        public string Sha1 { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date_modified")]
        public DateTime DateModified { get; set; }

        [JsonProperty("prerequisites")]
        public List<string> Prerequisites { get; set; }

        [JsonProperty("assessment_item_tags")]
        public List<string> AssessmentItemTags { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("global_id")]
        public string GlobalId { get; set; }

        [JsonProperty("seconds_per_fast_problem")]
        public double SecondsPerFastProblem { get; set; }

        [JsonProperty("sha")]
        public string Sha { get; set; }

        [JsonProperty("image_url")]
        public Uri ImageUrl { get; set; }

        [JsonProperty("tutorial_only")]
        public bool TutorialOnly { get; set; }

        [JsonProperty("current_revision_key")]
        public string CurrentRevisionKey { get; set; }

        [JsonProperty("image_url_256")]
        public Uri ImageUrl256 { get; set; }

        [JsonProperty("content_id")]
        public string ContentId { get; set; }

        [JsonProperty("content_kind")]
        public string ContentKind { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }

}
