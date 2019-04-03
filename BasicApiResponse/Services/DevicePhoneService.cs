using BasicApiResponse.Models.Dto;
using BasicApiResponse.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicApiResponse.Services
{
    public class DevicePhoneService : IDevicePhoneService
    {
        public List<DevicePhone> devicePhoneList = new List<DevicePhone>();

        public DevicePhoneService()
        {
            devicePhoneList.Add(new DevicePhone()
            {
                UserId = "1234567890",
                DeviceId = "d290f1ee-6c54-4b01-90e6-d701748f0850",
                PhoneNumber = "51942033637"
            });

            devicePhoneList.Add(new DevicePhone()
            {
                UserId = "1234567891",
                DeviceId = "d290f1ee-6c54-4b01-90e6-d701748f0851",
                PhoneNumber = "51920462470"
            });
        }

        public DevicePhone GetDevicePhone(string userid, string deviceid, string phonenumber)
            => devicePhoneList.FirstOrDefault(x => x.UserId == userid && x.DeviceId == deviceid && x.PhoneNumber == phonenumber);

        public ErrorResponse ValidateDevicePhone(string userid, string deviceid, string phonenumber)
        {
            var devicePhone = GetDevicePhone(userid, deviceid, phonenumber);

            if (devicePhone != null)
            {
                var errorResponse = new ErrorResponse()
                {
                    Code = -1,
                    Title = "Términos y Condiciones",
                    UserMessage = "Dispositivo ya se encuentra registrado"
                };
                return errorResponse;
            }

            return null;
        }
    }
}