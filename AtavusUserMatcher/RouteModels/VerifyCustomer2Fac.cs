using System.ComponentModel.DataAnnotations;

namespace AtavusUserMatcher.RouteModels
{
    public class VerifyCustomer2FacParam
    {
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public string Code { get; set; }

    }
}
