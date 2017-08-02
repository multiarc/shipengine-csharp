# ShipEngine.ApiClient.Api.ShipmentsApi

All URIs are relative to *https://api.shipengine.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ShipmentsAddTag**](ShipmentsApi.md#shipmentsaddtag) | **POST** /v1/shipments/{shipment_id}/tags/{tag} | 
[**ShipmentsCancel**](ShipmentsApi.md#shipmentscancel) | **PUT** /v1/shipments/{shipment_id}/cancel | 
[**ShipmentsCreateShipments**](ShipmentsApi.md#shipmentscreateshipments) | **POST** /v1/shipments | 
[**ShipmentsGet**](ShipmentsApi.md#shipmentsget) | **GET** /v1/shipments/{shipment_id} | 
[**ShipmentsGetByExternalId**](ShipmentsApi.md#shipmentsgetbyexternalid) | **GET** /v1/shipments/external_shipment_id/{external_shipment_id} | 
[**ShipmentsGetRatesForShipment**](ShipmentsApi.md#shipmentsgetratesforshipment) | **GET** /v1/shipments/{shipment_id}/rates | 
[**ShipmentsList**](ShipmentsApi.md#shipmentslist) | **GET** /v1/shipments | 
[**ShipmentsListErrors**](ShipmentsApi.md#shipmentslisterrors) | **GET** /v1/shipments/{shipment_id}/errors | 
[**ShipmentsRemoveTag**](ShipmentsApi.md#shipmentsremovetag) | **DELETE** /v1/shipments/{shipment_id}/tags/{tag} | 
[**ShipmentsUpdateShipment**](ShipmentsApi.md#shipmentsupdateshipment) | **PUT** /v1/shipments/{shipment_id} | 


<a name="shipmentsaddtag"></a>
# **ShipmentsAddTag**
> ShipmentAddTagResponse ShipmentsAddTag (string shipmentId, string tag, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class ShipmentsAddTagExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new ShipmentsApi();
            var shipmentId = shipmentId_example;  // string | 
            var tag = tag_example;  // string | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                ShipmentAddTagResponse result = apiInstance.ShipmentsAddTag(shipmentId, tag, apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShipmentsApi.ShipmentsAddTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **shipmentId** | **string**|  | 
 **tag** | **string**|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

[**ShipmentAddTagResponse**](ShipmentAddTagResponse.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="shipmentscancel"></a>
# **ShipmentsCancel**
> void ShipmentsCancel (string shipmentId, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class ShipmentsCancelExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new ShipmentsApi();
            var shipmentId = shipmentId_example;  // string | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                apiInstance.ShipmentsCancel(shipmentId, apiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShipmentsApi.ShipmentsCancel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **shipmentId** | **string**|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="shipmentscreateshipments"></a>
# **ShipmentsCreateShipments**
> CreateShipmentsResponse ShipmentsCreateShipments (CreateShipmentsRequest shipmentsRequest, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class ShipmentsCreateShipmentsExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new ShipmentsApi();
            var shipmentsRequest = new CreateShipmentsRequest(); // CreateShipmentsRequest | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                CreateShipmentsResponse result = apiInstance.ShipmentsCreateShipments(shipmentsRequest, apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShipmentsApi.ShipmentsCreateShipments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **shipmentsRequest** | [**CreateShipmentsRequest**](CreateShipmentsRequest.md)|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

[**CreateShipmentsResponse**](CreateShipmentsResponse.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="shipmentsget"></a>
# **ShipmentsGet**
> Shipment ShipmentsGet (string shipmentId, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class ShipmentsGetExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new ShipmentsApi();
            var shipmentId = shipmentId_example;  // string | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                Shipment result = apiInstance.ShipmentsGet(shipmentId, apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShipmentsApi.ShipmentsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **shipmentId** | **string**|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

[**Shipment**](Shipment.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="shipmentsgetbyexternalid"></a>
# **ShipmentsGetByExternalId**
> Shipment ShipmentsGetByExternalId (string externalShipmentId, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class ShipmentsGetByExternalIdExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new ShipmentsApi();
            var externalShipmentId = externalShipmentId_example;  // string | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                Shipment result = apiInstance.ShipmentsGetByExternalId(externalShipmentId, apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShipmentsApi.ShipmentsGetByExternalId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **externalShipmentId** | **string**|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

[**Shipment**](Shipment.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="shipmentsgetratesforshipment"></a>
# **ShipmentsGetRatesForShipment**
> RateResponse ShipmentsGetRatesForShipment (string shipmentId, string apiKey, DateTime? createdAtStart = null)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class ShipmentsGetRatesForShipmentExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new ShipmentsApi();
            var shipmentId = shipmentId_example;  // string | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)
            var createdAtStart = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 

            try
            {
                RateResponse result = apiInstance.ShipmentsGetRatesForShipment(shipmentId, apiKey, createdAtStart);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShipmentsApi.ShipmentsGetRatesForShipment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **shipmentId** | **string**|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]
 **createdAtStart** | **DateTime?**|  | [optional] 

### Return type

[**RateResponse**](RateResponse.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="shipmentslist"></a>
# **ShipmentsList**
> ListShipmentResponse ShipmentsList (string apiKey, string batchId = null, string tag = null, string shipmentStatus = null, DateTime? modifiedAtStart = null, DateTime? modifiedAtEnd = null, DateTime? createdAtStart = null, DateTime? createdAtEnd = null, int? page = null, int? pageSize = null, string sortDir = null, string sortBy = null)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class ShipmentsListExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new ShipmentsApi();
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)
            var batchId = batchId_example;  // string |  (optional) 
            var tag = tag_example;  // string |  (optional) 
            var shipmentStatus = shipmentStatus_example;  // string |  (optional) 
            var modifiedAtStart = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var modifiedAtEnd = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var createdAtStart = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var createdAtEnd = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var page = 56;  // int? |  (optional) 
            var pageSize = 56;  // int? |  (optional) 
            var sortDir = sortDir_example;  // string |  (optional) 
            var sortBy = sortBy_example;  // string |  (optional) 

            try
            {
                ListShipmentResponse result = apiInstance.ShipmentsList(apiKey, batchId, tag, shipmentStatus, modifiedAtStart, modifiedAtEnd, createdAtStart, createdAtEnd, page, pageSize, sortDir, sortBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShipmentsApi.ShipmentsList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]
 **batchId** | **string**|  | [optional] 
 **tag** | **string**|  | [optional] 
 **shipmentStatus** | **string**|  | [optional] 
 **modifiedAtStart** | **DateTime?**|  | [optional] 
 **modifiedAtEnd** | **DateTime?**|  | [optional] 
 **createdAtStart** | **DateTime?**|  | [optional] 
 **createdAtEnd** | **DateTime?**|  | [optional] 
 **page** | **int?**|  | [optional] 
 **pageSize** | **int?**|  | [optional] 
 **sortDir** | **string**|  | [optional] 
 **sortBy** | **string**|  | [optional] 

### Return type

[**ListShipmentResponse**](ListShipmentResponse.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="shipmentslisterrors"></a>
# **ShipmentsListErrors**
> ShipmentResponseErrors ShipmentsListErrors (string shipmentId, string apiKey, int? page = null, int? pagesize = null)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class ShipmentsListErrorsExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new ShipmentsApi();
            var shipmentId = shipmentId_example;  // string | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)
            var page = 56;  // int? |  (optional) 
            var pagesize = 56;  // int? |  (optional) 

            try
            {
                ShipmentResponseErrors result = apiInstance.ShipmentsListErrors(shipmentId, apiKey, page, pagesize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShipmentsApi.ShipmentsListErrors: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **shipmentId** | **string**|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]
 **page** | **int?**|  | [optional] 
 **pagesize** | **int?**|  | [optional] 

### Return type

[**ShipmentResponseErrors**](ShipmentResponseErrors.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="shipmentsremovetag"></a>
# **ShipmentsRemoveTag**
> void ShipmentsRemoveTag (string shipmentId, string tag, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class ShipmentsRemoveTagExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new ShipmentsApi();
            var shipmentId = shipmentId_example;  // string | 
            var tag = tag_example;  // string | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                apiInstance.ShipmentsRemoveTag(shipmentId, tag, apiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShipmentsApi.ShipmentsRemoveTag: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **shipmentId** | **string**|  | 
 **tag** | **string**|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="shipmentsupdateshipment"></a>
# **ShipmentsUpdateShipment**
> void ShipmentsUpdateShipment (string shipmentId, AddressValidatingShipment shipment, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class ShipmentsUpdateShipmentExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new ShipmentsApi();
            var shipmentId = shipmentId_example;  // string | 
            var shipment = new AddressValidatingShipment(); // AddressValidatingShipment | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                apiInstance.ShipmentsUpdateShipment(shipmentId, shipment, apiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShipmentsApi.ShipmentsUpdateShipment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **shipmentId** | **string**|  | 
 **shipment** | [**AddressValidatingShipment**](AddressValidatingShipment.md)|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

