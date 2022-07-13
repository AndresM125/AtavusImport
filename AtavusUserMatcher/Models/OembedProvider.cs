using System;
using System.Collections.Generic;

namespace AtavusUserMatcher.Models
{
    public partial class OembedProvider
    {
        public OembedProvider()
        {
            OembedResources = new HashSet<OembedResource>();
        }

        public long Id { get; set; }
        public string? Name { get; set; }
        public string? DefaultOptions { get; set; }
        public string? Format { get; set; }
        public string? UrlEndpoint { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual ICollection<OembedResource> OembedResources { get; set; }
    }
}
