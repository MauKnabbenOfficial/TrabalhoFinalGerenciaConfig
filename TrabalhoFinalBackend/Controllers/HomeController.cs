using Microsoft.AspNetCore.Mvc;

namespace TrabalhoFinalBackend.Controllers;

[ApiController]
[Route("home")]
public class HomeController : Controller
{
    public HomeController() { }

    [HttpGet("Info")]
    public async Task<string> Info() => "Hello World!";
}
