using System;

namespace BasicApiResponse.Models.Dto
{
    public class RateResponse
    {
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public double Amount { get; set; }
    }
}