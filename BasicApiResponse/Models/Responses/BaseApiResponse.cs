using System;

namespace BasicApiResponse.Models.Response
{
    public class BaseApiResponse
    {
        public string Identifier { get; set; }
        public DateTime RequestDate { get; set; }
        public DateTime ResponseDate { get; set; }
        public int StatusCode { get; set; }
        public object Result { get; set; }
        public ErrorResponse Error { get; set; }
        public string Url { get; set; }
        public string Version { get; set; }
    }
}