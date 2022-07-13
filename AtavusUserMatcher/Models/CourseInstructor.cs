using System;
using System.Collections.Generic;

namespace AtavusUserMatcher.Models
{
    public partial class CourseInstructor
    {
        public long Id { get; set; }
        public long? CourseId { get; set; }
        public long? InstructorId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Course? Course { get; set; }
        public virtual Instructor? Instructor { get; set; }
    }
}
