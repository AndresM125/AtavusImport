using System;
using System.Collections.Generic;

namespace AtavusUserMatcher.Models
{
    public partial class PracticeDrill
    {
        public long Id { get; set; }
        public long? VideoId { get; set; }
        public long? PracticeId { get; set; }
        public long? PracticeDrillCategoryId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int? Relevance { get; set; }

        public virtual Practice? Practice { get; set; }
        public virtual PracticeDrillCategory? PracticeDrillCategory { get; set; }
        public virtual Video? Video { get; set; }
    }
}
