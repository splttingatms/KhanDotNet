using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace KhanDotNet.Library.Contracts
{
    public class ProblemLog
    {
        [JsonProperty("relative_url")]
        public Uri RelativeUrl { get; set; }

        [JsonProperty("mission")]
        public object Mission { get; set; }

        [JsonProperty("pre_attempt_prediction")]
        public double PreAttemptPrediction { get; set; }

        [JsonProperty("attempts")]
        public List<string> Attempts { get; set; }

        [JsonProperty("seed")]
        public string Seed { get; set; }

        [JsonProperty("ka_url")]
        public Uri KaUrl { get; set; }

        [JsonProperty("problem_type")]
        public string ProblemType { get; set; }

        [JsonProperty("count_hints")]
        public int CountHints { get; set; }

        [JsonProperty("task_type")]
        public string TaskType { get; set; }

        [JsonProperty("user_id")]
        public string UserId { get; set; }

        [JsonProperty("time_taken")]
        public int TimeTaken { get; set; }

        [JsonProperty("review_mode")]
        public bool ReviewMode { get; set; }

        [JsonProperty("post_attempt_prediction")]
        public double PostAttemptPrediction { get; set; }

        [JsonProperty("hint_used")]
        public bool HintUsed { get; set; }

        [JsonProperty("time_taken_attempts")]
        public List<int> TimeTakenAttempts { get; set; }

        [JsonProperty("correct")]
        public bool Correct { get; set; }

        [JsonProperty("exercise")]
        public string Exercise { get; set; }

        [JsonProperty("skipped")]
        public bool Skipped { get; set; }

        [JsonProperty("hint_time_taken_list")]
        public List<object> HintTimeTakenList { get; set; }

        [JsonProperty("backup_timestamp")]
        public DateTime BackupTimestamp { get; set; }

        [JsonProperty("earned_proficiency")]
        public bool EarnedProficiency { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("outgoing_level")]
        public string OutgoingLevel { get; set; }

        [JsonProperty("ip_address")]
        public string IpAddress { get; set; }

        [JsonProperty("problem_number")]
        public int ProblemNumber { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("sha1")]
        public string Sha1 { get; set; }

        [JsonProperty("count_attempts")]
        public int CountAttempts { get; set; }

        [JsonProperty("task_id")]
        public string TaskId { get; set; }

        [JsonProperty("points_earned")]
        public int PointsEarned { get; set; }

        [JsonProperty("practiced_prereqs")]
        public bool PracticedPrereqs { get; set; }

        [JsonProperty("date_done_str")]
        public string DateDoneStr { get; set; }

        [JsonProperty("prediction_version")]
        public object PredictionVersion { get; set; }

        [JsonProperty("time_done")]
        public DateTime TimeDone { get; set; }

        [JsonProperty("random_float")]
        public double RandomFloat { get; set; }

        [JsonProperty("kaid")]
        public object KaId { get; set; }

        [JsonProperty("incoming_level")]
        public string IncomingLevel { get; set; }

        [JsonProperty("hint_after_attempt_list")]
        public List<object> HintAfterAttemptList { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
