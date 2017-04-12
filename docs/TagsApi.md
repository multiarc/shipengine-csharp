# IO.Swagger.Api.TagsApi

All URIs are relative to *https://api.shipengine.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TagsAddTag**](TagsApi.md#tagsaddtag) | **POST** /v1/tags/{tag_name} | Create a tag
[**TagsDelete**](TagsApi.md#tagsdelete) | **DELETE** /v1/tags/{tag_name} | Delete a tag
[**TagsListTags**](TagsApi.md#tagslisttags) | **GET** /v1/tags | Get tags
[**TagsUpdateTag**](TagsApi.md#tagsupdatetag) | **PUT** /v1/tags/{tag_name}/{new_name} | Rename a tag


<a name="tagsaddtag"></a>
# **TagsAddTag**
> void TagsAddTag (string tagName, string apiKey)

Create a tag

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TagsAddTagExample
    {
        public void main()
        {
            
            // Configure API key authorization: api-key
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new TagsApi();
            var tagName = tagName_example;  // string | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                // Create a tag
                apiInstance.TagsAddTag(tagName, apiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagsApi.TagsAddTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tagName** | **string**|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagsdelete"></a>
# **TagsDelete**
> ListTagResponse TagsDelete (string tagName, string apiKey)

Delete a tag

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TagsDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: api-key
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new TagsApi();
            var tagName = tagName_example;  // string | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                // Delete a tag
                ListTagResponse result = apiInstance.TagsDelete(tagName, apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagsApi.TagsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tagName** | **string**|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

[**ListTagResponse**](ListTagResponse.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagslisttags"></a>
# **TagsListTags**
> ListTagResponse TagsListTags (string apiKey)

Get tags

Get all tags associated with your account

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TagsListTagsExample
    {
        public void main()
        {
            
            // Configure API key authorization: api-key
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new TagsApi();
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                // Get tags
                ListTagResponse result = apiInstance.TagsListTags(apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagsApi.TagsListTags: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

[**ListTagResponse**](ListTagResponse.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tagsupdatetag"></a>
# **TagsUpdateTag**
> void TagsUpdateTag (string tagName, string newName, string apiKey)

Rename a tag

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TagsUpdateTagExample
    {
        public void main()
        {
            
            // Configure API key authorization: api-key
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new TagsApi();
            var tagName = tagName_example;  // string | Current tag name
            var newName = newName_example;  // string | New tag name
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                // Rename a tag
                apiInstance.TagsUpdateTag(tagName, newName, apiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TagsApi.TagsUpdateTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tagName** | **string**| Current tag name | 
 **newName** | **string**| New tag name | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

