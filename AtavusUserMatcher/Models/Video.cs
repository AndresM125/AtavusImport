using System;
using System.Collections.Generic;

namespace AtavusUserMatcher.Models
{
    public partial class Video
    {
        public Video()
        {
            PracticeDrills = new HashSet<PracticeDrill>();
        }

        public long Id { get; set; }
        public string? Purpose { get; set; }
        public long? CategoryId { get; set; }
        public long? CoachTipId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string? Name { get; set; }
        public long? OembedResourceId { get; set; }
        public int? Relevance { get; set; }

        public virtual Category? Category { get; set; }
        public virtual CoachTip? CoachTip { get; set; }
        public virtual OembedResource? OembedResource { get; set; }
        public virtual ICollection<PracticeDrill> PracticeDrills { get; set; }
    }
}
