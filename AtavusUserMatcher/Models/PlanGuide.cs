using System;
using System.Collections.Generic;

namespace AtavusUserMatcher.Models
{
    public partial class PlanGuide
    {
        public PlanGuide()
        {
            OrganizationPlansPlanGuides = new HashSet<OrganizationPlansPlanGuide>();
            PracticeWeeks = new HashSet<PracticeWeek>();
        }

        public long Id { get; set; }
        public string? Name { get; set; }
        public string? Slug { get; set; }
        public string? Description { get; set; }
        public string? DrillProgressionPhilosophy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string? Overview { get; set; }
        public bool? InCoachKit { get; set; }

        public virtual ICollection<OrganizationPlansPlanGuide> OrganizationPlansPlanGuides { get; set; }
        public virtual ICollection<PracticeWeek> PracticeWeeks { get; set; }
    }
}
