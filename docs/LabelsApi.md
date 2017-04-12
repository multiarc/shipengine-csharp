# IO.Swagger.Api.LabelsApi

All URIs are relative to *https://api.shipengine.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**LabelsGet**](LabelsApi.md#labelsget) | **GET** /v1/labels/{label_id} | Get a specific Label
[**LabelsList**](LabelsApi.md#labelslist) | **GET** /v1/labels | Get labels
[**LabelsPurchaseLabel**](LabelsApi.md#labelspurchaselabel) | **POST** /v1/labels | Purchase a label by providing full shipment info
[**LabelsPurchaseLabelWithRate**](LabelsApi.md#labelspurchaselabelwithrate) | **POST** /v1/labels/rates/{rate_id} | Purchase a label using a rate
[**LabelsPurchaseLabelWithShipment**](LabelsApi.md#labelspurchaselabelwithshipment) | **POST** /v1/labels/shipment/{shipment_id} | Purchase a label using an existing shipment
[**LabelsTrack**](LabelsApi.md#labelstrack) | **GET** /v1/labels/{label_id}/track | Get tracking information for a label
[**LabelsVoidLabel**](LabelsApi.md#labelsvoidlabel) | **PUT** /v1/labels/{label_id}/void | Void a label


<a name="labelsget"></a>
# **LabelsGet**
> Label LabelsGet (string labelId, string apiKey)

Get a specific Label

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LabelsGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: api-key
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new LabelsApi();
            var labelId = labelId_example;  // string | Label ID
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                // Get a specific Label
                Label result = apiInstance.LabelsGet(labelId, apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LabelsApi.LabelsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **labelId** | **string**| Label ID | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

[**Label**](Label.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="labelslist"></a>
# **LabelsList**
> ListLabelResponse LabelsList (string apiKey, string batchId = null, string labelStatus = null, string carrierId = null, string serviceCode = null, string trackingNumber = null, string warehouseId = null, DateTime? createdAtStart = null, DateTime? createdAtEnd = null, int? page = null, int? pageSize = null, string sortDir = null, string sortBy = null)

Get labels

Get a list of labels using optional criteria

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LabelsListExample
    {
        public void main()
        {
            
            // Configure API key authorization: api-key
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new LabelsApi();
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)
            var batchId = batchId_example;  // string | Batch ID (optional) 
            var labelStatus = labelStatus_example;  // string |  (optional) 
            var carrierId = carrierId_example;  // string | Carrier ID (optional) 
            var serviceCode = serviceCode_example;  // string |  (optional) 
            var trackingNumber = trackingNumber_example;  // string | Tracking Number (optional) 
            var warehouseId = warehouseId_example;  // string | Warehouse ID (optional) 
            var createdAtStart = 2013-10-20T19:20:30+01:00;  // DateTime? | Create date range start (optional) 
            var createdAtEnd = 2013-10-20T19:20:30+01:00;  // DateTime? | Create date range end (optional) 
            var page = 56;  // int? | Page number (optional) 
            var pageSize = 56;  // int? | Number of records per page (optional) 
            var sortDir = sortDir_example;  // string | Sort direction (optional) 
            var sortBy = sortBy_example;  // string | Sort by item (optional) 

            try
            {
                // Get labels
                ListLabelResponse result = apiInstance.LabelsList(apiKey, batchId, labelStatus, carrierId, serviceCode, trackingNumber, warehouseId, createdAtStart, createdAtEnd, page, pageSize, sortDir, sortBy);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LabelsApi.LabelsList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]
 **batchId** | **string**| Batch ID | [optional] 
 **labelStatus** | **string**|  | [optional] 
 **carrierId** | **string**| Carrier ID | [optional] 
 **serviceCode** | **string**|  | [optional] 
 **trackingNumber** | **string**| Tracking Number | [optional] 
 **warehouseId** | **string**| Warehouse ID | [optional] 
 **createdAtStart** | **DateTime?**| Create date range start | [optional] 
 **createdAtEnd** | **DateTime?**| Create date range end | [optional] 
 **page** | **int?**| Page number | [optional] 
 **pageSize** | **int?**| Number of records per page | [optional] 
 **sortDir** | **string**| Sort direction | [optional] 
 **sortBy** | **string**| Sort by item | [optional] 

### Return type

[**ListLabelResponse**](ListLabelResponse.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="labelspurchaselabel"></a>
# **LabelsPurchaseLabel**
> Label LabelsPurchaseLabel (PurchaseLabelRequest request, string apiKey)

Purchase a label by providing full shipment info

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LabelsPurchaseLabelExample
    {
        public void main()
        {
            
            // Configure API key authorization: api-key
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new LabelsApi();
            var request = new PurchaseLabelRequest(); // PurchaseLabelRequest | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                // Purchase a label by providing full shipment info
                Label result = apiInstance.LabelsPurchaseLabel(request, apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LabelsApi.LabelsPurchaseLabel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**PurchaseLabelRequest**](PurchaseLabelRequest.md)|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

[**Label**](Label.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="labelspurchaselabelwithrate"></a>
# **LabelsPurchaseLabelWithRate**
> Label LabelsPurchaseLabelWithRate (string rateId, PurchaseLabelWithoutShipmentRequest request, string apiKey)

Purchase a label using a rate

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LabelsPurchaseLabelWithRateExample
    {
        public void main()
        {
            
            // Configure API key authorization: api-key
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new LabelsApi();
            var rateId = rateId_example;  // string | 
            var request = new PurchaseLabelWithoutShipmentRequest(); // PurchaseLabelWithoutShipmentRequest | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                // Purchase a label using a rate
                Label result = apiInstance.LabelsPurchaseLabelWithRate(rateId, request, apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LabelsApi.LabelsPurchaseLabelWithRate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rateId** | **string**|  | 
 **request** | [**PurchaseLabelWithoutShipmentRequest**](PurchaseLabelWithoutShipmentRequest.md)|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

[**Label**](Label.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="labelspurchaselabelwithshipment"></a>
# **LabelsPurchaseLabelWithShipment**
> Label LabelsPurchaseLabelWithShipment (string shipmentId, PurchaseLabelWithoutShipmentRequest request, string apiKey)

Purchase a label using an existing shipment

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LabelsPurchaseLabelWithShipmentExample
    {
        public void main()
        {
            
            // Configure API key authorization: api-key
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new LabelsApi();
            var shipmentId = shipmentId_example;  // string | 
            var request = new PurchaseLabelWithoutShipmentRequest(); // PurchaseLabelWithoutShipmentRequest | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                // Purchase a label using an existing shipment
                Label result = apiInstance.LabelsPurchaseLabelWithShipment(shipmentId, request, apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LabelsApi.LabelsPurchaseLabelWithShipment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **shipmentId** | **string**|  | 
 **request** | [**PurchaseLabelWithoutShipmentRequest**](PurchaseLabelWithoutShipmentRequest.md)|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

[**Label**](Label.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="labelstrack"></a>
# **LabelsTrack**
> TrackingInformation LabelsTrack (string labelId, string apiKey)

Get tracking information for a label

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LabelsTrackExample
    {
        public void main()
        {
            
            // Configure API key authorization: api-key
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new LabelsApi();
            var labelId = labelId_example;  // string | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                // Get tracking information for a label
                TrackingInformation result = apiInstance.LabelsTrack(labelId, apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LabelsApi.LabelsTrack: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **labelId** | **string**|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

[**TrackingInformation**](TrackingInformation.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="labelsvoidlabel"></a>
# **LabelsVoidLabel**
> VoidLabelResponse LabelsVoidLabel (string labelId, string apiKey)

Void a label

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LabelsVoidLabelExample
    {
        public void main()
        {
            
            // Configure API key authorization: api-key
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new LabelsApi();
            var labelId = labelId_example;  // string | Label ID
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                // Void a label
                VoidLabelResponse result = apiInstance.LabelsVoidLabel(labelId, apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LabelsApi.LabelsVoidLabel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **labelId** | **string**| Label ID | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

[**VoidLabelResponse**](VoidLabelResponse.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

