using System;
using System.Collections.Generic;

namespace AtavusUserMatcher.Models
{
    public partial class QuestionVersion
    {
        public long Id { get; set; }
        public long? QuizVersionId { get; set; }
        public long? QuestionId { get; set; }
        public int? SortNumber { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Question? Question { get; set; }
        public virtual QuizVersion? QuizVersion { get; set; }
    }
}
