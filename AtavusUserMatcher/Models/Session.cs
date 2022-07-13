using System;
using System.Collections.Generic;

namespace AtavusUserMatcher.Models
{
    public partial class Session
    {
        public long Id { get; set; }
        public string SessionId { get; set; } = null!;
        public string? Data { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
