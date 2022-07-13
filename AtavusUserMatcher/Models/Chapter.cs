using System;
using System.Collections.Generic;

namespace AtavusUserMatcher.Models
{
    public partial class Chapter
    {
        public Chapter()
        {
            Units = new HashSet<Unit>();
        }

        public long Id { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? ReleasedAt { get; set; }
        public int? Weight { get; set; }
        public bool? IsGraded { get; set; }
        public string? LongDescription { get; set; }
        public int? SortNumber { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public long CourseVersionId { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }

        public virtual CourseVersion CourseVersion { get; set; } = null!;
        public virtual ICollection<Unit> Units { get; set; }
    }
}
