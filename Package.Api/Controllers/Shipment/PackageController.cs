using Microsoft.AspNetCore.Mvc;
using Package.Infrastructure.Interfaces;
using static Package.Infrastructure.DTO.DHL.Rate;

namespace Package.Api.Controllers;

[ApiController]
[Route("/Package")]
public class PackageController : ControllerBase
{
    private readonly IDHL  _dhl;
    private readonly ILogger<PackageController> _logger;

    public PackageController(ILogger<PackageController> logger, IDHL dhl)
    {
        _logger = logger;
        _dhl = dhl;
    }

    [HttpGet(Name = "Rating2")]
    public async Task<Root?> Get()
    {
       return await _dhl.Rate();
    }
    [HttpPost(Name = "Second")]
    public async Task<IEnumerable<string>> Post()
    {
        await _dhl.Rate();
        Console.WriteLine("Ya hice el llamado a la api");
       return new List<string>();
    }
}
