# ShipEngine.ApiClient.Api.ManifestsApi

All URIs are relative to *https://api.shipengine.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ManifestsCreate**](ManifestsApi.md#manifestscreate) | **POST** /v1/manifests | 
[**ManifestsGet**](ManifestsApi.md#manifestsget) | **GET** /v1/manifests/{manifest_id} | 
[**ManifestsList**](ManifestsApi.md#manifestslist) | **GET** /v1/manifests | 


<a name="manifestscreate"></a>
# **ManifestsCreate**
> Manifest ManifestsCreate (CreateManifestRequest request, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class ManifestsCreateExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new ManifestsApi();
            var request = new CreateManifestRequest(); // CreateManifestRequest | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                Manifest result = apiInstance.ManifestsCreate(request, apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ManifestsApi.ManifestsCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**CreateManifestRequest**](CreateManifestRequest.md)|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

[**Manifest**](Manifest.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="manifestsget"></a>
# **ManifestsGet**
> Manifest ManifestsGet (string manifestId, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class ManifestsGetExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new ManifestsApi();
            var manifestId = manifestId_example;  // string | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                Manifest result = apiInstance.ManifestsGet(manifestId, apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ManifestsApi.ManifestsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **manifestId** | **string**|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

[**Manifest**](Manifest.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="manifestslist"></a>
# **ManifestsList**
> ManifestsListResponse ManifestsList (string apiKey, string warehouseId = null, DateTime? shipDateStart = null, DateTime? shipDateEnd = null, DateTime? createdAtStart = null, DateTime? createdAtEnd = null, string carrierId = null, int? page = null, int? pageSize = null)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class ManifestsListExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new ManifestsApi();
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)
            var warehouseId = warehouseId_example;  // string |  (optional) 
            var shipDateStart = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var shipDateEnd = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var createdAtStart = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var createdAtEnd = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var carrierId = carrierId_example;  // string |  (optional) 
            var page = 56;  // int? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 

            try
            {
                ManifestsListResponse result = apiInstance.ManifestsList(apiKey, warehouseId, shipDateStart, shipDateEnd, createdAtStart, createdAtEnd, carrierId, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ManifestsApi.ManifestsList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]
 **warehouseId** | **string**|  | [optional] 
 **shipDateStart** | **DateTime?**|  | [optional] 
 **shipDateEnd** | **DateTime?**|  | [optional] 
 **createdAtStart** | **DateTime?**|  | [optional] 
 **createdAtEnd** | **DateTime?**|  | [optional] 
 **carrierId** | **string**|  | [optional] 
 **page** | **int?**|  | [optional] 
 **pageSize** | **int?**|  | [optional] 

### Return type

[**ManifestsListResponse**](ManifestsListResponse.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

