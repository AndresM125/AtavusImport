using System;
using System.Collections.Generic;

namespace AtavusUserMatcher.Models
{
    public partial class Organization
    {
        public Organization()
        {
            BrandingItemOrganizations = new HashSet<BrandingItemOrganization>();
            CourseRuns = new HashSet<CourseRun>();
            OrganizationCoursePolicies = new HashSet<OrganizationCoursePolicy>();
        }

        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public string Code { get; set; } = null!;
        public string? Description { get; set; }
        public string? Subdomain { get; set; }
        public string? State { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public long? OrganizationPlanId { get; set; }
        public long? ImportId { get; set; }
        public string? PersonalizedLogo { get; set; }
        public DateTime? LicenseStartsAt { get; set; }
        public DateTime? LicenseEndsAt { get; set; }
        public DateTime? PortalGoesLivesAt { get; set; }
        public string? AtavusGuid { get; set; }
        public string? TimeZone { get; set; }
        public long? PlanId { get; set; }
        public string? Domain { get; set; }

        public virtual Import? Import { get; set; }
        public virtual OrganizationPlan? OrganizationPlan { get; set; }
        public virtual Plan? Plan { get; set; }
        public virtual ICollection<BrandingItemOrganization> BrandingItemOrganizations { get; set; }
        public virtual ICollection<CourseRun> CourseRuns { get; set; }
        public virtual ICollection<OrganizationCoursePolicy> OrganizationCoursePolicies { get; set; }
    }
}
