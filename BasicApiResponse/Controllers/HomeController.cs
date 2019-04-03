using System.Web.Http;

namespace BasicApiResponse.Controllers
{
    [RoutePrefix("")]
    public class HomeController : ApiController
    {
        [HttpGet]
        public IHttpActionResult Index()
        {
            return Ok("Caja Trujillo: Microservices");
        }
    }
}