# Org.OpenAPITools.Api.OnCallApi

All URIs are relative to *https://api.victorops.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiPublicV1OncallCurrentGet**](OnCallApi.md#apipublicv1oncallcurrentget) | **GET** /api-public/v1/oncall/current | Get an organization&#39;s on-call users
[**ApiPublicV1PoliciesPolicyOncallUserPatch**](OnCallApi.md#apipublicv1policiespolicyoncalluserpatch) | **PATCH** /api-public/v1/policies/{policy}/oncall/user | Create an on-call override (take on-call)
[**ApiPublicV1TeamTeamOncallScheduleGet**](OnCallApi.md#apipublicv1teamteamoncallscheduleget) | **GET** /api-public/v1/team/{team}/oncall/schedule | Get a team&#39;s on-call schedule
[**ApiPublicV1TeamTeamOncallUserPatch**](OnCallApi.md#apipublicv1teamteamoncalluserpatch) | **PATCH** /api-public/v1/team/{team}/oncall/user | Create an on-call override (take on-call)
[**ApiPublicV1UserUserOncallScheduleGet**](OnCallApi.md#apipublicv1useruseroncallscheduleget) | **GET** /api-public/v1/user/{user}/oncall/schedule | Get a user&#39;s on-call schedule
[**ApiPublicV2TeamTeamOncallScheduleGet**](OnCallApi.md#apipublicv2teamteamoncallscheduleget) | **GET** /api-public/v2/team/{team}/oncall/schedule | Get a team&#39;s on-call schedule
[**ApiPublicV2UserUserOncallScheduleGet**](OnCallApi.md#apipublicv2useruseroncallscheduleget) | **GET** /api-public/v2/user/{user}/oncall/schedule | Get a user&#39;s on-call schedule


<a name="apipublicv1oncallcurrentget"></a>
# **ApiPublicV1OncallCurrentGet**
> InlineResponse2007 ApiPublicV1OncallCurrentGet (string xVOApiId, string xVOApiKey)

Get an organization's on-call users

Get all on-call users/teams for your organization.  This API may be called a maximum of 60 times per minute. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1OncallCurrentGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new OnCallApi(Configuration.Default);
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key

            try
            {
                // Get an organization's on-call users
                InlineResponse2007 result = apiInstance.ApiPublicV1OncallCurrentGet(xVOApiId, xVOApiKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnCallApi.ApiPublicV1OncallCurrentGet: " + e.Message );
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

[**InlineResponse2007**](InlineResponse2007.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | All users and escalation policies currently on call |  -  |
| **400** | Problem with the request arguments.  The response payload may include an error message. |  -  |
| **401** | Authentication parameters missing |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apipublicv1policiespolicyoncalluserpatch"></a>
# **ApiPublicV1PoliciesPolicyOncallUserPatch**
> TakeResult ApiPublicV1PoliciesPolicyOncallUserPatch (string xVOApiId, string xVOApiKey, string policy, TakeRequest body)

Create an on-call override (take on-call)

Replaces a currently on-call user in the escalation policy with another.  In many cases, the policy slug will match the slug of the team that contains it.  This API may be called a maximum of 60 times per minute. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1PoliciesPolicyOncallUserPatchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new OnCallApi(Configuration.Default);
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key
            var policy = policy_example;  // string | The VictorOps policy 'slug'
            var body = new TakeRequest(); // TakeRequest | The take on-call payload

            try
            {
                // Create an on-call override (take on-call)
                TakeResult result = apiInstance.ApiPublicV1PoliciesPolicyOncallUserPatch(xVOApiId, xVOApiKey, policy, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnCallApi.ApiPublicV1PoliciesPolicyOncallUserPatch: " + e.Message );
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
 **policy** | **string**| The VictorOps policy &#39;slug&#39; | 
 **body** | [**TakeRequest**](TakeRequest.md)| The take on-call payload | 

### Return type

[**TakeResult**](TakeResult.md)

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

<a name="apipublicv1teamteamoncallscheduleget"></a>
# **ApiPublicV1TeamTeamOncallScheduleGet**
> OnCallAndOverrides ApiPublicV1TeamTeamOncallScheduleGet (string xVOApiId, string xVOApiKey, string team, decimal? daysForward = null, decimal? daysSkip = null, decimal? step = null)

Get a team's on-call schedule

__NOTE: This call is deprecated. Please use `GET /api-public/v2/team/{team}/oncall/schedule`.__  Get the on-call schedule for a team, including on-call overrides.  This API may be called a maximum of 60 times per minute. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1TeamTeamOncallScheduleGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new OnCallApi(Configuration.Default);
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key
            var team = team_example;  // string | The VictorOps team 'slug'
            var daysForward = 8.14;  // decimal? | Days to include in returned schedule (30 max) (optional)  (default to 14.0M)
            var daysSkip = 8.14;  // decimal? | Days to skip before computing schedule to return (90 max) (optional)  (default to 0.0M)
            var step = 8.14;  // decimal? | Step of escalation policy (3 max) (optional)  (default to 0.0M)

            try
            {
                // Get a team's on-call schedule
                OnCallAndOverrides result = apiInstance.ApiPublicV1TeamTeamOncallScheduleGet(xVOApiId, xVOApiKey, team, daysForward, daysSkip, step);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnCallApi.ApiPublicV1TeamTeamOncallScheduleGet: " + e.Message );
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
 **daysForward** | **decimal?**| Days to include in returned schedule (30 max) | [optional] [default to 14.0M]
 **daysSkip** | **decimal?**| Days to skip before computing schedule to return (90 max) | [optional] [default to 0.0M]
 **step** | **decimal?**| Step of escalation policy (3 max) | [optional] [default to 0.0M]

### Return type

[**OnCallAndOverrides**](OnCallAndOverrides.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The on-call schedule for the team |  -  |
| **400** | Problem with the request arguments.  The response payload may include an error message. |  -  |
| **401** | Authentication parameters missing |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **404** | Team not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apipublicv1teamteamoncalluserpatch"></a>
# **ApiPublicV1TeamTeamOncallUserPatch**
> TakeResult ApiPublicV1TeamTeamOncallUserPatch (string xVOApiId, string xVOApiKey, string team, TakeRequest body)

Create an on-call override (take on-call)

__NOTE: This API call is deprecated. Please use `PATCH /api-public/v2/policies/{policy}/oncall/user`__  Replaces a currently on-call user on the team with another.  This API may be called a maximum of 60 times per minute. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1TeamTeamOncallUserPatchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new OnCallApi(Configuration.Default);
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key
            var team = team_example;  // string | The VictorOps team 'slug'
            var body = new TakeRequest(); // TakeRequest | The take on-call payload

            try
            {
                // Create an on-call override (take on-call)
                TakeResult result = apiInstance.ApiPublicV1TeamTeamOncallUserPatch(xVOApiId, xVOApiKey, team, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnCallApi.ApiPublicV1TeamTeamOncallUserPatch: " + e.Message );
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
 **body** | [**TakeRequest**](TakeRequest.md)| The take on-call payload | 

### Return type

[**TakeResult**](TakeResult.md)

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

<a name="apipublicv1useruseroncallscheduleget"></a>
# **ApiPublicV1UserUserOncallScheduleGet**
> List&lt;OnCallAndOverrides&gt; ApiPublicV1UserUserOncallScheduleGet (string xVOApiId, string xVOApiKey, string user, decimal? daysForward = null, decimal? daysSkip = null, decimal? step = null)

Get a user's on-call schedule

__NOTE: This call is deprecated. Please use `GET /api-public/v2/user/{user}/oncall/schedule`.__  Get the on-call schedule for a user for all teams, including on-call overrides.  This API may be called a maximum of 60 times per minute. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1UserUserOncallScheduleGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new OnCallApi(Configuration.Default);
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key
            var user = user_example;  // string | The VictorOps user ID
            var daysForward = 8.14;  // decimal? | Days to include in returned schedule (30 max) (optional)  (default to 14.0M)
            var daysSkip = 8.14;  // decimal? | Days to skip before computing schedule to return (90 max) (optional)  (default to 0.0M)
            var step = 8.14;  // decimal? | Step of escalation policy (3 max) (optional)  (default to 0.0M)

            try
            {
                // Get a user's on-call schedule
                List<OnCallAndOverrides> result = apiInstance.ApiPublicV1UserUserOncallScheduleGet(xVOApiId, xVOApiKey, user, daysForward, daysSkip, step);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnCallApi.ApiPublicV1UserUserOncallScheduleGet: " + e.Message );
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
 **user** | **string**| The VictorOps user ID | 
 **daysForward** | **decimal?**| Days to include in returned schedule (30 max) | [optional] [default to 14.0M]
 **daysSkip** | **decimal?**| Days to skip before computing schedule to return (90 max) | [optional] [default to 0.0M]
 **step** | **decimal?**| Step of escalation policy (3 max) | [optional] [default to 0.0M]

### Return type

[**List&lt;OnCallAndOverrides&gt;**](OnCallAndOverrides.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The on-call schedule for the user |  -  |
| **400** | Problem with the request arguments.  The response payload may include an error message. |  -  |
| **401** | Authentication parameters missing |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **404** | User not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apipublicv2teamteamoncallscheduleget"></a>
# **ApiPublicV2TeamTeamOncallScheduleGet**
> TeamSchedule ApiPublicV2TeamTeamOncallScheduleGet (string xVOApiId, string xVOApiKey, string team, decimal? daysForward = null, decimal? daysSkip = null, decimal? step = null)

Get a team's on-call schedule

Get the on-call schedule for a team, including on-call overrides.  This API may be called a maximum of 60 times per minute. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV2TeamTeamOncallScheduleGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new OnCallApi(Configuration.Default);
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key
            var team = team_example;  // string | The VictorOps team 'slug'
            var daysForward = 8.14;  // decimal? | Days to include in returned schedule (30 max) (optional)  (default to 14.0M)
            var daysSkip = 8.14;  // decimal? | Days to skip before computing schedule to return (90 max) (optional)  (default to 0.0M)
            var step = 8.14;  // decimal? | Step of escalation policy (3 max) (optional)  (default to 0.0M)

            try
            {
                // Get a team's on-call schedule
                TeamSchedule result = apiInstance.ApiPublicV2TeamTeamOncallScheduleGet(xVOApiId, xVOApiKey, team, daysForward, daysSkip, step);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnCallApi.ApiPublicV2TeamTeamOncallScheduleGet: " + e.Message );
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
 **daysForward** | **decimal?**| Days to include in returned schedule (30 max) | [optional] [default to 14.0M]
 **daysSkip** | **decimal?**| Days to skip before computing schedule to return (90 max) | [optional] [default to 0.0M]
 **step** | **decimal?**| Step of escalation policy (3 max) | [optional] [default to 0.0M]

### Return type

[**TeamSchedule**](TeamSchedule.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The on-call schedule for the team |  -  |
| **400** | Problem with the request arguments.  The response payload may include an error message. |  -  |
| **401** | Authentication parameters missing |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **404** | Team not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apipublicv2useruseroncallscheduleget"></a>
# **ApiPublicV2UserUserOncallScheduleGet**
> UserSchedule ApiPublicV2UserUserOncallScheduleGet (string xVOApiId, string xVOApiKey, string user, decimal? daysForward = null, decimal? daysSkip = null, decimal? step = null)

Get a user's on-call schedule

Get the on-call schedule for a user for all teams the user is on, including on-call overrides.  This API may be called a maximum of 60 times per minute. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV2UserUserOncallScheduleGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new OnCallApi(Configuration.Default);
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key
            var user = user_example;  // string | The VictorOps user ID
            var daysForward = 8.14;  // decimal? | Days to include in returned schedule (30 max) (optional)  (default to 14.0M)
            var daysSkip = 8.14;  // decimal? | Days to skip before computing schedule to return (90 max) (optional)  (default to 0.0M)
            var step = 8.14;  // decimal? | Step of escalation policy (3 max) (optional)  (default to 0.0M)

            try
            {
                // Get a user's on-call schedule
                UserSchedule result = apiInstance.ApiPublicV2UserUserOncallScheduleGet(xVOApiId, xVOApiKey, user, daysForward, daysSkip, step);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OnCallApi.ApiPublicV2UserUserOncallScheduleGet: " + e.Message );
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
 **user** | **string**| The VictorOps user ID | 
 **daysForward** | **decimal?**| Days to include in returned schedule (30 max) | [optional] [default to 14.0M]
 **daysSkip** | **decimal?**| Days to skip before computing schedule to return (90 max) | [optional] [default to 0.0M]
 **step** | **decimal?**| Step of escalation policy (3 max) | [optional] [default to 0.0M]

### Return type

[**UserSchedule**](UserSchedule.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The on-call schedule for the user |  -  |
| **400** | Problem with the request arguments.  The response payload may include an error message. |  -  |
| **401** | Authentication parameters missing |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **404** | User not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

