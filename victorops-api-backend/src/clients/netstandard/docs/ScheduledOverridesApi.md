# Org.OpenAPITools.Api.ScheduledOverridesApi

All URIs are relative to *https://api.victorops.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiPublicV1OverridesGet**](ScheduledOverridesApi.md#apipublicv1overridesget) | **GET** /api-public/v1/overrides | List the scheduled overrides
[**ApiPublicV1OverridesPost**](ScheduledOverridesApi.md#apipublicv1overridespost) | **POST** /api-public/v1/overrides | Creates a new scheduled override
[**ApiPublicV1OverridesPublicIdAssignmentsGet**](ScheduledOverridesApi.md#apipublicv1overridespublicidassignmentsget) | **GET** /api-public/v1/overrides/{publicId}/assignments | Get the specified scheduled override
[**ApiPublicV1OverridesPublicIdAssignmentsPolicySlugDelete**](ScheduledOverridesApi.md#apipublicv1overridespublicidassignmentspolicyslugdelete) | **DELETE** /api-public/v1/overrides/{publicId}/assignments/{policySlug} | Delete the scheduled override assignment
[**ApiPublicV1OverridesPublicIdAssignmentsPolicySlugGet**](ScheduledOverridesApi.md#apipublicv1overridespublicidassignmentspolicyslugget) | **GET** /api-public/v1/overrides/{publicId}/assignments/{policySlug} | Get the specified scheduled override assignment
[**ApiPublicV1OverridesPublicIdAssignmentsPolicySlugPut**](ScheduledOverridesApi.md#apipublicv1overridespublicidassignmentspolicyslugput) | **PUT** /api-public/v1/overrides/{publicId}/assignments/{policySlug} | Update the scheduled override assignment
[**ApiPublicV1OverridesPublicIdDelete**](ScheduledOverridesApi.md#apipublicv1overridespubliciddelete) | **DELETE** /api-public/v1/overrides/{publicId} | Deletes a scheduled override
[**ApiPublicV1OverridesPublicIdGet**](ScheduledOverridesApi.md#apipublicv1overridespublicidget) | **GET** /api-public/v1/overrides/{publicId} | Get the specified scheduled override


<a name="apipublicv1overridesget"></a>
# **ApiPublicV1OverridesGet**
> InlineResponse2008 ApiPublicV1OverridesGet (string xVOApiId, string xVOApiKey)

List the scheduled overrides

List all the scheduled overrides on the organization  This API may be called a maximum of 60 times per minute. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1OverridesGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new ScheduledOverridesApi(Configuration.Default);
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key

            try
            {
                // List the scheduled overrides
                InlineResponse2008 result = apiInstance.ApiPublicV1OverridesGet(xVOApiId, xVOApiKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScheduledOverridesApi.ApiPublicV1OverridesGet: " + e.Message );
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

[**InlineResponse2008**](InlineResponse2008.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of scheduled overrides for your organization |  -  |
| **400** | Problem with the request arguments.  The response payload may include an error message. |  -  |
| **401** | Authentication parameters missing |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **404** | Path not found |  -  |
| **422** | You have reached your user limit.  |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apipublicv1overridespost"></a>
# **ApiPublicV1OverridesPost**
> InlineResponse2009 ApiPublicV1OverridesPost (string xVOApiId, string xVOApiKey, ScheduledOverridePayload body)

Creates a new scheduled override

Creates a new scheduled override. Start and end dates are in ISO8601 format. E.g. `2018-09-28'T'05:00:00Z`  This API may be called a maximum of 60 times per minute. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1OverridesPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new ScheduledOverridesApi(Configuration.Default);
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key
            var body = new ScheduledOverridePayload(); // ScheduledOverridePayload | 

            try
            {
                // Creates a new scheduled override
                InlineResponse2009 result = apiInstance.ApiPublicV1OverridesPost(xVOApiId, xVOApiKey, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScheduledOverridesApi.ApiPublicV1OverridesPost: " + e.Message );
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
 **body** | [**ScheduledOverridePayload**](ScheduledOverridePayload.md)|  | 

### Return type

[**InlineResponse2009**](InlineResponse2009.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The created scheduled override |  -  |
| **400** | Problem with the request arguments.  The response payload may include an error message. |  -  |
| **401** | Authentication parameters missing |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **404** | Path not found |  -  |
| **422** | You have reached your user limit.  |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apipublicv1overridespublicidassignmentsget"></a>
# **ApiPublicV1OverridesPublicIdAssignmentsGet**
> List&lt;Assignment&gt; ApiPublicV1OverridesPublicIdAssignmentsGet (string xVOApiId, string xVOApiKey, string publicId)

Get the specified scheduled override

Get the specified scheduled override assignments  This API may be called a maximum of 60 times per minute. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1OverridesPublicIdAssignmentsGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new ScheduledOverridesApi(Configuration.Default);
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key
            var publicId = publicId_example;  // string | The publicId of the scheduled override

            try
            {
                // Get the specified scheduled override
                List<Assignment> result = apiInstance.ApiPublicV1OverridesPublicIdAssignmentsGet(xVOApiId, xVOApiKey, publicId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScheduledOverridesApi.ApiPublicV1OverridesPublicIdAssignmentsGet: " + e.Message );
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
 **publicId** | **string**| The publicId of the scheduled override | 

### Return type

[**List&lt;Assignment&gt;**](Assignment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The assignments for a given scheduled override |  -  |
| **400** | Problem with the request arguments.  The response payload may include an error message. |  -  |
| **401** | Authentication parameters missing |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **404** | Path not found |  -  |
| **422** | You have reached your user limit.  |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apipublicv1overridespublicidassignmentspolicyslugdelete"></a>
# **ApiPublicV1OverridesPublicIdAssignmentsPolicySlugDelete**
> Assignment ApiPublicV1OverridesPublicIdAssignmentsPolicySlugDelete (string xVOApiId, string xVOApiKey, string publicId, string policySlug)

Delete the scheduled override assignment

Delete the scheduled override assignment  This API may be called a maximum of 60 times per minute. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1OverridesPublicIdAssignmentsPolicySlugDeleteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new ScheduledOverridesApi(Configuration.Default);
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key
            var publicId = publicId_example;  // string | The publicId of the scheduled override
            var policySlug = policySlug_example;  // string | The policySlug of the assignment

            try
            {
                // Delete the scheduled override assignment
                Assignment result = apiInstance.ApiPublicV1OverridesPublicIdAssignmentsPolicySlugDelete(xVOApiId, xVOApiKey, publicId, policySlug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScheduledOverridesApi.ApiPublicV1OverridesPublicIdAssignmentsPolicySlugDelete: " + e.Message );
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
 **publicId** | **string**| The publicId of the scheduled override | 
 **policySlug** | **string**| The policySlug of the assignment | 

### Return type

[**Assignment**](Assignment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The assignment that was deleted for the given scheduled override and policySlug |  -  |
| **400** | Problem with the request arguments.  The response payload may include an error message. |  -  |
| **401** | Authentication parameters missing |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **404** | Path not found |  -  |
| **422** | You have reached your user limit.  |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apipublicv1overridespublicidassignmentspolicyslugget"></a>
# **ApiPublicV1OverridesPublicIdAssignmentsPolicySlugGet**
> Assignment ApiPublicV1OverridesPublicIdAssignmentsPolicySlugGet (string xVOApiId, string xVOApiKey, string publicId, string policySlug)

Get the specified scheduled override assignment

Get the specified scheduled override assignments  This API may be called a maximum of 60 times per minute. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1OverridesPublicIdAssignmentsPolicySlugGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new ScheduledOverridesApi(Configuration.Default);
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key
            var publicId = publicId_example;  // string | The publicId of the scheduled override
            var policySlug = policySlug_example;  // string | The policySlug of the assignment

            try
            {
                // Get the specified scheduled override assignment
                Assignment result = apiInstance.ApiPublicV1OverridesPublicIdAssignmentsPolicySlugGet(xVOApiId, xVOApiKey, publicId, policySlug);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScheduledOverridesApi.ApiPublicV1OverridesPublicIdAssignmentsPolicySlugGet: " + e.Message );
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
 **publicId** | **string**| The publicId of the scheduled override | 
 **policySlug** | **string**| The policySlug of the assignment | 

### Return type

[**Assignment**](Assignment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The assignment for the given publicId |  -  |
| **400** | Problem with the request arguments.  The response payload may include an error message. |  -  |
| **401** | Authentication parameters missing |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **404** | Path not found |  -  |
| **422** | You have reached your user limit.  |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apipublicv1overridespublicidassignmentspolicyslugput"></a>
# **ApiPublicV1OverridesPublicIdAssignmentsPolicySlugPut**
> Assignment ApiPublicV1OverridesPublicIdAssignmentsPolicySlugPut (string xVOApiId, string xVOApiKey, string publicId, string policySlug, UpdateAssignment body)

Update the scheduled override assignment

Update the scheduled override assignment  This API may be called a maximum of 60 times per minute. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1OverridesPublicIdAssignmentsPolicySlugPutExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new ScheduledOverridesApi(Configuration.Default);
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key
            var publicId = publicId_example;  // string | The publicId of the scheduled override
            var policySlug = policySlug_example;  // string | The policySlug of the assignment
            var body = new UpdateAssignment(); // UpdateAssignment | The policy and username we are assigning

            try
            {
                // Update the scheduled override assignment
                Assignment result = apiInstance.ApiPublicV1OverridesPublicIdAssignmentsPolicySlugPut(xVOApiId, xVOApiKey, publicId, policySlug, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScheduledOverridesApi.ApiPublicV1OverridesPublicIdAssignmentsPolicySlugPut: " + e.Message );
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
 **publicId** | **string**| The publicId of the scheduled override | 
 **policySlug** | **string**| The policySlug of the assignment | 
 **body** | [**UpdateAssignment**](UpdateAssignment.md)| The policy and username we are assigning | 

### Return type

[**Assignment**](Assignment.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The assignment for the given policySlug |  -  |
| **400** | Problem with the request arguments.  The response payload may include an error message. |  -  |
| **401** | Authentication parameters missing |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **404** | Path not found |  -  |
| **422** | You have reached your user limit.  |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apipublicv1overridespubliciddelete"></a>
# **ApiPublicV1OverridesPublicIdDelete**
> void ApiPublicV1OverridesPublicIdDelete (string xVOApiId, string xVOApiKey, string publicId)

Deletes a scheduled override

Deletes a scheduled override  This API may be called a maximum of 60 times per minute. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1OverridesPublicIdDeleteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new ScheduledOverridesApi(Configuration.Default);
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key
            var publicId = publicId_example;  // string | The publicId of the scheduled override

            try
            {
                // Deletes a scheduled override
                apiInstance.ApiPublicV1OverridesPublicIdDelete(xVOApiId, xVOApiKey, publicId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScheduledOverridesApi.ApiPublicV1OverridesPublicIdDelete: " + e.Message );
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
 **publicId** | **string**| The publicId of the scheduled override | 

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
| **200** | Whether or not the delete was successful |  -  |
| **400** | Problem with the request arguments.  The response payload may include an error message. |  -  |
| **401** | Authentication parameters missing |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **404** | Path not found |  -  |
| **422** | You have reached your user limit.  |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apipublicv1overridespublicidget"></a>
# **ApiPublicV1OverridesPublicIdGet**
> InlineResponse20010 ApiPublicV1OverridesPublicIdGet (string xVOApiId, string xVOApiKey, string publicId)

Get the specified scheduled override

Get the specified scheduled override  This API may be called a maximum of 60 times per minute. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1OverridesPublicIdGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new ScheduledOverridesApi(Configuration.Default);
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key
            var publicId = publicId_example;  // string | The publicId of the scheduled override

            try
            {
                // Get the specified scheduled override
                InlineResponse20010 result = apiInstance.ApiPublicV1OverridesPublicIdGet(xVOApiId, xVOApiKey, publicId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScheduledOverridesApi.ApiPublicV1OverridesPublicIdGet: " + e.Message );
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
 **publicId** | **string**| The publicId of the scheduled override | 

### Return type

[**InlineResponse20010**](InlineResponse20010.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The scheduled override |  -  |
| **400** | Problem with the request arguments.  The response payload may include an error message. |  -  |
| **401** | Authentication parameters missing |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **404** | Path not found |  -  |
| **422** | You have reached your user limit.  |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

