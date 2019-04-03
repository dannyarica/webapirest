using BasicApiResponse.Models.Dto;
using BasicApiResponse.Models.Response;

namespace BasicApiResponse.Services
{
    public interface ITermsConditionsService
    {
        string GetTermsConditionsUri();

        TermsConditions GetTermsConditions(string userid, string deviceid);

        ErrorResponse Match(string userid, string deviceid, TermsConditions model);

        TermsConditionsResponse AcceptTermsConditions(TermsConditions Model);
    }
}