using BasicApiResponse.Models.Dto;
using BasicApiResponse.Models.Response;

namespace BasicApiResponse.Services
{
    public interface IDeviceService
    {
        Device GetDevice(string userid, string deviceid);
        ErrorResponse ValidateDevice(string userid, string deviceid);
    }
}