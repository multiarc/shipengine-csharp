# ShipEngine.ApiClient.Api.TrackingApi

All URIs are relative to *https://api.shipengine.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TrackingStartTracking**](TrackingApi.md#trackingstarttracking) | **POST** /v1/tracking/start | Starts tracking events notifications
[**TrackingStopTracking**](TrackingApi.md#trackingstoptracking) | **POST** /v1/tracking/stop | Stops tracking events notifications
[**TrackingTrack**](TrackingApi.md#trackingtrack) | **GET** /v1/tracking | Get tracking information


<a name="trackingstarttracking"></a>
# **TrackingStartTracking**
> void TrackingStartTracking (string apiKey, string carrierCode = null, string trackingNumber = null)

Starts tracking events notifications

Starts tracking events webhook notifications for a tracking number

### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class TrackingStartTrackingExample
    {
        public void main()
        {
            
            // Configure API key authorization: api-key
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new TrackingApi();
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)
            var carrierCode = carrierCode_example;  // string |  (optional) 
            var trackingNumber = trackingNumber_example;  // string |  (optional) 

            try
            {
                // Starts tracking events notifications
                apiInstance.TrackingStartTracking(apiKey, carrierCode, trackingNumber);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackingApi.TrackingStartTracking: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]
 **carrierCode** | **string**|  | [optional] 
 **trackingNumber** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="trackingstoptracking"></a>
# **TrackingStopTracking**
> void TrackingStopTracking (string apiKey, string carrierCode = null, string trackingNumber = null)

Stops tracking events notifications

Stops tracking events webhook notifications for a tracking number

### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class TrackingStopTrackingExample
    {
        public void main()
        {
            
            // Configure API key authorization: api-key
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new TrackingApi();
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)
            var carrierCode = carrierCode_example;  // string |  (optional) 
            var trackingNumber = trackingNumber_example;  // string |  (optional) 

            try
            {
                // Stops tracking events notifications
                apiInstance.TrackingStopTracking(apiKey, carrierCode, trackingNumber);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackingApi.TrackingStopTracking: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]
 **carrierCode** | **string**|  | [optional] 
 **trackingNumber** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="trackingtrack"></a>
# **TrackingTrack**
> TrackingInformation TrackingTrack (string apiKey, string carrierCode = null, string trackingNumber = null)

Get tracking information

Get tracking information by tracking number

### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class TrackingTrackExample
    {
        public void main()
        {
            
            // Configure API key authorization: api-key
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new TrackingApi();
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)
            var carrierCode = carrierCode_example;  // string |  (optional) 
            var trackingNumber = trackingNumber_example;  // string |  (optional) 

            try
            {
                // Get tracking information
                TrackingInformation result = apiInstance.TrackingTrack(apiKey, carrierCode, trackingNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TrackingApi.TrackingTrack: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]
 **carrierCode** | **string**|  | [optional] 
 **trackingNumber** | **string**|  | [optional] 

### Return type

[**TrackingInformation**](TrackingInformation.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

