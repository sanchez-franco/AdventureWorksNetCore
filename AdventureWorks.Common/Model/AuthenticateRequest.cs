using System.ComponentModel.DataAnnotations;

namespace AdventureWorks.Common.Model
{
    public class AuthenticateRequest
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
