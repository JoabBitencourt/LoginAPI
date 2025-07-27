using LoginAPI.Data;
using LoginAPI.Models;
using LoginAPI.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LoginAPI.Repositories;

public class UserRepository : IUserRepository
{
    private readonly LoginContext _context;

    public UserRepository(LoginContext context)
    {
        _context = context;
    }
    public async Task<Models.User>? GetEmailAsync(string email)
    {
        var user = _context.Users
            .Include(u => u.Credentials)
            .FirstOrDefault(x => x.Email == email);
            return user;
    }

    public async Task CreateUserAsync(User user)
    {
        _context.Users.Add(user);
        await _context.SaveChangesAsync();
        
    }


}
