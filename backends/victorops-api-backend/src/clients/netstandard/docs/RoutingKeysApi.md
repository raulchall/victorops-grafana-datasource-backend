# Org.OpenAPITools.Api.RoutingKeysApi

All URIs are relative to *https://api.victorops.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiPublicV1OrgRoutingKeysGet**](RoutingKeysApi.md#apipublicv1orgroutingkeysget) | **GET** /api-public/v1/org/routing-keys | List routing keys with associated teams
[**ApiPublicV1OrgRoutingKeysPost**](RoutingKeysApi.md#apipublicv1orgroutingkeyspost) | **POST** /api-public/v1/org/routing-keys | Create a new routing key


<a name="apipublicv1orgroutingkeysget"></a>
# **ApiPublicV1OrgRoutingKeysGet**
> ListRoutingKeysResponse ApiPublicV1OrgRoutingKeysGet (string xVOApiId, string xVOApiKey)

List routing keys with associated teams

Retrieves a list of routing keys and associated teams. This API may be called a maximum of 60 times per minute.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1OrgRoutingKeysGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new RoutingKeysApi(Configuration.Default);
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key

            try
            {
                // List routing keys with associated teams
                ListRoutingKeysResponse result = apiInstance.ApiPublicV1OrgRoutingKeysGet(xVOApiId, xVOApiKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoutingKeysApi.ApiPublicV1OrgRoutingKeysGet: " + e.Message );
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

[**ListRoutingKeysResponse**](ListRoutingKeysResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The list of routing keys and associated teams |  -  |
| **400** | Problem with the request arguments.  The response payload may include an error message. |  -  |
| **401** | Authentication parameters missing |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **404** | Path not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apipublicv1orgroutingkeyspost"></a>
# **ApiPublicV1OrgRoutingKeysPost**
> CreateRoutingKeyResponse ApiPublicV1OrgRoutingKeysPost (string xVOApiId, string xVOApiKey, RoutingKeyPayload body)

Create a new routing key

Creates a new routing key with escalation policy mapping. The targets array is a list of escalation policy policySlugs that the new routing key will target. This API may be called a maximum of 60 times per minute.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1OrgRoutingKeysPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new RoutingKeysApi(Configuration.Default);
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key
            var body = new RoutingKeyPayload(); // RoutingKeyPayload | 

            try
            {
                // Create a new routing key
                CreateRoutingKeyResponse result = apiInstance.ApiPublicV1OrgRoutingKeysPost(xVOApiId, xVOApiKey, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RoutingKeysApi.ApiPublicV1OrgRoutingKeysPost: " + e.Message );
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
 **body** | [**RoutingKeyPayload**](RoutingKeyPayload.md)|  | 

### Return type

[**CreateRoutingKeyResponse**](CreateRoutingKeyResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The created routing-key |  -  |
| **400** | Problem with the request arguments.  The response payload may include an error message. |  -  |
| **401** | Authentication parameters missing |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **404** | Path not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

