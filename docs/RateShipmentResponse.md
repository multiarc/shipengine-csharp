# ShipEngine.ApiClient.Model.RateShipmentResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RateResponse** | [**RateResponse**](RateResponse.md) |  | [optional] 
**ShipmentId** | **string** |  | [optional] 
**CarrierId** | **string** |  | [optional] 
**ServiceCode** | **string** |  | [optional] 
**ExternalShipmentId** | **string** |  | [optional] 
**ShipDate** | **DateTime?** |  | [optional] 
**CreatedAt** | **DateTime?** |  | [optional] 
**ModifiedAt** | **DateTime?** |  | [optional] 
**ShipmentStatus** | **string** |  | [optional] 
**ShipTo** | [**AddressDTO**](AddressDTO.md) |  | [optional] 
**ShipFrom** | [**AddressDTO**](AddressDTO.md) |  | [optional] 
**WarehouseId** | **string** |  | [optional] 
**ReturnTo** | [**AddressDTO**](AddressDTO.md) |  | [optional] 
**Confirmation** | **string** |  | [optional] 
**Customs** | [**InternationalOptions**](InternationalOptions.md) |  | [optional] 
**AdvancedOptions** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**InsuranceProvider** | **string** | Set the insurance provider for the entire shipment, insurance is defaulted to &#39;insurance_options_provider_enum.none&#39;.  To enable insurance, set the insurance provider insurance_options_provider_enum.  Insured amount, should be set inside the shipment.packages collection for each shipment_package. | [optional] 
**Tags** | [**List&lt;TagResponse&gt;**](TagResponse.md) |  | [optional] 
**TotalWeight** | [**Weight**](Weight.md) |  | [optional] 
**Packages** | [**List&lt;ShipmentPackage&gt;**](ShipmentPackage.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

