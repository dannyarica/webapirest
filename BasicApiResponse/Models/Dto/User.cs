using System.ComponentModel.DataAnnotations;

namespace BasicApiResponse.Models.Dto
{
    public class User
    {
        [StringLength(10)]
        public string Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")]
        public string Email { get; set; }

        [Required]
        [StringLength(6)]
        public string Password { get; set; }
    }
}