using System.Threading.Tasks;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace ShipEngine.ApiClient.Api.Interfaces
{
    /// <summary>
    ///     Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IBatchesApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        ///     Add a shipment to a batch
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchId"></param>
        /// <param name="request"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns></returns>
        void BatchesAddToBatch(string batchId, ModifyBatchRequest request, string apiKey);

        /// <summary>
        ///     Add a shipment to a batch
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchId"></param>
        /// <param name="request"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<object> BatchesAddToBatchWithHttpInfo(string batchId, ModifyBatchRequest request, string apiKey);

        /// <summary>
        ///     Create a batch
        /// </summary>
        /// <remarks>
        ///     Create a batch of shipments to rate and purchase labels in bulk
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Batch</returns>
        Batch BatchesCreate(CreateBatchRequest request, string apiKey);

        /// <summary>
        ///     Create a batch
        /// </summary>
        /// <remarks>
        ///     Create a batch of shipments to rate and purchase labels in bulk
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>ApiResponse of Batch</returns>
        ApiResponse<Batch> BatchesCreateWithHttpInfo(CreateBatchRequest request, string apiKey);

        /// <summary>
        ///     Get a specific batch
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchId"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Batch</returns>
        Batch BatchesGet(string batchId, string apiKey);

        /// <summary>
        ///     Get a specific batch
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchId"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>ApiResponse of Batch</returns>
        ApiResponse<Batch> BatchesGetWithHttpInfo(string batchId, string apiKey);

        /// <summary>
        ///     Get a specific batch by an external id
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalBatchId"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns></returns>
        void BatchesGetByExternalId(string externalBatchId, string apiKey);

        /// <summary>
        ///     Get a specific batch by an external id
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalBatchId"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<object> BatchesGetByExternalIdWithHttpInfo(string externalBatchId, string apiKey);

        /// <summary>
        ///     Get batches
        /// </summary>
        /// <remarks>
        ///     Get a list of batches using optional criteria
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">API Key</param>
        /// <param name="status">Status (optional)</param>
        /// <param name="page">Page number - Default: 1 (optional)</param>
        /// <param name="pageSize"> (optional)</param>
        /// <param name="sortDir"> (optional)</param>
        /// <param name="sortBy"> (optional)</param>
        /// <returns>ListBatchResponse</returns>
        ListBatchResponse BatchesList(string apiKey, string status = null, int? page = null, int? pageSize = null,
            string sortDir = null, string sortBy = null);

        /// <summary>
        ///     Get batches
        /// </summary>
        /// <remarks>
        ///     Get a list of batches using optional criteria
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">API Key</param>
        /// <param name="status">Status (optional)</param>
        /// <param name="page">Page number - Default: 1 (optional)</param>
        /// <param name="pageSize"> (optional)</param>
        /// <param name="sortDir"> (optional)</param>
        /// <param name="sortBy"> (optional)</param>
        /// <returns>ApiResponse of ListBatchResponse</returns>
        ApiResponse<ListBatchResponse> BatchesListWithHttpInfo(string apiKey, string status = null, int? page = null,
            int? pageSize = null, string sortDir = null, string sortBy = null);

        /// <summary>
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchId"></param>
        /// <param name="apiKey">API Key</param>
        /// <param name="page"> (optional)</param>
        /// <param name="pagesize"> (optional)</param>
        /// <returns>BatchResponseErrors</returns>
        BatchResponseErrors BatchesListErrors(string batchId, string apiKey, int? page = null, int? pagesize = null);

        /// <summary>
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchId"></param>
        /// <param name="apiKey">API Key</param>
        /// <param name="page"> (optional)</param>
        /// <param name="pagesize"> (optional)</param>
        /// <returns>ApiResponse of BatchResponseErrors</returns>
        ApiResponse<BatchResponseErrors> BatchesListErrorsWithHttpInfo(string batchId, string apiKey, int? page = null,
            int? pagesize = null);

        /// <summary>
        ///     Process a batch
        /// </summary>
        /// <remarks>
        ///     Generates labels for a batch
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchId"></param>
        /// <param name="processBatchRequest"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns></returns>
        void BatchesProcess(string batchId, ProcessBatchRequest processBatchRequest, string apiKey);

        /// <summary>
        ///     Process a batch
        /// </summary>
        /// <remarks>
        ///     Generates labels for a batch
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchId"></param>
        /// <param name="processBatchRequest"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<object> BatchesProcessWithHttpInfo(string batchId, ProcessBatchRequest processBatchRequest,
            string apiKey);

        /// <summary>
        ///     Remove a shipment from a batch
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchId"></param>
        /// <param name="request"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns></returns>
        void BatchesRemoveFromBatch(string batchId, ModifyBatchRequest request, string apiKey);

        /// <summary>
        ///     Remove a shipment from a batch
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchId"></param>
        /// <param name="request"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<object> BatchesRemoveFromBatchWithHttpInfo(string batchId, ModifyBatchRequest request, string apiKey);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        ///     Add a shipment to a batch
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchId"></param>
        /// <param name="request"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of void</returns>
        Task BatchesAddToBatchAsync(string batchId, ModifyBatchRequest request, string apiKey);

        /// <summary>
        ///     Add a shipment to a batch
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchId"></param>
        /// <param name="request"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<object>> BatchesAddToBatchAsyncWithHttpInfo(string batchId, ModifyBatchRequest request,
            string apiKey);

        /// <summary>
        ///     Create a batch
        /// </summary>
        /// <remarks>
        ///     Create a batch of shipments to rate and purchase labels in bulk
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of Batch</returns>
        Task<Batch> BatchesCreateAsync(CreateBatchRequest request, string apiKey);

        /// <summary>
        ///     Create a batch
        /// </summary>
        /// <remarks>
        ///     Create a batch of shipments to rate and purchase labels in bulk
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of ApiResponse (Batch)</returns>
        Task<ApiResponse<Batch>> BatchesCreateAsyncWithHttpInfo(CreateBatchRequest request, string apiKey);

        /// <summary>
        ///     Get a specific batch
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchId"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of Batch</returns>
        Task<Batch> BatchesGetAsync(string batchId, string apiKey);

        /// <summary>
        ///     Get a specific batch
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchId"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of ApiResponse (Batch)</returns>
        Task<ApiResponse<Batch>> BatchesGetAsyncWithHttpInfo(string batchId, string apiKey);

        /// <summary>
        ///     Get a specific batch by an external id
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalBatchId"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of void</returns>
        Task BatchesGetByExternalIdAsync(string externalBatchId, string apiKey);

        /// <summary>
        ///     Get a specific batch by an external id
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="externalBatchId"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<object>> BatchesGetByExternalIdAsyncWithHttpInfo(string externalBatchId, string apiKey);

        /// <summary>
        ///     Get batches
        /// </summary>
        /// <remarks>
        ///     Get a list of batches using optional criteria
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">API Key</param>
        /// <param name="status">Status (optional)</param>
        /// <param name="page">Page number - Default: 1 (optional)</param>
        /// <param name="pageSize"> (optional)</param>
        /// <param name="sortDir"> (optional)</param>
        /// <param name="sortBy"> (optional)</param>
        /// <returns>Task of ListBatchResponse</returns>
        Task<ListBatchResponse> BatchesListAsync(string apiKey, string status = null, int? page = null,
            int? pageSize = null, string sortDir = null, string sortBy = null);

        /// <summary>
        ///     Get batches
        /// </summary>
        /// <remarks>
        ///     Get a list of batches using optional criteria
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">API Key</param>
        /// <param name="status">Status (optional)</param>
        /// <param name="page">Page number - Default: 1 (optional)</param>
        /// <param name="pageSize"> (optional)</param>
        /// <param name="sortDir"> (optional)</param>
        /// <param name="sortBy"> (optional)</param>
        /// <returns>Task of ApiResponse (ListBatchResponse)</returns>
        Task<ApiResponse<ListBatchResponse>> BatchesListAsyncWithHttpInfo(string apiKey, string status = null,
            int? page = null, int? pageSize = null, string sortDir = null, string sortBy = null);

        /// <summary>
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchId"></param>
        /// <param name="apiKey">API Key</param>
        /// <param name="page"> (optional)</param>
        /// <param name="pagesize"> (optional)</param>
        /// <returns>Task of BatchResponseErrors</returns>
        Task<BatchResponseErrors> BatchesListErrorsAsync(string batchId, string apiKey, int? page = null,
            int? pagesize = null);

        /// <summary>
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchId"></param>
        /// <param name="apiKey">API Key</param>
        /// <param name="page"> (optional)</param>
        /// <param name="pagesize"> (optional)</param>
        /// <returns>Task of ApiResponse (BatchResponseErrors)</returns>
        Task<ApiResponse<BatchResponseErrors>> BatchesListErrorsAsyncWithHttpInfo(string batchId, string apiKey,
            int? page = null, int? pagesize = null);

        /// <summary>
        ///     Process a batch
        /// </summary>
        /// <remarks>
        ///     Generates labels for a batch
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchId"></param>
        /// <param name="processBatchRequest"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of void</returns>
        Task BatchesProcessAsync(string batchId, ProcessBatchRequest processBatchRequest, string apiKey);

        /// <summary>
        ///     Process a batch
        /// </summary>
        /// <remarks>
        ///     Generates labels for a batch
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchId"></param>
        /// <param name="processBatchRequest"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<object>> BatchesProcessAsyncWithHttpInfo(string batchId,
            ProcessBatchRequest processBatchRequest, string apiKey);

        /// <summary>
        ///     Remove a shipment from a batch
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchId"></param>
        /// <param name="request"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of void</returns>
        Task BatchesRemoveFromBatchAsync(string batchId, ModifyBatchRequest request, string apiKey);

        /// <summary>
        ///     Remove a shipment from a batch
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="batchId"></param>
        /// <param name="request"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<object>> BatchesRemoveFromBatchAsyncWithHttpInfo(string batchId, ModifyBatchRequest request,
            string apiKey);

        #endregion Asynchronous Operations
    }
}