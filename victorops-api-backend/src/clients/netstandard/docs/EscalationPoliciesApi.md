# Org.OpenAPITools.Api.EscalationPoliciesApi

All URIs are relative to *https://api.victorops.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiPublicV1PoliciesGet**](EscalationPoliciesApi.md#apipublicv1policiesget) | **GET** /api-public/v1/policies | Get escalation policy info
[**ApiPublicV1TeamTeamPoliciesGet**](EscalationPoliciesApi.md#apipublicv1teamteampoliciesget) | **GET** /api-public/v1/team/{team}/policies | Retrieve a list of escalation policies for a team


<a name="apipublicv1policiesget"></a>
# **ApiPublicV1PoliciesGet**
> EscalationPolicyInfoList ApiPublicV1PoliciesGet (string xVOApiId, string xVOApiKey)

Get escalation policy info

Retrieves a list of escalation policy information. This API may be called a maximum of once a minute.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1PoliciesGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new EscalationPoliciesApi(Configuration.Default);
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key

            try
            {
                // Get escalation policy info
                EscalationPolicyInfoList result = apiInstance.ApiPublicV1PoliciesGet(xVOApiId, xVOApiKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EscalationPoliciesApi.ApiPublicV1PoliciesGet: " + e.Message );
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

### Return type

[**EscalationPolicyInfoList**](EscalationPolicyInfoList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The list of escalation policies |  -  |
| **400** | Problem with the request arguments.  The response payload may include an error message. |  -  |
| **401** | Authentication parameters missing |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **404** | Path not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apipublicv1teamteampoliciesget"></a>
# **ApiPublicV1TeamTeamPoliciesGet**
> EscalationPolicyList ApiPublicV1TeamTeamPoliciesGet (string xVOApiId, string xVOApiKey, string team)

Retrieve a list of escalation policies for a team

Get the escalation policies for the specified team.  This API may be called a maximum of 60 times per minute. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1TeamTeamPoliciesGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new EscalationPoliciesApi(Configuration.Default);
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key
            var team = team_example;  // string | The VictorOps team to fetch

            try
            {
                // Retrieve a list of escalation policies for a team
                EscalationPolicyList result = apiInstance.ApiPublicV1TeamTeamPoliciesGet(xVOApiId, xVOApiKey, team);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EscalationPoliciesApi.ApiPublicV1TeamTeamPoliciesGet: " + e.Message );
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
 **team** | **string**| The VictorOps team to fetch | 

### Return type

[**EscalationPolicyList**](EscalationPolicyList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The escalation policy list. This does not include details about the actual notification steps of the policy. |  -  |
| **400** | Problem with the request arguments.  The response payload may include an error message. |  -  |
| **401** | Authentication parameters missing |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **404** | Team not found |  -  |
| **422** | Team name or email is unavailable, or you have reached your team limit.  |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

