using System;
using System.Collections.Generic;

namespace AtavusUserMatcher.Models
{
    public partial class QuestionChoice
    {
        public QuestionChoice()
        {
            Answers = new HashSet<Answer>();
        }

        public long Id { get; set; }
        public long? QuestionId { get; set; }
        public string? Value { get; set; }
        public string? Text { get; set; }
        public int? SortNumber { get; set; }
        public bool? IsCorrect { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Question? Question { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }
    }
}
