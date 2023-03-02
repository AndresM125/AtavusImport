using System;
using System.Collections.Generic;

namespace AtavusUserMatcher.Models
{
    public partial class HtmlComponent
    {
        public long Id { get; set; }
        public string? Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
