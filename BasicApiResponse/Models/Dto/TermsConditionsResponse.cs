using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicApiResponse.Models.Dto
{
    public class TermsConditionsResponse
    {
        public string UserId { get; set; }
        public string DeviceId { get; set; }
        public string PhoneNumber { get; set; }
        public bool Accepted { get; set; }
    }
}