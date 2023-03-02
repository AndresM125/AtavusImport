using System;
using System.Collections.Generic;

namespace AtavusUserMatcher.Models
{
    public partial class StudentUnitProgress
    {
        public StudentUnitProgress()
        {
            StudentUnitProgressHistories = new HashSet<StudentUnitProgressHistory>();
        }

        public long Id { get; set; }
        public long? EnrollmentId { get; set; }
        public long? UnitId { get; set; }
        public DateTime? LastEventAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public string? State { get; set; }
        public DateTime? CompletedAt { get; set; }
        public decimal? LastCalculatedGrade { get; set; }
        public decimal? MaxCalculatedGrade { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Enrollment? Enrollment { get; set; }
        public virtual Unit? Unit { get; set; }
        public virtual ICollection<StudentUnitProgressHistory> StudentUnitProgressHistories { get; set; }
    }
}
