using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace LoginAPI.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int? Age { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        public int? Perfil { get; set; }

        [JsonIgnore]
        public required UserCredentials Credentials { get; set; }
    }
}
