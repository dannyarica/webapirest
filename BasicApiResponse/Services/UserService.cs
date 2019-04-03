using BasicApiResponse.Models.Dto;
using BasicApiResponse.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicApiResponse.Services
{
    public class UserService : IUserService
    {
        private List<User> userList = new List<User>();
        public UserService()
        {
            userList.Add(new User
            {
                Id = "1234567890",
                FirstName = "Alfredo",
                LastName = "Sánchez",
                Email = "alfredo.sanchez@avantica.net",
            });

            userList.Add(new User
            {
                Id = "1234567891",
                FirstName = "Danny",
                LastName = "Arica",
                Email = "danny.arica@avantica.net",
            });
        }

        public User GetUser(string userid)
            => userList.FirstOrDefault(x => x.Id == userid);

        public ErrorResponse ValidateUser(string userid)
        {
            var user = GetUser(userid);

            if (user == null)
            {
                var errorResponse = new ErrorResponse()
                {
                    Code = -1,
                    Title = "Usuario",
                    UserMessage = "Usuario no válido"
                };
                return errorResponse;
            }

            return null;
        }
    }
}