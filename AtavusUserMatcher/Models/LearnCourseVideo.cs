using System;
using System.Collections.Generic;

namespace AtavusUserMatcher.Models
{
    public partial class LearnCourseVideo
    {
        public long Id { get; set; }
        public long? CourseVideoId { get; set; }
        public long? LearnId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsFreeToPlay { get; set; }

        public virtual CourseVideo? CourseVideo { get; set; }
        public virtual Learn? Learn { get; set; }
    }
}
