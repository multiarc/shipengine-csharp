# ShipEngine.ApiClient.Api.ShipmentsApi

All URIs are relative to *https://api.shipengine.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ShipmentsAddTag**](ShipmentsApi.md#shipmentsaddtag) | **POST** /v1/shipments/{shipment_id}/tags/{tag} | Add a tag to a shipment
[**ShipmentsCancel**](ShipmentsApi.md#shipmentscancel) | **PUT** /v1/shipments/{shipment_id}/cancel | Cancel a shipment
[**ShipmentsCreateShipments**](ShipmentsApi.md#shipmentscreateshipments) | **POST** /v1/shipments | Create multiple shipments
[**ShipmentsGet**](ShipmentsApi.md#shipmentsget) | **GET** /v1/shipments/{shipment_id} | Get a specific shipment
[**ShipmentsGetByExternalId**](ShipmentsApi.md#shipmentsgetbyexternalid) | **GET** /v1/shipments/external_shipment_id/{external_shipment_id} | Get a specific shipment by an external id
[**ShipmentsGetRatesForShipment**](ShipmentsApi.md#shipmentsgetratesforshipment) | **GET** /v1/shipments/{shipment_id}/rates | Get rates for a specific shipment
[**ShipmentsList**](ShipmentsApi.md#shipmentslist) | **GET** /v1/shipments | Get shipments
[**ShipmentsListErrors**](ShipmentsApi.md#shipmentslisterrors) | **GET** /v1/shipments/{shipment_id}/errors | Lists the errors.
[**ShipmentsRemoveTag**](ShipmentsApi.md#shipmentsremovetag) | **DELETE** /v1/shipments/{shipment_id}/tags/{tag} | Remove a tag from a shipment
[**ShipmentsUpdateShipment**](ShipmentsApi.md#shipmentsupdateshipment) | **PUT** /v1/shipments/{shipment_id} | Update a shipment


<a name="shipmentsaddtag"></a>
# **ShipmentsAddTag**
> ShipmentAddTagResponse ShipmentsAddTag (string shipmentId, string tag, string apiKey)

Add a tag to a shipment

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
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new ShipmentsApi();
            var shipmentId = shipmentId_example;  // string | 
            var tag = tag_example;  // string | Tag
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                // Add a tag to a shipment
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
 **tag** | **string**| Tag | 
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

Cancel a shipment

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
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new ShipmentsApi();
            var shipmentId = shipmentId_example;  // string | Shipment ID
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                // Cancel a shipment
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
 **shipmentId** | **string**| Shipment ID | 
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

Create multiple shipments

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
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new ShipmentsApi();
            var shipmentsRequest = new CreateShipmentsRequest(); // CreateShipmentsRequest | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                // Create multiple shipments
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

Get a specific shipment

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
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new ShipmentsApi();
            var shipmentId = shipmentId_example;  // string | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                // Get a specific shipment
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

Get a specific shipment by an external id

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
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new ShipmentsApi();
            var externalShipmentId = externalShipmentId_example;  // string | External Shipment Id
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                // Get a specific shipment by an external id
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
 **externalShipmentId** | **string**| External Shipment Id | 
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

Get rates for a specific shipment

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
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new ShipmentsApi();
            var shipmentId = shipmentId_example;  // string | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)
            var createdAtStart = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 

            try
            {
                // Get rates for a specific shipment
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

Get shipments

Get a list of shipments using optional criteria

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
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new ShipmentsApi();
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)
            var batchId = batchId_example;  // string | Retrieve shipments in the specified batch_id (optional) 
            var tag = tag_example;  // string | Retrieve shipments by assocated tag (optional) 
            var shipmentStatus = shipmentStatus_example;  // string | Shipment status (optional) 
            var modifiedAtStart = 2013-10-20T19:20:30+01:00;  // DateTime? | Modify date range start (optional) 
            var modifiedAtEnd = 2013-10-20T19:20:30+01:00;  // DateTime? | Modify date range end (optional) 
            var createdAtStart = 2013-10-20T19:20:30+01:00;  // DateTime? | Create date range start (optional) 
            var createdAtEnd = 2013-10-20T19:20:30+01:00;  // DateTime? | Create date range end (optional) 
            var page = 56;  // int? | Page number (optional) 
            var pageSize = 56;  // int? | Number of records per page (optional) 
            var sortDir = sortDir_example;  // string | Sort direction (optional) 
            var sortBy = sortBy_example;  // string | Sort by item (optional) 

            try
            {
                // Get shipments
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
 **batchId** | **string**| Retrieve shipments in the specified batch_id | [optional] 
 **tag** | **string**| Retrieve shipments by assocated tag | [optional] 
 **shipmentStatus** | **string**| Shipment status | [optional] 
 **modifiedAtStart** | **DateTime?**| Modify date range start | [optional] 
 **modifiedAtEnd** | **DateTime?**| Modify date range end | [optional] 
 **createdAtStart** | **DateTime?**| Create date range start | [optional] 
 **createdAtEnd** | **DateTime?**| Create date range end | [optional] 
 **page** | **int?**| Page number | [optional] 
 **pageSize** | **int?**| Number of records per page | [optional] 
 **sortDir** | **string**| Sort direction | [optional] 
 **sortBy** | **string**| Sort by item | [optional] 

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

Lists the errors.

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
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new ShipmentsApi();
            var shipmentId = shipmentId_example;  // string | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)
            var page = 56;  // int? | The page. (optional) 
            var pagesize = 56;  // int? |  (optional) 

            try
            {
                // Lists the errors.
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
 **page** | **int?**| The page. | [optional] 
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

Remove a tag from a shipment

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
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new ShipmentsApi();
            var shipmentId = shipmentId_example;  // string | 
            var tag = tag_example;  // string | Tag
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                // Remove a tag from a shipment
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
 **tag** | **string**| Tag | 
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
> CreateShipmentResponse ShipmentsUpdateShipment (string shipmentId, AddressValidatingShipment shipment, string apiKey)

Update a shipment

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
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new ShipmentsApi();
            var shipmentId = shipmentId_example;  // string | Shipment ID
            var shipment = new AddressValidatingShipment(); // AddressValidatingShipment | Shipment
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                // Update a shipment
                CreateShipmentResponse result = apiInstance.ShipmentsUpdateShipment(shipmentId, shipment, apiKey);
                Debug.WriteLine(result);
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
 **shipmentId** | **string**| Shipment ID | 
 **shipment** | [**AddressValidatingShipment**](AddressValidatingShipment.md)| Shipment | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

[**CreateShipmentResponse**](CreateShipmentResponse.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

