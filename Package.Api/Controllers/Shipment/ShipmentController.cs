using Microsoft.AspNetCore.Mvc;
using Package.Infrastructure.Interfaces;
using Package.Infrastructure.Request;
using static Package.Infrastructure.DTO.DHL.Rate;

namespace Package.Api.Controllers;

[ApiController]
[Route("/Shipment")]
public class ShipmentController : ControllerBase
{
    private readonly IDHL _dhl;
    private readonly ILogger<ShipmentController> _logger;

    public ShipmentController(ILogger<ShipmentController> logger, IDHL dhl)
    {
        _logger = logger;
        _dhl = dhl;
    }


    [HttpPost(Name = "CreateShipment")]
    public async Task<IEnumerable<string>> Post(ShipmentRequest shipment)
    {
        await _dhl.CreateShipment(shipment);
        Console.WriteLine("Ya hice el llamado a la api");
        return new List<string>();
    }
}
