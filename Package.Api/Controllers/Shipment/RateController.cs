using Microsoft.AspNetCore.Mvc;
using Package.Infrastructure.Interfaces;
using Package.Infrastructure.Request;
using static Package.Infrastructure.DTO.DHL.Rate;

namespace Package.Api.Controllers;

[Route("Rate/")]
[ApiController]
public class RateController : ControllerBase
{
    private readonly IDHL _dhl;
    private readonly ILogger<RateController> _logger;

    public RateController(ILogger<RateController> logger, IDHL dhl)
    {
        _logger = logger;
        _dhl = dhl;
    }

    [HttpGet(Name = "Rating")]
    public async Task<Root?> Rate(
        string accountNumber,
        string originCountryCode,
        string originCityName,
        string destinationCountryCode,
        string destinationCityName,
        double weight,
        double length,
        double width,
        double height,
        DateTime plannedShippingDate,
        string? originPostalCode = null,
        string? destinationPostalCode = null,
        bool isCustomsDeclarable = false,
        string unitOfMeasurement = "metric",
        bool nextBusinessDay = false,
        bool strictValidation = false,
        bool getAllValueAddedServices = false,
        bool requestEstimatedDeliveryDate = true,
        string estimatedDeliveryDateType = "QDDF"
    )
    {
        RateRequest rateRequest =
            new(
                accountNumber,
                originCountryCode,
                originCityName,
                destinationCountryCode,
                destinationCityName,
                weight,
                length,
                width,
                height,
                plannedShippingDate,
                originPostalCode,
                destinationPostalCode,
                isCustomsDeclarable,
                unitOfMeasurement,
                nextBusinessDay,
                strictValidation,
                getAllValueAddedServices,
                requestEstimatedDeliveryDate,
                estimatedDeliveryDateType
            );
        return await _dhl.Rate(rateRequest);
    }
}
