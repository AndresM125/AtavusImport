using System;
using System.Collections.Generic;

namespace AtavusUserMatcher.Models
{
    public partial class Enrollment
    {
        public Enrollment()
        {
            Certificates = new HashSet<Certificate>();
            QuizSubmissions = new HashSet<QuizSubmission>();
            StudentUnitProgresses = new HashSet<StudentUnitProgress>();
        }

        public long Id { get; set; }
        public long? UserId { get; set; }
        public long? CourseRunId { get; set; }
        public string? EnrollmentType { get; set; }
        public DateTime? DroppedAt { get; set; }
        public DateTime? StartedAt { get; set; }
        public DateTime? EndedAt { get; set; }
        public int? SeedNumber { get; set; }
        public bool? IsDone { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual CourseRun? CourseRun { get; set; }
        public virtual User? User { get; set; }
        public virtual ICollection<Certificate> Certificates { get; set; }
        public virtual ICollection<QuizSubmission> QuizSubmissions { get; set; }
        public virtual ICollection<StudentUnitProgress> StudentUnitProgresses { get; set; }
    }
}
