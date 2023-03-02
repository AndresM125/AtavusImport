using System;
using System.Collections.Generic;

namespace AtavusUserMatcher.Models
{
    public partial class Quiz
    {
        public Quiz()
        {
            Questions = new HashSet<Question>();
            QuizSubmissions = new HashSet<QuizSubmission>();
            QuizVersions = new HashSet<QuizVersion>();
        }

        public long Id { get; set; }
        public string? Code { get; set; }
        public string? DisplayName { get; set; }
        public string? Description { get; set; }
        public string? Heading { get; set; }
        public int? MaxSubmissions { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<QuizSubmission> QuizSubmissions { get; set; }
        public virtual ICollection<QuizVersion> QuizVersions { get; set; }
    }
}
