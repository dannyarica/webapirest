using BasicApiResponse.Models.Dto;
using BasicApiResponse.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicApiResponse.Services
{
    public interface IDevicePhoneService
    {
        DevicePhone GetDevicePhone(string userid, string deviceid, string phonenumber);
        ErrorResponse ValidateDevicePhone(string userid, string deviceid, string phonenumber);
    }
}
