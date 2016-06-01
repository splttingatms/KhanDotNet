using Newtonsoft.Json;
using System;

namespace KhanDotNet.Library.Contracts
{
    public class ExerciseInteraction
    {
        [JsonProperty("streak")]
        public int Streak { get; set; }

        [JsonProperty("is_skill_check")]
        public bool IsSkillCheck { get; set; }

        [JsonProperty("mastery_points")]
        public int MasteryPoints { get; set; }

        [JsonProperty("snooze_time")]
        public string SnoozeTime { get; set; }

        [JsonProperty("maximum_exercise_progress_dt")]
        public DateTime MaximumExerciseProgressDt { get; set; }

        [JsonProperty("last_count_hints")]
        public int LastCountHints { get; set; }

        [JsonProperty("exercise_model")]
        public Exercise ExerciseModel { get; set; }

        [JsonProperty("MASTERY_CARD_SUPERPROMOTE_THRESHOLD")]
        public double MasteryCardSuperPromoteThreshold { get; set; }

        [JsonProperty("exercise_progress")]
        public ExerciseProgress ExerciseProgress { get; set; }

        [JsonProperty("practiced_date")]
        public DateTime? PracticedDate { get; set; }

        [JsonProperty("exercise")]
        public string Exercise { get; set; }

        [JsonProperty("clear_struggling_indicators")]
        public object ClearStrugglingIndicators { get; set; }

        [JsonProperty("total_done")]
        public int TotalDone { get; set; }

        [JsonProperty("exercise_states")]
        public ExerciseStates ExerciseStates { get; set; }

        [JsonProperty("backup_timestamp")]
        public DateTime? BackupTimestamp { get; set; }

        [JsonProperty("total_correct")]
        public int TotalCorrect { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("practiced")]
        public bool Practiced { get; set; }

        [JsonProperty("seconds_per_fast_problem")]
        public double SecondsPerFastProblem { get; set; }

        [JsonProperty("last_done")]
        public DateTime LastDone { get; set; }

        [JsonProperty("last_mastery_update")]
        public DateTime LastMasteryUpdate { get; set; }

        [JsonProperty("maximum_exercise_progress")]
        public ExerciseProgress MaximumExerciseProgress { get; set; }

        [JsonProperty("mastered")]
        public bool Mastered { get; set; }

        [JsonProperty("longest_streak")]
        public int LongestStreak { get; set; }

        [JsonProperty("kaid")]
        public string KaId { get; set; }

        [JsonProperty("content_kind")]
        public string ContentKind { get; set; }

        [JsonProperty("last_attempt_number")]
        public int LastAttemptNumber { get; set; }

        [JsonProperty("proficient_date")]
        public DateTime? ProficientDate { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
