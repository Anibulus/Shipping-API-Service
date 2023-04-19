using Package.Infrastructure.Request;
using static Package.Infrastructure.DTO.DHL.Rate;

namespace Package.Infrastructure.Interfaces;

public interface IDHL
{
    #region Rating
    ///<summary>
    /// Retrieve Rates for Multi-piece Shipments
    ///</summary>
    Task<Root?> Rate(RateRequest rateRequest);

    ///<summary>
    /// Retrieve Rates for Multi-piece Shipments
    ///</summary>
    void Rates();

    ///<summary>
    /// Landed cost
    ///</summary>
    void LandedCost();
    #endregion
    #region Products
    ///<summary>
    /// Retrieve available DHL Express products for a one piece Shipment
    ///</summary>
    void Products();
    #endregion
    #region Shipments
    ///<summary>
    /// Electronic Proof of Delivery
    ///</summary>
    void RetrieveShipments(string shipmentTrackingNumber);

    ///<summary>
    /// Upload Paperless Trade shipment (PLT) images of previously created shipment.
    ///</summary>
    void UpdateShipmentImage(string shipmentTrackingNumber);

    ///<summary>
    /// Create Shipment
    ///</summary>
    Task CreateShipment(ShipmentRequest shipmentRequest);

    ///<summary>
    /// Upload Commercial Invoice data for your DHL Express shipment
    ///</summary>
    void UpdateShipmentInvoiceData(string shipmentTrackingNumber);

    ///<summary>
    /// Get Image
    ///</summary>
    void RetrieveShipmentImage(string shipmentTrackingNumber);
    #endregion
    #region Traking
    ///<summary>
    /// Track a single DHL Express Shipment
    ///</summary>
    void TrackShipment(string shipmentTrackingNumber);

    ///<summary>
    /// Track a single or multiple DHL Express Shipments
    ///</summary>
    void TrackShipments();
    #endregion
    #region Pickup
    ///<summary>
    /// Cancel a DHL Express pickup booking request
    ///</summary>
    void CancelPickup(string dispatchConfirmationNumber);

    ///<summary>
    /// Update pickup information for an existing DHL Express pickup booking request
    ///</summary>
    void UpdatePickup(string dispatchConfirmationNumber);

    ///<summary>
    /// Create a DHL Express pickup booking request
    ///</summary>
    void CreatePickup();
    #endregion
    #region Identifier
    ///<summary>
    /// Service to allocate identifiers upfront for DHL Express Breakbulk or Loose Break Bulk shipments
    ///</summary>
    void RetrieveIdentifiers();
    #endregion
    #region Address
    ///<summary>
    /// Validate DHL Express pickup/delivery capabilities at origin/destination
    ///</summary>
    void ValidateAddress();
    #endregion
    #region Invoice
    ///<summary>
    /// Upload Commercial invoice data
    ///</summary>
    void UploadInvoiceData();
    #endregion
}
