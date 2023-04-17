using Package.Infrastructure.Interfaces;

namespace Package.Infrastructure.Services;

public class DHL : IDHL
{
    string SINGLE_RATE = "/rates"; //GET

    public void CancelPickup(string dispatchConfirmationNumber)
    {
        throw new NotImplementedException();
    }

    public void CreatePackage()
    {
        throw new NotImplementedException();
    }

    public void CreateShipment(string shipmentTrackingNumber)
    {
        throw new NotImplementedException();
    }

    public void LandedCost()
    {
        throw new NotImplementedException();
    }

    public void Products()
    {
        throw new NotImplementedException();
    }

    //TODO Conectar todas las variables para la cotizacion
    public async Task Rate()
    {
        var client = new HttpClient();
        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri("https://api-mock.dhl.com/mydhlapi/rates?accountNumber=123456789&originCountryCode=CZ&originPostalCode=14800&originCityName=Prague&destinationCountryCode=CZ&destinationPostalCode=14800&destinationCityName=Prague&weight=5&length=15&width=10&height=5&plannedShippingDate=2020-02-26&isCustomsDeclarable=false&unitOfMeasurement=metric&nextBusinessDay=false&strictValidation=false&getAllValueAddedServices=false&requestEstimatedDeliveryDate=true&estimatedDeliveryDateType=QDDF"),
            //Definition RequestUri = new Uri("https://api-mock.dhl.com/mydhlapi/rates?accountNumber=SOME_STRING_VALUE&originCountryCode=SOME_STRING_VALUE&originCityName=SOME_STRING_VALUE&destinationCountryCode=SOME_STRING_VALUE&destinationCityName=SOME_STRING_VALUE&weight=SOME_NUMBER_VALUE&length=SOME_NUMBER_VALUE&width=SOME_NUMBER_VALUE&height=SOME_NUMBER_VALUE&plannedShippingDate=SOME_STRING_VALUE&isCustomsDeclarable=SOME_BOOLEAN_VALUE&unitOfMeasurement=SOME_STRING_VALUE"),
            Headers =
            {
                { "Message-Reference", "d0e7832e-5c98-11ea-bc55-0242ac13" },
                { "Message-Reference-Date", "Wed, 21 Oct 2015 07:28:00 GMT" }, //TODO set date
                { "Plugin-Name", "" },
                { "Plugin-Version", "" },
                { "Shipping-System-Platform-Name", "" },
                { "Shipping-System-Platform-Version", "" },
                { "Webstore-Platform-Name", "" },
                { "Webstore-Platform-Version", "" },
                { "Authorization", "Basic ZGVtby1rZXk6ZGVtby1zZWNyZXQ=" },
            },
        };
        using (var response = await client.SendAsync(request))
        {
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            Console.WriteLine("Response:");
            Console.WriteLine(body);
        }
    }

    public void Rates()
    {
        throw new NotImplementedException();
    }

    public void RetrieveIdentifiers()
    {
        throw new NotImplementedException();
    }

    public void RetrieveShipmentImage(string shipmentTrackingNumber)
    {
        throw new NotImplementedException();
    }

    public void RetrieveShipments(string shipmentTrackingNumber)
    {
        throw new NotImplementedException();
    }

    public void TrackShipment(string shipmentTrackingNumber)
    {
        throw new NotImplementedException();
    }

    public void TrackShipments()
    {
        throw new NotImplementedException();
    }

    public void UpdatePackage(string dispatchConfirmationNumber)
    {
        throw new NotImplementedException();
    }

    public void UpdateShipmentImage(string shipmentTrackingNumber)
    {
        throw new NotImplementedException();
    }

    public void UpdateShipmentInvoiceData(string shipmentTrackingNumber)
    {
        throw new NotImplementedException();
    }

    public void UploadInvoiceData()
    {
        throw new NotImplementedException();
    }

    public void ValidateAddress()
    {
        throw new NotImplementedException();
    }
}
