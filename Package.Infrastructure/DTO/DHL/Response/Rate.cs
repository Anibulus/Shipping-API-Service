namespace Package.Infrastructure.DTO.DHL;

public class Rate
{
    public class Breakdown
    {
        public string name { get; set; }
        public string serviceCode { get; set; }
        public string localServiceCode { get; set; }
        public string typeCode { get; set; }
        public string serviceTypeCode { get; set; }
        public int price { get; set; }
        public string priceCurrency { get; set; }
        public bool isCustomerAgreement { get; set; }
        public bool isMarketedService { get; set; }
        public bool isBillingServiceIndicator { get; set; }
        public List<PriceBreakdown> priceBreakdown { get; set; }
    }

    public class DeliveryCapabilities
    {
        public string deliveryTypeCode { get; set; }
        public DateTime estimatedDeliveryDateAndTime { get; set; }
        public string destinationServiceAreaCode { get; set; }
        public string destinationFacilityAreaCode { get; set; }
        public int deliveryAdditionalDays { get; set; }
        public int deliveryDayOfWeek { get; set; }
        public int totalTransitDays { get; set; }
    }

    public class DetailedPriceBreakdown
    {
        public string currencyType { get; set; }
        public string priceCurrency { get; set; }
        public List<Breakdown> breakdown { get; set; }
    }

    public class ExchangeRate
    {
        public double currentExchangeRate { get; set; }
        public string currency { get; set; }
        public string baseCurrency { get; set; }
    }

    public class Item
    {
        public int number { get; set; }
        public List<Breakdown> breakdown { get; set; }
    }

    public class PickupCapabilities
    {
        public bool nextBusinessDay { get; set; }
        public DateTime localCutoffDateAndTime { get; set; }
        public string GMTCutoffTime { get; set; }
        public string pickupEarliest { get; set; }
        public string pickupLatest { get; set; }
        public string originServiceAreaCode { get; set; }
        public string originFacilityAreaCode { get; set; }
        public int pickupAdditionalDays { get; set; }
        public int pickupDayOfWeek { get; set; }
    }

    public class PriceBreakdown
    {
        public string typeCode { get; set; }
        public double price { get; set; }
        public string priceType { get; set; }
        public int rate { get; set; }
        public int basePrice { get; set; }
    }

    public class Product
    {
        public string productName { get; set; }
        public string productCode { get; set; }
        public string localProductCode { get; set; }
        public string localProductCountryCode { get; set; }
        public string networkTypeCode { get; set; }
        public bool isCustomerAgreement { get; set; }
        public Weight weight { get; set; }
        public List<TotalPrice> totalPrice { get; set; }
        public List<TotalPriceBreakdown> totalPriceBreakdown { get; set; }
        public List<DetailedPriceBreakdown> detailedPriceBreakdown { get; set; }
        public PickupCapabilities pickupCapabilities { get; set; }
        public DeliveryCapabilities deliveryCapabilities { get; set; }
        public List<Item> items { get; set; }
        public string pricingDate { get; set; }
    }

    public class Root
    {
        public List<Product> products { get; set; }
        public List<ExchangeRate> exchangeRates { get; set; }
        public List<string> warnings { get; set; }
    }

    public class TotalPrice
    {
        public string currencyType { get; set; }
        public string priceCurrency { get; set; }
        public double price { get; set; }
    }

    public class TotalPriceBreakdown
    {
        public string currencyType { get; set; }
        public string priceCurrency { get; set; }
        public List<PriceBreakdown> priceBreakdown { get; set; }
    }

    public class Weight
    {
        public int volumetric { get; set; }
        public double provided { get; set; }
        public string unitOfMeasurement { get; set; }
    }
}