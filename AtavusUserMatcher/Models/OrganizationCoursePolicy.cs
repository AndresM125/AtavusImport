using System;
using System.Collections.Generic;

namespace AtavusUserMatcher.Models
{
    public partial class OrganizationCoursePolicy
    {
        public long Id { get; set; }
        public long OrganizationId { get; set; }
        public decimal? LowestPassingGrade { get; set; }
        public long CourseId { get; set; }
        public DateTime? CertificationCompletionLimitAt { get; set; }
        public DateTime? EnrollmentStartsAt { get; set; }
        public DateTime? EnrollmentEndsAt { get; set; }
        public int? RecertificationFrequencyDays { get; set; }
        public decimal? DiscountPrecent { get; set; }
        public DateTime? DiscountEndsAt { get; set; }
        public int? DurationDays { get; set; }
        public DateTime? CourseEndsAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Course Course { get; set; } = null!;
        public virtual Organization Organization { get; set; } = null!;
    }
}
