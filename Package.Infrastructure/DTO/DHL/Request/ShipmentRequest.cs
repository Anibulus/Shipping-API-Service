using System.Text.Json.Serialization;

namespace Package.Infrastructure.Request;

public class ShipmentRequest
{
    public DateTime? plannedShippingDateAndTime { get; set; }
    [JsonIgnore]
    public string? PlannedShippingDateAndTime
    {
        get { return this.plannedShippingDateAndTime.GetValueOrDefault().ToLongDateString(); }
    }
    public Pickup? pickup { get; set; }
    public string? productCode { get; set; }
    public string? localProductCode { get; set; }
    public bool? getRateEstimates { get; set; }
    public List<Account>? accounts { get; set; }
    public List<ValueAddedService>? valueAddedServices { get; set; }
    public OutputImageProperties? outputImageProperties { get; set; }
    public CustomerDetails? customerDetails { get; set; }
    public Content? content { get; set; }
    public List<ShipmentNotification>? shipmentNotification { get; set; }
    public bool? getTransliteratedResponse { get; set; }
    public EstimatedDeliveryDate? estimatedDeliveryDate { get; set; }
    public List<GetAdditionalInformation>? getAdditionalInformation { get; set; }

    public class Account
    {
        public string? typeCode { get; set; }
        public string? number { get; set; }
    }

    public class AdditionalCharge
    {
        public int? value { get; set; }
        public string? caption { get; set; }
        public string? typeCode { get; set; }
    }

    public class BankDetail
    {
        public string? name { get; set; }
        public string? settlementLocalCurrency { get; set; }
        public string? settlementForeignCurrency { get; set; }
    }

    public class CommodityCode
    {
        public string? typeCode { get; set; }
        public string? value { get; set; }
    }

    public class ContactInformation
    {
        public string? email { get; set; }
        public string? phone { get; set; }
        public string? mobilePhone { get; set; }
        public string? companyName { get; set; }
        public string? fullName { get; set; }
    }

    public class Content
    {
        public List<Package>? packages { get; set; }
        public bool? isCustomsDeclarable { get; set; }
        public int? declaredValue { get; set; }
        public string? declaredValueCurrency { get; set; }
        public ExportDeclaration? exportDeclaration { get; set; }
        public string? description { get; set; }
        public string? USFilingTypeValue { get; set; }
        public string? incoterm { get; set; }
        public string? unitOfMeasurement { get; set; }
    }

    public class CustomerDetails
    {
        public ShipperDetails? shipperDetails { get; set; }
        public ReceiverDetails? receiverDetails { get; set; }
    }

    public class CustomerReference
    {
        public string? value { get; set; }
        public string? typeCode { get; set; }
    }

    public class CustomsDocument
    {
        public string? typeCode { get; set; }
        public string? value { get; set; }
    }

    public class DeclarationNote
    {
        public string? value { get; set; }
    }

    public class Dimensions
    {
        public int? length { get; set; }
        public int? width { get; set; }
        public int? height { get; set; }
    }

    public class EstimatedDeliveryDate
    {
        public bool? isRequested { get; set; }
        public string? typeCode { get; set; }
    }

    public class ExportDeclaration
    {
        public List<LineItem>? lineItems { get; set; }
        public Invoice? invoice { get; set; }
        public List<Remark>? remarks { get; set; }
        public List<AdditionalCharge>? additionalCharges { get; set; }
        public string? destinationPortName { get; set; }
        public string? placeOfIncoterm { get; set; }
        public string? payerVATNumber { get; set; }
        public string? recipientReference { get; set; }
        public Exporter? exporter { get; set; }
        public string? packageMarks { get; set; }
        public List<DeclarationNote>? declarationNotes { get; set; }
        public string? exportReference { get; set; }
        public string? exportReason { get; set; }
        public string? exportReasonType { get; set; }
        public List<License>? licenses { get; set; }
        public string? shipmentType { get; set; }
        public List<CustomsDocument>? customsDocuments { get; set; }
    }

    public class Exporter
    {
        public string? id { get; set; }
        public string? code { get; set; }
    }

    public class GetAdditionalInformation
    {
        public string? typeCode { get; set; }
        public bool? isRequested { get; set; }
    }

