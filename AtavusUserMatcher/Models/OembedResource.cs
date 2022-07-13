using System;
using System.Collections.Generic;

namespace AtavusUserMatcher.Models
{
    public partial class OembedResource
    {
        public OembedResource()
        {
            CoachTips = new HashSet<CoachTip>();
            CourseVersions = new HashSet<CourseVersion>();
            CourseVideos = new HashSet<CourseVideo>();
            Videos = new HashSet<Video>();
        }

        public long Id { get; set; }
        public string? Url { get; set; }
        public string? Options { get; set; }
        public long? OembedProviderId { get; set; }
        public string? LastResponse { get; set; }
        public DateTime? LastResponseAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual OembedProvider? OembedProvider { get; set; }
        public virtual ICollection<CoachTip> CoachTips { get; set; }
        public virtual ICollection<CourseVersion> CourseVersions { get; set; }
        public virtual ICollection<CourseVideo> CourseVideos { get; set; }
        public virtual ICollection<Video> Videos { get; set; }
    }
}
