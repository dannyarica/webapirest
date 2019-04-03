using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicApiResponse.Models.Response
{
    public class HyperMediaLink
    {
        public string Rel { get; set; }
        public string Href { get; set; }
        public string Action { get; set; }
        public HyperMediaLink(string rel, string href, string action)
        {
            Rel = rel;
            Href = href;
            Action = action;
        }
    }
}