using System.Web;
using Package.Infrastructure.Interfaces;
using static Package.Infrastructure.DTO.DHL.Rate;

namespace Package.Infrastructure.Services;

public class DHL : IDHL
{
    private readonly string URL;
    private readonly HttpClient _client;
    public DHL()
    {
        this.URL = Environment.GetEnvironmentVariable("DHL_URL") ?? "";
        this._client = new HttpClient();
    }

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
    public async Task<Root?> Rate()
    {
        Root? root = null;
        string uri = $@"{this.URL}/rates";
        var builder = new UriBuilder(uri);
        var query = HttpUtility.ParseQueryString(builder.Query);
        query["accountNumber"] = "123456789";
        query["originCountryCode"] = "CZ";
        query["originPostalCode"] = "14800";
        query["originCityName"] = "Prague";
        query["destinationCountryCode"] = "CZ";
        query["destinationPostalCode"] = "14800";
        query["destinationCityName"] = "Prague";
        query["weight"] = "5";
        query["length"] = "15";
        query["width"] = "10";
        query["height"] = "5";
        query["plannedShippingDate"] = "2020-02-26";
        query["isCustomsDeclarable"] = "false";
        query["unitOfMeasurement"] = "metric";
        query["nextBusinessDay"] = "false";
        query["strictValidation"] = "false";
        query["getAllValueAddedServices"] = "false";
        query["requestEstimatedDeliveryDate"] = "true";
        query["estimatedDeliveryDateType"] = "QDDF";
        builder.Query = query.ToString();
        uri = builder.ToString();

        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri(uri),
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
        using (var response = await _client.SendAsync(request))
        {
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            Console.WriteLine("Response:");
            Console.WriteLine(body);
            root = System.Text.Json.JsonSerializer.Deserialize<Root>(body);
        }
        return root;
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
