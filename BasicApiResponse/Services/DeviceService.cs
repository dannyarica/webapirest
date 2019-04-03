using BasicApiResponse.Models.Dto;
using BasicApiResponse.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BasicApiResponse.Services
{
    public class DeviceService : IDeviceService
    {
        public List<Device> deviceList = new List<Device>();

        public DeviceService()
        {
            deviceList.Add(new Device()
            {
                DeviceId = "d290f1ee-6c54-4b01-90e6-d701748f0850",
                UserId = "1234567890"
            });

            deviceList.Add(new Device()
            {
                DeviceId = "d290f1ee-6c54-4b01-90e6-d701748f0851",
                UserId = "1234567891"
            });
        }

        public Device GetDevice(string userid, string deviceid)
            => deviceList.FirstOrDefault(x => x.UserId == userid && x.DeviceId == deviceid);

        public ErrorResponse ValidateDevice(string userid, string deviceid)
        {
            var device = GetDevice(userid, deviceid);

            if (device == null)
            {
                var errorResponse = new ErrorResponse()
                {
                    Code = -1,
                    Title = "Dispositivo",
                    UserMessage = "Dispositivo no válido"
                };
                return errorResponse;
            }

            return null;
        }
    }
}