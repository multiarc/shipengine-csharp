# IO.Swagger.Api.WarehousesApi

All URIs are relative to *https://api.shipengine.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**WarehousesCreate**](WarehousesApi.md#warehousescreate) | **POST** /v1/warehouses | Create a warehouse
[**WarehousesDelete**](WarehousesApi.md#warehousesdelete) | **DELETE** /v1/warehouses/{warehouse_id} | Delete a warehouse
[**WarehousesGet**](WarehousesApi.md#warehousesget) | **GET** /v1/warehouses/{warehouse_id} | Get a specific warehouse
[**WarehousesList**](WarehousesApi.md#warehouseslist) | **GET** /v1/warehouses | Get warehouses
[**WarehousesUpdate**](WarehousesApi.md#warehousesupdate) | **PUT** /v1/warehouses/{warehouse_id} | Update a warehouse


<a name="warehousescreate"></a>
# **WarehousesCreate**
> WarehouseDTO WarehousesCreate (WarehouseRequest request, string apiKey)

Create a warehouse

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WarehousesCreateExample
    {
        public void main()
        {
            
            // Configure API key authorization: api-key
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new WarehousesApi();
            var request = new WarehouseRequest(); // WarehouseRequest | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                // Create a warehouse
                WarehouseDTO result = apiInstance.WarehousesCreate(request, apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehousesApi.WarehousesCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **request** | [**WarehouseRequest**](WarehouseRequest.md)|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

[**WarehouseDTO**](WarehouseDTO.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="warehousesdelete"></a>
# **WarehousesDelete**
> void WarehousesDelete (string warehouseId, string apiKey)

Delete a warehouse

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WarehousesDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: api-key
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new WarehousesApi();
            var warehouseId = warehouseId_example;  // string | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                // Delete a warehouse
                apiInstance.WarehousesDelete(warehouseId, apiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehousesApi.WarehousesDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **warehouseId** | **string**|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="warehousesget"></a>
# **WarehousesGet**
> WarehouseDTO WarehousesGet (string warehouseId, string apiKey)

Get a specific warehouse

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WarehousesGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: api-key
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new WarehousesApi();
            var warehouseId = warehouseId_example;  // string | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                // Get a specific warehouse
                WarehouseDTO result = apiInstance.WarehousesGet(warehouseId, apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehousesApi.WarehousesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **warehouseId** | **string**|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

[**WarehouseDTO**](WarehouseDTO.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="warehouseslist"></a>
# **WarehousesList**
> WarehouseListDTO WarehousesList (string apiKey)

Get warehouses

Get a list of Warehouses

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WarehousesListExample
    {
        public void main()
        {
            
            // Configure API key authorization: api-key
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new WarehousesApi();
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                // Get warehouses
                WarehouseListDTO result = apiInstance.WarehousesList(apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehousesApi.WarehousesList: " + e.Message );
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

[**WarehouseListDTO**](WarehouseListDTO.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="warehousesupdate"></a>
# **WarehousesUpdate**
> void WarehousesUpdate (string warehouseId, WarehouseRequest request, string apiKey)

Update a warehouse

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WarehousesUpdateExample
    {
        public void main()
        {
            
            // Configure API key authorization: api-key
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new WarehousesApi();
            var warehouseId = warehouseId_example;  // string | 
            var request = new WarehouseRequest(); // WarehouseRequest | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                // Update a warehouse
                apiInstance.WarehousesUpdate(warehouseId, request, apiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WarehousesApi.WarehousesUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **warehouseId** | **string**|  | 
 **request** | [**WarehouseRequest**](WarehouseRequest.md)|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

