using System;
using System.Collections.Generic;

namespace AtavusUserMatcher.Models
{
    public partial class CoachTip
    {
        public CoachTip()
        {
            Videos = new HashSet<Video>();
        }

        public long Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public long? OembedResourceId { get; set; }

        public virtual OembedResource? OembedResource { get; set; }
        public virtual ICollection<Video> Videos { get; set; }
    }
}
