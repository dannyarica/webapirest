using BasicApiResponse.Models.Response;
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace BasicApiResponse.Delegates
{
    public class ApiResponseDelegate : DelegatingHandler
    {
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            BaseApiResponse baseResponse = new BaseApiResponse
            {
                Identifier = Guid.NewGuid().ToString(),
                Version = "1.0.0",
                RequestDate = DateTime.Now
            };

            var response = await base.SendAsync(request, cancellationToken);

            baseResponse.ResponseDate = DateTime.Now;

            var result = CreateResponse(request, response, baseResponse);
            return result;
        }

        protected HttpResponseMessage CreateResponse(HttpRequestMessage request, HttpResponseMessage response, BaseApiResponse baseResponse)
        {
            baseResponse.StatusCode = (int)response.StatusCode;
            baseResponse.Url = request.RequestUri.AbsoluteUri;

            object content;
            response.TryGetContentValue(out content);

            if (response.IsSuccessStatusCode)
            {
                baseResponse.Result = content;
            }
            else
            {
                if (content is ErrorResponse)
                {
                    baseResponse.Error = (ErrorResponse)content;
                }
                else
                {
                    baseResponse.Error = new ErrorResponse()
                    {
                        Code = 101,
                        Title = "Error", 
                        UserMessage = content.ToString(),
                        Detail = response.ReasonPhrase
                    };
                }
            }

            var newResponse = request.CreateResponse(response.StatusCode, baseResponse);

            foreach(var header in response.Headers)
            {
                newResponse.Headers.Add(header.Key, header.Value);
            }

            return newResponse;
        }
    }
}