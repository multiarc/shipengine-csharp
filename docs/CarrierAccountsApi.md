# ShipEngine.ApiClient.Api.CarrierAccountsApi

All URIs are relative to *https://api.shipengine.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AccessWorldwideAccountCarrierConnectAccount**](CarrierAccountsApi.md#accessworldwideaccountcarrierconnectaccount) | **POST** /v1/connections/carriers/access_worldwide | 
[**AccessWorldwideAccountCarrierDisconnectAccount**](CarrierAccountsApi.md#accessworldwideaccountcarrierdisconnectaccount) | **DELETE** /v1/connections/carriers/access_worldwide/{carrier_id} | 
[**ApcAccountCarrierConnectAccount**](CarrierAccountsApi.md#apcaccountcarrierconnectaccount) | **POST** /v1/connections/carriers/apc | 
[**ApcAccountCarrierDisconnectAccount**](CarrierAccountsApi.md#apcaccountcarrierdisconnectaccount) | **DELETE** /v1/connections/carriers/apc/{carrier_id} | 
[**AsendiaAccountCarrierConnectAccount**](CarrierAccountsApi.md#asendiaaccountcarrierconnectaccount) | **POST** /v1/connections/carriers/asendia | 
[**AsendiaAccountCarrierDisconnectAccount**](CarrierAccountsApi.md#asendiaaccountcarrierdisconnectaccount) | **DELETE** /v1/connections/carriers/asendia/{carrier_id} | 
[**DHLExpressAccountCarrierConnectAccount**](CarrierAccountsApi.md#dhlexpressaccountcarrierconnectaccount) | **POST** /v1/connections/carriers/dhl_express | 
[**DHLExpressAccountCarrierDisconnectAccount**](CarrierAccountsApi.md#dhlexpressaccountcarrierdisconnectaccount) | **DELETE** /v1/connections/carriers/dhl_express/{carrier_id} | 
[**DHLExpressAccountCarrierUpdateSettings**](CarrierAccountsApi.md#dhlexpressaccountcarrierupdatesettings) | **PUT** /v1/connections/carriers/dhl_express/{carrier_id}/settings | 
[**EndiciaAccountCarrierConnectAccount**](CarrierAccountsApi.md#endiciaaccountcarrierconnectaccount) | **POST** /v1/connections/carriers/endicia | 
[**EndiciaAccountCarrierDisconnectAccount**](CarrierAccountsApi.md#endiciaaccountcarrierdisconnectaccount) | **DELETE** /v1/connections/carriers/endicia/{carrier_id} | 
[**FedExAccountCarrierConnectAccount**](CarrierAccountsApi.md#fedexaccountcarrierconnectaccount) | **POST** /v1/connections/carriers/fedex | 
[**FedExAccountCarrierDisconnectAccount**](CarrierAccountsApi.md#fedexaccountcarrierdisconnectaccount) | **DELETE** /v1/connections/carriers/fedex/{carrier_id} | 
[**FedExAccountCarrierUpdateSettings**](CarrierAccountsApi.md#fedexaccountcarrierupdatesettings) | **PUT** /v1/connections/carriers/fedex/{carrier_id}/settings | 
[**FirstMileAccountCarrierConnectAccount**](CarrierAccountsApi.md#firstmileaccountcarrierconnectaccount) | **POST** /v1/connections/carriers/firstmile | 
[**FirstMileAccountCarrierDisconnectAccount**](CarrierAccountsApi.md#firstmileaccountcarrierdisconnectaccount) | **DELETE** /v1/connections/carriers/firstmile/{carrier_id} | 
[**GlobegisticsAccountCarrierConnectAccount**](CarrierAccountsApi.md#globegisticsaccountcarrierconnectaccount) | **POST** /v1/connections/carriers/globegistics | 
[**GlobegisticsAccountCarrierDisconnectAccount**](CarrierAccountsApi.md#globegisticsaccountcarrierdisconnectaccount) | **DELETE** /v1/connections/carriers/globegistics/{carrier_id} | 
[**ImexAccountCarrierConnectAccount**](CarrierAccountsApi.md#imexaccountcarrierconnectaccount) | **POST** /v1/connections/carriers/imex | 
[**ImexAccountCarrierDisconnectAccount**](CarrierAccountsApi.md#imexaccountcarrierdisconnectaccount) | **DELETE** /v1/connections/carriers/imex/{carrier_id} | 
[**NewgisticsAccountCarrierConnectAccount**](CarrierAccountsApi.md#newgisticsaccountcarrierconnectaccount) | **POST** /v1/connections/carriers/newgistics | 
[**NewgisticsAccountCarrierDisconnectAccount**](CarrierAccountsApi.md#newgisticsaccountcarrierdisconnectaccount) | **DELETE** /v1/connections/carriers/newgistics/{carrier_id} | 
[**NewgisticsAccountCarrierUpdateSettings**](CarrierAccountsApi.md#newgisticsaccountcarrierupdatesettings) | **PUT** /v1/connections/carriers/newgistics/{carrier_id}/settings | 
[**OnTracAccountCarrierConnectAccount**](CarrierAccountsApi.md#ontracaccountcarrierconnectaccount) | **POST** /v1/connections/carriers/ontrac | 
[**OnTracAccountCarrierDisconnectAccount**](CarrierAccountsApi.md#ontracaccountcarrierdisconnectaccount) | **DELETE** /v1/connections/carriers/ontrac/{carrier_id} | 
[**RrDonnelleyAccountCarrierConnectAccount**](CarrierAccountsApi.md#rrdonnelleyaccountcarrierconnectaccount) | **POST** /v1/connections/carriers/rr_donnelley | 
[**RrDonnelleyAccountCarrierDisconnectAccount**](CarrierAccountsApi.md#rrdonnelleyaccountcarrierdisconnectaccount) | **DELETE** /v1/connections/carriers/rr_donnelley/{carrier_id} | 
[**StampsAccountCarrierConnectAccount**](CarrierAccountsApi.md#stampsaccountcarrierconnectaccount) | **POST** /v1/connections/carriers/stamps_com | 
[**StampsAccountCarrierDisconnectAccount**](CarrierAccountsApi.md#stampsaccountcarrierdisconnectaccount) | **DELETE** /v1/connections/carriers/stamps_com/{carrier_id} | 
[**UPSAccountCarrierConnectAccount**](CarrierAccountsApi.md#upsaccountcarrierconnectaccount) | **POST** /v1/connections/carriers/ups | 
[**UPSAccountCarrierDisconnectAccount**](CarrierAccountsApi.md#upsaccountcarrierdisconnectaccount) | **DELETE** /v1/connections/carriers/ups/{carrier_id} | 
[**UPSAccountCarrierUpdateSettings**](CarrierAccountsApi.md#upsaccountcarrierupdatesettings) | **PUT** /v1/connections/carriers/ups/{carrier_id}/settings | 


<a name="accessworldwideaccountcarrierconnectaccount"></a>
# **AccessWorldwideAccountCarrierConnectAccount**
> ConnectAccountResponseDTO AccessWorldwideAccountCarrierConnectAccount (AccessWorldwideAccountInformationDTO model, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class AccessWorldwideAccountCarrierConnectAccountExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new CarrierAccountsApi();
            var model = new AccessWorldwideAccountInformationDTO(); // AccessWorldwideAccountInformationDTO | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                ConnectAccountResponseDTO result = apiInstance.AccessWorldwideAccountCarrierConnectAccount(model, apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CarrierAccountsApi.AccessWorldwideAccountCarrierConnectAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**AccessWorldwideAccountInformationDTO**](AccessWorldwideAccountInformationDTO.md)|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

[**ConnectAccountResponseDTO**](ConnectAccountResponseDTO.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accessworldwideaccountcarrierdisconnectaccount"></a>
# **AccessWorldwideAccountCarrierDisconnectAccount**
> void AccessWorldwideAccountCarrierDisconnectAccount (string carrierId, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class AccessWorldwideAccountCarrierDisconnectAccountExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new CarrierAccountsApi();
            var carrierId = carrierId_example;  // string | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                apiInstance.AccessWorldwideAccountCarrierDisconnectAccount(carrierId, apiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CarrierAccountsApi.AccessWorldwideAccountCarrierDisconnectAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **carrierId** | **string**|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apcaccountcarrierconnectaccount"></a>
# **ApcAccountCarrierConnectAccount**
> ConnectAccountResponseDTO ApcAccountCarrierConnectAccount (ApcAccountInformationDTO model, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class ApcAccountCarrierConnectAccountExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new CarrierAccountsApi();
            var model = new ApcAccountInformationDTO(); // ApcAccountInformationDTO | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                ConnectAccountResponseDTO result = apiInstance.ApcAccountCarrierConnectAccount(model, apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CarrierAccountsApi.ApcAccountCarrierConnectAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**ApcAccountInformationDTO**](ApcAccountInformationDTO.md)|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

[**ConnectAccountResponseDTO**](ConnectAccountResponseDTO.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apcaccountcarrierdisconnectaccount"></a>
# **ApcAccountCarrierDisconnectAccount**
> void ApcAccountCarrierDisconnectAccount (string carrierId, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class ApcAccountCarrierDisconnectAccountExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new CarrierAccountsApi();
            var carrierId = carrierId_example;  // string | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                apiInstance.ApcAccountCarrierDisconnectAccount(carrierId, apiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CarrierAccountsApi.ApcAccountCarrierDisconnectAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **carrierId** | **string**|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="asendiaaccountcarrierconnectaccount"></a>
# **AsendiaAccountCarrierConnectAccount**
> ConnectAccountResponseDTO AsendiaAccountCarrierConnectAccount (AsendiaAccountInformationDTO model, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class AsendiaAccountCarrierConnectAccountExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new CarrierAccountsApi();
            var model = new AsendiaAccountInformationDTO(); // AsendiaAccountInformationDTO | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                ConnectAccountResponseDTO result = apiInstance.AsendiaAccountCarrierConnectAccount(model, apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CarrierAccountsApi.AsendiaAccountCarrierConnectAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**AsendiaAccountInformationDTO**](AsendiaAccountInformationDTO.md)|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

[**ConnectAccountResponseDTO**](ConnectAccountResponseDTO.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="asendiaaccountcarrierdisconnectaccount"></a>
# **AsendiaAccountCarrierDisconnectAccount**
> void AsendiaAccountCarrierDisconnectAccount (string carrierId, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class AsendiaAccountCarrierDisconnectAccountExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new CarrierAccountsApi();
            var carrierId = carrierId_example;  // string | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                apiInstance.AsendiaAccountCarrierDisconnectAccount(carrierId, apiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CarrierAccountsApi.AsendiaAccountCarrierDisconnectAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **carrierId** | **string**|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dhlexpressaccountcarrierconnectaccount"></a>
# **DHLExpressAccountCarrierConnectAccount**
> ConnectAccountResponseDTO DHLExpressAccountCarrierConnectAccount (DHLExpressAccountInformationDTO model, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class DHLExpressAccountCarrierConnectAccountExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new CarrierAccountsApi();
            var model = new DHLExpressAccountInformationDTO(); // DHLExpressAccountInformationDTO | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                ConnectAccountResponseDTO result = apiInstance.DHLExpressAccountCarrierConnectAccount(model, apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CarrierAccountsApi.DHLExpressAccountCarrierConnectAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**DHLExpressAccountInformationDTO**](DHLExpressAccountInformationDTO.md)|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

[**ConnectAccountResponseDTO**](ConnectAccountResponseDTO.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dhlexpressaccountcarrierdisconnectaccount"></a>
# **DHLExpressAccountCarrierDisconnectAccount**
> void DHLExpressAccountCarrierDisconnectAccount (string carrierId, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class DHLExpressAccountCarrierDisconnectAccountExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new CarrierAccountsApi();
            var carrierId = carrierId_example;  // string | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                apiInstance.DHLExpressAccountCarrierDisconnectAccount(carrierId, apiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CarrierAccountsApi.DHLExpressAccountCarrierDisconnectAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **carrierId** | **string**|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="dhlexpressaccountcarrierupdatesettings"></a>
# **DHLExpressAccountCarrierUpdateSettings**
> void DHLExpressAccountCarrierUpdateSettings (string carrierId, DHLExpressAccountSettingsDTO settings, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class DHLExpressAccountCarrierUpdateSettingsExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new CarrierAccountsApi();
            var carrierId = carrierId_example;  // string | 
            var settings = new DHLExpressAccountSettingsDTO(); // DHLExpressAccountSettingsDTO | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                apiInstance.DHLExpressAccountCarrierUpdateSettings(carrierId, settings, apiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CarrierAccountsApi.DHLExpressAccountCarrierUpdateSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **carrierId** | **string**|  | 
 **settings** | [**DHLExpressAccountSettingsDTO**](DHLExpressAccountSettingsDTO.md)|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="endiciaaccountcarrierconnectaccount"></a>
# **EndiciaAccountCarrierConnectAccount**
> ConnectAccountResponseDTO EndiciaAccountCarrierConnectAccount (EndiciaAccountInformationDTO model, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class EndiciaAccountCarrierConnectAccountExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new CarrierAccountsApi();
            var model = new EndiciaAccountInformationDTO(); // EndiciaAccountInformationDTO | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                ConnectAccountResponseDTO result = apiInstance.EndiciaAccountCarrierConnectAccount(model, apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CarrierAccountsApi.EndiciaAccountCarrierConnectAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**EndiciaAccountInformationDTO**](EndiciaAccountInformationDTO.md)|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

[**ConnectAccountResponseDTO**](ConnectAccountResponseDTO.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="endiciaaccountcarrierdisconnectaccount"></a>
# **EndiciaAccountCarrierDisconnectAccount**
> void EndiciaAccountCarrierDisconnectAccount (string carrierId, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class EndiciaAccountCarrierDisconnectAccountExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new CarrierAccountsApi();
            var carrierId = carrierId_example;  // string | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                apiInstance.EndiciaAccountCarrierDisconnectAccount(carrierId, apiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CarrierAccountsApi.EndiciaAccountCarrierDisconnectAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **carrierId** | **string**|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fedexaccountcarrierconnectaccount"></a>
# **FedExAccountCarrierConnectAccount**
> ConnectAccountResponseDTO FedExAccountCarrierConnectAccount (FedExAccountInformationDTO model, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class FedExAccountCarrierConnectAccountExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new CarrierAccountsApi();
            var model = new FedExAccountInformationDTO(); // FedExAccountInformationDTO | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                ConnectAccountResponseDTO result = apiInstance.FedExAccountCarrierConnectAccount(model, apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CarrierAccountsApi.FedExAccountCarrierConnectAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**FedExAccountInformationDTO**](FedExAccountInformationDTO.md)|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

[**ConnectAccountResponseDTO**](ConnectAccountResponseDTO.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fedexaccountcarrierdisconnectaccount"></a>
# **FedExAccountCarrierDisconnectAccount**
> void FedExAccountCarrierDisconnectAccount (string carrierId, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class FedExAccountCarrierDisconnectAccountExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new CarrierAccountsApi();
            var carrierId = carrierId_example;  // string | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                apiInstance.FedExAccountCarrierDisconnectAccount(carrierId, apiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CarrierAccountsApi.FedExAccountCarrierDisconnectAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **carrierId** | **string**|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fedexaccountcarrierupdatesettings"></a>
# **FedExAccountCarrierUpdateSettings**
> void FedExAccountCarrierUpdateSettings (string carrierId, FedExAccountSettingsDTO settings, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class FedExAccountCarrierUpdateSettingsExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new CarrierAccountsApi();
            var carrierId = carrierId_example;  // string | 
            var settings = new FedExAccountSettingsDTO(); // FedExAccountSettingsDTO | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                apiInstance.FedExAccountCarrierUpdateSettings(carrierId, settings, apiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CarrierAccountsApi.FedExAccountCarrierUpdateSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **carrierId** | **string**|  | 
 **settings** | [**FedExAccountSettingsDTO**](FedExAccountSettingsDTO.md)|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="firstmileaccountcarrierconnectaccount"></a>
# **FirstMileAccountCarrierConnectAccount**
> ConnectAccountResponseDTO FirstMileAccountCarrierConnectAccount (FirstMileAccountInformationDTO model, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class FirstMileAccountCarrierConnectAccountExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new CarrierAccountsApi();
            var model = new FirstMileAccountInformationDTO(); // FirstMileAccountInformationDTO | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                ConnectAccountResponseDTO result = apiInstance.FirstMileAccountCarrierConnectAccount(model, apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CarrierAccountsApi.FirstMileAccountCarrierConnectAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**FirstMileAccountInformationDTO**](FirstMileAccountInformationDTO.md)|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

[**ConnectAccountResponseDTO**](ConnectAccountResponseDTO.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="firstmileaccountcarrierdisconnectaccount"></a>
# **FirstMileAccountCarrierDisconnectAccount**
> void FirstMileAccountCarrierDisconnectAccount (string carrierId, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class FirstMileAccountCarrierDisconnectAccountExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new CarrierAccountsApi();
            var carrierId = carrierId_example;  // string | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                apiInstance.FirstMileAccountCarrierDisconnectAccount(carrierId, apiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CarrierAccountsApi.FirstMileAccountCarrierDisconnectAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **carrierId** | **string**|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="globegisticsaccountcarrierconnectaccount"></a>
# **GlobegisticsAccountCarrierConnectAccount**
> ConnectAccountResponseDTO GlobegisticsAccountCarrierConnectAccount (GlobegisticsAccountInformationDTO model, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class GlobegisticsAccountCarrierConnectAccountExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new CarrierAccountsApi();
            var model = new GlobegisticsAccountInformationDTO(); // GlobegisticsAccountInformationDTO | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                ConnectAccountResponseDTO result = apiInstance.GlobegisticsAccountCarrierConnectAccount(model, apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CarrierAccountsApi.GlobegisticsAccountCarrierConnectAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**GlobegisticsAccountInformationDTO**](GlobegisticsAccountInformationDTO.md)|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

[**ConnectAccountResponseDTO**](ConnectAccountResponseDTO.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="globegisticsaccountcarrierdisconnectaccount"></a>
# **GlobegisticsAccountCarrierDisconnectAccount**
> void GlobegisticsAccountCarrierDisconnectAccount (string carrierId, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class GlobegisticsAccountCarrierDisconnectAccountExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new CarrierAccountsApi();
            var carrierId = carrierId_example;  // string | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                apiInstance.GlobegisticsAccountCarrierDisconnectAccount(carrierId, apiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CarrierAccountsApi.GlobegisticsAccountCarrierDisconnectAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **carrierId** | **string**|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="imexaccountcarrierconnectaccount"></a>
# **ImexAccountCarrierConnectAccount**
> ConnectAccountResponseDTO ImexAccountCarrierConnectAccount (ImexAccountInformationDTO model, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class ImexAccountCarrierConnectAccountExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new CarrierAccountsApi();
            var model = new ImexAccountInformationDTO(); // ImexAccountInformationDTO | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                ConnectAccountResponseDTO result = apiInstance.ImexAccountCarrierConnectAccount(model, apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CarrierAccountsApi.ImexAccountCarrierConnectAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**ImexAccountInformationDTO**](ImexAccountInformationDTO.md)|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

[**ConnectAccountResponseDTO**](ConnectAccountResponseDTO.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="imexaccountcarrierdisconnectaccount"></a>
# **ImexAccountCarrierDisconnectAccount**
> void ImexAccountCarrierDisconnectAccount (string carrierId, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class ImexAccountCarrierDisconnectAccountExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new CarrierAccountsApi();
            var carrierId = carrierId_example;  // string | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                apiInstance.ImexAccountCarrierDisconnectAccount(carrierId, apiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CarrierAccountsApi.ImexAccountCarrierDisconnectAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **carrierId** | **string**|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="newgisticsaccountcarrierconnectaccount"></a>
# **NewgisticsAccountCarrierConnectAccount**
> ConnectAccountResponseDTO NewgisticsAccountCarrierConnectAccount (NewgisticsAccountInformationDTO model, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class NewgisticsAccountCarrierConnectAccountExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new CarrierAccountsApi();
            var model = new NewgisticsAccountInformationDTO(); // NewgisticsAccountInformationDTO | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                ConnectAccountResponseDTO result = apiInstance.NewgisticsAccountCarrierConnectAccount(model, apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CarrierAccountsApi.NewgisticsAccountCarrierConnectAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**NewgisticsAccountInformationDTO**](NewgisticsAccountInformationDTO.md)|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

[**ConnectAccountResponseDTO**](ConnectAccountResponseDTO.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="newgisticsaccountcarrierdisconnectaccount"></a>
# **NewgisticsAccountCarrierDisconnectAccount**
> void NewgisticsAccountCarrierDisconnectAccount (string carrierId, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class NewgisticsAccountCarrierDisconnectAccountExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new CarrierAccountsApi();
            var carrierId = carrierId_example;  // string | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                apiInstance.NewgisticsAccountCarrierDisconnectAccount(carrierId, apiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CarrierAccountsApi.NewgisticsAccountCarrierDisconnectAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **carrierId** | **string**|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="newgisticsaccountcarrierupdatesettings"></a>
# **NewgisticsAccountCarrierUpdateSettings**
> void NewgisticsAccountCarrierUpdateSettings (string carrierId, NewgisticsAccountSettingsDTO settings, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class NewgisticsAccountCarrierUpdateSettingsExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new CarrierAccountsApi();
            var carrierId = carrierId_example;  // string | 
            var settings = new NewgisticsAccountSettingsDTO(); // NewgisticsAccountSettingsDTO | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                apiInstance.NewgisticsAccountCarrierUpdateSettings(carrierId, settings, apiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CarrierAccountsApi.NewgisticsAccountCarrierUpdateSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **carrierId** | **string**|  | 
 **settings** | [**NewgisticsAccountSettingsDTO**](NewgisticsAccountSettingsDTO.md)|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ontracaccountcarrierconnectaccount"></a>
# **OnTracAccountCarrierConnectAccount**
> ConnectAccountResponseDTO OnTracAccountCarrierConnectAccount (OnTracAccountInformationDTO model, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class OnTracAccountCarrierConnectAccountExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new CarrierAccountsApi();
            var model = new OnTracAccountInformationDTO(); // OnTracAccountInformationDTO | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                ConnectAccountResponseDTO result = apiInstance.OnTracAccountCarrierConnectAccount(model, apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CarrierAccountsApi.OnTracAccountCarrierConnectAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**OnTracAccountInformationDTO**](OnTracAccountInformationDTO.md)|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

[**ConnectAccountResponseDTO**](ConnectAccountResponseDTO.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ontracaccountcarrierdisconnectaccount"></a>
# **OnTracAccountCarrierDisconnectAccount**
> void OnTracAccountCarrierDisconnectAccount (string carrierId, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class OnTracAccountCarrierDisconnectAccountExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new CarrierAccountsApi();
            var carrierId = carrierId_example;  // string | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                apiInstance.OnTracAccountCarrierDisconnectAccount(carrierId, apiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CarrierAccountsApi.OnTracAccountCarrierDisconnectAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **carrierId** | **string**|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rrdonnelleyaccountcarrierconnectaccount"></a>
# **RrDonnelleyAccountCarrierConnectAccount**
> ConnectAccountResponseDTO RrDonnelleyAccountCarrierConnectAccount (RrDonnelleyAccountInformationDTO model, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class RrDonnelleyAccountCarrierConnectAccountExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new CarrierAccountsApi();
            var model = new RrDonnelleyAccountInformationDTO(); // RrDonnelleyAccountInformationDTO | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                ConnectAccountResponseDTO result = apiInstance.RrDonnelleyAccountCarrierConnectAccount(model, apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CarrierAccountsApi.RrDonnelleyAccountCarrierConnectAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**RrDonnelleyAccountInformationDTO**](RrDonnelleyAccountInformationDTO.md)|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

[**ConnectAccountResponseDTO**](ConnectAccountResponseDTO.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rrdonnelleyaccountcarrierdisconnectaccount"></a>
# **RrDonnelleyAccountCarrierDisconnectAccount**
> void RrDonnelleyAccountCarrierDisconnectAccount (string carrierId, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class RrDonnelleyAccountCarrierDisconnectAccountExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new CarrierAccountsApi();
            var carrierId = carrierId_example;  // string | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                apiInstance.RrDonnelleyAccountCarrierDisconnectAccount(carrierId, apiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CarrierAccountsApi.RrDonnelleyAccountCarrierDisconnectAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **carrierId** | **string**|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stampsaccountcarrierconnectaccount"></a>
# **StampsAccountCarrierConnectAccount**
> ConnectAccountResponseDTO StampsAccountCarrierConnectAccount (StampsAccountInformationDTO model, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class StampsAccountCarrierConnectAccountExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new CarrierAccountsApi();
            var model = new StampsAccountInformationDTO(); // StampsAccountInformationDTO | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                ConnectAccountResponseDTO result = apiInstance.StampsAccountCarrierConnectAccount(model, apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CarrierAccountsApi.StampsAccountCarrierConnectAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**StampsAccountInformationDTO**](StampsAccountInformationDTO.md)|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

[**ConnectAccountResponseDTO**](ConnectAccountResponseDTO.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stampsaccountcarrierdisconnectaccount"></a>
# **StampsAccountCarrierDisconnectAccount**
> void StampsAccountCarrierDisconnectAccount (string carrierId, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class StampsAccountCarrierDisconnectAccountExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new CarrierAccountsApi();
            var carrierId = carrierId_example;  // string | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                apiInstance.StampsAccountCarrierDisconnectAccount(carrierId, apiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CarrierAccountsApi.StampsAccountCarrierDisconnectAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **carrierId** | **string**|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="upsaccountcarrierconnectaccount"></a>
# **UPSAccountCarrierConnectAccount**
> ConnectAccountResponseDTO UPSAccountCarrierConnectAccount (UPSAccountInformationDTO model, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class UPSAccountCarrierConnectAccountExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new CarrierAccountsApi();
            var model = new UPSAccountInformationDTO(); // UPSAccountInformationDTO | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                ConnectAccountResponseDTO result = apiInstance.UPSAccountCarrierConnectAccount(model, apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CarrierAccountsApi.UPSAccountCarrierConnectAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**UPSAccountInformationDTO**](UPSAccountInformationDTO.md)|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

[**ConnectAccountResponseDTO**](ConnectAccountResponseDTO.md)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="upsaccountcarrierdisconnectaccount"></a>
# **UPSAccountCarrierDisconnectAccount**
> void UPSAccountCarrierDisconnectAccount (string carrierId, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class UPSAccountCarrierDisconnectAccountExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new CarrierAccountsApi();
            var carrierId = carrierId_example;  // string | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                apiInstance.UPSAccountCarrierDisconnectAccount(carrierId, apiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CarrierAccountsApi.UPSAccountCarrierDisconnectAccount: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **carrierId** | **string**|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="upsaccountcarrierupdatesettings"></a>
# **UPSAccountCarrierUpdateSettings**
> void UPSAccountCarrierUpdateSettings (string carrierId, UPSAccountSettingsDTO settings, string apiKey)



### Example
```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class UPSAccountCarrierUpdateSettingsExample
    {
        public void main()
        {
            // Configure API key authorization: api-key
            Configuration.Default.AddApiKey("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api-key", "Bearer");

            var apiInstance = new CarrierAccountsApi();
            var carrierId = carrierId_example;  // string | 
            var settings = new UPSAccountSettingsDTO(); // UPSAccountSettingsDTO | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                apiInstance.UPSAccountCarrierUpdateSettings(carrierId, settings, apiKey);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CarrierAccountsApi.UPSAccountCarrierUpdateSettings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **carrierId** | **string**|  | 
 **settings** | [**UPSAccountSettingsDTO**](UPSAccountSettingsDTO.md)|  | 
 **apiKey** | **string**| API Key | [default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY]

### Return type

void (empty response body)

### Authorization

[api-key](../README.md#api-key)

### HTTP request headers

 - **Content-Type**: application/json, text/json
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

