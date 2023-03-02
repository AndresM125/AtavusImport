using System;
using System.Collections.Generic;

namespace AtavusUserMatcher.Models
{
    public partial class BrandingItemOrganization
    {
        public long Id { get; set; }
        public long? BrandingItemId { get; set; }
        public string? Value { get; set; }
        public long? OrganizationId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual BrandingItem? BrandingItem { get; set; }
        public virtual Organization? Organization { get; set; }
    }
}
