using System.Collections.Generic;
using System.Threading.Tasks;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace ShipEngine.ApiClient.Api.Interfaces
{
    /// <summary>
    ///     Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAddressValidationApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addresses"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>ApiResponseDTOListAddressValidationResponseDTO</returns>
        List<AddressValidationResponseDTO> AddressValidationValidateAddresses(List<AddressDTO> addresses,
            string apiKey);

        /// <summary>
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addresses"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>ApiResponse of ApiResponseDTOListAddressValidationResponseDTO</returns>
        ApiResponse<List<AddressValidationResponseDTO>> AddressValidationValidateAddressesWithHttpInfo(
            List<AddressDTO> addresses, string apiKey);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addresses"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of ApiResponseDTOListAddressValidationResponseDTO</returns>
        Task<List<AddressValidationResponseDTO>> AddressValidationValidateAddressesAsync(
            List<AddressDTO> addresses, string apiKey);

        /// <summary>
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addresses"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of ApiResponse (ApiResponseDTOListAddressValidationResponseDTO)</returns>
        Task<ApiResponse<List<AddressValidationResponseDTO>>>
            AddressValidationValidateAddressesAsyncWithHttpInfo(List<AddressDTO> addresses, string apiKey);

        #endregion Asynchronous Operations
    }
}