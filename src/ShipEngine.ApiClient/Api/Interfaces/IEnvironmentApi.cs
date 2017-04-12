using System.Threading.Tasks;
using ShipEngine.ApiClient.Client;

namespace ShipEngine.ApiClient.Api.Interfaces
{
    /// <summary>
    ///     Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IEnvironmentApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">API Key</param>
        /// <returns>Object</returns>
        object EnvironmentWebhooks(string apiKey);

        /// <summary>
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">API Key</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<object> EnvironmentWebhooksWithHttpInfo(string apiKey);

        /// <summary>
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">API Key</param>
        /// <returns>Object</returns>
        object EnvironmentWhoami(string apiKey);

        /// <summary>
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">API Key</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<object> EnvironmentWhoamiWithHttpInfo(string apiKey);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of Object</returns>
        Task<object> EnvironmentWebhooksAsync(string apiKey);

        /// <summary>
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        Task<ApiResponse<object>> EnvironmentWebhooksAsyncWithHttpInfo(string apiKey);

        /// <summary>
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of Object</returns>
        Task<object> EnvironmentWhoamiAsync(string apiKey);

        /// <summary>
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        Task<ApiResponse<object>> EnvironmentWhoamiAsyncWithHttpInfo(string apiKey);

        #endregion Asynchronous Operations
    }
}