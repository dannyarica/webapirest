using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BasicApiResponse.Models.Response;

namespace BasicApiResponse.Models.Dto
{
    public class RateResponse
    {
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
    }
}