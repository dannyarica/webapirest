using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BasicApiResponse.Models.Request
{
    public class BaseApiRequest<T> where T : class
    {
        [Required]
        public string DeviceId { get; set; }
        [Required]
        public T Model { get; set; }
    }
}