# Org.OpenAPITools.Api.TeamsApi

All URIs are relative to *https://api.victorops.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiPublicV1TeamGet**](TeamsApi.md#apipublicv1teamget) | **GET** /api-public/v1/team | List teams
[**ApiPublicV1TeamPost**](TeamsApi.md#apipublicv1teampost) | **POST** /api-public/v1/team | Add a team
[**ApiPublicV1TeamTeamAdminsGet**](TeamsApi.md#apipublicv1teamteamadminsget) | **GET** /api-public/v1/team/{team}/admins | Retrieve a list of team admins for a team
[**ApiPublicV1TeamTeamDelete**](TeamsApi.md#apipublicv1teamteamdelete) | **DELETE** /api-public/v1/team/{team} | Remove a team
[**ApiPublicV1TeamTeamGet**](TeamsApi.md#apipublicv1teamteamget) | **GET** /api-public/v1/team/{team} | Retrieve information for a team
[**ApiPublicV1TeamTeamMembersGet**](TeamsApi.md#apipublicv1teamteammembersget) | **GET** /api-public/v1/team/{team}/members | Retrieve a list of members for a team
[**ApiPublicV1TeamTeamMembersPost**](TeamsApi.md#apipublicv1teamteammemberspost) | **POST** /api-public/v1/team/{team}/members | Add a team member
[**ApiPublicV1TeamTeamMembersUserDelete**](TeamsApi.md#apipublicv1teamteammembersuserdelete) | **DELETE** /api-public/v1/team/{team}/members/{user} | Remove a team member
[**ApiPublicV1TeamTeamPoliciesGet**](TeamsApi.md#apipublicv1teamteampoliciesget) | **GET** /api-public/v1/team/{team}/policies | Retrieve a list of escalation policies for a team
[**ApiPublicV1TeamTeamPut**](TeamsApi.md#apipublicv1teamteamput) | **PUT** /api-public/v1/team/{team} | Update a team


<a name="apipublicv1teamget"></a>
# **ApiPublicV1TeamGet**
> List&lt;TeamDetail&gt; ApiPublicV1TeamGet (string xVOApiId, string xVOApiKey)

List teams

Get a list of teams for your organization.  This API may be called a maximum of 60 times per minute. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1TeamGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new TeamsApi(Configuration.Default);
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key

            try
            {
                // List teams
                List<TeamDetail> result = apiInstance.ApiPublicV1TeamGet(xVOApiId, xVOApiKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.ApiPublicV1TeamGet: " + e.Message );
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

[**List&lt;TeamDetail&gt;**](TeamDetail.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of teams for your organization |  -  |
| **400** | Problem with the request arguments.  The response payload may include an error message. |  -  |
| **401** | Authentication parameters missing |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **404** | Team not found |  -  |
| **422** | You have reached your team limit.  |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apipublicv1teampost"></a>
# **ApiPublicV1TeamPost**
> TeamDetail ApiPublicV1TeamPost (string xVOApiId, string xVOApiKey, AddTeamPayload body)

Add a team

Add a team to your organization.  This API may be called a maximum of 60 times per minute. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1TeamPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new TeamsApi(Configuration.Default);
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key
            var body = new AddTeamPayload(); // AddTeamPayload | The team information

            try
            {
                // Add a team
                TeamDetail result = apiInstance.ApiPublicV1TeamPost(xVOApiId, xVOApiKey, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.ApiPublicV1TeamPost: " + e.Message );
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
 **body** | [**AddTeamPayload**](AddTeamPayload.md)| The team information | 

### Return type

[**TeamDetail**](TeamDetail.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Some details about the team that was added |  -  |
| **400** | Problem with the request arguments.  The response payload may include an error message. |  -  |
| **401** | Authentication parameters missing |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **404** | Team not found |  -  |
| **422** | Team name or email is unavailable, or you have reached your team limit.  |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apipublicv1teamteamadminsget"></a>
# **ApiPublicV1TeamTeamAdminsGet**
> TeamAdminsResponse ApiPublicV1TeamTeamAdminsGet (string xVOApiId, string xVOApiKey, string team)

Retrieve a list of team admins for a team

Get the team admins for the specified team.  This API may be called a maximum of 60 times per minute. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1TeamTeamAdminsGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new TeamsApi(Configuration.Default);
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key
            var team = team_example;  // string | The VictorOps team

            try
            {
                // Retrieve a list of team admins for a team
                TeamAdminsResponse result = apiInstance.ApiPublicV1TeamTeamAdminsGet(xVOApiId, xVOApiKey, team);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.ApiPublicV1TeamTeamAdminsGet: " + e.Message );
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
 **team** | **string**| The VictorOps team | 

### Return type

[**TeamAdminsResponse**](TeamAdminsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Some details about the team that was added |  -  |
| **400** | Problem with the request arguments.  The response payload may include an error message. |  -  |
| **401** | Authentication parameters missing |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **404** | Team not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apipublicv1teamteamdelete"></a>
# **ApiPublicV1TeamTeamDelete**
> void ApiPublicV1TeamTeamDelete (string xVOApiId, string xVOApiKey, string team)

Remove a team

Remove a team from your organization.  This API may be called a maximum of 60 times per minute. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1TeamTeamDeleteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new TeamsApi(Configuration.Default);
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key
            var team = team_example;  // string | The VictorOps team to be deleted

            try
            {
                // Remove a team
                apiInstance.ApiPublicV1TeamTeamDelete(xVOApiId, xVOApiKey, team);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.ApiPublicV1TeamTeamDelete: " + e.Message );
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
 **team** | **string**| The VictorOps team to be deleted | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Team was deleted |  -  |
| **400** | Problem with the request arguments.  The response payload may include an error message. |  -  |
| **401** | Authentication parameters missing |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **404** | Team not found |  -  |
| **422** | There was a problem with the delete such as the replacement team was not found.  |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apipublicv1teamteamget"></a>
# **ApiPublicV1TeamTeamGet**
> TeamDetail ApiPublicV1TeamTeamGet (string xVOApiId, string xVOApiKey, string team)

Retrieve information for a team

Get the information for the specified team.  This API may be called a maximum of 60 times per minute. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1TeamTeamGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new TeamsApi(Configuration.Default);
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key
            var team = team_example;  // string | The VictorOps team to fetch

            try
            {
                // Retrieve information for a team
                TeamDetail result = apiInstance.ApiPublicV1TeamTeamGet(xVOApiId, xVOApiKey, team);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.ApiPublicV1TeamTeamGet: " + e.Message );
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

[**TeamDetail**](TeamDetail.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Some details about the team that was added |  -  |
| **400** | Problem with the request arguments.  The response payload may include an error message. |  -  |
| **401** | Authentication parameters missing |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **404** | Team not found |  -  |
| **422** | Team name or email is unavailable, or you have reached your team limit.  |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apipublicv1teamteammembersget"></a>
# **ApiPublicV1TeamTeamMembersGet**
> ListTeamMembersResponse ApiPublicV1TeamTeamMembersGet (string xVOApiId, string xVOApiKey, string team)

Retrieve a list of members for a team

Get the members for the specified team.  This API may be called a maximum of 60 times per minute. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1TeamTeamMembersGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new TeamsApi(Configuration.Default);
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key
            var team = team_example;  // string | The VictorOps team to fetch

            try
            {
                // Retrieve a list of members for a team
                ListTeamMembersResponse result = apiInstance.ApiPublicV1TeamTeamMembersGet(xVOApiId, xVOApiKey, team);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.ApiPublicV1TeamTeamMembersGet: " + e.Message );
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

[**ListTeamMembersResponse**](ListTeamMembersResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Some details about the team that was added |  -  |
| **400** | Problem with the request arguments.  The response payload may include an error message. |  -  |
| **401** | Authentication parameters missing |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **404** | Team not found |  -  |
| **422** | Team name or email is unavailable, or you have reached your team limit.  |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apipublicv1teamteammemberspost"></a>
# **ApiPublicV1TeamTeamMembersPost**
> ListTeamMembersResponse ApiPublicV1TeamTeamMembersPost (string xVOApiId, string xVOApiKey, string team, AddTeamMemberPayload body)

Add a team member

Add a team member to your team.  This API may be called a maximum of 60 times per minute. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1TeamTeamMembersPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new TeamsApi(Configuration.Default);
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key
            var team = team_example;  // string | The VictorOps team to fetch
            var body = new AddTeamMemberPayload(); // AddTeamMemberPayload | 

            try
            {
                // Add a team member
                ListTeamMembersResponse result = apiInstance.ApiPublicV1TeamTeamMembersPost(xVOApiId, xVOApiKey, team, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.ApiPublicV1TeamTeamMembersPost: " + e.Message );
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
 **body** | [**AddTeamMemberPayload**](AddTeamMemberPayload.md)|  | 

### Return type

[**ListTeamMembersResponse**](ListTeamMembersResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Some details about the team that was added |  -  |
| **400** | Problem with the request arguments.  The response payload may include an error message. |  -  |
| **401** | Authentication parameters missing |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **404** | Team not found |  -  |
| **422** | Team name or email is unavailable, or you have reached your team limit.  |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apipublicv1teamteammembersuserdelete"></a>
# **ApiPublicV1TeamTeamMembersUserDelete**
> void ApiPublicV1TeamTeamMembersUserDelete (string xVOApiId, string xVOApiKey, string team, string user, RemoveTeamMemberPayload body)

Remove a team member

Remove a team from your organization.  This API may be called a maximum of 60 times per minute. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1TeamTeamMembersUserDeleteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new TeamsApi(Configuration.Default);
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key
            var team = team_example;  // string | The VictorOps team to be deleted
            var user = user_example;  // string | The team member username
            var body = new RemoveTeamMemberPayload(); // RemoveTeamMemberPayload | The user information

            try
            {
                // Remove a team member
                apiInstance.ApiPublicV1TeamTeamMembersUserDelete(xVOApiId, xVOApiKey, team, user, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.ApiPublicV1TeamTeamMembersUserDelete: " + e.Message );
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
 **team** | **string**| The VictorOps team to be deleted | 
 **user** | **string**| The team member username | 
 **body** | [**RemoveTeamMemberPayload**](RemoveTeamMemberPayload.md)| The user information | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Team was deleted |  -  |
| **400** | Problem with the request arguments.  The response payload may include an error message. |  -  |
| **401** | Authentication parameters missing |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **404** | Team not found |  -  |
| **422** | There was a problem with the delete such as the replacement team member was not found.  |  -  |
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
            var apiInstance = new TeamsApi(Configuration.Default);
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
                Debug.Print("Exception when calling TeamsApi.ApiPublicV1TeamTeamPoliciesGet: " + e.Message );
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

<a name="apipublicv1teamteamput"></a>
# **ApiPublicV1TeamTeamPut**
> TeamDetail ApiPublicV1TeamTeamPut (string xVOApiId, string xVOApiKey, string team, AddTeamPayload body)

Update a team

Update the designated team  This API may be called a maximum of 60 times per minute. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1TeamTeamPutExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new TeamsApi(Configuration.Default);
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key
            var team = team_example;  // string | The VictorOps team to be updated
            var body = new AddTeamPayload(); // AddTeamPayload | The team information

            try
            {
                // Update a team
                TeamDetail result = apiInstance.ApiPublicV1TeamTeamPut(xVOApiId, xVOApiKey, team, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TeamsApi.ApiPublicV1TeamTeamPut: " + e.Message );
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
 **team** | **string**| The VictorOps team to be updated | 
 **body** | [**AddTeamPayload**](AddTeamPayload.md)| The team information | 

### Return type

[**TeamDetail**](TeamDetail.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Some details about the team that was added |  -  |
| **400** | Problem with the request arguments.  The response payload may include an error message. |  -  |
| **401** | Authentication parameters missing |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **404** | Team not found |  -  |
| **422** | Team name or email is unavailable, or you have reached your team limit.  |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

