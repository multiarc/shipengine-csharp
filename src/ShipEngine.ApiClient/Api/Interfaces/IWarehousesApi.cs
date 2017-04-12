using System.Threading.Tasks;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace ShipEngine.ApiClient.Api.Interfaces
{
    /// <summary>
    ///     Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IWarehousesApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        ///     Create a warehouse
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>WarehouseDTO</returns>
        WarehouseDTO WarehousesCreate(WarehouseRequest request, string apiKey);

        /// <summary>
        ///     Create a warehouse
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>ApiResponse of WarehouseDTO</returns>
        ApiResponse<WarehouseDTO> WarehousesCreateWithHttpInfo(WarehouseRequest request, string apiKey);

        /// <summary>
        ///     Delete a warehouse
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseId"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns></returns>
        void WarehousesDelete(string warehouseId, string apiKey);

        /// <summary>
        ///     Delete a warehouse
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseId"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<object> WarehousesDeleteWithHttpInfo(string warehouseId, string apiKey);

        /// <summary>
        ///     Get a specific warehouse
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseId"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>WarehouseDTO</returns>
        WarehouseDTO WarehousesGet(string warehouseId, string apiKey);

        /// <summary>
        ///     Get a specific warehouse
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseId"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>ApiResponse of WarehouseDTO</returns>
        ApiResponse<WarehouseDTO> WarehousesGetWithHttpInfo(string warehouseId, string apiKey);

        /// <summary>
        ///     Get warehouses
        /// </summary>
        /// <remarks>
        ///     Get a list of Warehouses
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">API Key</param>
        /// <returns>WarehouseListDTO</returns>
        WarehouseListDTO WarehousesList(string apiKey);

        /// <summary>
        ///     Get warehouses
        /// </summary>
        /// <remarks>
        ///     Get a list of Warehouses
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">API Key</param>
        /// <returns>ApiResponse of WarehouseListDTO</returns>
        ApiResponse<WarehouseListDTO> WarehousesListWithHttpInfo(string apiKey);

        /// <summary>
        ///     Update a warehouse
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseId"></param>
        /// <param name="request"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns></returns>
        void WarehousesUpdate(string warehouseId, WarehouseRequest request, string apiKey);

        /// <summary>
        ///     Update a warehouse
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseId"></param>
        /// <param name="request"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<object> WarehousesUpdateWithHttpInfo(string warehouseId, WarehouseRequest request, string apiKey);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        ///     Create a warehouse
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of WarehouseDTO</returns>
        Task<WarehouseDTO> WarehousesCreateAsync(WarehouseRequest request, string apiKey);

        /// <summary>
        ///     Create a warehouse
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of ApiResponse (WarehouseDTO)</returns>
        Task<ApiResponse<WarehouseDTO>> WarehousesCreateAsyncWithHttpInfo(WarehouseRequest request, string apiKey);

        /// <summary>
        ///     Delete a warehouse
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseId"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of void</returns>
        Task WarehousesDeleteAsync(string warehouseId, string apiKey);

        /// <summary>
        ///     Delete a warehouse
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseId"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<object>> WarehousesDeleteAsyncWithHttpInfo(string warehouseId, string apiKey);

        /// <summary>
        ///     Get a specific warehouse
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseId"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of WarehouseDTO</returns>
        Task<WarehouseDTO> WarehousesGetAsync(string warehouseId, string apiKey);

        /// <summary>
        ///     Get a specific warehouse
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseId"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of ApiResponse (WarehouseDTO)</returns>
        Task<ApiResponse<WarehouseDTO>> WarehousesGetAsyncWithHttpInfo(string warehouseId, string apiKey);

        /// <summary>
        ///     Get warehouses
        /// </summary>
        /// <remarks>
        ///     Get a list of Warehouses
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of WarehouseListDTO</returns>
        Task<WarehouseListDTO> WarehousesListAsync(string apiKey);

        /// <summary>
        ///     Get warehouses
        /// </summary>
        /// <remarks>
        ///     Get a list of Warehouses
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of ApiResponse (WarehouseListDTO)</returns>
        Task<ApiResponse<WarehouseListDTO>> WarehousesListAsyncWithHttpInfo(string apiKey);

        /// <summary>
        ///     Update a warehouse
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseId"></param>
        /// <param name="request"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of void</returns>
        Task WarehousesUpdateAsync(string warehouseId, WarehouseRequest request, string apiKey);

        /// <summary>
        ///     Update a warehouse
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="warehouseId"></param>
        /// <param name="request"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<object>> WarehousesUpdateAsyncWithHttpInfo(string warehouseId, WarehouseRequest request,
            string apiKey);

        #endregion Asynchronous Operations
    }
}