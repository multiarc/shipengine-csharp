using System.Threading.Tasks;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace ShipEngine.ApiClient.Api.Interfaces
{
    /// <summary>
    ///     Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITrackingApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        ///     Starts tracking events notifications
        /// </summary>
        /// <remarks>
        ///     Starts tracking events webhook notifications for a tracking number
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">API Key</param>
        /// <param name="carrierCode"> (optional)</param>
        /// <param name="trackingNumber"> (optional)</param>
        /// <returns></returns>
        void TrackingStartTracking(string apiKey, string carrierCode = null, string trackingNumber = null);

        /// <summary>
        ///     Starts tracking events notifications
        /// </summary>
        /// <remarks>
        ///     Starts tracking events webhook notifications for a tracking number
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">API Key</param>
        /// <param name="carrierCode"> (optional)</param>
        /// <param name="trackingNumber"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<object> TrackingStartTrackingWithHttpInfo(string apiKey, string carrierCode = null,
            string trackingNumber = null);

        /// <summary>
        ///     Stops tracking events notifications
        /// </summary>
        /// <remarks>
        ///     Stops tracking events webhook notifications for a tracking number
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">API Key</param>
        /// <param name="carrierCode"> (optional)</param>
        /// <param name="trackingNumber"> (optional)</param>
        /// <returns></returns>
        void TrackingStopTracking(string apiKey, string carrierCode = null, string trackingNumber = null);

        /// <summary>
        ///     Stops tracking events notifications
        /// </summary>
        /// <remarks>
        ///     Stops tracking events webhook notifications for a tracking number
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">API Key</param>
        /// <param name="carrierCode"> (optional)</param>
        /// <param name="trackingNumber"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<object> TrackingStopTrackingWithHttpInfo(string apiKey, string carrierCode = null,
            string trackingNumber = null);

        /// <summary>
        ///     Get tracking information
        /// </summary>
        /// <remarks>
        ///     Get tracking information by tracking number
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">API Key</param>
        /// <param name="carrierCode"> (optional)</param>
        /// <param name="trackingNumber"> (optional)</param>
        /// <returns>TrackingInformation</returns>
        TrackingInformation TrackingTrack(string apiKey, string carrierCode = null, string trackingNumber = null);

        /// <summary>
        ///     Get tracking information
        /// </summary>
        /// <remarks>
        ///     Get tracking information by tracking number
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">API Key</param>
        /// <param name="carrierCode"> (optional)</param>
        /// <param name="trackingNumber"> (optional)</param>
        /// <returns>ApiResponse of TrackingInformation</returns>
        ApiResponse<TrackingInformation> TrackingTrackWithHttpInfo(string apiKey, string carrierCode = null,
            string trackingNumber = null);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        ///     Starts tracking events notifications
        /// </summary>
        /// <remarks>
        ///     Starts tracking events webhook notifications for a tracking number
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">API Key</param>
        /// <param name="carrierCode"> (optional)</param>
        /// <param name="trackingNumber"> (optional)</param>
        /// <returns>Task of void</returns>
        Task TrackingStartTrackingAsync(string apiKey, string carrierCode = null, string trackingNumber = null);

        /// <summary>
        ///     Starts tracking events notifications
        /// </summary>
        /// <remarks>
        ///     Starts tracking events webhook notifications for a tracking number
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">API Key</param>
        /// <param name="carrierCode"> (optional)</param>
        /// <param name="trackingNumber"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<object>> TrackingStartTrackingAsyncWithHttpInfo(string apiKey, string carrierCode = null,
            string trackingNumber = null);

        /// <summary>
        ///     Stops tracking events notifications
        /// </summary>
        /// <remarks>
        ///     Stops tracking events webhook notifications for a tracking number
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">API Key</param>
        /// <param name="carrierCode"> (optional)</param>
        /// <param name="trackingNumber"> (optional)</param>
        /// <returns>Task of void</returns>
        Task TrackingStopTrackingAsync(string apiKey, string carrierCode = null, string trackingNumber = null);

        /// <summary>
        ///     Stops tracking events notifications
        /// </summary>
        /// <remarks>
        ///     Stops tracking events webhook notifications for a tracking number
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">API Key</param>
        /// <param name="carrierCode"> (optional)</param>
        /// <param name="trackingNumber"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<object>> TrackingStopTrackingAsyncWithHttpInfo(string apiKey, string carrierCode = null,
            string trackingNumber = null);

        /// <summary>
        ///     Get tracking information
        /// </summary>
        /// <remarks>
        ///     Get tracking information by tracking number
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">API Key</param>
        /// <param name="carrierCode"> (optional)</param>
        /// <param name="trackingNumber"> (optional)</param>
        /// <returns>Task of TrackingInformation</returns>
        Task<TrackingInformation> TrackingTrackAsync(string apiKey, string carrierCode = null,
            string trackingNumber = null);

        /// <summary>
        ///     Get tracking information
        /// </summary>
        /// <remarks>
        ///     Get tracking information by tracking number
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">API Key</param>
        /// <param name="carrierCode"> (optional)</param>
        /// <param name="trackingNumber"> (optional)</param>
        /// <returns>Task of ApiResponse (TrackingInformation)</returns>
        Task<ApiResponse<TrackingInformation>> TrackingTrackAsyncWithHttpInfo(string apiKey, string carrierCode = null,
            string trackingNumber = null);

        #endregion Asynchronous Operations
    }
}