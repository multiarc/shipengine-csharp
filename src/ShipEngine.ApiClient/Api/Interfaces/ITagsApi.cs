using System.Threading.Tasks;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace ShipEngine.ApiClient.Api.Interfaces
{
    /// <summary>
    ///     Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITagsApi : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        ///     Create a tag
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tagName"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns></returns>
        void TagsAddTag(string tagName, string apiKey);

        /// <summary>
        ///     Create a tag
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tagName"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<object> TagsAddTagWithHttpInfo(string tagName, string apiKey);

        /// <summary>
        ///     Delete a tag
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tagName"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>ListTagResponse</returns>
        ListTagResponse TagsDelete(string tagName, string apiKey);

        /// <summary>
        ///     Delete a tag
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tagName"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>ApiResponse of ListTagResponse</returns>
        ApiResponse<ListTagResponse> TagsDeleteWithHttpInfo(string tagName, string apiKey);

        /// <summary>
        ///     Get tags
        /// </summary>
        /// <remarks>
        ///     Get all tags associated with your account
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">API Key</param>
        /// <returns>ListTagResponse</returns>
        ListTagResponse TagsListTags(string apiKey);

        /// <summary>
        ///     Get tags
        /// </summary>
        /// <remarks>
        ///     Get all tags associated with your account
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">API Key</param>
        /// <returns>ApiResponse of ListTagResponse</returns>
        ApiResponse<ListTagResponse> TagsListTagsWithHttpInfo(string apiKey);

        /// <summary>
        ///     Rename a tag
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tagName">Current tag name</param>
        /// <param name="newName">New tag name</param>
        /// <param name="apiKey">API Key</param>
        /// <returns></returns>
        void TagsUpdateTag(string tagName, string newName, string apiKey);

        /// <summary>
        ///     Rename a tag
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tagName">Current tag name</param>
        /// <param name="newName">New tag name</param>
        /// <param name="apiKey">API Key</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<object> TagsUpdateTagWithHttpInfo(string tagName, string newName, string apiKey);

        #endregion Synchronous Operations

        #region Asynchronous Operations

        /// <summary>
        ///     Create a tag
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tagName"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of void</returns>
        Task TagsAddTagAsync(string tagName, string apiKey);

        /// <summary>
        ///     Create a tag
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tagName"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<object>> TagsAddTagAsyncWithHttpInfo(string tagName, string apiKey);

        /// <summary>
        ///     Delete a tag
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tagName"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of ListTagResponse</returns>
        Task<ListTagResponse> TagsDeleteAsync(string tagName, string apiKey);

        /// <summary>
        ///     Delete a tag
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tagName"></param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of ApiResponse (ListTagResponse)</returns>
        Task<ApiResponse<ListTagResponse>> TagsDeleteAsyncWithHttpInfo(string tagName, string apiKey);

        /// <summary>
        ///     Get tags
        /// </summary>
        /// <remarks>
        ///     Get all tags associated with your account
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of ListTagResponse</returns>
        Task<ListTagResponse> TagsListTagsAsync(string apiKey);

        /// <summary>
        ///     Get tags
        /// </summary>
        /// <remarks>
        ///     Get all tags associated with your account
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of ApiResponse (ListTagResponse)</returns>
        Task<ApiResponse<ListTagResponse>> TagsListTagsAsyncWithHttpInfo(string apiKey);

        /// <summary>
        ///     Rename a tag
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tagName">Current tag name</param>
        /// <param name="newName">New tag name</param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of void</returns>
        Task TagsUpdateTagAsync(string tagName, string newName, string apiKey);

        /// <summary>
        ///     Rename a tag
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <exception cref="ShipEngine.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="tagName">Current tag name</param>
        /// <param name="newName">New tag name</param>
        /// <param name="apiKey">API Key</param>
        /// <returns>Task of ApiResponse</returns>
        Task<ApiResponse<object>> TagsUpdateTagAsyncWithHttpInfo(string tagName, string newName, string apiKey);

        #endregion Asynchronous Operations
    }
}