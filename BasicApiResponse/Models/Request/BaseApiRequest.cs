using System.ComponentModel.DataAnnotations;

namespace BasicApiResponse.Models.Request
{
    public class BaseApiRequest<T> where T : class
    {
        [Required]
        public string DeviceId { get; set; }

        [Required]
        public T Model { get; set; }
    }
}