# Org.OpenAPITools.Model.ActiveMaintenanceMode
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstanceId** | **string** | external friendly unique id for maintenance mode | [optional] 
**StartedBy** | **string** | username of the user that started maintenance mode | [optional] 
**StartedAt** | **decimal** | millis from epoch marking the start time | [optional] 
**Targets** | [**List&lt;MaintenanceModeTarget&gt;**](MaintenanceModeTarget.md) |  | [optional] 
**IsGlobal** | **bool** | whether this instance is a global maintenance mode or for specific routing keys | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

