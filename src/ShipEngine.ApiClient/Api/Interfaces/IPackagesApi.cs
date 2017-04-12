using System.Threading.Tasks;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace ShipEngine.ApiClient.Api.Interfaces
{
    /// <summary>
    ///     Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPackagesApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        ///     Create a package
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="package"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Package</returns>
        Package PackagesCreate(Package package, string apiKey);

        /// <summary>
        ///     Create a package
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="package"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>ApiResponse of Package</returns>
        ApiResponse<Package> PackagesCreateWithHttpInfo(Package package, string apiKey);

        /// <summary>
        ///     Delete a package
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="packageId"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns></returns>
        void PackagesDelete(string packageId, string apiKey);

        /// <summary>
        ///     Delete a package
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="packageId"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<object> PackagesDeleteWithHttpInfo(string packageId, string apiKey);

        /// <summary>
        ///     Get a specific package
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="packageId"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Package</returns>
        Package PackagesGet(string packageId, string apiKey);

        /// <summary>
        ///     Get a specific package
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="packageId"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>ApiResponse of Package</returns>
        ApiResponse<Package> PackagesGetWithHttpInfo(string packageId, string apiKey);

        /// <summary>
        ///     Get packages
        /// </summary>
        /// <remarks>
        ///     Get a list of packages
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">API Key</param>
        /// <returns>PackagesListResponse</returns>
        PackagesListResponse PackagesList(string apiKey);

        /// <summary>
        ///     Get packages
        /// </summary>
        /// <remarks>
        ///     Get a list of packages
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">API Key</param>
        /// <returns>ApiResponse of PackagesListResponse</returns>
        ApiResponse<PackagesListResponse> PackagesListWithHttpInfo(string apiKey);

        /// <summary>
        ///     Update a package
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="packageId">Package ID</param>
        /// <param name="package"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns></returns>
        void PackagesUpdate(string packageId, Package package, string apiKey);

        /// <summary>
        ///     Update a package
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="packageId">Package ID</param>
        /// <param name="package"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<object> PackagesUpdateWithHttpInfo(string packageId, Package package, string apiKey);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        ///     Create a package
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="package"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of Package</returns>
        Task<Package> PackagesCreateAsync(Package package, string apiKey);

        /// <summary>
        ///     Create a package
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="package"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of ApiResponse (Package)</returns>
        Task<ApiResponse<Package>> PackagesCreateAsyncWithHttpInfo(Package package, string apiKey);

        /// <summary>
        ///     Delete a package
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="packageId"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of void</returns>
        Task PackagesDeleteAsync(string packageId, string apiKey);

        /// <summary>
        ///     Delete a package
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="packageId"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<object>> PackagesDeleteAsyncWithHttpInfo(string packageId, string apiKey);

        /// <summary>
        ///     Get a specific package
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="packageId"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of Package</returns>
        Task<Package> PackagesGetAsync(string packageId, string apiKey);

        /// <summary>
        ///     Get a specific package
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="packageId"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of ApiResponse (Package)</returns>
        Task<ApiResponse<Package>> PackagesGetAsyncWithHttpInfo(string packageId, string apiKey);

        /// <summary>
        ///     Get packages
        /// </summary>
        /// <remarks>
        ///     Get a list of packages
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of PackagesListResponse</returns>
        Task<PackagesListResponse> PackagesListAsync(string apiKey);

        /// <summary>
        ///     Get packages
        /// </summary>
        /// <remarks>
        ///     Get a list of packages
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of ApiResponse (PackagesListResponse)</returns>
        Task<ApiResponse<PackagesListResponse>> PackagesListAsyncWithHttpInfo(string apiKey);

        /// <summary>
        ///     Update a package
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="packageId">Package ID</param>
        /// <param name="package"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of void</returns>
        Task PackagesUpdateAsync(string packageId, Package package, string apiKey);

        /// <summary>
        ///     Update a package
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="packageId">Package ID</param>
        /// <param name="package"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<object>> PackagesUpdateAsyncWithHttpInfo(string packageId, Package package, string apiKey);

        #endregion Asynchronous Operations
    }
}