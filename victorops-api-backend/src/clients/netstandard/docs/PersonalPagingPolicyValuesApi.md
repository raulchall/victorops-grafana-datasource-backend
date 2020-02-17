# Org.OpenAPITools.Api.PersonalPagingPolicyValuesApi

All URIs are relative to *https://api.victorops.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiPublicV1PoliciesTypesContactsGet**](PersonalPagingPolicyValuesApi.md#apipublicv1policiestypescontactsget) | **GET** /api-public/v1/policies/types/contacts | Get the available contact types
[**ApiPublicV1PoliciesTypesNotificationsGet**](PersonalPagingPolicyValuesApi.md#apipublicv1policiestypesnotificationsget) | **GET** /api-public/v1/policies/types/notifications | Get the available notification types
[**ApiPublicV1PoliciesTypesTimeoutsGet**](PersonalPagingPolicyValuesApi.md#apipublicv1policiestypestimeoutsget) | **GET** /api-public/v1/policies/types/timeouts | Get the available timeout values


<a name="apipublicv1policiestypescontactsget"></a>
# **ApiPublicV1PoliciesTypesContactsGet**
> InlineResponse2001 ApiPublicV1PoliciesTypesContactsGet (string xVOApiId, string xVOApiKey)

Get the available contact types

Get the available contact types  description: \"Email Address\", type: \"email\" description: \"Phone Number\", type: \"phone\"  This API may be called a maximum of 60 times per minute. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1PoliciesTypesContactsGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new PersonalPagingPolicyValuesApi(Configuration.Default);
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key

            try
            {
                // Get the available contact types
                InlineResponse2001 result = apiInstance.ApiPublicV1PoliciesTypesContactsGet(xVOApiId, xVOApiKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonalPagingPolicyValuesApi.ApiPublicV1PoliciesTypesContactsGet: " + e.Message );
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

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | All the available contact types |  -  |
| **400** | Problem with the request arguments.  The response payload may include an error message. |  -  |
| **401** | Authentication parameters missing |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apipublicv1policiestypesnotificationsget"></a>
# **ApiPublicV1PoliciesTypesNotificationsGet**
> InlineResponse200 ApiPublicV1PoliciesTypesNotificationsGet (string xVOApiId, string xVOApiKey)

Get the available notification types

Get the available notification types  description: \"Send a push notification to all my devices\", type: \"push\" description: \"Send an email to an email address\", type: \"email\" description: \"Send an SMS to a phone number\", type: \"sms\" description: \"Make a phone call to a phone number\", type: \"phone\"  This API may be called a maximum of 60 times per minute. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1PoliciesTypesNotificationsGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new PersonalPagingPolicyValuesApi(Configuration.Default);
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key

            try
            {
                // Get the available notification types
                InlineResponse200 result = apiInstance.ApiPublicV1PoliciesTypesNotificationsGet(xVOApiId, xVOApiKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonalPagingPolicyValuesApi.ApiPublicV1PoliciesTypesNotificationsGet: " + e.Message );
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

[**InlineResponse200**](InlineResponse200.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | All the available contact types |  -  |
| **400** | Problem with the request arguments.  The response payload may include an error message. |  -  |
| **401** | Authentication parameters missing |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apipublicv1policiestypestimeoutsget"></a>
# **ApiPublicV1PoliciesTypesTimeoutsGet**
> InlineResponse2002 ApiPublicV1PoliciesTypesTimeoutsGet (string xVOApiId, string xVOApiKey)

Get the available timeout values

Get the available timeout values  description: \"If still unacked after 1 minute\", type: 1 description: \"If still unacked after 5 minutes\", type: 5 description: \"If still unacked after 10 minutes\", type: 10 description: \"If still unacked after 15 minutes\", type: 15 description: \"If still unacked after 20 minutes\", type: 20 description: \"If still unacked after 25 minutes\", type: 25 description: \"If still unacked after 30 minutes\", type: 30 description: \"If still unacked after 45 minutes\", type: 45 description: \"If still unacked after 60 minutes\", type: 60  This API may be called a maximum of 60 times per minute. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1PoliciesTypesTimeoutsGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new PersonalPagingPolicyValuesApi(Configuration.Default);
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key

            try
            {
                // Get the available timeout values
                InlineResponse2002 result = apiInstance.ApiPublicV1PoliciesTypesTimeoutsGet(xVOApiId, xVOApiKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PersonalPagingPolicyValuesApi.ApiPublicV1PoliciesTypesTimeoutsGet: " + e.Message );
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

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | All the available timeout types. |  -  |
| **400** | Problem with the request arguments.  The response payload may include an error message. |  -  |
| **401** | Authentication parameters missing |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

