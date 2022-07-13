using System;
using System.Collections.Generic;

namespace AtavusUserMatcher.Models
{
    public partial class Question
    {
        public Question()
        {
            QuestionChoices = new HashSet<QuestionChoice>();
            QuestionVersions = new HashSet<QuestionVersion>();
        }

        public long Id { get; set; }
        public long? QuizId { get; set; }
        public string? Code { get; set; }
        public string? Text { get; set; }
        public string? QuestionType { get; set; }
        public int? SortNumber { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public long? ChapterId { get; set; }
        public string? Media { get; set; }

        public virtual Quiz? Quiz { get; set; }
        public virtual ICollection<QuestionChoice> QuestionChoices { get; set; }
        public virtual ICollection<QuestionVersion> QuestionVersions { get; set; }
    }
}
