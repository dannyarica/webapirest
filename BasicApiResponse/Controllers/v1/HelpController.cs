using BasicApiResponse.RoutePrefixes;
using System.Web.Http;

namespace BasicApiResponse.Controllers.v1
{
    [ApiVersion1RoutePrefix("help")]
    public class HelpController : ApiController
    {
        [HttpGet]
        [Route("")]
        public IHttpActionResult Index()
        {
            return Ok("The Ping API is a service that allows developers to test their APIs. It can be used to determine when an API is down or behaving unexpectedly, to determine the response times from different scenarios");
        }

        [HttpGet]
        [Route("echo")]
        public IHttpActionResult Echo(string message)
        {
            return Ok(message);
        }
    }
}