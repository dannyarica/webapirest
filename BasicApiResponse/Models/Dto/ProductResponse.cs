using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BasicApiResponse.Models.Dto
{
    public class ProductResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}