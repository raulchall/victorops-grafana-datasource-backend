# Org.OpenAPITools.Model.IncidentInfo
Incidents contain the following fields (all should be considered optional)
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IncidentNumber** | **string** | The VictorOps incident number | [optional] 
**StartTime** | **string** | The time the incident started | [optional] 
**CurrentPhase** | **string** | The current phase of the incident \&quot;resolved\&quot;, \&quot;triggered\&quot; or \&quot;acknowledged\&quot;. | [optional] 
**AlertCount** | **decimal** | The number of alerts received for this incident | [optional] 
**LastAlertTime** | **string** | The time of the last alert received for the incident | [optional] 
**LastAlertID** | **string** | The unique id of the last alert for the incident | [optional] 
**AckUserId** | **string** | The VictorOps user id of the user that acknowledged the incident | [optional] 
**AckTime** | **string** | The time of the last acknowledgment of the incident | [optional] 
**EntityId** | **string** | The unique identification of the entity being monitored that caused the incident | [optional] 
**Host** | **string** | The host on which the incident occurred | [optional] 
**Service** | **string** | The service name causing the incident (if any) | [optional] 
**EndTime** | **string** | The time the incident ended | [optional] 
**AckUser** | [**AckUser**](AckUser.md) |  | [optional] 
**EntityType** | **string** | The type of entity causing the incident (host/service) | [optional] 
**EntityDispName** | **string** | The display name of the entity causing the incident | [optional] 
**Teams** | **string** | The teams that were paged for the incident (comma separated). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

