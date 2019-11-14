# Org.OpenAPITools.Model.ActiveIncidentInfo
Incidents contain the following fields (all should be considered optional)
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IncidentNumber** | **string** | The VictorOps incident number | [optional] 
**StartTime** | **string** | The time the incident started | [optional] 
**CurrentPhase** | **string** | The current phase of the incident \&quot;resolved\&quot;, \&quot;triggered\&quot; or \&quot;acknowledged\&quot;. | [optional] 
**AlertCount** | **decimal** | The number of alerts received for this incident | [optional] 
**LastAlertTime** | **string** | The time of the last alert received for the incident | [optional] 
**LastAlertId** | **string** | The unique id of the last alert for the incident | [optional] 
**EntityId** | **string** | The unique identification of the entity being monitored that caused the incident | [optional] 
**Host** | **string** | The host on which the incident occurred | [optional] 
**Service** | **string** | The service name causing the incident (if any) | [optional] 
**PagedUsers** | **List&lt;string&gt;** | The users that were paged for the incident. | [optional] 
**PagedTeams** | **List&lt;string&gt;** | The teams that were paged for the incident | [optional] 
**PagedPolicies** | [**List&lt;EscalationPolicyInfo&gt;**](EscalationPolicyInfo.md) | The escalation policies that were triggered for the incident | [optional] 
**Transitions** | [**List&lt;IncidentTransition&gt;**](IncidentTransition.md) | Transitions of the incident state over time | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

