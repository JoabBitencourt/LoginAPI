using System.ComponentModel.DataAnnotations;

namespace LoginAPI.Dtos
{
    public class CreateUserDto
    {
        [Required]
        public string Name { get; set; }

        public int? Age { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public int? Perfil { get; set; }
    }
}
