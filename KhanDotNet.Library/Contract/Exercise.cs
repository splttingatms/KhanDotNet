using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace KhanDotNet.Library.Contract
{

    public class Item
    {
        public string sha { get; set; }
        public bool live { get; set; }
        public string id { get; set; }
    }

    public class TranslatedProblemType
    {
        public List<Item> items { get; set; }
        public List<object> related_videos { get; set; }
        public string name { get; set; }
    }

    public class ThumbnailData
    {
        public string url { get; set; }
        public bool skip_filter { get; set; }
        public string title_text { get; set; }
        public string gcs_name { get; set; }
    }

    public class AllAssessmentItem
    {
        public string sha { get; set; }
        public bool live { get; set; }
        public string id { get; set; }
    }

    public class ConceptTagsInfo
    {
        public string display_name { get; set; }
        public string id { get; set; }
        public string slug { get; set; }
    }

    public class Item2
    {
        public string sha { get; set; }
        public bool live { get; set; }
        public string id { get; set; }
    }

    public class ProblemType
    {
        public List<Item2> items { get; set; }
        public List<object> related_videos { get; set; }
        public string name { get; set; }
    }

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
        public string translated_short_display_name { get; set; }
        public bool uses_assessment_items { get; set; }
        public string ka_url { get; set; }
        public string short_display_name { get; set; }
        public string translated_title { get; set; }
        public string author_key { get; set; }
        public string translated_description_html { get; set; }
        public string id { get; set; }
        public List<string> concept_tags { get; set; }
        public bool is_quiz { get; set; }
        public string display_name { get; set; }
        public object tracking_document_url { get; set; }
        public string description_html { get; set; }
        public bool do_not_publish { get; set; }
        public List<object> tags { get; set; }
        public List<TranslatedProblemType> translated_problem_types { get; set; }
        public string progress_key { get; set; }
        public string suggested_completion_criteria { get; set; }
        public string edit_slug { get; set; }
        public bool summative { get; set; }
        public bool live { get; set; }
        public string translated_description { get; set; }
        public string pretty_display_name { get; set; }
        public object deleted_mod_time { get; set; }
        public ThumbnailData thumbnail_data { get; set; }
        public List<AllAssessmentItem> all_assessment_items { get; set; }
        public string description { get; set; }
        public string translated_pretty_display_name { get; set; }
        public string node_slug { get; set; }
        public bool deleted { get; set; }
        public object backup_timestamp { get; set; }
        public List<ConceptTagsInfo> concept_tags_info { get; set; }
        public List<ProblemType> problem_types { get; set; }
        public List<string> curated_related_videos { get; set; }
        public List<object> covers { get; set; }
        public int h_position { get; set; }
        public string translated_display_name { get; set; }
        public string kind { get; set; }
        public string sha1 { get; set; }
        public string name { get; set; }
        public string date_modified { get; set; }
        public List<object> prerequisites { get; set; }
        public List<string> assessment_item_tags { get; set; }
        public string title { get; set; }
        public string global_id { get; set; }
        public double seconds_per_fast_problem { get; set; }
        public string sha { get; set; }
        public string image_url { get; set; }
        public bool tutorial_only { get; set; }
        public string current_revision_key { get; set; }
        public string image_url_256 { get; set; }
        public string content_id { get; set; }
        public string content_kind { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }

}
