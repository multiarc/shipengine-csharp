using System;
using System.Threading.Tasks;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace ShipEngine.ApiClient.Api.Interfaces
{
    /// <summary>
    ///     Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IShipmentsApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        ///     Add a tag to a shipment
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId"></param>
        /// <param name="tag">Tag</param>
        /// <param name="apiKey">API Key</param>
        /// <returns>ShipmentAddTagResponse</returns>
        ShipmentAddTagResponse ShipmentsAddTag(string shipmentId, string tag, string apiKey);

        /// <summary>
        ///     Add a tag to a shipment
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId"></param>
        /// <param name="tag">Tag</param>
        /// <param name="apiKey">API Key</param>
        /// <returns>ApiResponse of ShipmentAddTagResponse</returns>
        ApiResponse<ShipmentAddTagResponse> ShipmentsAddTagWithHttpInfo(string shipmentId, string tag, string apiKey);

        /// <summary>
        ///     Cancel a shipment
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">Shipment ID</param>
        /// <param name="apiKey">API Key</param>
        /// <returns></returns>
        void ShipmentsCancel(string shipmentId, string apiKey);

        /// <summary>
        ///     Cancel a shipment
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">Shipment ID</param>
        /// <param name="apiKey">API Key</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<object> ShipmentsCancelWithHttpInfo(string shipmentId, string apiKey);

        /// <summary>
        ///     Create multiple shipments
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentsRequest"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>CreateShipmentsResponse</returns>
        CreateShipmentsResponse ShipmentsCreateShipments(CreateShipmentsRequest shipmentsRequest, string apiKey);

        /// <summary>
        ///     Create multiple shipments
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentsRequest"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>ApiResponse of CreateShipmentsResponse</returns>
        ApiResponse<CreateShipmentsResponse> ShipmentsCreateShipmentsWithHttpInfo(
            CreateShipmentsRequest shipmentsRequest, string apiKey);

        /// <summary>
        ///     Get a specific shipment
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Shipment</returns>
        Shipment ShipmentsGet(string shipmentId, string apiKey);

        /// <summary>
        ///     Get a specific shipment
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>ApiResponse of Shipment</returns>
        ApiResponse<Shipment> ShipmentsGetWithHttpInfo(string shipmentId, string apiKey);

        /// <summary>
        ///     Get a specific shipment by an external id
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShipmentId">External Shipment Id</param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Shipment</returns>
        Shipment ShipmentsGetByExternalId(string externalShipmentId, string apiKey);

        /// <summary>
        ///     Get a specific shipment by an external id
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShipmentId">External Shipment Id</param>
        /// <param name="apiKey">API Key</param>
        /// <returns>ApiResponse of Shipment</returns>
        ApiResponse<Shipment> ShipmentsGetByExternalIdWithHttpInfo(string externalShipmentId, string apiKey);

        /// <summary>
        ///     Get rates for a specific shipment
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId"></param>
        /// <param name="apiKey">API Key</param>
        /// <param name="createdAtStart"> (optional)</param>
        /// <returns>RateResponse</returns>
        RateResponse ShipmentsGetRatesForShipment(string shipmentId, string apiKey, DateTime? createdAtStart = null);

        /// <summary>
        ///     Get rates for a specific shipment
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId"></param>
        /// <param name="apiKey">API Key</param>
        /// <param name="createdAtStart"> (optional)</param>
        /// <returns>ApiResponse of RateResponse</returns>
        ApiResponse<RateResponse> ShipmentsGetRatesForShipmentWithHttpInfo(string shipmentId, string apiKey,
            DateTime? createdAtStart = null);

        /// <summary>
        ///     Get shipments
        /// </summary>
        /// <remarks>
        ///     Get a list of shipments using optional criteria
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">API Key</param>
        /// <param name="batchId">Retrieve shipments in the specified batch_id (optional)</param>
        /// <param name="tag">Retrieve shipments by associated tag (optional)</param>
        /// <param name="shipmentStatus">Shipment status (optional)</param>
        /// <param name="modifiedAtStart">Modify date range start (optional)</param>
        /// <param name="modifiedAtEnd">Modify date range end (optional)</param>
        /// <param name="createdAtStart">Create date range start (optional)</param>
        /// <param name="createdAtEnd">Create date range end (optional)</param>
        /// <param name="page">Page number (optional)</param>
        /// <param name="pageSize">Number of records per page (optional)</param>
        /// <param name="sortDir">Sort direction (optional)</param>
        /// <param name="sortBy">Sort by item (optional)</param>
        /// <returns>ListShipmentResponse</returns>
        ListShipmentResponse ShipmentsList(string apiKey, string batchId = null, string tag = null,
            string shipmentStatus = null, DateTime? modifiedAtStart = null, DateTime? modifiedAtEnd = null,
            DateTime? createdAtStart = null, DateTime? createdAtEnd = null, int? page = null, int? pageSize = null,
            string sortDir = null, string sortBy = null);

        /// <summary>
        ///     Get shipments
        /// </summary>
        /// <remarks>
        ///     Get a list of shipments using optional criteria
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">API Key</param>
        /// <param name="batchId">Retrieve shipments in the specified batch_id (optional)</param>
        /// <param name="tag">Retrieve shipments by associated tag (optional)</param>
        /// <param name="shipmentStatus">Shipment status (optional)</param>
        /// <param name="modifiedAtStart">Modify date range start (optional)</param>
        /// <param name="modifiedAtEnd">Modify date range end (optional)</param>
        /// <param name="createdAtStart">Create date range start (optional)</param>
        /// <param name="createdAtEnd">Create date range end (optional)</param>
        /// <param name="page">Page number (optional)</param>
        /// <param name="pageSize">Number of records per page (optional)</param>
        /// <param name="sortDir">Sort direction (optional)</param>
        /// <param name="sortBy">Sort by item (optional)</param>
        /// <returns>ApiResponse of ListShipmentResponse</returns>
        ApiResponse<ListShipmentResponse> ShipmentsListWithHttpInfo(string apiKey, string batchId = null,
            string tag = null, string shipmentStatus = null, DateTime? modifiedAtStart = null,
            DateTime? modifiedAtEnd = null, DateTime? createdAtStart = null, DateTime? createdAtEnd = null,
            int? page = null, int? pageSize = null, string sortDir = null, string sortBy = null);

        /// <summary>
        ///     Lists the errors.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId"></param>
        /// <param name="apiKey">API Key</param>
        /// <param name="page">The page. (optional)</param>
        /// <param name="pagesize"> (optional)</param>
        /// <returns>ShipmentResponseErrors</returns>
        ShipmentResponseErrors ShipmentsListErrors(string shipmentId, string apiKey, int? page = null,
            int? pagesize = null);

        /// <summary>
        ///     Lists the errors.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId"></param>
        /// <param name="apiKey">API Key</param>
        /// <param name="page">The page. (optional)</param>
        /// <param name="pagesize"> (optional)</param>
        /// <returns>ApiResponse of ShipmentResponseErrors</returns>
        ApiResponse<ShipmentResponseErrors> ShipmentsListErrorsWithHttpInfo(string shipmentId, string apiKey,
            int? page = null, int? pagesize = null);

        /// <summary>
        ///     Remove a tag from a shipment
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId"></param>
        /// <param name="tag">Tag</param>
        /// <param name="apiKey">API Key</param>
        /// <returns></returns>
        void ShipmentsRemoveTag(string shipmentId, string tag, string apiKey);

        /// <summary>
        ///     Remove a tag from a shipment
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId"></param>
        /// <param name="tag">Tag</param>
        /// <param name="apiKey">API Key</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<object> ShipmentsRemoveTagWithHttpInfo(string shipmentId, string tag, string apiKey);

        /// <summary>
        ///     Update a shipment
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">Shipment ID</param>
        /// <param name="shipment">Shipment</param>
        /// <param name="apiKey">API Key</param>
        /// <returns>CreateShipmentResponse</returns>
        CreateShipmentResponse ShipmentsUpdateShipment(string shipmentId, AddressValidatingShipment shipment,
            string apiKey);

        /// <summary>
        ///     Update a shipment
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">Shipment ID</param>
        /// <param name="shipment">Shipment</param>
        /// <param name="apiKey">API Key</param>
        /// <returns>ApiResponse of CreateShipmentResponse</returns>
        ApiResponse<CreateShipmentResponse> ShipmentsUpdateShipmentWithHttpInfo(string shipmentId,
            AddressValidatingShipment shipment, string apiKey);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        ///     Add a tag to a shipment
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId"></param>
        /// <param name="tag">Tag</param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of ShipmentAddTagResponse</returns>
        Task<ShipmentAddTagResponse> ShipmentsAddTagAsync(string shipmentId, string tag, string apiKey);

        /// <summary>
        ///     Add a tag to a shipment
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId"></param>
        /// <param name="tag">Tag</param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of ApiResponse (ShipmentAddTagResponse)</returns>
        Task<ApiResponse<ShipmentAddTagResponse>> ShipmentsAddTagAsyncWithHttpInfo(string shipmentId, string tag,
            string apiKey);

        /// <summary>
        ///     Cancel a shipment
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">Shipment ID</param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of void</returns>
        Task ShipmentsCancelAsync(string shipmentId, string apiKey);

        /// <summary>
        ///     Cancel a shipment
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">Shipment ID</param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<object>> ShipmentsCancelAsyncWithHttpInfo(string shipmentId, string apiKey);

        /// <summary>
        ///     Create multiple shipments
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentsRequest"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of CreateShipmentsResponse</returns>
        Task<CreateShipmentsResponse> ShipmentsCreateShipmentsAsync(CreateShipmentsRequest shipmentsRequest,
            string apiKey);

        /// <summary>
        ///     Create multiple shipments
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentsRequest"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of ApiResponse (CreateShipmentsResponse)</returns>
        Task<ApiResponse<CreateShipmentsResponse>> ShipmentsCreateShipmentsAsyncWithHttpInfo(
            CreateShipmentsRequest shipmentsRequest, string apiKey);

        /// <summary>
        ///     Get a specific shipment
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of Shipment</returns>
        Task<Shipment> ShipmentsGetAsync(string shipmentId, string apiKey);

        /// <summary>
        ///     Get a specific shipment
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of ApiResponse (Shipment)</returns>
        Task<ApiResponse<Shipment>> ShipmentsGetAsyncWithHttpInfo(string shipmentId, string apiKey);

        /// <summary>
        ///     Get a specific shipment by an external id
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShipmentId">External Shipment Id</param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of Shipment</returns>
        Task<Shipment> ShipmentsGetByExternalIdAsync(string externalShipmentId, string apiKey);

        /// <summary>
        ///     Get a specific shipment by an external id
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalShipmentId">External Shipment Id</param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of ApiResponse (Shipment)</returns>
        Task<ApiResponse<Shipment>> ShipmentsGetByExternalIdAsyncWithHttpInfo(string externalShipmentId, string apiKey);

        /// <summary>
        ///     Get rates for a specific shipment
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId"></param>
        /// <param name="apiKey">API Key</param>
        /// <param name="createdAtStart"> (optional)</param>
        /// <returns>Task of RateResponse</returns>
        Task<RateResponse> ShipmentsGetRatesForShipmentAsync(string shipmentId, string apiKey,
            DateTime? createdAtStart = null);

        /// <summary>
        ///     Get rates for a specific shipment
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId"></param>
        /// <param name="apiKey">API Key</param>
        /// <param name="createdAtStart"> (optional)</param>
        /// <returns>Task of ApiResponse (RateResponse)</returns>
        Task<ApiResponse<RateResponse>> ShipmentsGetRatesForShipmentAsyncWithHttpInfo(string shipmentId, string apiKey,
            DateTime? createdAtStart = null);

        /// <summary>
        ///     Get shipments
        /// </summary>
        /// <remarks>
        ///     Get a list of shipments using optional criteria
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">API Key</param>
        /// <param name="batchId">Retrieve shipments in the specified batch_id (optional)</param>
        /// <param name="tag">Retrieve shipments by associated tag (optional)</param>
        /// <param name="shipmentStatus">Shipment status (optional)</param>
        /// <param name="modifiedAtStart">Modify date range start (optional)</param>
        /// <param name="modifiedAtEnd">Modify date range end (optional)</param>
        /// <param name="createdAtStart">Create date range start (optional)</param>
        /// <param name="createdAtEnd">Create date range end (optional)</param>
        /// <param name="page">Page number (optional)</param>
        /// <param name="pageSize">Number of records per page (optional)</param>
        /// <param name="sortDir">Sort direction (optional)</param>
        /// <param name="sortBy">Sort by item (optional)</param>
        /// <returns>Task of ListShipmentResponse</returns>
        Task<ListShipmentResponse> ShipmentsListAsync(string apiKey, string batchId = null, string tag = null,
            string shipmentStatus = null, DateTime? modifiedAtStart = null, DateTime? modifiedAtEnd = null,
            DateTime? createdAtStart = null, DateTime? createdAtEnd = null, int? page = null, int? pageSize = null,
            string sortDir = null, string sortBy = null);

        /// <summary>
        ///     Get shipments
        /// </summary>
        /// <remarks>
        ///     Get a list of shipments using optional criteria
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">API Key</param>
        /// <param name="batchId">Retrieve shipments in the specified batch_id (optional)</param>
        /// <param name="tag">Retrieve shipments by associated tag (optional)</param>
        /// <param name="shipmentStatus">Shipment status (optional)</param>
        /// <param name="modifiedAtStart">Modify date range start (optional)</param>
        /// <param name="modifiedAtEnd">Modify date range end (optional)</param>
        /// <param name="createdAtStart">Create date range start (optional)</param>
        /// <param name="createdAtEnd">Create date range end (optional)</param>
        /// <param name="page">Page number (optional)</param>
        /// <param name="pageSize">Number of records per page (optional)</param>
        /// <param name="sortDir">Sort direction (optional)</param>
        /// <param name="sortBy">Sort by item (optional)</param>
        /// <returns>Task of ApiResponse (ListShipmentResponse)</returns>
        Task<ApiResponse<ListShipmentResponse>> ShipmentsListAsyncWithHttpInfo(string apiKey, string batchId = null,
            string tag = null, string shipmentStatus = null, DateTime? modifiedAtStart = null,
            DateTime? modifiedAtEnd = null, DateTime? createdAtStart = null, DateTime? createdAtEnd = null,
            int? page = null, int? pageSize = null, string sortDir = null, string sortBy = null);

        /// <summary>
        ///     Lists the errors.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId"></param>
        /// <param name="apiKey">API Key</param>
        /// <param name="page">The page. (optional)</param>
        /// <param name="pagesize"> (optional)</param>
        /// <returns>Task of ShipmentResponseErrors</returns>
        Task<ShipmentResponseErrors> ShipmentsListErrorsAsync(string shipmentId, string apiKey, int? page = null,
            int? pagesize = null);

        /// <summary>
        ///     Lists the errors.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId"></param>
        /// <param name="apiKey">API Key</param>
        /// <param name="page">The page. (optional)</param>
        /// <param name="pagesize"> (optional)</param>
        /// <returns>Task of ApiResponse (ShipmentResponseErrors)</returns>
        Task<ApiResponse<ShipmentResponseErrors>> ShipmentsListErrorsAsyncWithHttpInfo(string shipmentId, string apiKey,
            int? page = null, int? pagesize = null);

        /// <summary>
        ///     Remove a tag from a shipment
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId"></param>
        /// <param name="tag">Tag</param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of void</returns>
        Task ShipmentsRemoveTagAsync(string shipmentId, string tag, string apiKey);

        /// <summary>
        ///     Remove a tag from a shipment
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId"></param>
        /// <param name="tag">Tag</param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<object>> ShipmentsRemoveTagAsyncWithHttpInfo(string shipmentId, string tag, string apiKey);

        /// <summary>
        ///     Update a shipment
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">Shipment ID</param>
        /// <param name="shipment">Shipment</param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of CreateShipmentResponse</returns>
        Task<CreateShipmentResponse> ShipmentsUpdateShipmentAsync(string shipmentId, AddressValidatingShipment shipment,
            string apiKey);

        /// <summary>
        ///     Update a shipment
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="shipmentId">Shipment ID</param>
        /// <param name="shipment">Shipment</param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of ApiResponse (CreateShipmentResponse)</returns>
        Task<ApiResponse<CreateShipmentResponse>> ShipmentsUpdateShipmentAsyncWithHttpInfo(string shipmentId,
            AddressValidatingShipment shipment, string apiKey);

        #endregion Asynchronous Operations
    }
}