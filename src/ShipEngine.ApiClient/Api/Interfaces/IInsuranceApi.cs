using System.Threading.Tasks;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace ShipEngine.ApiClient.Api.Interfaces
{
    /// <summary>
    ///     Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IInsuranceApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        ///     Add funds to your Shipsurance balance
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cost"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>MoneyDTO</returns>
        MoneyDTO InsuranceAddFunds(MoneyDTO cost, string apiKey);

        /// <summary>
        ///     Add funds to your Shipsurance balance
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cost"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>ApiResponse of MoneyDTO</returns>
        ApiResponse<MoneyDTO> InsuranceAddFundsWithHttpInfo(MoneyDTO cost, string apiKey);

        /// <summary>
        ///     Get your Shipsurance balance
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">API Key</param>
        /// <returns>MoneyDTO</returns>
        MoneyDTO InsuranceGetBalance(string apiKey);

        /// <summary>
        ///     Get your Shipsurance balance
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">API Key</param>
        /// <returns>ApiResponse of MoneyDTO</returns>
        ApiResponse<MoneyDTO> InsuranceGetBalanceWithHttpInfo(string apiKey);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        ///     Add funds to your Shipsurance balance
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cost"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of MoneyDTO</returns>
        Task<MoneyDTO> InsuranceAddFundsAsync(MoneyDTO cost, string apiKey);

        /// <summary>
        ///     Add funds to your Shipsurance balance
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cost"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of ApiResponse (MoneyDTO)</returns>
        Task<ApiResponse<MoneyDTO>> InsuranceAddFundsAsyncWithHttpInfo(MoneyDTO cost, string apiKey);

        /// <summary>
        ///     Get your Shipsurance balance
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of MoneyDTO</returns>
        Task<MoneyDTO> InsuranceGetBalanceAsync(string apiKey);

        /// <summary>
        ///     Get your Shipsurance balance
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of ApiResponse (MoneyDTO)</returns>
        Task<ApiResponse<MoneyDTO>> InsuranceGetBalanceAsyncWithHttpInfo(string apiKey);

        #endregion Asynchronous Operations
    }
}