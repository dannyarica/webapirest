using BasicApiResponse.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicApiResponse.Models.Enrichers
{
    public class ModelEnricher<T> where T : class
    {
        public ModelEnricher(T model)
        {
            Data = model;
        }

        public T Data { get; set; }
        public List<HyperMediaLink> Links { get; set; }
    }
}