using BasicApiResponse.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicApiResponse.Services
{
    public interface IRateService
    {
       List<RateResponse> GetRateByDate(DateTime date);
    }
}
