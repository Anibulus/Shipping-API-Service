using Microsoft.AspNetCore.Mvc;
using Package.Infrastructure.Interfaces;

namespace Package.Api.Controllers;

[ApiController]
[Route("/")]
public class HomeController : ControllerBase
{
    private readonly IDHL  _dhl;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger, IDHL dhl)
    {
        _logger = logger;
        _dhl = dhl;
    }

    [HttpGet(Name = "PackageTest")]
    public async Task<IEnumerable<string>> Get()
    {
        await _dhl.Rate();
        Console.WriteLine("Ya hice el llamado a la api");
       return new List<string>();
    }
}
