using System;
using System.Collections.Generic;

namespace AtavusUserMatcher.Models
{
    public partial class Category
    {
        public Category()
        {
            OrganizationPlanCategories = new HashSet<OrganizationPlanCategory>();
            Videos = new HashSet<Video>();
        }

        public long Id { get; set; }
        public string? Name { get; set; }
        public string? BgColor { get; set; }
        public int? Relevance { get; set; }
        public string? Focus { get; set; }
        public string? FgColor { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string? Label { get; set; }
        public string? DefaultThumbnailUrl { get; set; }
        public string? PracticeTime { get; set; }
        public string? Description { get; set; }
        public bool? IsContentMastery { get; set; }

        public virtual ICollection<OrganizationPlanCategory> OrganizationPlanCategories { get; set; }
        public virtual ICollection<Video> Videos { get; set; }
    }
}
