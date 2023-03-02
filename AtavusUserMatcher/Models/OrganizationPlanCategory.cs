using System;
using System.Collections.Generic;

namespace AtavusUserMatcher.Models
{
    public partial class OrganizationPlanCategory
    {
        public long Id { get; set; }
        public long? OrganizationPlanId { get; set; }
        public long? CategoryId { get; set; }

        public virtual Category? Category { get; set; }
        public virtual OrganizationPlan? OrganizationPlan { get; set; }
    }
}
