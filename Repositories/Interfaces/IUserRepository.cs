using LoginAPI.Models;

namespace LoginAPI.Repositories.Interfaces;

public interface IUserRepository
{
    Task<User?> GetEmailAsync(string email);
    Task CreateUserAsync(User user);

}
