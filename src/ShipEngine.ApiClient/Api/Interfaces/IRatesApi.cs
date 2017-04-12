using System.Collections.Generic;
using System.Threading.Tasks;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace ShipEngine.ApiClient.Api.Interfaces
{
    /// <summary>
    ///     Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IRatesApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        ///     Get a rate quote
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="estimateRequest">Get a rate quote without creating a shipment</param>
        /// <param name="apiKey">API Key</param>
        /// <returns>List&lt;Rate&gt;</returns>
        List<Rate> RatesEstimate(RateEstimateRequest estimateRequest, string apiKey);

        /// <summary>
        ///     Get a rate quote
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="estimateRequest">Get a rate quote without creating a shipment</param>
        /// <param name="apiKey">API Key</param>
        /// <returns>ApiResponse of List&lt;Rate&gt;</returns>
        ApiResponse<List<Rate>> RatesEstimateWithHttpInfo(RateEstimateRequest estimateRequest, string apiKey);

        /// <summary>
        ///     Get a rate
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="rateId"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Rate</returns>
        Rate RatesGet(string rateId, string apiKey);

        /// <summary>
        ///     Get a rate
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="rateId"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>ApiResponse of Rate</returns>
        ApiResponse<Rate> RatesGetWithHttpInfo(string rateId, string apiKey);

        /// <summary>
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>RateShipmentResponse</returns>
        RateShipmentResponse RatesRateShipment(RateShipmentRequest request, string apiKey);

        /// <summary>
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>ApiResponse of RateShipmentResponse</returns>
        ApiResponse<RateShipmentResponse> RatesRateShipmentWithHttpInfo(RateShipmentRequest request, string apiKey);

        /// <summary>
        ///     Rate shipments asynchronously
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns></returns>
        void RatesRateShipmentsBulk(RateShipmentsRequest request, string apiKey);

        /// <summary>
        ///     Rate shipments asynchronously
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<object> RatesRateShipmentsBulkWithHttpInfo(RateShipmentsRequest request, string apiKey);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        ///     Get a rate quote
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="estimateRequest">Get a rate quote without creating a shipment</param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of List&lt;Rate&gt;</returns>
        Task<List<Rate>> RatesEstimateAsync(RateEstimateRequest estimateRequest, string apiKey);

        /// <summary>
        ///     Get a rate quote
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="estimateRequest">Get a rate quote without creating a shipment</param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of ApiResponse (List&lt;Rate&gt;)</returns>
        Task<ApiResponse<List<Rate>>> RatesEstimateAsyncWithHttpInfo(RateEstimateRequest estimateRequest, string apiKey);

        /// <summary>
        ///     Get a rate
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="rateId"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of Rate</returns>
        Task<Rate> RatesGetAsync(string rateId, string apiKey);

        /// <summary>
        ///     Get a rate
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="rateId"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of ApiResponse (Rate)</returns>
        Task<ApiResponse<Rate>> RatesGetAsyncWithHttpInfo(string rateId, string apiKey);

        /// <summary>
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of RateShipmentResponse</returns>
        Task<RateShipmentResponse> RatesRateShipmentAsync(RateShipmentRequest request, string apiKey);

        /// <summary>
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of ApiResponse (RateShipmentResponse)</returns>
        Task<ApiResponse<RateShipmentResponse>> RatesRateShipmentAsyncWithHttpInfo(RateShipmentRequest request,
            string apiKey);

        /// <summary>
        ///     Rate shipments asynchronously
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of void</returns>
        Task RatesRateShipmentsBulkAsync(RateShipmentsRequest request, string apiKey);

        /// <summary>
        ///     Rate shipments asynchronously
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<object>> RatesRateShipmentsBulkAsyncWithHttpInfo(RateShipmentsRequest request, string apiKey);

        #endregion Asynchronous Operations
    }
}