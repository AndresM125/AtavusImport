using System;
using System.Collections.Generic;

namespace AtavusUserMatcher.Models
{
    public partial class Certificate
    {
        public long Id { get; set; }
        public long? EnrollmentId { get; set; }
        public string? VerifyUuid { get; set; }
        public string? DownloadUrl { get; set; }
        public decimal? Grade { get; set; }
        public string? ErrorReason { get; set; }
        public DateTime? LastGeneratedAt { get; set; }
        public string? Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? ExpiredAt { get; set; }

        public virtual Enrollment? Enrollment { get; set; }
    }
}
