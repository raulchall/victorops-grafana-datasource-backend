# Org.OpenAPITools.Api.PersonalPagingPoliciesApi

All URIs are relative to *https://api.victorops.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiPublicV1ProfileUsernamePoliciesGet**](PersonalPagingPoliciesApi.md#apipublicv1profileusernamepoliciesget) | **GET** /api-public/v1/profile/{username}/policies | Get the user&#39;s paging policy
[**ApiPublicV1ProfileUsernamePoliciesPost**](PersonalPagingPoliciesApi.md#apipublicv1profileusernamepoliciespost) | **POST** /api-public/v1/profile/{username}/policies | Create a paging policy step
[**ApiPublicV1ProfileUsernamePoliciesStepGet**](PersonalPagingPoliciesApi.md#apipublicv1profileusernamepoliciesstepget) | **GET** /api-public/v1/profile/{username}/policies/{step} | Get a paging policy step
[**ApiPublicV1ProfileUsernamePoliciesStepPost**](PersonalPagingPoliciesApi.md#apipublicv1profileusernamepoliciessteppost) | **POST** /api-public/v1/profile/{username}/policies/{step} | Create a rule for a paging policy step
[**ApiPublicV1ProfileUsernamePoliciesStepPut**](PersonalPagingPoliciesApi.md#apipublicv1profileusernamepoliciesstepput) | **PUT** /api-public/v1/profile/{username}/policies/{step} | Update a paging policy step
[**ApiPublicV1ProfileUsernamePoliciesStepRuleDelete**](PersonalPagingPoliciesApi.md#apipublicv1profileusernamepoliciesstepruledelete) | **DELETE** /api-public/v1/profile/{username}/policies/{step}/{rule} | Delete a rule from a paging policy step
[**ApiPublicV1ProfileUsernamePoliciesStepRuleGet**](PersonalPagingPoliciesApi.md#apipublicv1profileusernamepoliciesstepruleget) | **GET** /api-public/v1/profile/{username}/policies/{step}/{rule} | Get a rule from a paging policy step
[**ApiPublicV1ProfileUsernamePoliciesStepRulePut**](PersonalPagingPoliciesApi.md#apipublicv1profileusernamepoliciesstepruleput) | **PUT** /api-public/v1/profile/{username}/policies/{step}/{rule} | Update a rule for a paging policy step


<a name="apipublicv1profileusernamepoliciesget"></a>
# **ApiPublicV1ProfileUsernamePoliciesGet**
> InlineResponse2003 ApiPublicV1ProfileUsernamePoliciesGet (string username, string xVOApiId, string xVOApiKey)

Get the user's paging policy

Get all the paging policy steps for the user on the org associated with the API key  This API may be called a maximum of 60 times per minute. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1ProfileUsernamePoliciesGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new PersonalPagingPoliciesApi(Configuration.Default);
            var username = username_example;  // string | Your username
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key

            try
            {
                // Get the user's paging policy
                InlineResponse2003 result = apiInstance.ApiPublicV1ProfileUsernamePoliciesGet(username, xVOApiId, xVOApiKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonalPagingPoliciesApi.ApiPublicV1ProfileUsernamePoliciesGet: " + e.Message );
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
 **username** | **string**| Your username | 
 **xVOApiId** | **string**| Your API ID | 
 **xVOApiKey** | **string**| Your API Key | 

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | All steps of the user&#39;s paging policy |  -  |
| **400** | Problem with the request arguments.  The response payload may include an error message. |  -  |
| **401** | Authentication parameters missing |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apipublicv1profileusernamepoliciespost"></a>
# **ApiPublicV1ProfileUsernamePoliciesPost**
> InlineResponse2004 ApiPublicV1ProfileUsernamePoliciesPost (string username, string xVOApiId, string xVOApiKey, AddGroupPayload body)

Create a paging policy step

Create a paging policy step  This API may be called a maximum of 60 times per minute. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1ProfileUsernamePoliciesPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new PersonalPagingPoliciesApi(Configuration.Default);
            var username = username_example;  // string | Your username
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key
            var body = new AddGroupPayload(); // AddGroupPayload | 

            try
            {
                // Create a paging policy step
                InlineResponse2004 result = apiInstance.ApiPublicV1ProfileUsernamePoliciesPost(username, xVOApiId, xVOApiKey, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonalPagingPoliciesApi.ApiPublicV1ProfileUsernamePoliciesPost: " + e.Message );
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
 **username** | **string**| Your username | 
 **xVOApiId** | **string**| Your API ID | 
 **xVOApiKey** | **string**| Your API Key | 
 **body** | [**AddGroupPayload**](AddGroupPayload.md)|  | 

### Return type

[**InlineResponse2004**](InlineResponse2004.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The created paging policy step |  -  |
| **400** | Problem with the request arguments.  The response payload may include an error message. |  -  |
| **401** | Authentication parameters missing |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apipublicv1profileusernamepoliciesstepget"></a>
# **ApiPublicV1ProfileUsernamePoliciesStepGet**
> InlineResponse2004 ApiPublicV1ProfileUsernamePoliciesStepGet (string username, decimal step, string xVOApiId, string xVOApiKey)

Get a paging policy step

Get a paging policy step  This API may be called a maximum of 60 times per minute. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1ProfileUsernamePoliciesStepGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new PersonalPagingPoliciesApi(Configuration.Default);
            var username = username_example;  // string | Your username
            var step = 8.14;  // decimal | Paging policy step
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key

            try
            {
                // Get a paging policy step
                InlineResponse2004 result = apiInstance.ApiPublicV1ProfileUsernamePoliciesStepGet(username, step, xVOApiId, xVOApiKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonalPagingPoliciesApi.ApiPublicV1ProfileUsernamePoliciesStepGet: " + e.Message );
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
 **username** | **string**| Your username | 
 **step** | **decimal**| Paging policy step | 
 **xVOApiId** | **string**| Your API ID | 
 **xVOApiKey** | **string**| Your API Key | 

### Return type

[**InlineResponse2004**](InlineResponse2004.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The paging policy step |  -  |
| **400** | Problem with the request arguments.  The response payload may include an error message. |  -  |
| **401** | Authentication parameters missing |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apipublicv1profileusernamepoliciessteppost"></a>
# **ApiPublicV1ProfileUsernamePoliciesStepPost**
> InlineResponse2005 ApiPublicV1ProfileUsernamePoliciesStepPost (string username, decimal step, string xVOApiId, string xVOApiKey, AddStepPayload body)

Create a rule for a paging policy step

Create a rule for a paging policy step  This API may be called a maximum of 60 times per minute. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1ProfileUsernamePoliciesStepPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new PersonalPagingPoliciesApi(Configuration.Default);
            var username = username_example;  // string | Your username
            var step = 8.14;  // decimal | Paging policy step
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key
            var body = new AddStepPayload(); // AddStepPayload | 

            try
            {
                // Create a rule for a paging policy step
                InlineResponse2005 result = apiInstance.ApiPublicV1ProfileUsernamePoliciesStepPost(username, step, xVOApiId, xVOApiKey, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonalPagingPoliciesApi.ApiPublicV1ProfileUsernamePoliciesStepPost: " + e.Message );
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
 **username** | **string**| Your username | 
 **step** | **decimal**| Paging policy step | 
 **xVOApiId** | **string**| Your API ID | 
 **xVOApiKey** | **string**| Your API Key | 
 **body** | [**AddStepPayload**](AddStepPayload.md)|  | 

### Return type

[**InlineResponse2005**](InlineResponse2005.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The created rule for the paging policy step |  -  |
| **400** | Problem with the request arguments.  The response payload may include an error message. |  -  |
| **401** | Authentication parameters missing |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apipublicv1profileusernamepoliciesstepput"></a>
# **ApiPublicV1ProfileUsernamePoliciesStepPut**
> InlineResponse2004 ApiPublicV1ProfileUsernamePoliciesStepPut (string username, decimal step, string xVOApiId, string xVOApiKey, AddGroupPayload body)

Update a paging policy step

Update a paging policy step  This API may be called a maximum of 60 times per minute. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1ProfileUsernamePoliciesStepPutExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new PersonalPagingPoliciesApi(Configuration.Default);
            var username = username_example;  // string | Your username
            var step = 8.14;  // decimal | Paging policy step
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key
            var body = new AddGroupPayload(); // AddGroupPayload | 

            try
            {
                // Update a paging policy step
                InlineResponse2004 result = apiInstance.ApiPublicV1ProfileUsernamePoliciesStepPut(username, step, xVOApiId, xVOApiKey, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonalPagingPoliciesApi.ApiPublicV1ProfileUsernamePoliciesStepPut: " + e.Message );
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
 **username** | **string**| Your username | 
 **step** | **decimal**| Paging policy step | 
 **xVOApiId** | **string**| Your API ID | 
 **xVOApiKey** | **string**| Your API Key | 
 **body** | [**AddGroupPayload**](AddGroupPayload.md)|  | 

### Return type

[**InlineResponse2004**](InlineResponse2004.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated paging policy step |  -  |
| **400** | Problem with the request arguments.  The response payload may include an error message. |  -  |
| **401** | Authentication parameters missing |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apipublicv1profileusernamepoliciesstepruledelete"></a>
# **ApiPublicV1ProfileUsernamePoliciesStepRuleDelete**
> InlineResponse2005 ApiPublicV1ProfileUsernamePoliciesStepRuleDelete (string username, decimal step, decimal rule, string xVOApiId, string xVOApiKey)

Delete a rule from a paging policy step

Delete a rule from a paging policy step  This API may be called a maximum of 60 times per minute. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1ProfileUsernamePoliciesStepRuleDeleteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new PersonalPagingPoliciesApi(Configuration.Default);
            var username = username_example;  // string | Your username
            var step = 8.14;  // decimal | Paging policy step
            var rule = 8.14;  // decimal | Rule for a paging policy step
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key

            try
            {
                // Delete a rule from a paging policy step
                InlineResponse2005 result = apiInstance.ApiPublicV1ProfileUsernamePoliciesStepRuleDelete(username, step, rule, xVOApiId, xVOApiKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonalPagingPoliciesApi.ApiPublicV1ProfileUsernamePoliciesStepRuleDelete: " + e.Message );
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
 **username** | **string**| Your username | 
 **step** | **decimal**| Paging policy step | 
 **rule** | **decimal**| Rule for a paging policy step | 
 **xVOApiId** | **string**| Your API ID | 
 **xVOApiKey** | **string**| Your API Key | 

### Return type

[**InlineResponse2005**](InlineResponse2005.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The deleted rule from the paging policy step |  -  |
| **400** | Problem with the request arguments.  The response payload may include an error message. |  -  |
| **401** | Authentication parameters missing |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apipublicv1profileusernamepoliciesstepruleget"></a>
# **ApiPublicV1ProfileUsernamePoliciesStepRuleGet**
> InlineResponse2005 ApiPublicV1ProfileUsernamePoliciesStepRuleGet (string username, decimal step, decimal rule, string xVOApiId, string xVOApiKey)

Get a rule from a paging policy step

Get a rule from a paging policy step  This API may be called a maximum of 60 times per minute. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1ProfileUsernamePoliciesStepRuleGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new PersonalPagingPoliciesApi(Configuration.Default);
            var username = username_example;  // string | Your username
            var step = 8.14;  // decimal | Paging policy step
            var rule = 8.14;  // decimal | Rule for a paging policy step
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key

            try
            {
                // Get a rule from a paging policy step
                InlineResponse2005 result = apiInstance.ApiPublicV1ProfileUsernamePoliciesStepRuleGet(username, step, rule, xVOApiId, xVOApiKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonalPagingPoliciesApi.ApiPublicV1ProfileUsernamePoliciesStepRuleGet: " + e.Message );
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
 **username** | **string**| Your username | 
 **step** | **decimal**| Paging policy step | 
 **rule** | **decimal**| Rule for a paging policy step | 
 **xVOApiId** | **string**| Your API ID | 
 **xVOApiKey** | **string**| Your API Key | 

### Return type

[**InlineResponse2005**](InlineResponse2005.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The rule from the paging policy step |  -  |
| **400** | Problem with the request arguments.  The response payload may include an error message. |  -  |
| **401** | Authentication parameters missing |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apipublicv1profileusernamepoliciesstepruleput"></a>
# **ApiPublicV1ProfileUsernamePoliciesStepRulePut**
> InlineResponse2005 ApiPublicV1ProfileUsernamePoliciesStepRulePut (string username, decimal step, decimal rule, string xVOApiId, string xVOApiKey, AddStepPayload body)

Update a rule for a paging policy step

Update a rule for a paging policy step  This API may be called a maximum of 60 times per minute. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1ProfileUsernamePoliciesStepRulePutExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new PersonalPagingPoliciesApi(Configuration.Default);
            var username = username_example;  // string | Your username
            var step = 8.14;  // decimal | Paging policy step
            var rule = 8.14;  // decimal | Rule for a paging policy step
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key
            var body = new AddStepPayload(); // AddStepPayload | 

            try
            {
                // Update a rule for a paging policy step
                InlineResponse2005 result = apiInstance.ApiPublicV1ProfileUsernamePoliciesStepRulePut(username, step, rule, xVOApiId, xVOApiKey, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonalPagingPoliciesApi.ApiPublicV1ProfileUsernamePoliciesStepRulePut: " + e.Message );
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
 **username** | **string**| Your username | 
 **step** | **decimal**| Paging policy step | 
 **rule** | **decimal**| Rule for a paging policy step | 
 **xVOApiId** | **string**| Your API ID | 
 **xVOApiKey** | **string**| Your API Key | 
 **body** | [**AddStepPayload**](AddStepPayload.md)|  | 

### Return type

[**InlineResponse2005**](InlineResponse2005.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated rule for the paging policy step |  -  |
| **400** | Problem with the request arguments.  The response payload may include an error message. |  -  |
| **401** | Authentication parameters missing |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

