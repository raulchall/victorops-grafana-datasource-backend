# Org.OpenAPITools.Api.AlertsApi

All URIs are relative to *https://api.victorops.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiPublicV1AlertsUuidGet**](AlertsApi.md#apipublicv1alertsuuidget) | **GET** /api-public/v1/alerts/{uuid} | Retrieve alert details.


<a name="apipublicv1alertsuuidget"></a>
# **ApiPublicV1AlertsUuidGet**
> GetAlertResponse ApiPublicV1AlertsUuidGet (string xVOApiId, string xVOApiKey, string uuid)

Retrieve alert details.

Retrieve the details of an alert that was sent VictorOps by you.  This API may be called a maximum of 60 times per minute. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1AlertsUuidGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new AlertsApi(Configuration.Default);
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key
            var uuid = uuid_example;  // string | The VictorOps uuid of the alert

            try
            {
                // Retrieve alert details.
                GetAlertResponse result = apiInstance.ApiPublicV1AlertsUuidGet(xVOApiId, xVOApiKey, uuid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AlertsApi.ApiPublicV1AlertsUuidGet: " + e.Message );
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
 **uuid** | **string**| The VictorOps uuid of the alert | 

### Return type

[**GetAlertResponse**](GetAlertResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The alert, if found.  |  -  |
| **400** | Problem with the request arguments.  The response payload may include an error message. |  -  |
| **401** | Authentication parameters missing |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **404** | User not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

