using System;
using System.Web.Http;

namespace BasicApiResponse.Controllers
{
    public class BaseController : ApiController
    {
        protected Uri GetLocationUri(string routeName, object routeValues)
        {
            string uri = Url.Link(routeName, routeValues);
            return new Uri(uri);
        }
    }
}