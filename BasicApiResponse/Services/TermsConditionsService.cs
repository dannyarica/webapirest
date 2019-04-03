using BasicApiResponse.Models.Dto;
using BasicApiResponse.Models.Response;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace BasicApiResponse.Services
{
    public class TermsConditionsService : ITermsConditionsService
    {
        public List<TermsConditions> listTermsConditions = new List<TermsConditions>(); 

        public TermsConditionsService()
        {
            listTermsConditions.Add(new TermsConditions()
            {
                UserId = "1234567890",
                DeviceId = "d290f1ee-6c54-4b01-90e6-d701748f0850",
                PhoneNumber = "51942033637",
                Accepted = true,
                AcceptedOn = DateTime.Now
            });

            listTermsConditions.Add(new TermsConditions()
            {
                UserId = "1234567891",
                DeviceId = "d290f1ee-6c54-4b01-90e6-d701748f0851",
                PhoneNumber = "51920462470",
                Accepted = true,
                AcceptedOn = DateTime.Now
            });
        }

        private ErrorResponse GenerateErrorResponse(string userMessage)
        {
            ErrorResponse errorResponse = new ErrorResponse()
            {
                Code = -1,
                Title = "Términos y Condiciones",
                UserMessage = userMessage
            };

            return errorResponse;
        }

        public string GetTermsConditionsUri()
            => ConfigurationManager.AppSettings["TermsConditionsUri"];

        public TermsConditions GetTermsConditions(string userid, string deviceid)
            => listTermsConditions.FirstOrDefault(x => x.UserId == userid && x.DeviceId == deviceid);

        public ErrorResponse Match(string userid, string deviceid, TermsConditions model)
        {
            if (userid != model.UserId)
            {
                return GenerateErrorResponse("Usuario no coincide");
            }
            if (deviceid != model.DeviceId)
            {
                GenerateErrorResponse("Dispositivo no coincide");
            }

            return null;
        }

        public TermsConditionsResponse AcceptTermsConditions(TermsConditions Model)
        {
            listTermsConditions.Add(Model);
            var ModelResult = new TermsConditionsResponse()
            {
                UserId = Model.UserId,
                DeviceId = Model.DeviceId,
                PhoneNumber = Model.PhoneNumber,
                Accepted = Model.Accepted
            };

            return ModelResult;
        }
    }
}