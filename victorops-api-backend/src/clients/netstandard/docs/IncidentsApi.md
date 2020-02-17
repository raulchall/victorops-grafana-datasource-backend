# Org.OpenAPITools.Api.IncidentsApi

All URIs are relative to *https://api.victorops.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiPublicV1IncidentsAckPatch**](IncidentsApi.md#apipublicv1incidentsackpatch) | **PATCH** /api-public/v1/incidents/ack | Acknowledge an incident or list of incidents
[**ApiPublicV1IncidentsByUserAckPatch**](IncidentsApi.md#apipublicv1incidentsbyuserackpatch) | **PATCH** /api-public/v1/incidents/byUser/ack | Acknowledge all incidents for which a user was paged.
[**ApiPublicV1IncidentsByUserResolvePatch**](IncidentsApi.md#apipublicv1incidentsbyuserresolvepatch) | **PATCH** /api-public/v1/incidents/byUser/resolve | Resolve all incidents for which a user was paged.
[**ApiPublicV1IncidentsGet**](IncidentsApi.md#apipublicv1incidentsget) | **GET** /api-public/v1/incidents | Get current incident information
[**ApiPublicV1IncidentsPost**](IncidentsApi.md#apipublicv1incidentspost) | **POST** /api-public/v1/incidents | Create a new incident
[**ApiPublicV1IncidentsReroutePost**](IncidentsApi.md#apipublicv1incidentsreroutepost) | **POST** /api-public/v1/incidents/reroute | Reroute one or more incidents to one or more new routable destinations.
[**ApiPublicV1IncidentsResolvePatch**](IncidentsApi.md#apipublicv1incidentsresolvepatch) | **PATCH** /api-public/v1/incidents/resolve | Resolve an incident or list of incidents


<a name="apipublicv1incidentsackpatch"></a>
# **ApiPublicV1IncidentsAckPatch**
> AckOrResolveResponse ApiPublicV1IncidentsAckPatch (string xVOApiId, string xVOApiKey, AckOrResolveRequest body)

Acknowledge an incident or list of incidents

The incident(s) must be currently open.  The user supplied must be a valid VictorOps user and a member of your organization.  This API may be called a maximum of 60 times per minute. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1IncidentsAckPatchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new IncidentsApi(Configuration.Default);
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key
            var body = new AckOrResolveRequest(); // AckOrResolveRequest | Ack/Resolve payload

            try
            {
                // Acknowledge an incident or list of incidents
                AckOrResolveResponse result = apiInstance.ApiPublicV1IncidentsAckPatch(xVOApiId, xVOApiKey, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IncidentsApi.ApiPublicV1IncidentsAckPatch: " + e.Message );
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
 **body** | [**AckOrResolveRequest**](AckOrResolveRequest.md)| Ack/Resolve payload | 

### Return type

[**AckOrResolveResponse**](AckOrResolveResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The result of each acknowledge incident action. |  -  |
| **400** | Problem with the request arguments.  The response payload may include an error message. |  -  |
| **401** | Authentication parameters missing |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **404** | User not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apipublicv1incidentsbyuserackpatch"></a>
# **ApiPublicV1IncidentsByUserAckPatch**
> AckOrResolveResponse ApiPublicV1IncidentsByUserAckPatch (string xVOApiId, string xVOApiKey, AckOrResolveByUserRequest body)

Acknowledge all incidents for which a user was paged.

The incident(s) must be currently open.  The user supplied must be a valid VictorOps user and a member of your organization.  This API may be called a maximum of 60 times per minute. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1IncidentsByUserAckPatchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new IncidentsApi(Configuration.Default);
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key
            var body = new AckOrResolveByUserRequest(); // AckOrResolveByUserRequest | Ack/Resolve payload

            try
            {
                // Acknowledge all incidents for which a user was paged.
                AckOrResolveResponse result = apiInstance.ApiPublicV1IncidentsByUserAckPatch(xVOApiId, xVOApiKey, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IncidentsApi.ApiPublicV1IncidentsByUserAckPatch: " + e.Message );
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
 **body** | [**AckOrResolveByUserRequest**](AckOrResolveByUserRequest.md)| Ack/Resolve payload | 

### Return type

[**AckOrResolveResponse**](AckOrResolveResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The result of each acknowledge incident action. |  -  |
| **400** | Problem with the request arguments.  The response payload may include an error message. |  -  |
| **401** | Authentication parameters missing |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **404** | User not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apipublicv1incidentsbyuserresolvepatch"></a>
# **ApiPublicV1IncidentsByUserResolvePatch**
> AckOrResolveResponse ApiPublicV1IncidentsByUserResolvePatch (string xVOApiId, string xVOApiKey, AckOrResolveByUserRequest body)

Resolve all incidents for which a user was paged.

The incident(s) must be currently open.  The user supplied must be a valid VictorOps user and a member of your organization.  This API may be called a maximum of 60 times per minute. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1IncidentsByUserResolvePatchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new IncidentsApi(Configuration.Default);
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key
            var body = new AckOrResolveByUserRequest(); // AckOrResolveByUserRequest | Ack/Resolve payload

            try
            {
                // Resolve all incidents for which a user was paged.
                AckOrResolveResponse result = apiInstance.ApiPublicV1IncidentsByUserResolvePatch(xVOApiId, xVOApiKey, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IncidentsApi.ApiPublicV1IncidentsByUserResolvePatch: " + e.Message );
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
 **body** | [**AckOrResolveByUserRequest**](AckOrResolveByUserRequest.md)| Ack/Resolve payload | 

### Return type

[**AckOrResolveResponse**](AckOrResolveResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The result of each resolve incident action. |  -  |
| **400** | Problem with the request arguments.  The response payload may include an error message. |  -  |
| **401** | Authentication parameters missing |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **404** | User not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apipublicv1incidentsget"></a>
# **ApiPublicV1IncidentsGet**
> ActiveIncidentList ApiPublicV1IncidentsGet (string xVOApiId, string xVOApiKey)

Get current incident information

Get a list of the currently open, acknowledged and recently resolved incidents.  This API may be called a maximum of 60 times per minute. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1IncidentsGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new IncidentsApi(Configuration.Default);
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key

            try
            {
                // Get current incident information
                ActiveIncidentList result = apiInstance.ApiPublicV1IncidentsGet(xVOApiId, xVOApiKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IncidentsApi.ApiPublicV1IncidentsGet: " + e.Message );
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

[**ActiveIncidentList**](ActiveIncidentList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The set of incidents.  |  -  |
| **400** | Problem with the request arguments.  The response payload may include an error message. |  -  |
| **401** | Authentication parameters missing |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **404** | Path not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apipublicv1incidentspost"></a>
# **ApiPublicV1IncidentsPost**
> CreatedIncident ApiPublicV1IncidentsPost (string xVOApiId, string xVOApiKey, CreateIncidentRequest body)

Create a new incident

Create a new incident.  This call replicates the function of our <a href=\"https://help.victorops.com/knowledge-base/manual-incident-creation/\">manual incident creation process</a>. Monitoring tools and custom integrations should be configured using our <a href=\"https://help.victorops.com/knowledge-base/victorops-restendpoint-integration/\">REST Endpoint</a>.  The \"isMultiResponder\" option will require a response from each paged user and escalation policy before paging is stopped. The option is available only to Enterprise accounts.  This API may be called a maximum of 60 times per minute. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1IncidentsPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new IncidentsApi(Configuration.Default);
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key
            var body = new CreateIncidentRequest(); // CreateIncidentRequest | The incident details

            try
            {
                // Create a new incident
                CreatedIncident result = apiInstance.ApiPublicV1IncidentsPost(xVOApiId, xVOApiKey, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IncidentsApi.ApiPublicV1IncidentsPost: " + e.Message );
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
 **body** | [**CreateIncidentRequest**](CreateIncidentRequest.md)| The incident details | 

### Return type

[**CreatedIncident**](CreatedIncident.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Information about the incident created  |  -  |
| **400** | Problem with the request arguments.  The response payload may include an error message. |  -  |
| **401** | Authentication parameters missing |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **404** | Path not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apipublicv1incidentsreroutepost"></a>
# **ApiPublicV1IncidentsReroutePost**
> RerouteStatusResponse ApiPublicV1IncidentsReroutePost (string xVOApiId, string xVOApiKey, RerouteCollection body)

Reroute one or more incidents to one or more new routable destinations.

Reroute one or more incidents to one or more users and/or escalation policies.  The \"addTargets\" option converts the incident to requiring a response from each paged user and escalation policy before paging is stopped. The option is available only to Enterprise accounts.  This API may be called a maximum of 60 times per minute. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1IncidentsReroutePostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new IncidentsApi(Configuration.Default);
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key
            var body = new RerouteCollection(); // RerouteCollection | The reroute rules

            try
            {
                // Reroute one or more incidents to one or more new routable destinations.
                RerouteStatusResponse result = apiInstance.ApiPublicV1IncidentsReroutePost(xVOApiId, xVOApiKey, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IncidentsApi.ApiPublicV1IncidentsReroutePost: " + e.Message );
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
 **body** | [**RerouteCollection**](RerouteCollection.md)| The reroute rules | 

### Return type

[**RerouteStatusResponse**](RerouteStatusResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The created reroute object |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apipublicv1incidentsresolvepatch"></a>
# **ApiPublicV1IncidentsResolvePatch**
> AckOrResolveResponse ApiPublicV1IncidentsResolvePatch (string xVOApiId, string xVOApiKey, AckOrResolveRequest body)

Resolve an incident or list of incidents

The incident(s) must be currently open.  The user supplied must be a valid VictorOps user and a member of your organization.  This API may be called a maximum of 60 times per minute. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1IncidentsResolvePatchExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new IncidentsApi(Configuration.Default);
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key
            var body = new AckOrResolveRequest(); // AckOrResolveRequest | Ack/Resolve payload

            try
            {
                // Resolve an incident or list of incidents
                AckOrResolveResponse result = apiInstance.ApiPublicV1IncidentsResolvePatch(xVOApiId, xVOApiKey, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IncidentsApi.ApiPublicV1IncidentsResolvePatch: " + e.Message );
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
 **body** | [**AckOrResolveRequest**](AckOrResolveRequest.md)| Ack/Resolve payload | 

### Return type

[**AckOrResolveResponse**](AckOrResolveResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The result of each resolve incident action. |  -  |
| **400** | Problem with the request arguments.  The response payload may include an error message. |  -  |
| **401** | Authentication parameters missing |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **404** | User not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

