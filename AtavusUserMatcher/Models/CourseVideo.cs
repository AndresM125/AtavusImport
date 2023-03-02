using System;
using System.Collections.Generic;

namespace AtavusUserMatcher.Models
{
    public partial class CourseVideo
    {
        public CourseVideo()
        {
            LearnCourseVideos = new HashSet<LearnCourseVideo>();
        }

        public long Id { get; set; }
        public long? OembedResourceId { get; set; }
        public string? UrlName { get; set; }
        public string? DisplayName { get; set; }
        public bool? ShowsCaptions { get; set; }
        public string? Captions { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int? SortNumber { get; set; }
        public DateOnly? UploadAt { get; set; }
        public string? Authors { get; set; }

        public virtual OembedResource? OembedResource { get; set; }
        public virtual ICollection<LearnCourseVideo> LearnCourseVideos { get; set; }
    }
}
