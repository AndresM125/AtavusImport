using System;
using System.Collections.Generic;

namespace AtavusUserMatcher.Models
{
    public partial class PracticeWeek
    {
        public PracticeWeek()
        {
            Practices = new HashSet<Practice>();
        }

        public long Id { get; set; }
        public string? Name { get; set; }
        public long? PlanGuideId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int? Relevance { get; set; }

        public virtual PlanGuide? PlanGuide { get; set; }
        public virtual ICollection<Practice> Practices { get; set; }
    }
}
