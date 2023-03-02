using System;
using System.Collections.Generic;

namespace AtavusUserMatcher.Models
{
    public partial class CourseVersion
    {
        public CourseVersion()
        {
            Chapters = new HashSet<Chapter>();
            CourseRuns = new HashSet<CourseRun>();
        }

        public long Id { get; set; }
        public string DisplayName { get; set; } = null!;
        public DateTime? AnnouncementAt { get; set; }
        public string? ShortDescription { get; set; }
        public string? LongDescription { get; set; }
        public DateTime? CertificateAvailableAt { get; set; }
        public long? OembedResourceId { get; set; }
        public long CourseId { get; set; }
        public int VersionNumber { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string? Code { get; set; }
        public string? CourseInfo { get; set; }
        public string? CourseAuthors { get; set; }

        public virtual Course Course { get; set; } = null!;
        public virtual OembedResource? OembedResource { get; set; }
        public virtual ICollection<Chapter> Chapters { get; set; }
        public virtual ICollection<CourseRun> CourseRuns { get; set; }
    }
}
