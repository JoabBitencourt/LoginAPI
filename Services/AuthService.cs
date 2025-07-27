using LoginAPI.Dtos.Auth;
using LoginAPI.Repositories.Interfaces;
using LoginAPI.Security;
using System.Text;

namespace LoginAPI.Services;

public class AuthService : IAuthService
{
    private readonly TokenService _tokenService;
    private readonly IUserRepository _userRepository;
    public AuthService(IUserRepository userRepository, TokenService tokenService)
    {
        _tokenService = tokenService;
        _userRepository = userRepository;
    }

    public async Task<LoginResponse> LoginAsync(LoginRequest request)
    {
        var user = await _userRepository.GetEmailAsync(request.Email);
        if (user == null || !PasswordHasher.Verify(request.Password, user.Credentials.PasswordHash))
            throw new UnauthorizedAccessException("Invalid credentials");
        var response = new LoginResponse
        {
            Token = _tokenService.Generate(user),
            Email = request.Email,
            Name = user.Name
        };
        return response;
    }
}
