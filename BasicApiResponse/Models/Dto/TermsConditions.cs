using System;
using System.ComponentModel.DataAnnotations;

namespace BasicApiResponse.Models.Dto
{
    public class TermsConditions
    {
        [Required]
        public string UserId { get; set; }

        [Required]
        public string DeviceId { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public bool Accepted { get; set; }

        [Required]
        public DateTime AcceptedOn { get; set; }
    }
}