using BasicApiResponse.Models.Dto;
using BasicApiResponse.Models.Response;
using System.Collections.Generic;

namespace BasicApiResponse.Models.Enrichers
{
    public class RateEnricher : IEnricher<RateResponse, ModelEnricher<RateResponse>>
    {
        public ModelEnricher<RateResponse> Enrich(RateResponse model)
        {
            var enricher = new ModelEnricher<RateResponse>(model)
            {
                Links = new List<HyperMediaLink>()
            };
            enricher.Links.Add(new HyperMediaLink("self", "asdasdasdas", "GET"));
            return enricher;
        }
    }
}