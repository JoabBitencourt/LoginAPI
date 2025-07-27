using LoginAPI.Dtos;
using LoginAPI.Models;
using LoginAPI.Repositories.Interfaces;
using LoginAPI.Security;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoginAPI.Controllers;

[Authorize]
[ApiController]
[Route("api/user")]
public class UserController : Controller
{

    public readonly IUserRepository _userRepo;

    public UserController( IUserRepository userRepo)
        { _userRepo = userRepo; }

    [HttpPost]
    public IActionResult PostUser(CreateUserDto userPost)
    {
        var credentials = new UserCredentials
        {
            PasswordHash = PasswordHasher.Hash(userPost.Password),
            Email = userPost.Email,
            PasswordSalt = userPost.Password,
        };
        var newUser = new User {
            Name = userPost.Name,
            Email = userPost.Email,
            Perfil = 1,
            Credentials = credentials,
        };
        _userRepo.CreateUserAsync(newUser).Wait();
        if (newUser != null)
             return BadRequest(newUser.Name);
        return Ok(newUser);
    }


}
