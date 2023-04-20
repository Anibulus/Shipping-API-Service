using Microsoft.AspNetCore.Mvc;

namespace Package.Api.Controllers;

[ApiController]
[Route("/")]
public class HomeController : ControllerBase
{
    public HomeController()
    {

    }

    [HttpGet("Index")]
    public IActionResult Index()
    {
        return Redirect("/Swagger/index.html");
    }
}