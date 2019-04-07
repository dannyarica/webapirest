using BasicApiResponse.Models.Dto;
using BasicApiResponse.Models.Request;
using BasicApiResponse.RoutePrefixes;
using BasicApiResponse.Services;
using System.Web.Http;

namespace BasicApiResponse.Controllers.v1
{
    [ApiVersion1RoutePrefix("users/{userid:length(10)}/devices/{deviceid}/terms-conditions")]
    public class TermsConditionsController : ApiController
    {
        private IUserService _userService;
        private IDeviceService _deviceService;
        private IDevicePhoneService _devicePhoneService;
        private ITermsConditionsService _termsconditionsservice;

        public TermsConditionsController(IUserService userService,
                                         IDeviceService deviceService,
                                         IDevicePhoneService devicePhoneService,
                                         ITermsConditionsService termsconditionsservice)
        {
            _userService = userService;
            _deviceService = deviceService;
            _devicePhoneService = devicePhoneService;
            _termsconditionsservice = termsconditionsservice;
        }

        [HttpGet]
        [Route("uri", Name = "GetTermsConditionsUri")]
        public IHttpActionResult GetTermsConditionsUri(string userid, string deviceid)
        {
            var validateUser = _userService.ValidateUser(userid);
            if (validateUser != null)
            {
                return Content(System.Net.HttpStatusCode.BadRequest, validateUser);
            }

            return Ok(_termsconditionsservice.GetTermsConditionsUri());
        }

        [HttpGet]
        [Route("", Name = "GetTermsConditions")]
        public IHttpActionResult GetTermsConditions(string userid, string deviceid)
        {
            var termsConditions = _termsconditionsservice.GetTermsConditions(userid, deviceid);
            return Ok(termsConditions);
        }

        [HttpPost]
        [Route("", Name = "AcceptTermsConditions")]
        public IHttpActionResult Post(string userid, string deviceid, [FromBody]BaseApiRequest<TermsConditions> termsConditionsRequest)
        {
            return Created(Url.Link(nameof(this.GetTermsConditions), new { userid, deviceid }), termsConditionsRequest.Model);
        }
    }
}