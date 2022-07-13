using System;
using System.Collections.Generic;

namespace AtavusUserMatcher.Models
{
    public partial class OrganizationPlansPlanGuide
    {
        public long Id { get; set; }
        public long? OrganizationPlanId { get; set; }
        public long? PlanGuideId { get; set; }

        public virtual OrganizationPlan? OrganizationPlan { get; set; }
        public virtual PlanGuide? PlanGuide { get; set; }
    }
}
