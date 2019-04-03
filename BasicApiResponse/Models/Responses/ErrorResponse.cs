namespace BasicApiResponse.Models.Response
{
    public class ErrorResponse
    {
        public int Code { get; set; }
        public string Title { get; set; }
        public string UserMessage { get; set; }
        public string Detail { get; set; }
    }
}