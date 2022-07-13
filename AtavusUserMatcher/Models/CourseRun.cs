using System;
using System.Collections.Generic;

namespace AtavusUserMatcher.Models
{
    public partial class CourseRun
    {
        public CourseRun()
        {
            Enrollments = new HashSet<Enrollment>();
        }

        public long Id { get; set; }
        public DateTime? StartsAt { get; set; }
        public DateTime? EndsAt { get; set; }
        public DateTime? EnrollmentStartsAt { get; set; }
        public DateTime? EnrollmentEndsAt { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public long CourseVersionId { get; set; }
        public long? OrganizationId { get; set; }

        public virtual CourseVersion CourseVersion { get; set; } = null!;
        public virtual Organization? Organization { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
