# Org.OpenAPITools.Api.MaintenanceModeApi

All URIs are relative to *https://api.victorops.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiPublicV1MaintenancemodeGet**](MaintenanceModeApi.md#apipublicv1maintenancemodeget) | **GET** /api-public/v1/maintenancemode | Get an organization&#39;s current maintenance mode state
[**ApiPublicV1MaintenancemodeMaintenancemodeidEndPut**](MaintenanceModeApi.md#apipublicv1maintenancemodemaintenancemodeidendput) | **PUT** /api-public/v1/maintenancemode/{maintenancemodeid}/end | End maintenance mode for routing keys
[**ApiPublicV1MaintenancemodeStartPost**](MaintenanceModeApi.md#apipublicv1maintenancemodestartpost) | **POST** /api-public/v1/maintenancemode/start | Start maintenance mode for routing keys


<a name="apipublicv1maintenancemodeget"></a>
# **ApiPublicV1MaintenancemodeGet**
> MaintenanceModeState ApiPublicV1MaintenancemodeGet (string xVOApiId, string xVOApiKey)

Get an organization's current maintenance mode state

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1MaintenancemodeGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new MaintenanceModeApi(Configuration.Default);
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key

            try
            {
                // Get an organization's current maintenance mode state
                MaintenanceModeState result = apiInstance.ApiPublicV1MaintenancemodeGet(xVOApiId, xVOApiKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MaintenanceModeApi.ApiPublicV1MaintenancemodeGet: " + e.Message );
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

[**MaintenanceModeState**](MaintenanceModeState.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | maintenance mode state |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apipublicv1maintenancemodemaintenancemodeidendput"></a>
# **ApiPublicV1MaintenancemodeMaintenancemodeidEndPut**
> MaintenanceModeState ApiPublicV1MaintenancemodeMaintenancemodeidEndPut (string xVOApiId, string xVOApiKey, string maintenancemodeid)

End maintenance mode for routing keys

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1MaintenancemodeMaintenancemodeidEndPutExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new MaintenanceModeApi(Configuration.Default);
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key
            var maintenancemodeid = maintenancemodeid_example;  // string | The id of the maintenance mode found in the active maintenance mode object

            try
            {
                // End maintenance mode for routing keys
                MaintenanceModeState result = apiInstance.ApiPublicV1MaintenancemodeMaintenancemodeidEndPut(xVOApiId, xVOApiKey, maintenancemodeid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MaintenanceModeApi.ApiPublicV1MaintenancemodeMaintenancemodeidEndPut: " + e.Message );
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
 **maintenancemodeid** | **string**| The id of the maintenance mode found in the active maintenance mode object | 

### Return type

[**MaintenanceModeState**](MaintenanceModeState.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | maintenance mode state |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apipublicv1maintenancemodestartpost"></a>
# **ApiPublicV1MaintenancemodeStartPost**
> MaintenanceModeState ApiPublicV1MaintenancemodeStartPost (string xVOApiId, string xVOApiKey, InlineObject body)

Start maintenance mode for routing keys

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1MaintenancemodeStartPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new MaintenanceModeApi(Configuration.Default);
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key
            var body = new InlineObject(); // InlineObject | 

            try
            {
                // Start maintenance mode for routing keys
                MaintenanceModeState result = apiInstance.ApiPublicV1MaintenancemodeStartPost(xVOApiId, xVOApiKey, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MaintenanceModeApi.ApiPublicV1MaintenancemodeStartPost: " + e.Message );
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
 **body** | [**InlineObject**](InlineObject.md)|  | 

### Return type

[**MaintenanceModeState**](MaintenanceModeState.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | maintenance mode state |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **409** | You have an active global maintanance mode and are attempting to start a second. You may only have a single Global maintenance mode at a time |  -  |
| **420** | You have reached the limit of allowed active maintenance modes |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

