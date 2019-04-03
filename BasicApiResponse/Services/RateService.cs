using BasicApiResponse.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicApiResponse.Services
{
    public class RateService : IRateService
    {
        private List<RateResponse> rateList = new List<RateResponse>();
        public RateService()
        {
            rateList.Add(new RateResponse
            {
                Date = DateTime.Now.Date,
                Description = "Compra",
                Amount = 3.19
            });

            rateList.Add(new RateResponse
            {
                Date = DateTime.Now.Date,
                Description = "Venta",
                Amount = 3.23
            });
        }

        public List<RateResponse> GetRateByDate(DateTime date)
        {
            List<RateResponse> rates = rateList.Where(x => x.Date.Year == date.Year &&
                                       x.Date.Month == date.Month &&
                                       x.Date.Day == date.Day).ToList();
            return rates;
        }
    }
}