using System;
using System.Threading.Tasks;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace ShipEngine.ApiClient.Api.Interfaces
{
    /// <summary>
    ///     Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IManifestsApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        ///     Create a manifest
        /// </summary>
        /// <remarks>
        ///     Create/generate a manifest for a specific shipping provider and date
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Manifest</returns>
        Manifest ManifestsCreate(CreateManifestRequest request, string apiKey);

        /// <summary>
        ///     Create a manifest
        /// </summary>
        /// <remarks>
        ///     Create/generate a manifest for a specific shipping provider and date
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>ApiResponse of Manifest</returns>
        ApiResponse<Manifest> ManifestsCreateWithHttpInfo(CreateManifestRequest request, string apiKey);

        /// <summary>
        ///     Get a specific manifest
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manifestId"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Manifest</returns>
        Manifest ManifestsGet(string manifestId, string apiKey);

        /// <summary>
        ///     Get a specific manifest
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manifestId"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>ApiResponse of Manifest</returns>
        ApiResponse<Manifest> ManifestsGetWithHttpInfo(string manifestId, string apiKey);

        /// <summary>
        ///     Get manifests
        /// </summary>
        /// <remarks>
        ///     Get a list of manifests using optional criteria
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">API Key</param>
        /// <param name="warehouseId"> (optional)</param>
        /// <param name="shipDateStart"> (optional)</param>
        /// <param name="shipDateEnd"> (optional)</param>
        /// <param name="createdAtStart"> (optional)</param>
        /// <param name="createdAtEnd"> (optional)</param>
        /// <param name="carrierId">Carrier ID (optional)</param>
        /// <param name="page"> (optional)</param>
        /// <param name="pageSize"> (optional)</param>
        /// <returns>ManifestsListResponse</returns>
        ManifestsListResponse ManifestsList(string apiKey, string warehouseId = null, DateTime? shipDateStart = null,
            DateTime? shipDateEnd = null, DateTime? createdAtStart = null, DateTime? createdAtEnd = null,
            string carrierId = null, int? page = null, int? pageSize = null);

        /// <summary>
        ///     Get manifests
        /// </summary>
        /// <remarks>
        ///     Get a list of manifests using optional criteria
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">API Key</param>
        /// <param name="warehouseId"> (optional)</param>
        /// <param name="shipDateStart"> (optional)</param>
        /// <param name="shipDateEnd"> (optional)</param>
        /// <param name="createdAtStart"> (optional)</param>
        /// <param name="createdAtEnd"> (optional)</param>
        /// <param name="carrierId">Carrier ID (optional)</param>
        /// <param name="page"> (optional)</param>
        /// <param name="pageSize"> (optional)</param>
        /// <returns>ApiResponse of ManifestsListResponse</returns>
        ApiResponse<ManifestsListResponse> ManifestsListWithHttpInfo(string apiKey, string warehouseId = null,
            DateTime? shipDateStart = null, DateTime? shipDateEnd = null, DateTime? createdAtStart = null,
            DateTime? createdAtEnd = null, string carrierId = null, int? page = null, int? pageSize = null);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        ///     Create a manifest
        /// </summary>
        /// <remarks>
        ///     Create/generate a manifest for a specific shipping provider and date
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of Manifest</returns>
        Task<Manifest> ManifestsCreateAsync(CreateManifestRequest request, string apiKey);

        /// <summary>
        ///     Create a manifest
        /// </summary>
        /// <remarks>
        ///     Create/generate a manifest for a specific shipping provider and date
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of ApiResponse (Manifest)</returns>
        Task<ApiResponse<Manifest>> ManifestsCreateAsyncWithHttpInfo(CreateManifestRequest request, string apiKey);

        /// <summary>
        ///     Get a specific manifest
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manifestId"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of Manifest</returns>
        Task<Manifest> ManifestsGetAsync(string manifestId, string apiKey);

        /// <summary>
        ///     Get a specific manifest
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="manifestId"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of ApiResponse (Manifest)</returns>
        Task<ApiResponse<Manifest>> ManifestsGetAsyncWithHttpInfo(string manifestId, string apiKey);

        /// <summary>
        ///     Get manifests
        /// </summary>
        /// <remarks>
        ///     Get a list of manifests using optional criteria
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">API Key</param>
        /// <param name="warehouseId"> (optional)</param>
        /// <param name="shipDateStart"> (optional)</param>
        /// <param name="shipDateEnd"> (optional)</param>
        /// <param name="createdAtStart"> (optional)</param>
        /// <param name="createdAtEnd"> (optional)</param>
        /// <param name="carrierId">Carrier ID (optional)</param>
        /// <param name="page"> (optional)</param>
        /// <param name="pageSize"> (optional)</param>
        /// <returns>Task of ManifestsListResponse</returns>
        Task<ManifestsListResponse> ManifestsListAsync(string apiKey, string warehouseId = null,
            DateTime? shipDateStart = null, DateTime? shipDateEnd = null, DateTime? createdAtStart = null,
            DateTime? createdAtEnd = null, string carrierId = null, int? page = null, int? pageSize = null);

        /// <summary>
        ///     Get manifests
        /// </summary>
        /// <remarks>
        ///     Get a list of manifests using optional criteria
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">API Key</param>
        /// <param name="warehouseId"> (optional)</param>
        /// <param name="shipDateStart"> (optional)</param>
        /// <param name="shipDateEnd"> (optional)</param>
        /// <param name="createdAtStart"> (optional)</param>
        /// <param name="createdAtEnd"> (optional)</param>
        /// <param name="carrierId">Carrier ID (optional)</param>
        /// <param name="page"> (optional)</param>
        /// <param name="pageSize"> (optional)</param>
        /// <returns>Task of ApiResponse (ManifestsListResponse)</returns>
        Task<ApiResponse<ManifestsListResponse>> ManifestsListAsyncWithHttpInfo(string apiKey, string warehouseId = null,
            DateTime? shipDateStart = null, DateTime? shipDateEnd = null, DateTime? createdAtStart = null,
            DateTime? createdAtEnd = null, string carrierId = null, int? page = null, int? pageSize = null);

        #endregion Asynchronous Operations
    }
}