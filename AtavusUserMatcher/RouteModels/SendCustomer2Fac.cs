using System.ComponentModel.DataAnnotations;

namespace AtavusUserMatcher.RouteModels
{
    public class SendCustomer2FacParam
    {
        [Required]
        public int CustomerId { get; set; }
        [Required]
        [Phone]
        public string PhoneNumber { get; set; }
    }

    public class SendCustomer2FacResult
    {
    }
}
