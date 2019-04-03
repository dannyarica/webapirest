using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

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