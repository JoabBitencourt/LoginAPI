using System.ComponentModel.DataAnnotations;

namespace LoginAPI.Models;

public class UserCredentials
{
    [Key]
    public int UserId { get; set; }

    [Required]
    public string PasswordHash { get; set; }

    [Required]
    public string PasswordSalt { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    public User User { get; set; } = null!;
}
