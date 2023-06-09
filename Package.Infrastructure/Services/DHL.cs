﻿using System.Net.Http.Headers;
using System.Web;
using System.Text.Json;
using Package.Infrastructure.Interfaces;
using Package.Infrastructure.Request;
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

    public void CreatePickup()
    {
        throw new NotImplementedException();
    }

    //TODO Añadir retorno y de data que incluya todas las respuestas y tambien usar el objeto como input de shipmentRequest
    public async Task CreateShipment(ShipmentRequest shipmentRequest)
    {
        string uri = $@"{this.URL}/shipments";

        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Post,
            RequestUri = new Uri(uri),
            Headers =
            {
                { "Message-Reference", "d0e7832e-5c98-11ea-bc55-0242ac13" },
                { "Message-Reference-Date", "Wed, 21 Oct 2015 07:28:00 GMT" },
                { "Plugin-Name", "" },
                { "Plugin-Version", "" },
                { "Shipping-System-Platform-Name", "" },
                { "Shipping-System-Platform-Version", "" },
                { "Webstore-Platform-Name", "" },
                { "Webstore-Platform-Version", "" },
                { "Authorization", "Basic ZGVtby1rZXk6ZGVtby1zZWNyZXQ=" },
            },
            //Content = new StringContent(JsonSerializer.Serialize(shipmentRequest))
            Content = new StringContent("{\"plannedShippingDateAndTime\":\"2019-08-04T14:00:31GMT+01:00\",\"pickup\":{\"isRequested\":false,\"closeTime\":\"18:00\",\"location\":\"reception\",\"specialInstructions\":[{\"value\":\"please ring door bell\",\"typeCode\":\"TBD\"}],\"pickupDetails\":{\"postalAddress\":{\"postalCode\":\"14800\",\"cityName\":\"Prague\",\"countryCode\":\"CZ\",\"provinceCode\":\"CZ\",\"addressLine1\":\"V Parku 2308/10\",\"addressLine2\":\"addres2\",\"addressLine3\":\"addres3\",\"countyName\":\"Central Bohemia\",\"provinceName\":\"Central Bohemia\",\"countryName\":\"Czech Republic\"},\"contactInformation\":{\"email\":\"that@before.de\",\"phone\":\"+1123456789\",\"mobilePhone\":\"+60112345678\",\"companyName\":\"Company Name\",\"fullName\":\"John Brew\"},\"registrationNumbers\":[{\"typeCode\":\"VAT\",\"number\":\"CZ123456789\",\"issuerCountryCode\":\"CZ\"}],\"bankDetails\":[{\"name\":\"Russian Bank Name\",\"settlementLocalCurrency\":\"RUB\",\"settlementForeignCurrency\":\"USD\"}],\"typeCode\":\"business\"},\"pickupRequestorDetails\":{\"postalAddress\":{\"postalCode\":\"14800\",\"cityName\":\"Prague\",\"countryCode\":\"CZ\",\"provinceCode\":\"CZ\",\"addressLine1\":\"V Parku 2308/10\",\"addressLine2\":\"addres2\",\"addressLine3\":\"addres3\",\"countyName\":\"Central Bohemia\",\"provinceName\":\"Central Bohemia\",\"countryName\":\"Czech Republic\"},\"contactInformation\":{\"email\":\"that@before.de\",\"phone\":\"+1123456789\",\"mobilePhone\":\"+60112345678\",\"companyName\":\"Company Name\",\"fullName\":\"John Brew\"},\"registrationNumbers\":[{\"typeCode\":\"VAT\",\"number\":\"CZ123456789\",\"issuerCountryCode\":\"CZ\"}],\"bankDetails\":[{\"name\":\"Russian Bank Name\",\"settlementLocalCurrency\":\"RUB\",\"settlementForeignCurrency\":\"USD\"}],\"typeCode\":\"business\"}},\"productCode\":\"D\",\"localProductCode\":\"D\",\"getRateEstimates\":false,\"accounts\":[{\"typeCode\":\"shipper\",\"number\":\"123456789\"}],\"valueAddedServices\":[{\"serviceCode\":\"II\",\"value\":100,\"currency\":\"GBP\",\"method\":\"cash\",\"dangerousGoods\":[{\"contentId\":\"908\",\"dryIceTotalNetWeight\":12,\"customDescription\":\"1 package Lithium ion batteries in compliance with Section II of P.I. 9661\",\"unCodes\":[1234]}]}],\"outputImageProperties\":{\"printerDPI\":300,\"customerBarcodes\":[{\"content\":\"barcode content\",\"textBelowBarcode\":\"text below barcode\",\"symbologyCode\":\"93\"}],\"customerLogos\":[{\"fileFormat\":\"PNG\",\"content\":\"base64 encoded image\"}],\"encodingFormat\":\"pdf\",\"imageOptions\":[{\"typeCode\":\"label\",\"templateName\":\"ECOM26_84_001\",\"isRequested\":true,\"hideAccountNumber\":false,\"numberOfCopies\":1,\"invoiceType\":\"commercial\",\"languageCode\":\"eng\",\"languageCountryCode\":\"br\",\"encodingFormat\":\"png\",\"renderDHLLogo\":false,\"fitLabelsToA4\":false,\"labelFreeText\":\"string\",\"labelCustomerDataText\":\"string\"}],\"splitTransportAndWaybillDocLabels\":true,\"allDocumentsInOneImage\":true,\"splitDocumentsByPages\":true,\"splitInvoiceAndReceipt\":true,\"receiptAndLabelsInOneImage\":true},\"customerReferences\":[{\"value\":\"Customer reference\",\"typeCode\":\"CU\"}],\"identifiers\":[{\"typeCode\":\"shipmentId\",\"value\":\"1234567890\",\"dataIdentifier\":\"00\"}],\"customerDetails\":{\"shipperDetails\":{\"postalAddress\":{\"postalCode\":\"14800\",\"cityName\":\"Prague\",\"countryCode\":\"CZ\",\"provinceCode\":\"CZ\",\"addressLine1\":\"V Parku 2308/10\",\"addressLine2\":\"addres2\",\"addressLine3\":\"addres3\",\"countyName\":\"Central Bohemia\",\"provinceName\":\"Central Bohemia\",\"countryName\":\"Czech Republic\"},\"contactInformation\":{\"email\":\"that@before.de\",\"phone\":\"+1123456789\",\"mobilePhone\":\"+60112345678\",\"companyName\":\"Company Name\",\"fullName\":\"John Brew\"},\"registrationNumbers\":[{\"typeCode\":\"VAT\",\"number\":\"CZ123456789\",\"issuerCountryCode\":\"CZ\"}],\"bankDetails\":[{\"name\":\"Russian Bank Name\",\"settlementLocalCurrency\":\"RUB\",\"settlementForeignCurrency\":\"USD\"}],\"typeCode\":\"business\"},\"receiverDetails\":{\"postalAddress\":{\"postalCode\":\"14800\",\"cityName\":\"Prague\",\"countryCode\":\"CZ\",\"provinceCode\":\"CZ\",\"addressLine1\":\"V Parku 2308/10\",\"addressLine2\":\"addres2\",\"addressLine3\":\"addres3\",\"countyName\":\"Central Bohemia\",\"provinceName\":\"Central Bohemia\",\"countryName\":\"Czech Republic\"},\"contactInformation\":{\"email\":\"that@before.de\",\"phone\":\"+1123456789\",\"mobilePhone\":\"+60112345678\",\"companyName\":\"Company Name\",\"fullName\":\"John Brew\"},\"registrationNumbers\":[{\"typeCode\":\"VAT\",\"number\":\"CZ123456789\",\"issuerCountryCode\":\"CZ\"}],\"bankDetails\":[{\"name\":\"Russian Bank Name\",\"settlementLocalCurrency\":\"RUB\",\"settlementForeignCurrency\":\"USD\"}],\"typeCode\":\"business\"},\"buyerDetails\":{\"postalAddress\":{\"postalCode\":\"14800\",\"cityName\":\"Prague\",\"countryCode\":\"CZ\",\"provinceCode\":\"CZ\",\"addressLine1\":\"V Parku 2308/10\",\"addressLine2\":\"addres2\",\"addressLine3\":\"addres3\",\"countyName\":\"Central Bohemia\",\"provinceName\":\"Central Bohemia\",\"countryName\":\"Czech Republic\"},\"contactInformation\":{\"email\":\"buyer@domain.com\",\"phone\":\"+44123456789\",\"mobilePhone\":\"+42123456789\",\"companyName\":\"Customer Company Name\",\"fullName\":\"Mark Companer\"},\"registrationNumbers\":[{\"typeCode\":\"VAT\",\"number\":\"CZ123456789\",\"issuerCountryCode\":\"CZ\"}],\"bankDetails\":[{\"name\":\"Russian Bank Name\",\"settlementLocalCurrency\":\"RUB\",\"settlementForeignCurrency\":\"USD\"}],\"typeCode\":\"business\"},\"importerDetails\":{\"postalAddress\":{\"postalCode\":\"14800\",\"cityName\":\"Prague\",\"countryCode\":\"CZ\",\"provinceCode\":\"CZ\",\"addressLine1\":\"V Parku 2308/10\",\"addressLine2\":\"addres2\",\"addressLine3\":\"addres3\",\"countyName\":\"Central Bohemia\",\"provinceName\":\"Central Bohemia\",\"countryName\":\"Czech Republic\"},\"contactInformation\":{\"email\":\"that@before.de\",\"phone\":\"+1123456789\",\"mobilePhone\":\"+60112345678\",\"companyName\":\"Company Name\",\"fullName\":\"John Brew\"},\"registrationNumbers\":[{\"typeCode\":\"VAT\",\"number\":\"CZ123456789\",\"issuerCountryCode\":\"CZ\"}],\"bankDetails\":[{\"name\":\"Russian Bank Name\",\"settlementLocalCurrency\":\"RUB\",\"settlementForeignCurrency\":\"USD\"}],\"typeCode\":\"business\"},\"exporterDetails\":{\"postalAddress\":{\"postalCode\":\"14800\",\"cityName\":\"Prague\",\"countryCode\":\"CZ\",\"provinceCode\":\"CZ\",\"addressLine1\":\"V Parku 2308/10\",\"addressLine2\":\"addres2\",\"addressLine3\":\"addres3\",\"countyName\":\"Central Bohemia\",\"provinceName\":\"Central Bohemia\",\"countryName\":\"Czech Republic\"},\"contactInformation\":{\"email\":\"that@before.de\",\"phone\":\"+1123456789\",\"mobilePhone\":\"+60112345678\",\"companyName\":\"Company Name\",\"fullName\":\"John Brew\"},\"registrationNumbers\":[{\"typeCode\":\"VAT\",\"number\":\"CZ123456789\",\"issuerCountryCode\":\"CZ\"}],\"bankDetails\":[{\"name\":\"Russian Bank Name\",\"settlementLocalCurrency\":\"RUB\",\"settlementForeignCurrency\":\"USD\"}],\"typeCode\":\"business\"},\"sellerDetails\":{\"postalAddress\":{\"postalCode\":\"14800\",\"cityName\":\"Prague\",\"countryCode\":\"CZ\",\"provinceCode\":\"CZ\",\"addressLine1\":\"V Parku 2308/10\",\"addressLine2\":\"addres2\",\"addressLine3\":\"addres3\",\"countyName\":\"Central Bohemia\",\"provinceName\":\"Central Bohemia\",\"countryName\":\"Czech Republic\"},\"contactInformation\":{\"email\":\"that@before.de\",\"phone\":\"+1123456789\",\"mobilePhone\":\"+60112345678\",\"companyName\":\"Company Name\",\"fullName\":\"John Brew\"},\"registrationNumbers\":[{\"typeCode\":\"VAT\",\"number\":\"CZ123456789\",\"issuerCountryCode\":\"CZ\"}],\"bankDetails\":[{\"name\":\"Russian Bank Name\",\"settlementLocalCurrency\":\"RUB\",\"settlementForeignCurrency\":\"USD\"}],\"typeCode\":\"business\"},\"payerDetails\":{\"postalAddress\":{\"postalCode\":\"14800\",\"cityName\":\"Prague\",\"countryCode\":\"CZ\",\"provinceCode\":\"CZ\",\"addressLine1\":\"V Parku 2308/10\",\"addressLine2\":\"addres2\",\"addressLine3\":\"addres3\",\"countyName\":\"Central Bohemia\",\"provinceName\":\"Central Bohemia\",\"countryName\":\"Czech Republic\"},\"contactInformation\":{\"email\":\"that@before.de\",\"phone\":\"+1123456789\",\"mobilePhone\":\"+60112345678\",\"companyName\":\"Company Name\",\"fullName\":\"John Brew\"},\"registrationNumbers\":[{\"typeCode\":\"VAT\",\"number\":\"CZ123456789\",\"issuerCountryCode\":\"CZ\"}],\"bankDetails\":[{\"name\":\"Russian Bank Name\",\"settlementLocalCurrency\":\"RUB\",\"settlementForeignCurrency\":\"USD\"}],\"typeCode\":\"business\"},\"ultimateConsigneeDetails\":{\"postalAddress\":{\"postalCode\":\"14800\",\"cityName\":\"Prague\",\"countryCode\":\"CZ\",\"provinceCode\":\"CZ\",\"addressLine1\":\"V Parku 2308/10\",\"addressLine2\":\"addres2\",\"addressLine3\":\"addres3\",\"countyName\":\"Central Bohemia\",\"provinceName\":\"Central Bohemia\",\"countryName\":\"Czech Republic\"},\"contactInformation\":{\"email\":\"that@before.de\",\"phone\":\"+1123456789\",\"mobilePhone\":\"+60112345678\",\"companyName\":\"Company Name\",\"fullName\":\"John Brew\"},\"registrationNumbers\":[{\"typeCode\":\"VAT\",\"number\":\"CZ123456789\",\"issuerCountryCode\":\"CZ\"}],\"bankDetails\":{\"typeCode\":\"VAT\",\"number\":\"CZ123456789\",\"issuerCountryCode\":\"CZ\"},\"typeCode\":\"string\"}},\"content\":{\"packages\":[{\"typeCode\":\"2BP\",\"weight\":22.501,\"dimensions\":{\"length\":15.001,\"width\":15.001,\"height\":40.001},\"customerReferences\":[{\"value\":\"Customer reference\",\"typeCode\":\"CU\"}],\"identifiers\":[{\"typeCode\":\"shipmentId\",\"value\":\"1234567890\",\"dataIdentifier\":\"00\"}],\"description\":\"Piece content description\",\"labelBarcodes\":[{\"position\":\"left\",\"symbologyCode\":\"93\",\"content\":\"string\",\"textBelowBarcode\":\"text below left barcode\"}],\"labelText\":[{\"position\":\"left\",\"caption\":\"text caption\",\"value\":\"text value\"}],\"labelDescription\":\"bespoke label description\"}],\"isCustomsDeclarable\":true,\"declaredValue\":150,\"declaredValueCurrency\":\"CZK\",\"exportDeclaration\":{\"lineItems\":[{\"number\":1,\"description\":\"line item description\",\"price\":150,\"quantity\":{\"value\":1,\"unitOfMeasurement\":\"BOX\"},\"commodityCodes\":[{\"typeCode\":\"outbound\",\"value\":851713}],\"exportReasonType\":\"permanent\",\"manufacturerCountry\":\"CZ\",\"exportControlClassificationNumber\":\"US123456789\",\"weight\":{\"netValue\":10,\"grossValue\":10},\"isTaxesPaid\":true,\"additionalInformation\":[\"string\"],\"customerReferences\":[{\"typeCode\":\"AFE\",\"value\":\"custref123\"}],\"customsDocuments\":[{\"typeCode\":\"972\",\"value\":\"custdoc456\"}]}],\"invoice\":{\"number\":\"12345-ABC\",\"date\":\"2020-03-18\",\"signatureName\":\"Brewer\",\"signatureTitle\":\"Mr.\",\"signatureImage\":\"Base64 encoded image\",\"instructions\":[\"string\"],\"customerDataTextEntries\":[\"string\"],\"totalNetWeight\":999999999999,\"totalGrossWeight\":999999999999,\"customerReferences\":[{\"typeCode\":\"CU\",\"value\":\"custref112\"}],\"termsOfPayment\":\"100 days\",\"indicativeCustomsValues\":{\"importCustomsDutyValue\":150.57,\"importTaxesValue\":49.43}},\"remarks\":[{\"value\":\"declaration remark\"}],\"additionalCharges\":[{\"value\":10,\"caption\":\"fee\",\"typeCode\":\"freight\"}],\"destinationPortName\":\"port details\",\"placeOfIncoterm\":\"port of departure or destination details\",\"payerVATNumber\":\"12345ED\",\"recipientReference\":\"recipient reference\",\"exporter\":{\"id\":\"123\",\"code\":\"EXPCZ\"},\"packageMarks\":\"marks\",\"declarationNotes\":[{\"value\":\"up to three declaration notes\"}],\"exportReference\":\"export reference\",\"exportReason\":\"export reason\",\"exportReasonType\":\"permanent\",\"licenses\":[{\"typeCode\":\"export\",\"value\":\"license\"}],\"shipmentType\":\"personal\",\"customsDocuments\":[{\"typeCode\":\"972\",\"value\":\"custdoc445\"}]},\"description\":\"shipment description\",\"USFilingTypeValue\":\"12345\",\"incoterm\":\"DAP\",\"unitOfMeasurement\":\"metric\"},\"documentImages\":[{\"typeCode\":\"INV\",\"imageFormat\":\"PDF\",\"content\":\"base64 encoded image\"}],\"onDemandDelivery\":{\"deliveryOption\":\"servicepoint\",\"location\":\"front door\",\"specialInstructions\":\"ringe twice\",\"gateCode\":\"1234\",\"whereToLeave\":\"concierge\",\"neighbourName\":\"Mr.Dan\",\"neighbourHouseNumber\":\"777\",\"authorizerName\":\"Newman\",\"servicePointId\":\"SPL123\",\"requestedDeliveryDate\":\"2020-04-20\"},\"requestOndemandDeliveryURL\":false,\"shipmentNotification\":[{\"typeCode\":\"email\",\"receiverId\":\"receiver@email.com\",\"languageCode\":\"eng\",\"languageCountryCode\":\"UK\",\"bespokeMessage\":\"message to be included in the notification\"}],\"prepaidCharges\":[{\"typeCode\":\"freight\",\"currency\":\"CZK\",\"value\":200,\"method\":\"cash\"}],\"getTransliteratedResponse\":false,\"estimatedDeliveryDate\":{\"isRequested\":false,\"typeCode\":\"QDDC\"},\"getAdditionalInformation\":[{\"typeCode\":\"pickupDetails\",\"isRequested\":true}],\"parentShipment\":{\"productCode\":\"s\",\"packagesCount\":1}}")
            {
                Headers =
                {
                    ContentType = new MediaTypeHeaderValue("application/json")
                }
            }
        };
        using (var response = await _client.SendAsync(request))
        {
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();
            Console.WriteLine(body);
        }
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
    public async Task<Root?> Rate(RateRequest rateRequest)
    {
        Root? root = null;
        string uri = $@"{this.URL}/rates";
        var builder = new UriBuilder(uri);
        var query = HttpUtility.ParseQueryString(builder.Query);
        query["accountNumber"] = rateRequest.accountNumber; // "123456789";
        query["originCountryCode"] = rateRequest.originCountryCode; // "CZ";
        query["originPostalCode"] = rateRequest.originPostalCode; // "14800";
        query["originCityName"] = rateRequest.originCityName; // "Prague";
        query["destinationCountryCode"] = rateRequest.destinationCountryCode; // "CZ";
        query["destinationPostalCode"] = rateRequest.destinationPostalCode; // "14800";
        query["destinationCityName"] = rateRequest.destinationCityName; // "Prague";
        query["weight"] = rateRequest.Weight; // "5";
        query["length"] = rateRequest.Length; // "15";
        query["width"] = rateRequest.Width; // "10";
        query["height"] = rateRequest.Height; // "5";
        query["plannedShippingDate"] = rateRequest.PlannedShippingDate; // "2020-02-26";
        query["isCustomsDeclarable"] = rateRequest.IsCustomsDeclarable; // "false";
        query["unitOfMeasurement"] = rateRequest.unitOfMeasurement; // "metric";
        query["nextBusinessDay"] = rateRequest.NextBusinessDay; // "false";
        query["strictValidation"] = rateRequest.StrictValidation; // "false";
        query["getAllValueAddedServices"] = rateRequest.GetAllValueAddedServices; // "false";
        query["requestEstimatedDeliveryDate"] = rateRequest.RequestEstimatedDeliveryDate; // "true";
        query["estimatedDeliveryDateType"] = rateRequest.estimatedDeliveryDateType; // "QDDF";
        builder.Query = query.ToString();
        uri = builder.ToString();

        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri(uri),
            Headers =
            {
                { "Message-Reference", "d0e7832e-5c98-11ea-bc55-0242ac13" }, // TODO set message reference
                { "Message-Reference-Date", "Wed, 21 Oct 2015 07:28:00 GMT" }, //TODO set date
                { "Plugin-Name", "" },
                { "Plugin-Version", "" },
                { "Shipping-System-Platform-Name", "" },
                { "Shipping-System-Platform-Version", "" },
                { "Webstore-Platform-Name", "" },
                { "Webstore-Platform-Version", "" },
                { "Authorization", "Basic ZGVtby1rZXk6ZGVtby1zZWNyZXQ=" }, //TODO conect authentication
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

    public void UpdatePickup(string dispatchConfirmationNumber)
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
