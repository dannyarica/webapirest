using BasicApiResponse.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicApiResponse.Models.Responses
{
    public class LinkHelper<T> where T : class
    {
        public T Data { get; set; }
        public List<HyperMediaLink> Links { get; set; }

        public LinkHelper()
        {
            Links = new List<HyperMediaLink>();
        }

        public LinkHelper(T item) : base()
        {
            Data = item;
            Links = new List<HyperMediaLink>();
        }
    }
}