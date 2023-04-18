using Microsoft.AspNetCore.Mvc;
using Package.Infrastructure.Interfaces;

namespace Package.Api.Controllers;

[ApiController]
[Route("/Shipment")]
public class ShipmentController : ControllerBase
{
    private readonly IDHL  _dhl;
    private readonly ILogger<ShipmentController> _logger;

    public ShipmentController(ILogger<ShipmentController> logger, IDHL dhl)
    {
        _logger = logger;
        _dhl = dhl;
    }

    [HttpGet(Name = "Rating")]
    public async Task<IEnumerable<string>> Get()
    {
        await _dhl.Rate();
        Console.WriteLine("Ya hice el llamado a la api");
       return new List<string>();
    }
    [HttpPost(Name = "Shipment")]
    public async Task<IEnumerable<string>> Post()
    {
        await _dhl.Rate();
        Console.WriteLine("Ya hice el llamado a la api");
       return new List<string>();
    }
}
