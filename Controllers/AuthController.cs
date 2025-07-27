using LoginAPI.Dtos.Auth;
using LoginAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace LoginAPI.Controllers;

[Route("/api/login")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }
    [HttpPost]
    public async Task<IActionResult> GenerateToken(LoginRequest login) 
    {
        var response = await _authService.LoginAsync(login);
        if (response == null)
        {
            return NotFound();
        }
        return Ok(response);
    }


}
