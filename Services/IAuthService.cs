using LoginAPI.Dtos.Auth;

namespace LoginAPI.Services;

public interface IAuthService
{
    Task<LoginResponse> LoginAsync(LoginRequest request);
}
