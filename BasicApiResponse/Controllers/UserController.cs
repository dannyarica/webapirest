using BasicApiResponse.Filters;
using BasicApiResponse.Models.Dto;
using BasicApiResponse.Models.Request;
using BasicApiResponse.Models.Response;
using BasicApiResponse.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BasicApiResponse.Controllers
{
    [RoutePrefix("api/v1/users")]
    public class UserController : BaseController
    {
        private IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [Route("{userid:length(10)}", Name = "GetUserById")]
        public IHttpActionResult GetUserById(string userid)
        {
            var user = _userService.GetUser(userid);
            if (user == null)
            {
                var errorResponse = new ErrorResponse()
                {
                    Code = -1,
                    Title = "Usuario",
                    UserMessage = "No se ha encontrado el usuario ingresado"
                };
                return Content(System.Net.HttpStatusCode.NotFound, errorResponse);
            }

            return Ok(user);
        }

        [HttpPost]
        [Route("", Name = "PostUser")]
        public IHttpActionResult PostUser([FromBody]BaseApiRequest<User> userRequest)
        {
            string newId = "1234567892";
            return Created(GetLocationUri("GetUserById", new { userid = newId }), userRequest.Model);
        }
    }
}
