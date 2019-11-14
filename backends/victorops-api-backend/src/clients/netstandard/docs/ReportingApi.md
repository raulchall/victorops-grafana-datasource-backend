# Org.OpenAPITools.Api.ReportingApi

All URIs are relative to *https://api.victorops.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiReportingV1IncidentsGet**](ReportingApi.md#apireportingv1incidentsget) | **GET** /api-reporting/v1/incidents | Get/search incident history
[**ApiReportingV1TeamTeamOncallLogGet**](ReportingApi.md#apireportingv1teamteamoncalllogget) | **GET** /api-reporting/v1/team/{team}/oncall/log | A list of shift changes for a team
[**ApiReportingV2IncidentsGet**](ReportingApi.md#apireportingv2incidentsget) | **GET** /api-reporting/v2/incidents | Get/search incident history


<a name="apireportingv1incidentsget"></a>
# **ApiReportingV1IncidentsGet**
> List&lt;IncidentList&gt; ApiReportingV1IncidentsGet (string xVOApiId, string xVOApiKey, decimal? offset = null, decimal? limit = null, string entityId = null, string incidentNumber = null, string startedAfter = null, string startedBefore = null, string host = null, string service = null, string currentPhase = null)

Get/search incident history

 __NOTE: This call is deprecated. Please use `GET /api-reporting/v2/incidents`.__  Retrieve incident history for your company, searching over date ranges and with filtering options.  This is historical data, and may be up to 15 minutes behind real-time incident data.  By default, only resolved incidents will be returned.  This API may be called a maximum of once a minute.  Incident requests are paginated with a offset and limit query string parameters.   The query for incidents is run and offset records are skipped, after which limit records will be returned.  The default offset is 0 and the default limit is 20. The maximum value allowed for limit is 100.  On return, the total number of records available for that query will be returned in the payload as 'total'. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiReportingV1IncidentsGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new ReportingApi(Configuration.Default);
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key
            var offset = 8.14;  // decimal? | The offset within the set of matching incidents (optional)  (default to 0.0M)
            var limit = 8.14;  // decimal? | The maximum number of matching incidents to return (100 max) (optional)  (default to 20.0M)
            var entityId = entityId_example;  // string | The entity ID involved  This is the unique identifier for the entity causing the incident. (optional) 
            var incidentNumber = incidentNumber_example;  // string | The incident number as shown in VictorOps Multiple values and ranges are allowed: 4,5,20:50  (optional) 
            var startedAfter = startedAfter_example;  // string | Return incidents started after this timestamp Specify the timestamp in ISO8601 format (optional) 
            var startedBefore = startedBefore_example;  // string | Find incidents started before this timestamp  Specify the timestamp in ISO8601 format (optional) 
            var host = host_example;  // string | The host involved in the incident Multiple values can be separated with commas. (optional) 
            var service = service_example;  // string | The service involved in the incident (if any) Multiple values can be separated with commas. (optional) 
            var currentPhase = currentPhase_example;  // string | The current phase of the incident \"resolved\", \"triggered\" or \"acknowledged\". Multiple values can be separated with commas. (optional) 

            try
            {
                // Get/search incident history
                List<IncidentList> result = apiInstance.ApiReportingV1IncidentsGet(xVOApiId, xVOApiKey, offset, limit, entityId, incidentNumber, startedAfter, startedBefore, host, service, currentPhase);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReportingApi.ApiReportingV1IncidentsGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xVOApiId** | **string**| Your API ID | 
 **xVOApiKey** | **string**| Your API Key | 
 **offset** | **decimal?**| The offset within the set of matching incidents | [optional] [default to 0.0M]
 **limit** | **decimal?**| The maximum number of matching incidents to return (100 max) | [optional] [default to 20.0M]
 **entityId** | **string**| The entity ID involved  This is the unique identifier for the entity causing the incident. | [optional] 
 **incidentNumber** | **string**| The incident number as shown in VictorOps Multiple values and ranges are allowed: 4,5,20:50  | [optional] 
 **startedAfter** | **string**| Return incidents started after this timestamp Specify the timestamp in ISO8601 format | [optional] 
 **startedBefore** | **string**| Find incidents started before this timestamp  Specify the timestamp in ISO8601 format | [optional] 
 **host** | **string**| The host involved in the incident Multiple values can be separated with commas. | [optional] 
 **service** | **string**| The service involved in the incident (if any) Multiple values can be separated with commas. | [optional] 
 **currentPhase** | **string**| The current phase of the incident \&quot;resolved\&quot;, \&quot;triggered\&quot; or \&quot;acknowledged\&quot;. Multiple values can be separated with commas. | [optional] 

### Return type

[**List&lt;IncidentList&gt;**](IncidentList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The list of incidents matching the request filters |  -  |
| **400** | Problem with the request arguments.  The response payload may include an error message. |  -  |
| **401** | Authentication parameters missing |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **404** | Path not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apireportingv1teamteamoncalllogget"></a>
# **ApiReportingV1TeamTeamOncallLogGet**
> OnCallLog ApiReportingV1TeamTeamOncallLogGet (string xVOApiId, string xVOApiKey, string team, DateTime? start = null, DateTime? end = null, string userName = null)

A list of shift changes for a team

Returns a log of user shift changes for the specified team. This is historical data, and may be up to 15 minutes behind real-time log data.  This API may be called a maximum of 60 times per minute. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiReportingV1TeamTeamOncallLogGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new ReportingApi(Configuration.Default);
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key
            var team = team_example;  // string | The VictorOps team 'slug'
            var start = 2013-10-20T19:20:30+01:00;  // DateTime? | Return shift changes occurring after this timestamp. The default is the start of the day at midnight. Specify the timestamp in ISO8601 format (optional) 
            var end = 2013-10-20T19:20:30+01:00;  // DateTime? | Return shift changes occurring before this timestamp. The default is the end of the day at 11:59:59. Specify the timestamp in ISO8601 format (optional) 
            var userName = userName_example;  // string | The VictorOps user ID. Return shift changes occurring during the interval specified for this user. Without this parameter, all relevant users (with respect to the specified interval) are returned (optional) 

            try
            {
                // A list of shift changes for a team
                OnCallLog result = apiInstance.ApiReportingV1TeamTeamOncallLogGet(xVOApiId, xVOApiKey, team, start, end, userName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReportingApi.ApiReportingV1TeamTeamOncallLogGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xVOApiId** | **string**| Your API ID | 
 **xVOApiKey** | **string**| Your API Key | 
 **team** | **string**| The VictorOps team &#39;slug&#39; | 
 **start** | **DateTime?**| Return shift changes occurring after this timestamp. The default is the start of the day at midnight. Specify the timestamp in ISO8601 format | [optional] 
 **end** | **DateTime?**| Return shift changes occurring before this timestamp. The default is the end of the day at 11:59:59. Specify the timestamp in ISO8601 format | [optional] 
 **userName** | **string**| The VictorOps user ID. Return shift changes occurring during the interval specified for this user. Without this parameter, all relevant users (with respect to the specified interval) are returned | [optional] 

### Return type

[**OnCallLog**](OnCallLog.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The result of the take request |  -  |
| **400** | Problem with the request arguments.  The response payload may include an error message. |  -  |
| **401** | Authentication parameters missing |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **404** | Team or user(s) not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apireportingv2incidentsget"></a>
# **ApiReportingV2IncidentsGet**
> ActiveIncidentList ApiReportingV2IncidentsGet (string xVOApiId, string xVOApiKey, decimal? offset = null, decimal? limit = null, string entityId = null, string incidentNumber = null, string startedAfter = null, string startedBefore = null, string host = null, string service = null, string currentPhase = null, string routingKey = null)

Get/search incident history

Retrieve incident history for your company, searching over date ranges and with filtering options.  This API may be called a maximum of once a minute.  Incident requests are paginated with a offset and limit query string parameters.   The query for incidents is run and offset records are skipped, after which limit records will be returned.  The default offset is 0 and the default limit is 20. The maximum value allowed for limit is 100.  Unless specified otherwise with the parameter currentPhase, the response will only contain resolved incidents.  On return, the total number of records available for that query will be returned in the payload as 'total'. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiReportingV2IncidentsGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new ReportingApi(Configuration.Default);
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key
            var offset = 8.14;  // decimal? | The offset within the set of matching incidents (optional)  (default to 0.0M)
            var limit = 8.14;  // decimal? | The maximum number of matching incidents to return (100 max) (optional)  (default to 20.0M)
            var entityId = entityId_example;  // string | The entity ID involved  This is the unique identifier for the entity causing the incident. (optional) 
            var incidentNumber = incidentNumber_example;  // string | The incident number as shown in VictorOps Multiple values and ranges are allowed: 4,5,20:50  (optional) 
            var startedAfter = startedAfter_example;  // string | Return incidents started after this timestamp Specify the timestamp in ISO8601 format (optional) 
            var startedBefore = startedBefore_example;  // string | Find incidents started before this timestamp  Specify the timestamp in ISO8601 format (optional) 
            var host = host_example;  // string | The host involved in the incident Multiple values can be separated with commas. (optional) 
            var service = service_example;  // string | The service involved in the incident (if any) Multiple values can be separated with commas. (optional) 
            var currentPhase = currentPhase_example;  // string | The current phase of the incident \"resolved\", \"triggered\" or \"acknowledged\". Multiple values can be separated with commas. By default, response contains only \"resolved\" incidents (optional) 
            var routingKey = routingKey_example;  // string | The original routing of the incident (optional) 

            try
            {
                // Get/search incident history
                ActiveIncidentList result = apiInstance.ApiReportingV2IncidentsGet(xVOApiId, xVOApiKey, offset, limit, entityId, incidentNumber, startedAfter, startedBefore, host, service, currentPhase, routingKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReportingApi.ApiReportingV2IncidentsGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xVOApiId** | **string**| Your API ID | 
 **xVOApiKey** | **string**| Your API Key | 
 **offset** | **decimal?**| The offset within the set of matching incidents | [optional] [default to 0.0M]
 **limit** | **decimal?**| The maximum number of matching incidents to return (100 max) | [optional] [default to 20.0M]
 **entityId** | **string**| The entity ID involved  This is the unique identifier for the entity causing the incident. | [optional] 
 **incidentNumber** | **string**| The incident number as shown in VictorOps Multiple values and ranges are allowed: 4,5,20:50  | [optional] 
 **startedAfter** | **string**| Return incidents started after this timestamp Specify the timestamp in ISO8601 format | [optional] 
 **startedBefore** | **string**| Find incidents started before this timestamp  Specify the timestamp in ISO8601 format | [optional] 
 **host** | **string**| The host involved in the incident Multiple values can be separated with commas. | [optional] 
 **service** | **string**| The service involved in the incident (if any) Multiple values can be separated with commas. | [optional] 
 **currentPhase** | **string**| The current phase of the incident \&quot;resolved\&quot;, \&quot;triggered\&quot; or \&quot;acknowledged\&quot;. Multiple values can be separated with commas. By default, response contains only \&quot;resolved\&quot; incidents | [optional] 
 **routingKey** | **string**| The original routing of the incident | [optional] 

### Return type

[**ActiveIncidentList**](ActiveIncidentList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The list of incidents matching the request filters |  -  |
| **400** | Problem with the request arguments.  The response payload may include an error message. |  -  |
| **401** | Authentication parameters missing |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **404** | Path not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