    public class ImageOption
    {
        public string? typeCode { get; set; }
        public string? templateName { get; set; }
        public bool? isRequested { get; set; }
        public string? invoiceType { get; set; }
        public string? languageCode { get; set; }
        public string? languageCountryCode { get; set; }
        public bool? hideAccountNumber { get; set; }
        public int? numberOfCopies { get; set; }
        public bool? renderDHLLogo { get; set; }
        public bool? fitLabelsToA4 { get; set; }
    }

    public class IndicativeCustomsValues
    {
        public double? importCustomsDutyValue { get; set; }
        public double? importTaxesValue { get; set; }
    }

    public class Invoice
    {
        public string? number { get; set; }
        public string? date { get; set; }
        public List<string>? instructions { get; set; }
        public double? totalNetWeight { get; set; }
        public double? totalGrossWeight { get; set; }
        public List<CustomerReference>? customerReferences { get; set; }
        public string? termsOfPayment { get; set; }
        public IndicativeCustomsValues? indicativeCustomsValues { get; set; }
    }

    public class License
    {
        public string? typeCode { get; set; }
        public string? value { get; set; }
    }

    public class LineItem
    {
        public int? number { get; set; }
        public string? description { get; set; }
        public int? price { get; set; }
        public Quantity? quantity { get; set; }
        public List<CommodityCode>? commodityCodes { get; set; }
        public string? exportReasonType { get; set; }
        public string? manufacturerCountry { get; set; }
        public string? exportControlClassificationNumber { get; set; }
        //[JsonPropertyName("weight")]
        //public Weight? Weight { get; set; }
        public bool? isTaxesPaid { get; set; }
        public List<string>? additionalInformation { get; set; }
        public List<CustomerReference>? customerReferences { get; set; }
        public List<CustomsDocument>? customsDocuments { get; set; }
    }

    public class OutputImageProperties
    {
        public int? printerDPI { get; set; }
        public string? encodingFormat { get; set; }
        public List<ImageOption>? imageOptions { get; set; }
        public bool? splitTransportAndWaybillDocLabels { get; set; }
        public bool? allDocumentsInOneImage { get; set; }
        public bool? splitDocumentsByPages { get; set; }
        public bool? splitInvoiceAndReceipt { get; set; }
        public bool? receiptAndLabelsInOneImage { get; set; }
    }

    public class Package
    {
        public string? typeCode { get; set; }
        public double? weight { get; set; }
        public Dimensions? dimensions { get; set; }
        public List<CustomerReference>? customerReferences { get; set; }
        public string? description { get; set; }
        public string? labelDescription { get; set; }
    }

    public class Pickup
    {
        public bool? isRequested { get; set; }
    }

    public class PostalAddress
    {
        public string? postalCode { get; set; }
        public string? cityName { get; set; }
        public string? countryCode { get; set; }
        public string? addressLine1 { get; set; }
        public string? addressLine2 { get; set; }
        public string? addressLine3 { get; set; }
        public string? countyName { get; set; }
        public string? countryName { get; set; }
    }

    public class Quantity
    {
        public int? value { get; set; }
        public string? unitOfMeasurement { get; set; }
    }

    public class ReceiverDetails
    {
        public PostalAddress? postalAddress { get; set; }
        public ContactInformation? contactInformation { get; set; }
        public List<RegistrationNumber>? registrationNumbers { get; set; }
        public List<BankDetail>? bankDetails { get; set; }
        public string? typeCode { get; set; }
    }

    public class RegistrationNumber
    {
        public string? typeCode { get; set; }
        public string? number { get; set; }
        public string? issuerCountryCode { get; set; }
    }

    public class Remark
    {
        public string? value { get; set; }
    }

    public class ShipmentNotification
    {
        public string? typeCode { get; set; }
        public string? receiverId { get; set; }
        public string? languageCode { get; set; }
        public string? languageCountryCode { get; set; }
        public string? bespokeMessage { get; set; }
    }

    public class ShipperDetails
    {
        public PostalAddress? postalAddress { get; set; }
        public ContactInformation? contactInformation { get; set; }
        public List<RegistrationNumber>? registrationNumbers { get; set; }
        public List<BankDetail>? bankDetails { get; set; }
        public string? typeCode { get; set; }
    }

    public class ValueAddedService
    {
        public string? serviceCode { get; set; }
        public int? value { get; set; }
        public string? currency { get; set; }
    }

    public class Weight
    {
        public double? netValue { get; set; }
        public double? grossValue { get; set; }
    }
}
