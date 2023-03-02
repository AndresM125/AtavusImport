using System;
using System.Collections.Generic;

namespace AtavusUserMatcher.Models
{
    public partial class OrganizationPlan
    {
        public OrganizationPlan()
        {
            OrganizationPlanCategories = new HashSet<OrganizationPlanCategory>();
            OrganizationPlansPlanGuides = new HashSet<OrganizationPlansPlanGuide>();
            Organizations = new HashSet<Organization>();
        }

        public long Id { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual ICollection<OrganizationPlanCategory> OrganizationPlanCategories { get; set; }
        public virtual ICollection<OrganizationPlansPlanGuide> OrganizationPlansPlanGuides { get; set; }
        public virtual ICollection<Organization> Organizations { get; set; }
    }
}
