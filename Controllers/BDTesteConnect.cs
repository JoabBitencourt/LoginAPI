using LoginAPI.Data;
using Microsoft.AspNetCore.Mvc;

namespace LoginAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BDTesteConnect : Controller
{
    private readonly LoginContext _loginContext;

    public BDTesteConnect(LoginContext loginContext)
    {
        _loginContext = loginContext;
    }
    [HttpGet]
    public IActionResult TesteConn()
    {
        try
        {
            bool isConn = _loginContext.Database.CanConnect();
            if (isConn)

                return Ok("conectado ao banco de dados");
            else
                return StatusCode(500, "falha na conecção");
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Erro: {ex.Message} \n \n {ex.InnerException?.Message}");
        }
    }

}
