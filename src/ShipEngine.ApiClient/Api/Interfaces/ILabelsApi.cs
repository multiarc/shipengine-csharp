using System;
using System.Threading.Tasks;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace ShipEngine.ApiClient.Api.Interfaces
{
    /// <summary>
    ///     Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ILabelsApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        ///     Get a specific Label
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="labelId">Label ID</param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Label</returns>
        Label LabelsGet(string labelId, string apiKey);

        /// <summary>
        ///     Get a specific Label
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="labelId">Label ID</param>
        /// <param name="apiKey">API Key</param>
        /// <returns>ApiResponse of Label</returns>
        ApiResponse<Label> LabelsGetWithHttpInfo(string labelId, string apiKey);

        /// <summary>
        ///     Get labels
        /// </summary>
        /// <remarks>
        ///     Get a list of labels using optional criteria
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">API Key</param>
        /// <param name="batchId">Batch ID (optional)</param>
        /// <param name="labelStatus"> (optional)</param>
        /// <param name="carrierId">Carrier ID (optional)</param>
        /// <param name="serviceCode"> (optional)</param>
        /// <param name="trackingNumber">Tracking Number (optional)</param>
        /// <param name="warehouseId">Warehouse ID (optional)</param>
        /// <param name="createdAtStart">Create date range start (optional)</param>
        /// <param name="createdAtEnd">Create date range end (optional)</param>
        /// <param name="page">Page number (optional)</param>
        /// <param name="pageSize">Number of records per page (optional)</param>
        /// <param name="sortDir">Sort direction (optional)</param>
        /// <param name="sortBy">Sort by item (optional)</param>
        /// <returns>ListLabelResponse</returns>
        ListLabelResponse LabelsList(string apiKey, string batchId = null, string labelStatus = null,
            string carrierId = null, string serviceCode = null, string trackingNumber = null, string warehouseId = null,
            DateTime? createdAtStart = null, DateTime? createdAtEnd = null, int? page = null, int? pageSize = null,
            string sortDir = null, string sortBy = null);

        /// <summary>
        ///     Get labels
        /// </summary>
        /// <remarks>
        ///     Get a list of labels using optional criteria
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">API Key</param>
        /// <param name="batchId">Batch ID (optional)</param>
        /// <param name="labelStatus"> (optional)</param>
        /// <param name="carrierId">Carrier ID (optional)</param>
        /// <param name="serviceCode"> (optional)</param>
        /// <param name="trackingNumber">Tracking Number (optional)</param>
        /// <param name="warehouseId">Warehouse ID (optional)</param>
        /// <param name="createdAtStart">Create date range start (optional)</param>
        /// <param name="createdAtEnd">Create date range end (optional)</param>
        /// <param name="page">Page number (optional)</param>
        /// <param name="pageSize">Number of records per page (optional)</param>
        /// <param name="sortDir">Sort direction (optional)</param>
        /// <param name="sortBy">Sort by item (optional)</param>
        /// <returns>ApiResponse of ListLabelResponse</returns>
        ApiResponse<ListLabelResponse> LabelsListWithHttpInfo(string apiKey, string batchId = null,
            string labelStatus = null, string carrierId = null, string serviceCode = null, string trackingNumber = null,
            string warehouseId = null, DateTime? createdAtStart = null, DateTime? createdAtEnd = null, int? page = null,
            int? pageSize = null, string sortDir = null, string sortBy = null);

        /// <summary>
        ///     Purchase a label by providing full shipment info
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Label</returns>
        Label LabelsPurchaseLabel(PurchaseLabelRequest request, string apiKey);

        /// <summary>
        ///     Purchase a label by providing full shipment info
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>ApiResponse of Label</returns>
        ApiResponse<Label> LabelsPurchaseLabelWithHttpInfo(PurchaseLabelRequest request, string apiKey);

        /// <summary>
        ///     Purchase a label using a rate
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="rateId"></param>
        /// <param name="request"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Label</returns>
        Label LabelsPurchaseLabelWithRate(string rateId, PurchaseLabelWithoutShipmentRequest request, string apiKey);

        /// <summary>
        ///     Purchase a label using a rate
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="rateId"></param>
        /// <param name="request"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>ApiResponse of Label</returns>
        ApiResponse<Label> LabelsPurchaseLabelWithRateWithHttpInfo(string rateId,
            PurchaseLabelWithoutShipmentRequest request, string apiKey);

        /// <summary>
        ///     Purchase a label using an existing shipment
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId"></param>
        /// <param name="request"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Label</returns>
        Label LabelsPurchaseLabelWithShipment(string shipmentId, PurchaseLabelWithoutShipmentRequest request,
            string apiKey);

        /// <summary>
        ///     Purchase a label using an existing shipment
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId"></param>
        /// <param name="request"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>ApiResponse of Label</returns>
        ApiResponse<Label> LabelsPurchaseLabelWithShipmentWithHttpInfo(string shipmentId,
            PurchaseLabelWithoutShipmentRequest request, string apiKey);

        /// <summary>
        ///     Get tracking information for a label
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="labelId"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>TrackingInformation</returns>
        TrackingInformation LabelsTrack(string labelId, string apiKey);

        /// <summary>
        ///     Get tracking information for a label
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="labelId"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>ApiResponse of TrackingInformation</returns>
        ApiResponse<TrackingInformation> LabelsTrackWithHttpInfo(string labelId, string apiKey);

        /// <summary>
        ///     Void a label
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="labelId">Label ID</param>
        /// <param name="apiKey">API Key</param>
        /// <returns>VoidLabelResponse</returns>
        VoidLabelResponse LabelsVoidLabel(string labelId, string apiKey);

        /// <summary>
        ///     Void a label
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="labelId">Label ID</param>
        /// <param name="apiKey">API Key</param>
        /// <returns>ApiResponse of VoidLabelResponse</returns>
        ApiResponse<VoidLabelResponse> LabelsVoidLabelWithHttpInfo(string labelId, string apiKey);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        ///     Get a specific Label
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="labelId">Label ID</param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of Label</returns>
        Task<Label> LabelsGetAsync(string labelId, string apiKey);

        /// <summary>
        ///     Get a specific Label
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="labelId">Label ID</param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of ApiResponse (Label)</returns>
        Task<ApiResponse<Label>> LabelsGetAsyncWithHttpInfo(string labelId, string apiKey);

        /// <summary>
        ///     Get labels
        /// </summary>
        /// <remarks>
        ///     Get a list of labels using optional criteria
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">API Key</param>
        /// <param name="batchId">Batch ID (optional)</param>
        /// <param name="labelStatus"> (optional)</param>
        /// <param name="carrierId">Carrier ID (optional)</param>
        /// <param name="serviceCode"> (optional)</param>
        /// <param name="trackingNumber">Tracking Number (optional)</param>
        /// <param name="warehouseId">Warehouse ID (optional)</param>
        /// <param name="createdAtStart">Create date range start (optional)</param>
        /// <param name="createdAtEnd">Create date range end (optional)</param>
        /// <param name="page">Page number (optional)</param>
        /// <param name="pageSize">Number of records per page (optional)</param>
        /// <param name="sortDir">Sort direction (optional)</param>
        /// <param name="sortBy">Sort by item (optional)</param>
        /// <returns>Task of ListLabelResponse</returns>
        Task<ListLabelResponse> LabelsListAsync(string apiKey, string batchId = null, string labelStatus = null,
            string carrierId = null, string serviceCode = null, string trackingNumber = null, string warehouseId = null,
            DateTime? createdAtStart = null, DateTime? createdAtEnd = null, int? page = null, int? pageSize = null,
            string sortDir = null, string sortBy = null);

        /// <summary>
        ///     Get labels
        /// </summary>
        /// <remarks>
        ///     Get a list of labels using optional criteria
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">API Key</param>
        /// <param name="batchId">Batch ID (optional)</param>
        /// <param name="labelStatus"> (optional)</param>
        /// <param name="carrierId">Carrier ID (optional)</param>
        /// <param name="serviceCode"> (optional)</param>
        /// <param name="trackingNumber">Tracking Number (optional)</param>
        /// <param name="warehouseId">Warehouse ID (optional)</param>
        /// <param name="createdAtStart">Create date range start (optional)</param>
        /// <param name="createdAtEnd">Create date range end (optional)</param>
        /// <param name="page">Page number (optional)</param>
        /// <param name="pageSize">Number of records per page (optional)</param>
        /// <param name="sortDir">Sort direction (optional)</param>
        /// <param name="sortBy">Sort by item (optional)</param>
        /// <returns>Task of ApiResponse (ListLabelResponse)</returns>
        Task<ApiResponse<ListLabelResponse>> LabelsListAsyncWithHttpInfo(string apiKey, string batchId = null,
            string labelStatus = null, string carrierId = null, string serviceCode = null, string trackingNumber = null,
            string warehouseId = null, DateTime? createdAtStart = null, DateTime? createdAtEnd = null, int? page = null,
            int? pageSize = null, string sortDir = null, string sortBy = null);

        /// <summary>
        ///     Purchase a label by providing full shipment info
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of Label</returns>
        Task<Label> LabelsPurchaseLabelAsync(PurchaseLabelRequest request, string apiKey);

        /// <summary>
        ///     Purchase a label by providing full shipment info
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of ApiResponse (Label)</returns>
        Task<ApiResponse<Label>> LabelsPurchaseLabelAsyncWithHttpInfo(PurchaseLabelRequest request, string apiKey);

        /// <summary>
        ///     Purchase a label using a rate
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="rateId"></param>
        /// <param name="request"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of Label</returns>
        Task<Label> LabelsPurchaseLabelWithRateAsync(string rateId, PurchaseLabelWithoutShipmentRequest request,
            string apiKey);

        /// <summary>
        ///     Purchase a label using a rate
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="rateId"></param>
        /// <param name="request"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of ApiResponse (Label)</returns>
        Task<ApiResponse<Label>> LabelsPurchaseLabelWithRateAsyncWithHttpInfo(string rateId,
            PurchaseLabelWithoutShipmentRequest request, string apiKey);

        /// <summary>
        ///     Purchase a label using an existing shipment
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId"></param>
        /// <param name="request"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of Label</returns>
        Task<Label> LabelsPurchaseLabelWithShipmentAsync(string shipmentId, PurchaseLabelWithoutShipmentRequest request,
            string apiKey);

        /// <summary>
        ///     Purchase a label using an existing shipment
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId"></param>
        /// <param name="request"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of ApiResponse (Label)</returns>
        Task<ApiResponse<Label>> LabelsPurchaseLabelWithShipmentAsyncWithHttpInfo(string shipmentId,
            PurchaseLabelWithoutShipmentRequest request, string apiKey);

        /// <summary>
        ///     Get tracking information for a label
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="labelId"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of TrackingInformation</returns>
        Task<TrackingInformation> LabelsTrackAsync(string labelId, string apiKey);

        /// <summary>
        ///     Get tracking information for a label
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="labelId"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of ApiResponse (TrackingInformation)</returns>
        Task<ApiResponse<TrackingInformation>> LabelsTrackAsyncWithHttpInfo(string labelId, string apiKey);

        /// <summary>
        ///     Void a label
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="labelId">Label ID</param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of VoidLabelResponse</returns>
        Task<VoidLabelResponse> LabelsVoidLabelAsync(string labelId, string apiKey);

        /// <summary>
        ///     Void a label
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="labelId">Label ID</param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of ApiResponse (VoidLabelResponse)</returns>
        Task<ApiResponse<VoidLabelResponse>> LabelsVoidLabelAsyncWithHttpInfo(string labelId, string apiKey);

        #endregion Asynchronous Operations
    }
}