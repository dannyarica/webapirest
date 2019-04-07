using BasicApiResponse.Models.Dto;
using BasicApiResponse.Models.Response;
using BasicApiResponse.RoutePrefixes;
using BasicApiResponse.Services;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace BasicApiResponse.Controllers.v1
{
    [ApiVersion1RoutePrefix("exchange-rates")]
    public class ExchangeRatesController : ApiController
    {
        private IRateService _rateService;
        public ExchangeRatesController(IRateService rateService)
        {
            _rateService = rateService;
        }

        [HttpGet]
        [Route("{date:datetime:regex(\\d{4}-\\d{2}-\\d{2})}", Name = "GetRates")]
        public IHttpActionResult GetRates(DateTime date)
        {
            List<RateResponse> rates = _rateService.GetRateByDate(date);

            if (rates.Count > 0)
            {
                return Ok(rates);
            }
            else
            {
                var errorResponse = new ErrorResponse()
                {
                    Code = -1,
                    Title = "Tipo Cambio",
                    UserMessage = "No se encontraron tipos de cambio para esta fecha"
                };
                return Content(System.Net.HttpStatusCode.NotFound, errorResponse);
            }
        }
    }
}