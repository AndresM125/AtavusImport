using System;
using System.Collections.Generic;

namespace AtavusUserMatcher.Models
{
    public partial class Learn
    {
        public Learn()
        {
            LearnCourseVideos = new HashSet<LearnCourseVideo>();
        }

        public long Id { get; set; }
        public long? CourseId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Code { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Course? Course { get; set; }
        public virtual ICollection<LearnCourseVideo> LearnCourseVideos { get; set; }
    }
}
