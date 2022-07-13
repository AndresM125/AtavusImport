using System;
using System.Collections.Generic;

namespace AtavusUserMatcher.Models
{
    public partial class Instructor
    {
        public Instructor()
        {
            CourseInstructors = new HashSet<CourseInstructor>();
        }

        public long Id { get; set; }
        public string? Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string? Code { get; set; }

        public virtual ICollection<CourseInstructor> CourseInstructors { get; set; }
    }
}
