using System.Text.Json.Serialization;

namespace Package.Infrastructure.Request;

public class RateRequest
{
    public RateRequest()
    {
        this.accountNumber = "";
        this.originCountryCode = "";
        this.originCityName = "";
        this.destinationCountryCode = "";
        this.destinationCityName = "";
        this.weight = 0;
        this.length = 0;
        this.width = 0;
        this.height = 0;
        this.estimatedDeliveryDateType = "";
        this.unitOfMeasurement = "";
        this.plannedShippingDate = DateTime.UtcNow;
        this.requestEstimatedDeliveryDate = true;
        this.isCustomsDeclarable = false;
        this.nextBusinessDay = false;
        this.strictValidation = false;
        this.getAllValueAddedServices = false;
    }

    public RateRequest(
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
        this.accountNumber = accountNumber;
        this.originCountryCode = originCountryCode;
        this.originCityName = originCityName;
        this.destinationCountryCode = destinationCountryCode;
        this.destinationCityName = destinationCityName;
        this.weight = weight;
        this.length = length;
        this.width = width;
        this.height = height;
        this.estimatedDeliveryDateType = estimatedDeliveryDateType;
        this.unitOfMeasurement = unitOfMeasurement;
        this.plannedShippingDate = plannedShippingDate;
        this.requestEstimatedDeliveryDate = requestEstimatedDeliveryDate;
        this.isCustomsDeclarable = isCustomsDeclarable;
        this.nextBusinessDay = nextBusinessDay;
        this.strictValidation = strictValidation;
        this.getAllValueAddedServices = getAllValueAddedServices;
    }

    ///<summary>
    /// DHL Express customer account number
    ///</summary>
    public string accountNumber { get; set; }

    ///<summary>
    /// A short text string code (see values defined in ISO 3166) specifying the shipment origin country.
    ///</summary>
    public string originCountryCode { get; set; } //LINK https://gs1.org/voc/Country

    ///<summary>
    /// Text specifying the postal code for an address.
    ///</summary>
    public string? originPostalCode { get; set; } //LINK https://gs1.org/voc/postalCode

    ///<summary>
    /// Text specifying the city name
    ///</summary>
    public string originCityName { get; set; }

    ///<summary>
    /// A short text string code (see values defined in ISO 3166) specifying the shipment destination country.
    ///</summary>
    public string destinationCountryCode { get; set; }

    ///<summary>
    /// Text specifying the postal code for an address.
    ///</summary>
    public string? destinationPostalCode { get; set; }

    ///<summary>
    /// Text specifying the city name
    ///</summary>
    public string destinationCityName { get; set; }

    ///<summary>
    /// Gross weight of the shipment including packaging.
    ///</summary>
    public double weight { get; set; }
    [JsonIgnore]
    public string Weight { get{ return this.weight.ToString(); }}

    ///<summary>
    /// Total length of the shipment including packaging.
    ///</summary>
    public double length { get; set; }
    [JsonIgnore]
    public string Length { get{ return this.length.ToString(); }}

    ///<summary>
    /// Total width of the shipment including packaging.
    ///</summary>
    public double width { get; set; }
    [JsonIgnore]
    public string Width { get{ return this.width.ToString(); }}

    ///<summary>
    /// Total height of the shipment including packaging.
    ///</summary>
    public double height { get; set; }
    [JsonIgnore]
    public string Height { get{ return this.height.ToString(); }}

    ///<summary>
    /// Timestamp represents the date you plan to ship your prospected shipment
    ///</summary>
    public DateTime plannedShippingDate { get; set; }
    [JsonIgnore]
    public string PlannedShippingDate
    {
        get { return this.plannedShippingDate.ToString("yyyy-MM-dd"); }
    }
    public bool isCustomsDeclarable { get; set; }
    public string IsCustomsDeclarable { get{ return this.isCustomsDeclarable.ToString(); } }

    ///<summary>
    /// The UnitOfMeasurement node conveys the unit of measurements used in the operation. This single value corresponds to the units of weight and measurement which are used throughout the message processing.
    ///</summary>
    public string unitOfMeasurement { get; set; } //metric | imperial

    ///<summary>
    /// When set to true and there are no products available for given plannedShippingDate then products available for the next possible pickup date are returned
    ///</summary>
    public bool nextBusinessDay { get; set; }
    public string NextBusinessDay { get{ return this.nextBusinessDay.ToString(); } }

    ///<summary>
    /// If set to true, indicate strict DCT validation of address details, and validation of product and service(s) combination provided in request.
    ///</summary>
    public bool strictValidation { get; set; }
    public string StrictValidation { get{ return this.strictValidation.ToString(); } }

    ///<summary>
    /// Option to return list of all value added services and its rule groups if applicable
    ///</summary>
    public bool getAllValueAddedServices { get; set; }
    public string GetAllValueAddedServices { get{ return this.getAllValueAddedServices.ToString(); } }

    ///<summary>
    /// Option to return Estimated Delivery Date in response
    ///</summary>
    public bool requestEstimatedDeliveryDate { get; set; }
    public string RequestEstimatedDeliveryDate { get{ return this.requestEstimatedDeliveryDate.ToString(); } }

    ///<summary>
    /// Estimated Delivery Date Type. QDDF: is the fastest 'docs' transit time as quoted to the customer at booking or shipment creation. No custom clearance is considered. QDDC: constitutes DHL's service commitment as quoted at booking or shipment creation. QDDc builds in clearance time, and potentially other special perational non-transport component(s), when relevant.
    ///</summary>
    public string estimatedDeliveryDateType { get; set; } // QDDF | QDDC
}
