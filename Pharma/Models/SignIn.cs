using System.ComponentModel.DataAnnotations;

namespace Pharma.Models
{
    public class SignIn
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
