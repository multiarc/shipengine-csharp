# ShipEngine.ApiClient.Model.CreateShipmentResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Errors** | **List&lt;string&gt;** |  | [optional] 
**AddressValidation** | [**AddressValidationResponseDTO**](AddressValidationResponseDTO.md) |  | [optional] 
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
**InsuranceProvider** | **string** |  | [optional] 
**Tags** | [**List&lt;TagResponse&gt;**](TagResponse.md) |  | [optional] 
**Packages** | [**List&lt;ShipmentPackage&gt;**](ShipmentPackage.md) |  | [optional] 
**TotalWeight** | [**Weight**](Weight.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

