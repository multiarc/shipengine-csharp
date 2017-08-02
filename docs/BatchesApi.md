# ShipEngine.ApiClient.Api.BatchesApi

All URIs are relative to *https://api.shipengine.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BatchesAddToBatch**](BatchesApi.md#batchesaddtobatch) | **POST** /v1/batches/{batch_id}/add | 
[**BatchesCreate**](BatchesApi.md#batchescreate) | **POST** /v1/batches | 
[**BatchesGet**](BatchesApi.md#batchesget) | **GET** /v1/batches/{batch_id} | 
[**BatchesGetByExternalId**](BatchesApi.md#batchesgetbyexternalid) | **GET** /v1/batches/external_batch_id/{external_batch_id} | 
[**BatchesList**](BatchesApi.md#batcheslist) | **GET** /v1/batches | 
[**BatchesListErrors**](BatchesApi.md#batcheslisterrors) | **GET** /v1/batches/{batch_id}/errors | 
[**BatchesProcess**](BatchesApi.md#batchesprocess) | **POST** /v1/batches/{batch_id}/process/labels | 
[**BatchesRemoveFromBatch**](BatchesApi.md#batchesremovefrombatch) | **POST** /v1/batches/{batch_id}/remove | 


<a name="batchesaddtobatch"></a>
# **BatchesAddToBatch**
> void BatchesAddToBatch (string batchId, ModifyBatchRequest request, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class BatchesAddToBatchExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new BatchesApi();
            var batchId = batchId_example;  // string | 
            var request = new ModifyBatchRequest(); // ModifyBatchRequest | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                apiInstance.BatchesAddToBatch(batchId, request, apiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BatchesApi.BatchesAddToBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **batchId** | **string**|  | 
 **request** | [**ModifyBatchRequest**](ModifyBatchRequest.md)|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="batchescreate"></a>
# **BatchesCreate**
> Batch BatchesCreate (CreateBatchRequest request, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class BatchesCreateExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new BatchesApi();
            var request = new CreateBatchRequest(); // CreateBatchRequest | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                Batch result = apiInstance.BatchesCreate(request, apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BatchesApi.BatchesCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**CreateBatchRequest**](CreateBatchRequest.md)|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

[**Batch**](Batch.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="batchesget"></a>
# **BatchesGet**
> Batch BatchesGet (string batchId, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class BatchesGetExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new BatchesApi();
            var batchId = batchId_example;  // string | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                Batch result = apiInstance.BatchesGet(batchId, apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BatchesApi.BatchesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **batchId** | **string**|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

[**Batch**](Batch.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="batchesgetbyexternalid"></a>
# **BatchesGetByExternalId**
> void BatchesGetByExternalId (string externalBatchId, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class BatchesGetByExternalIdExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new BatchesApi();
            var externalBatchId = externalBatchId_example;  // string | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                apiInstance.BatchesGetByExternalId(externalBatchId, apiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BatchesApi.BatchesGetByExternalId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **externalBatchId** | **string**|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="batcheslist"></a>
# **BatchesList**
> ListBatchResponse BatchesList (string apiKey, string status = null, int? page = null, int? pageSize = null, string sortDir = null, string sortBy = null)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class BatchesListExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new BatchesApi();
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)
            var status = status_example;  // string |  (optional) 
            var page = 56;  // int? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 
            var sortDir = sortDir_example;  // string |  (optional) 
            var sortBy = sortBy_example;  // string |  (optional) 

            try
            {
                ListBatchResponse result = apiInstance.BatchesList(apiKey, status, page, pageSize, sortDir, sortBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BatchesApi.BatchesList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]
 **status** | **string**|  | [optional] 
 **page** | **int?**|  | [optional] 
 **pageSize** | **int?**|  | [optional] 
 **sortDir** | **string**|  | [optional] 
 **sortBy** | **string**|  | [optional] 

### Return type

[**ListBatchResponse**](ListBatchResponse.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="batcheslisterrors"></a>
# **BatchesListErrors**
> BatchResponseErrors BatchesListErrors (string batchId, string apiKey, int? page = null, int? pagesize = null)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class BatchesListErrorsExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new BatchesApi();
            var batchId = batchId_example;  // string | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)
            var page = 56;  // int? |  (optional) 
            var pagesize = 56;  // int? |  (optional) 

            try
            {
                BatchResponseErrors result = apiInstance.BatchesListErrors(batchId, apiKey, page, pagesize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BatchesApi.BatchesListErrors: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **batchId** | **string**|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]
 **page** | **int?**|  | [optional] 
 **pagesize** | **int?**|  | [optional] 

### Return type

[**BatchResponseErrors**](BatchResponseErrors.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="batchesprocess"></a>
# **BatchesProcess**
> void BatchesProcess (string batchId, ProcessBatchRequest processBatchRequest, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class BatchesProcessExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new BatchesApi();
            var batchId = batchId_example;  // string | 
            var processBatchRequest = new ProcessBatchRequest(); // ProcessBatchRequest | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                apiInstance.BatchesProcess(batchId, processBatchRequest, apiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BatchesApi.BatchesProcess: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **batchId** | **string**|  | 
 **processBatchRequest** | [**ProcessBatchRequest**](ProcessBatchRequest.md)|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="batchesremovefrombatch"></a>
# **BatchesRemoveFromBatch**
> void BatchesRemoveFromBatch (string batchId, ModifyBatchRequest request, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class BatchesRemoveFromBatchExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new BatchesApi();
            var batchId = batchId_example;  // string | 
            var request = new ModifyBatchRequest(); // ModifyBatchRequest | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                apiInstance.BatchesRemoveFromBatch(batchId, request, apiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BatchesApi.BatchesRemoveFromBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **batchId** | **string**|  | 
 **request** | [**ModifyBatchRequest**](ModifyBatchRequest.md)|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

