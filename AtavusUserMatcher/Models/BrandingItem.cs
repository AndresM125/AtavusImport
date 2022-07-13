using System;
using System.Collections.Generic;

namespace AtavusUserMatcher.Models
{
    public partial class BrandingItem
    {
        public BrandingItem()
        {
            BrandingItemOrganizations = new HashSet<BrandingItemOrganization>();
        }

        public long Id { get; set; }
        public string? Key { get; set; }
        public string? Value { get; set; }
        public string? ValueType { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual ICollection<BrandingItemOrganization> BrandingItemOrganizations { get; set; }
    }
}
