# ShipEngine.ApiClient - the C# library for the ShipEngine™

<a name="nuget-install"></a>
## Nuget Installation
We're listed on Nuget for installation, simply find us in the package explorer, or install us using the Package Manager Console.

```
Install-Package ShipEngine.ApiClient
```

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;
```

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using ShipEngine.ApiClient.Api;
using ShipEngine.ApiClient.Client;
using ShipEngine.ApiClient.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {
            
            // Configure API key authorization: api-key
            Configuration.Default.ApiKey.Add("api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api-key", "Bearer");

            var apiInstance = new AddressValidationApi();
            var addresses = new List<AddressDTO>(); // List<AddressDTO> | 
            var apiKey = apiKey_example;  // string | API Key (default to jHpriMLAiP0f8PszTUn37t4D3+q2lW/G+eaMgGAupBY)

            try
            {
                List<AddressValidationResponseDTO> result = apiInstance.AddressValidationValidateAddresses(addresses, apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AddressValidationApi.AddressValidationValidateAddresses: " + e.Message );
            }
        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.shipengine.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AddressValidationApi* | [**AddressValidationValidateAddresses**](docs/AddressValidationApi.md#addressvalidationvalidateaddresses) | **POST** /v1/addresses/validate | 
*BatchesApi* | [**BatchesAddToBatch**](docs/BatchesApi.md#batchesaddtobatch) | **POST** /v1/batches/{batch_id}/add | Add a shipment to a batch
*BatchesApi* | [**BatchesCreate**](docs/BatchesApi.md#batchescreate) | **POST** /v1/batches | Create a batch
*BatchesApi* | [**BatchesGet**](docs/BatchesApi.md#batchesget) | **GET** /v1/batches/{batch_id} | Get a specific batch
*BatchesApi* | [**BatchesGetByExternalId**](docs/BatchesApi.md#batchesgetbyexternalid) | **GET** /v1/batches/external_batch_id/{external_batch_id} | Get a specific batch by an external id
*BatchesApi* | [**BatchesList**](docs/BatchesApi.md#batcheslist) | **GET** /v1/batches | Get batches
*BatchesApi* | [**BatchesListErrors**](docs/BatchesApi.md#batcheslisterrors) | **GET** /v1/batches/{batch_id}/errors | 
*BatchesApi* | [**BatchesProcess**](docs/BatchesApi.md#batchesprocess) | **POST** /v1/batches/{batch_id}/process/labels | Process a batch
*BatchesApi* | [**BatchesRemoveFromBatch**](docs/BatchesApi.md#batchesremovefrombatch) | **POST** /v1/batches/{batch_id}/remove | Remove a shipment from a batch
*CarriersApi* | [**CarriersGet**](docs/CarriersApi.md#carriersget) | **GET** /v1/carriers/{carrier_id} | Get a specific carrier
*CarriersApi* | [**CarriersGetOptions**](docs/CarriersApi.md#carriersgetoptions) | **GET** /v1/carriers/{carrier_id}/options | Get advanced options for a carrier
*CarriersApi* | [**CarriersList**](docs/CarriersApi.md#carrierslist) | **GET** /v1/carriers | Get carriers
*CarriersApi* | [**CarriersListPackages**](docs/CarriersApi.md#carrierslistpackages) | **GET** /v1/carriers/{carrier_id}/packages | Get packages for a carrier
*CarriersApi* | [**CarriersListServices**](docs/CarriersApi.md#carrierslistservices) | **GET** /v1/carriers/{carrier_id}/services | Get shipping services for a carrier
*EnvironmentApi* | [**EnvironmentWebhooks**](docs/EnvironmentApi.md#environmentwebhooks) | **GET** /v1/environment/webhooks | 
*EnvironmentApi* | [**EnvironmentWhoami**](docs/EnvironmentApi.md#environmentwhoami) | **GET** /v1/environment/whoami | 
*InsuranceApi* | [**InsuranceAddFunds**](docs/InsuranceApi.md#insuranceaddfunds) | **PATCH** /v1/insurance/shipsurance/add_funds | Add funds to your Shipsurance balance
*InsuranceApi* | [**InsuranceGetBalance**](docs/InsuranceApi.md#insurancegetbalance) | **GET** /v1/insurance/shipsurance/balance | Get your Shipsurance balance
*LabelsApi* | [**LabelsGet**](docs/LabelsApi.md#labelsget) | **GET** /v1/labels/{label_id} | Get a specific Label
*LabelsApi* | [**LabelsList**](docs/LabelsApi.md#labelslist) | **GET** /v1/labels | Get labels
*LabelsApi* | [**LabelsPurchaseLabel**](docs/LabelsApi.md#labelspurchaselabel) | **POST** /v1/labels | Purchase a label by providing full shipment info
*LabelsApi* | [**LabelsPurchaseLabelWithRate**](docs/LabelsApi.md#labelspurchaselabelwithrate) | **POST** /v1/labels/rates/{rate_id} | Purchase a label using a rate
*LabelsApi* | [**LabelsPurchaseLabelWithShipment**](docs/LabelsApi.md#labelspurchaselabelwithshipment) | **POST** /v1/labels/shipment/{shipment_id} | Purchase a label using an existing shipment
*LabelsApi* | [**LabelsTrack**](docs/LabelsApi.md#labelstrack) | **GET** /v1/labels/{label_id}/track | Get tracking information for a label
*LabelsApi* | [**LabelsVoidLabel**](docs/LabelsApi.md#labelsvoidlabel) | **PUT** /v1/labels/{label_id}/void | Void a label
*ManifestsApi* | [**ManifestsCreate**](docs/ManifestsApi.md#manifestscreate) | **POST** /v1/manifests | Create a manifest
*ManifestsApi* | [**ManifestsGet**](docs/ManifestsApi.md#manifestsget) | **GET** /v1/manifests/{manifest_id} | Get a specific manifest
*ManifestsApi* | [**ManifestsList**](docs/ManifestsApi.md#manifestslist) | **GET** /v1/manifests | Get manifests
*PackagesApi* | [**PackagesCreate**](docs/PackagesApi.md#packagescreate) | **POST** /v1/packages | Create a package
*PackagesApi* | [**PackagesDelete**](docs/PackagesApi.md#packagesdelete) | **DELETE** /v1/packages/{package_id} | Delete a package
*PackagesApi* | [**PackagesGet**](docs/PackagesApi.md#packagesget) | **GET** /v1/packages/{package_id} | Get a specific package
*PackagesApi* | [**PackagesList**](docs/PackagesApi.md#packageslist) | **GET** /v1/packages | Get packages
*PackagesApi* | [**PackagesUpdate**](docs/PackagesApi.md#packagesupdate) | **PUT** /v1/packages/{package_id} | Update a package
*RatesApi* | [**RatesEstimate**](docs/RatesApi.md#ratesestimate) | **POST** /v1/rates/estimate | Get a rate quote
*RatesApi* | [**RatesGet**](docs/RatesApi.md#ratesget) | **GET** /v1/rates/{rate_id} | Get a rate
*RatesApi* | [**RatesRateShipment**](docs/RatesApi.md#ratesrateshipment) | **POST** /v1/rates | 
*RatesApi* | [**RatesRateShipmentsBulk**](docs/RatesApi.md#ratesrateshipmentsbulk) | **POST** /v1/rates/bulk | Rate shipments asynchronously
*ShipmentsApi* | [**ShipmentsAddTag**](docs/ShipmentsApi.md#shipmentsaddtag) | **POST** /v1/shipments/{shipment_id}/tags/{tag} | Add a tag to a shipment
*ShipmentsApi* | [**ShipmentsCancel**](docs/ShipmentsApi.md#shipmentscancel) | **PUT** /v1/shipments/{shipment_id}/cancel | Cancel a shipment
*ShipmentsApi* | [**ShipmentsCreateShipments**](docs/ShipmentsApi.md#shipmentscreateshipments) | **POST** /v1/shipments | Create multiple shipments
*ShipmentsApi* | [**ShipmentsGet**](docs/ShipmentsApi.md#shipmentsget) | **GET** /v1/shipments/{shipment_id} | Get a specific shipment
*ShipmentsApi* | [**ShipmentsGetByExternalId**](docs/ShipmentsApi.md#shipmentsgetbyexternalid) | **GET** /v1/shipments/external_shipment_id/{external_shipment_id} | Get a specific shipment by an external id
*ShipmentsApi* | [**ShipmentsGetRatesForShipment**](docs/ShipmentsApi.md#shipmentsgetratesforshipment) | **GET** /v1/shipments/{shipment_id}/rates | Get rates for a specific shipment
*ShipmentsApi* | [**ShipmentsList**](docs/ShipmentsApi.md#shipmentslist) | **GET** /v1/shipments | Get shipments
*ShipmentsApi* | [**ShipmentsListErrors**](docs/ShipmentsApi.md#shipmentslisterrors) | **GET** /v1/shipments/{shipment_id}/errors | Lists the errors.
*ShipmentsApi* | [**ShipmentsRemoveTag**](docs/ShipmentsApi.md#shipmentsremovetag) | **DELETE** /v1/shipments/{shipment_id}/tags/{tag} | Remove a tag from a shipment
*ShipmentsApi* | [**ShipmentsUpdateShipment**](docs/ShipmentsApi.md#shipmentsupdateshipment) | **PUT** /v1/shipments/{shipment_id} | Update a shipment
*TagsApi* | [**TagsAddTag**](docs/TagsApi.md#tagsaddtag) | **POST** /v1/tags/{tag_name} | Create a tag
*TagsApi* | [**TagsDelete**](docs/TagsApi.md#tagsdelete) | **DELETE** /v1/tags/{tag_name} | Delete a tag
*TagsApi* | [**TagsListTags**](docs/TagsApi.md#tagslisttags) | **GET** /v1/tags | Get tags
*TagsApi* | [**TagsUpdateTag**](docs/TagsApi.md#tagsupdatetag) | **PUT** /v1/tags/{tag_name}/{new_name} | Rename a tag
*TrackingApi* | [**TrackingStartTracking**](docs/TrackingApi.md#trackingstarttracking) | **POST** /v1/tracking/start | Starts tracking events notifications
*TrackingApi* | [**TrackingStopTracking**](docs/TrackingApi.md#trackingstoptracking) | **POST** /v1/tracking/stop | Stops tracking events notifications
*TrackingApi* | [**TrackingTrack**](docs/TrackingApi.md#trackingtrack) | **GET** /v1/tracking | Get tracking information
*WarehousesApi* | [**WarehousesCreate**](docs/WarehousesApi.md#warehousescreate) | **POST** /v1/warehouses | Create a warehouse
*WarehousesApi* | [**WarehousesDelete**](docs/WarehousesApi.md#warehousesdelete) | **DELETE** /v1/warehouses/{warehouse_id} | Delete a warehouse
*WarehousesApi* | [**WarehousesGet**](docs/WarehousesApi.md#warehousesget) | **GET** /v1/warehouses/{warehouse_id} | Get a specific warehouse
*WarehousesApi* | [**WarehousesList**](docs/WarehousesApi.md#warehouseslist) | **GET** /v1/warehouses | Get warehouses
*WarehousesApi* | [**WarehousesUpdate**](docs/WarehousesApi.md#warehousesupdate) | **PUT** /v1/warehouses/{warehouse_id} | Update a warehouse


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AddressDTO](docs/AddressDTO.md)
 - [Model.AddressValidatingShipment](docs/AddressValidatingShipment.md)
 - [Model.AddressValidationResponseDTO](docs/AddressValidationResponseDTO.md)
 - [Model.ApiErrorDTO](docs/ApiErrorDTO.md)
 - [Model.ApiErrorResponseDTO](docs/ApiErrorResponseDTO.md)
 - [Model.Batch](docs/Batch.md)
 - [Model.BatchResponseError](docs/BatchResponseError.md)
 - [Model.BatchResponseErrors](docs/BatchResponseErrors.md)
 - [Model.Carrier](docs/Carrier.md)
 - [Model.CarrierAdvancedOption](docs/CarrierAdvancedOption.md)
 - [Model.CarrierListOptionsResponse](docs/CarrierListOptionsResponse.md)
 - [Model.CarrierListPackagesResponse](docs/CarrierListPackagesResponse.md)
 - [Model.CarrierListResponse](docs/CarrierListResponse.md)
 - [Model.CarrierListServicesResponse](docs/CarrierListServicesResponse.md)
 - [Model.CreateBatchRequest](docs/CreateBatchRequest.md)
 - [Model.CreateManifestRequest](docs/CreateManifestRequest.md)
 - [Model.CreateShipmentResponse](docs/CreateShipmentResponse.md)
 - [Model.CreateShipmentsRequest](docs/CreateShipmentsRequest.md)
 - [Model.CreateShipmentsResponse](docs/CreateShipmentsResponse.md)
 - [Model.CustomsItem](docs/CustomsItem.md)
 - [Model.Dimensions](docs/Dimensions.md)
 - [Model.InternationalOptions](docs/InternationalOptions.md)
 - [Model.Label](docs/Label.md)
 - [Model.LinkDTO](docs/LinkDTO.md)
 - [Model.ListBatchResponse](docs/ListBatchResponse.md)
 - [Model.ListLabelResponse](docs/ListLabelResponse.md)
 - [Model.ListShipmentResponse](docs/ListShipmentResponse.md)
 - [Model.ListTagResponse](docs/ListTagResponse.md)
 - [Model.Manifest](docs/Manifest.md)
 - [Model.ManifestsListResponse](docs/ManifestsListResponse.md)
 - [Model.ModifyBatchRequest](docs/ModifyBatchRequest.md)
 - [Model.MoneyDTO](docs/MoneyDTO.md)
 - [Model.Package](docs/Package.md)
 - [Model.PackagesListResponse](docs/PackagesListResponse.md)
 - [Model.PaginationLinkDTO](docs/PaginationLinkDTO.md)
 - [Model.ProcessBatchRequest](docs/ProcessBatchRequest.md)
 - [Model.ProviderError](docs/ProviderError.md)
 - [Model.PurchaseLabelRequest](docs/PurchaseLabelRequest.md)
 - [Model.PurchaseLabelWithoutShipmentRequest](docs/PurchaseLabelWithoutShipmentRequest.md)
 - [Model.Rate](docs/Rate.md)
 - [Model.RateEstimateRequest](docs/RateEstimateRequest.md)
 - [Model.RateRequest](docs/RateRequest.md)
 - [Model.RateResponse](docs/RateResponse.md)
 - [Model.RateShipmentRequest](docs/RateShipmentRequest.md)
 - [Model.RateShipmentResponse](docs/RateShipmentResponse.md)
 - [Model.RateShipmentsRequest](docs/RateShipmentsRequest.md)
 - [Model.ResponseMessageDTO](docs/ResponseMessageDTO.md)
 - [Model.Service](docs/Service.md)
 - [Model.Shipment](docs/Shipment.md)
 - [Model.ShipmentAddTagResponse](docs/ShipmentAddTagResponse.md)
 - [Model.ShipmentPackage](docs/ShipmentPackage.md)
 - [Model.ShipmentResponseError](docs/ShipmentResponseError.md)
 - [Model.ShipmentResponseErrors](docs/ShipmentResponseErrors.md)
 - [Model.TagResponse](docs/TagResponse.md)
 - [Model.TrackEvent](docs/TrackEvent.md)
 - [Model.TrackingInformation](docs/TrackingInformation.md)
 - [Model.VoidLabelResponse](docs/VoidLabelResponse.md)
 - [Model.WarehouseDTO](docs/WarehouseDTO.md)
 - [Model.WarehouseListDTO](docs/WarehouseListDTO.md)
 - [Model.WarehouseRequest](docs/WarehouseRequest.md)
 - [Model.Weight](docs/Weight.md)

<a name="api-key"></a>
### api-key

- **Type**: API key
- **API key parameter name**: api-key
- **Location**: HTTP header

