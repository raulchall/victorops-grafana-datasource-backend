# Org.OpenAPITools.Api.UserPagingPoliciesApi

All URIs are relative to *https://api.victorops.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiPublicV1UserUserPoliciesGet**](UserPagingPoliciesApi.md#apipublicv1useruserpoliciesget) | **GET** /api-public/v1/user/{user}/policies | Get a list of paging policies for a user


<a name="apipublicv1useruserpoliciesget"></a>
# **ApiPublicV1UserUserPoliciesGet**
> Policies ApiPublicV1UserUserPoliciesGet (string xVOApiId, string xVOApiKey, string user)

Get a list of paging policies for a user

Get paging policies for a user  This API may be called a maximum of 60 times per minute. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1UserUserPoliciesGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new UserPagingPoliciesApi(Configuration.Default);
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key
            var user = user_example;  // string | The VictorOps user ID

            try
            {
                // Get a list of paging policies for a user
                Policies result = apiInstance.ApiPublicV1UserUserPoliciesGet(xVOApiId, xVOApiKey, user);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserPagingPoliciesApi.ApiPublicV1UserUserPoliciesGet: " + e.Message );
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

### Return type

[**Policies**](Policies.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | All configured paging policies for a user |  -  |
| **400** | Problem with the request arguments.  The response payload may include an error message. |  -  |
| **401** | Authentication parameters missing |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **404** | User not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

