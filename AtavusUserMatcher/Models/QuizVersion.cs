using System;
using System.Collections.Generic;

namespace AtavusUserMatcher.Models
{
    public partial class QuizVersion
    {
        public QuizVersion()
        {
            QuestionVersions = new HashSet<QuestionVersion>();
        }

        public long Id { get; set; }
        public long? QuizId { get; set; }
        public string? VersionCode { get; set; }
        public int? SortNumber { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Quiz? Quiz { get; set; }
        public virtual ICollection<QuestionVersion> QuestionVersions { get; set; }
    }
}
