# Org.OpenAPITools.Model.GetAlertResponse
Alert details. All fields should be considered optional.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MessageType** | **string** | The type of alert; INFO, WARNING, ACKNOWLEDGEMENT, CRITICAL, RECOVERY  | [optional] 
**EntityId** | **string** | Identifies the entity (host, service, etc.) this alert was about.  | [optional] 
**Timestamp** | **decimal** | Timestamp of the alert in seconds since epoch. | [optional] 
**StateStartTime** | **decimal** | The time this entity entered its current state (seconds since epoch). | [optional] 
**StateMessage** | **string** | Any additional status information from the alert item. | [optional] 
**MonitoringTool** | **string** | The name of the monitoring system software (eg. nagios, icinga, sensu, etc.) | [optional] 
**EntityDisplayName** | **string** | Used within VictorOps to display a human-readable name for the entity. | [optional] 
**AckMsg** | **string** | A user entered comment for the acknowledgment. | [optional] 
**AckAuthor** | **string** | The user that acknowledged the incident. | [optional] 
**Raw** | **string** | The full, raw alert details JSON string (i.e. parse the string into a JSON object)  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

