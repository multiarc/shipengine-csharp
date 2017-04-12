using System.Threading.Tasks;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace ShipEngine.ApiClient.Api.Interfaces
{
    /// <summary>
    ///     Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICarriersApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        ///     Get a specific carrier
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="carrierId"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Carrier</returns>
        Carrier CarriersGet(string carrierId, string apiKey);

        /// <summary>
        ///     Get a specific carrier
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="carrierId"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>ApiResponse of Carrier</returns>
        ApiResponse<Carrier> CarriersGetWithHttpInfo(string carrierId, string apiKey);

        /// <summary>
        ///     Get advanced options for a carrier
        /// </summary>
        /// <remarks>
        ///     Get advanced options (such as Saturday delivery, special handling, etc...) for a carrier
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="carrierId"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>CarrierListOptionsResponse</returns>
        CarrierListOptionsResponse CarriersGetOptions(string carrierId, string apiKey);

        /// <summary>
        ///     Get advanced options for a carrier
        /// </summary>
        /// <remarks>
        ///     Get advanced options (such as Saturday delivery, special handling, etc...) for a carrier
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="carrierId"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>ApiResponse of CarrierListOptionsResponse</returns>
        ApiResponse<CarrierListOptionsResponse> CarriersGetOptionsWithHttpInfo(string carrierId, string apiKey);

        /// <summary>
        ///     Get carriers
        /// </summary>
        /// <remarks>
        ///     Get a list of carriers (carrier accounts)
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">API Key</param>
        /// <returns>CarrierListResponse</returns>
        CarrierListResponse CarriersList(string apiKey);

        /// <summary>
        ///     Get carriers
        /// </summary>
        /// <remarks>
        ///     Get a list of carriers (carrier accounts)
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">API Key</param>
        /// <returns>ApiResponse of CarrierListResponse</returns>
        ApiResponse<CarrierListResponse> CarriersListWithHttpInfo(string apiKey);

        /// <summary>
        ///     Get packages for a carrier
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="carrierId"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>CarrierListPackagesResponse</returns>
        CarrierListPackagesResponse CarriersListPackages(string carrierId, string apiKey);

        /// <summary>
        ///     Get packages for a carrier
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="carrierId"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>ApiResponse of CarrierListPackagesResponse</returns>
        ApiResponse<CarrierListPackagesResponse> CarriersListPackagesWithHttpInfo(string carrierId, string apiKey);

        /// <summary>
        ///     Get shipping services for a carrier
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="carrierId"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>CarrierListServicesResponse</returns>
        CarrierListServicesResponse CarriersListServices(string carrierId, string apiKey);

        /// <summary>
        ///     Get shipping services for a carrier
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="carrierId"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>ApiResponse of CarrierListServicesResponse</returns>
        ApiResponse<CarrierListServicesResponse> CarriersListServicesWithHttpInfo(string carrierId, string apiKey);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        ///     Get a specific carrier
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="carrierId"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of Carrier</returns>
        Task<Carrier> CarriersGetAsync(string carrierId, string apiKey);

        /// <summary>
        ///     Get a specific carrier
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="carrierId"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of ApiResponse (Carrier)</returns>
        Task<ApiResponse<Carrier>> CarriersGetAsyncWithHttpInfo(string carrierId, string apiKey);

        /// <summary>
        ///     Get advanced options for a carrier
        /// </summary>
        /// <remarks>
        ///     Get advanced options (such as Saturday delivery, special handling, etc...) for a carrier
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="carrierId"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of CarrierListOptionsResponse</returns>
        Task<CarrierListOptionsResponse> CarriersGetOptionsAsync(string carrierId, string apiKey);

        /// <summary>
        ///     Get advanced options for a carrier
        /// </summary>
        /// <remarks>
        ///     Get advanced options (such as Saturday delivery, special handling, etc...) for a carrier
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="carrierId"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of ApiResponse (CarrierListOptionsResponse)</returns>
        Task<ApiResponse<CarrierListOptionsResponse>> CarriersGetOptionsAsyncWithHttpInfo(string carrierId,
            string apiKey);

        /// <summary>
        ///     Get carriers
        /// </summary>
        /// <remarks>
        ///     Get a list of carriers (carrier accounts)
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of CarrierListResponse</returns>
        Task<CarrierListResponse> CarriersListAsync(string apiKey);

        /// <summary>
        ///     Get carriers
        /// </summary>
        /// <remarks>
        ///     Get a list of carriers (carrier accounts)
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of ApiResponse (CarrierListResponse)</returns>
        Task<ApiResponse<CarrierListResponse>> CarriersListAsyncWithHttpInfo(string apiKey);

        /// <summary>
        ///     Get packages for a carrier
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="carrierId"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of CarrierListPackagesResponse</returns>
        Task<CarrierListPackagesResponse> CarriersListPackagesAsync(string carrierId, string apiKey);

        /// <summary>
        ///     Get packages for a carrier
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="carrierId"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of ApiResponse (CarrierListPackagesResponse)</returns>
        Task<ApiResponse<CarrierListPackagesResponse>> CarriersListPackagesAsyncWithHttpInfo(string carrierId,
            string apiKey);

        /// <summary>
        ///     Get shipping services for a carrier
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="carrierId"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of CarrierListServicesResponse</returns>
        Task<CarrierListServicesResponse> CarriersListServicesAsync(string carrierId, string apiKey);

        /// <summary>
        ///     Get shipping services for a carrier
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="carrierId"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of ApiResponse (CarrierListServicesResponse)</returns>
        Task<ApiResponse<CarrierListServicesResponse>> CarriersListServicesAsyncWithHttpInfo(string carrierId,
            string apiKey);

        #endregion Asynchronous Operations
    }
}