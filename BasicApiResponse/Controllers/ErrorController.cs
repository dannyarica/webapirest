using System.Web.Http;

namespace BasicApiResponse.Controllers
{
    public class ErrorController : ApiController
    {
        [HttpGet, HttpPost, HttpPut, HttpDelete]
        public IHttpActionResult Handle404(string url)
        {
            return Content(System.Net.HttpStatusCode.NotFound, string.Format("The path {0} is not valid.", url));
        }
    }
}