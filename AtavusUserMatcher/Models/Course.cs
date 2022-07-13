using System;
using System.Collections.Generic;

namespace AtavusUserMatcher.Models
{
    public partial class Course
    {
        public Course()
        {
            CourseInstructors = new HashSet<CourseInstructor>();
            CourseVersions = new HashSet<CourseVersion>();
            Learns = new HashSet<Learn>();
            OrganizationCoursePolicies = new HashSet<OrganizationCoursePolicy>();
        }

        public long Id { get; set; }
        public string? Slug { get; set; }
        public bool? IsCertified { get; set; }
        public decimal? LowestPassingGrade { get; set; }
        public string? CertificateName { get; set; }
        public bool? IsAdvertised { get; set; }
        public DateTime? CertificateAvailableAt { get; set; }
        public bool? IsVisibleToStudents { get; set; }
        public int? MaxStudentsEnrollmentAllowed { get; set; }
        public int? DurationDays { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string? LevelName { get; set; }
        public string? CoursePrereqSlug { get; set; }

        public virtual ICollection<CourseInstructor> CourseInstructors { get; set; }
        public virtual ICollection<CourseVersion> CourseVersions { get; set; }
        public virtual ICollection<Learn> Learns { get; set; }
        public virtual ICollection<OrganizationCoursePolicy> OrganizationCoursePolicies { get; set; }
    }
}
