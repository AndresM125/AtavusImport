using System;
using System.Collections.Generic;

namespace AtavusUserMatcher.Models
{
    public partial class UserCoupon
    {
        public long Id { get; set; }
        public long? UserId { get; set; }
        public string? CouponableType { get; set; }
        public long? CouponableId { get; set; }
        public string? StripeCode { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
