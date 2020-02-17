# Org.OpenAPITools.Api.UserContactMethodsApi

All URIs are relative to *https://api.victorops.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApiPublicV1UserUserContactMethodsDevicesContactIdDelete**](UserContactMethodsApi.md#apipublicv1userusercontactmethodsdevicescontactiddelete) | **DELETE** /api-public/v1/user/{user}/contact-methods/devices/{contactId} | Delete a contact device for a user
[**ApiPublicV1UserUserContactMethodsDevicesContactIdGet**](UserContactMethodsApi.md#apipublicv1userusercontactmethodsdevicescontactidget) | **GET** /api-public/v1/user/{user}/contact-methods/devices/{contactId} | Get the indicated contact device for a user
[**ApiPublicV1UserUserContactMethodsDevicesContactIdPut**](UserContactMethodsApi.md#apipublicv1userusercontactmethodsdevicescontactidput) | **PUT** /api-public/v1/user/{user}/contact-methods/devices/{contactId} | Update a contact device for a user
[**ApiPublicV1UserUserContactMethodsDevicesGet**](UserContactMethodsApi.md#apipublicv1userusercontactmethodsdevicesget) | **GET** /api-public/v1/user/{user}/contact-methods/devices | Get a list of all contact devices for a user
[**ApiPublicV1UserUserContactMethodsEmailsContactIdDelete**](UserContactMethodsApi.md#apipublicv1userusercontactmethodsemailscontactiddelete) | **DELETE** /api-public/v1/user/{user}/contact-methods/emails/{contactId} | Delete a contact email for a user
[**ApiPublicV1UserUserContactMethodsEmailsContactIdGet**](UserContactMethodsApi.md#apipublicv1userusercontactmethodsemailscontactidget) | **GET** /api-public/v1/user/{user}/contact-methods/emails/{contactId} | Get the indicated contact email for a user
[**ApiPublicV1UserUserContactMethodsEmailsGet**](UserContactMethodsApi.md#apipublicv1userusercontactmethodsemailsget) | **GET** /api-public/v1/user/{user}/contact-methods/emails | Get a list of all contact emails for a user
[**ApiPublicV1UserUserContactMethodsEmailsPost**](UserContactMethodsApi.md#apipublicv1userusercontactmethodsemailspost) | **POST** /api-public/v1/user/{user}/contact-methods/emails | Create a contact emails for a user
[**ApiPublicV1UserUserContactMethodsGet**](UserContactMethodsApi.md#apipublicv1userusercontactmethodsget) | **GET** /api-public/v1/user/{user}/contact-methods | Get a list of all contact methods for a user
[**ApiPublicV1UserUserContactMethodsPhonesContactIdDelete**](UserContactMethodsApi.md#apipublicv1userusercontactmethodsphonescontactiddelete) | **DELETE** /api-public/v1/user/{user}/contact-methods/phones/{contactId} | Delete a contact phone for a user
[**ApiPublicV1UserUserContactMethodsPhonesContactIdGet**](UserContactMethodsApi.md#apipublicv1userusercontactmethodsphonescontactidget) | **GET** /api-public/v1/user/{user}/contact-methods/phones/{contactId} | Get the indicated contact phone for a user
[**ApiPublicV1UserUserContactMethodsPhonesGet**](UserContactMethodsApi.md#apipublicv1userusercontactmethodsphonesget) | **GET** /api-public/v1/user/{user}/contact-methods/phones | Get a list of all contact phones for a user
[**ApiPublicV1UserUserContactMethodsPhonesPost**](UserContactMethodsApi.md#apipublicv1userusercontactmethodsphonespost) | **POST** /api-public/v1/user/{user}/contact-methods/phones | Create a contact phones for a user


<a name="apipublicv1userusercontactmethodsdevicescontactiddelete"></a>
# **ApiPublicV1UserUserContactMethodsDevicesContactIdDelete**
> ContactDevice ApiPublicV1UserUserContactMethodsDevicesContactIdDelete (string xVOApiId, string xVOApiKey, string user, string contactId)

Delete a contact device for a user

Delete a contact device for a user  This API may be called a maximum of 60 times per minute. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1UserUserContactMethodsDevicesContactIdDeleteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new UserContactMethodsApi(Configuration.Default);
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key
            var user = user_example;  // string | The VictorOps user ID
            var contactId = contactId_example;  // string | The unique contact identifier

            try
            {
                // Delete a contact device for a user
                ContactDevice result = apiInstance.ApiPublicV1UserUserContactMethodsDevicesContactIdDelete(xVOApiId, xVOApiKey, user, contactId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserContactMethodsApi.ApiPublicV1UserUserContactMethodsDevicesContactIdDelete: " + e.Message );
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
 **contactId** | **string**| The unique contact identifier | 

### Return type

[**ContactDevice**](ContactDevice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Deleted contact device for the user |  -  |
| **400** | Problem with the request arguments.  The response payload may include an error message. |  -  |
| **401** | Authentication parameters missing |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **404** | User not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apipublicv1userusercontactmethodsdevicescontactidget"></a>
# **ApiPublicV1UserUserContactMethodsDevicesContactIdGet**
> List&lt;ContactDevice&gt; ApiPublicV1UserUserContactMethodsDevicesContactIdGet (string xVOApiId, string xVOApiKey, string user, string contactId)

Get the indicated contact device for a user

Get the indicated contact device for a user  This API may be called a maximum of 60 times per minute. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1UserUserContactMethodsDevicesContactIdGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new UserContactMethodsApi(Configuration.Default);
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key
            var user = user_example;  // string | The VictorOps user ID
            var contactId = contactId_example;  // string | The unique contact identifier

            try
            {
                // Get the indicated contact device for a user
                List<ContactDevice> result = apiInstance.ApiPublicV1UserUserContactMethodsDevicesContactIdGet(xVOApiId, xVOApiKey, user, contactId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserContactMethodsApi.ApiPublicV1UserUserContactMethodsDevicesContactIdGet: " + e.Message );
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
 **contactId** | **string**| The unique contact identifier | 

### Return type

[**List&lt;ContactDevice&gt;**](ContactDevice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The list of contact devices for the user |  -  |
| **401** | Authentication parameters missing |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **404** | User not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apipublicv1userusercontactmethodsdevicescontactidput"></a>
# **ApiPublicV1UserUserContactMethodsDevicesContactIdPut**
> ContactDevice ApiPublicV1UserUserContactMethodsDevicesContactIdPut (string xVOApiId, string xVOApiKey, string user, string contactId, ContactDeviceAdd body)

Update a contact device for a user

Update a contact device for a user  This API may be called a maximum of 60 times per minute. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1UserUserContactMethodsDevicesContactIdPutExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new UserContactMethodsApi(Configuration.Default);
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key
            var user = user_example;  // string | The VictorOps user ID
            var contactId = contactId_example;  // string | The unique contact identifier
            var body = new ContactDeviceAdd(); // ContactDeviceAdd | The contact device

            try
            {
                // Update a contact device for a user
                ContactDevice result = apiInstance.ApiPublicV1UserUserContactMethodsDevicesContactIdPut(xVOApiId, xVOApiKey, user, contactId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserContactMethodsApi.ApiPublicV1UserUserContactMethodsDevicesContactIdPut: " + e.Message );
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
 **contactId** | **string**| The unique contact identifier | 
 **body** | [**ContactDeviceAdd**](ContactDeviceAdd.md)| The contact device | 

### Return type

[**ContactDevice**](ContactDevice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The list of contact devices for the user |  -  |
| **400** | Problem with the request arguments.  The response payload may include an error message. |  -  |
| **401** | Authentication parameters missing |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **404** | User not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apipublicv1userusercontactmethodsdevicesget"></a>
# **ApiPublicV1UserUserContactMethodsDevicesGet**
> List&lt;ContactDevice&gt; ApiPublicV1UserUserContactMethodsDevicesGet (string xVOApiId, string xVOApiKey, string user)

Get a list of all contact devices for a user

Get the contact methods for a user  This API may be called a maximum of 60 times per minute. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1UserUserContactMethodsDevicesGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new UserContactMethodsApi(Configuration.Default);
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key
            var user = user_example;  // string | The VictorOps user ID

            try
            {
                // Get a list of all contact devices for a user
                List<ContactDevice> result = apiInstance.ApiPublicV1UserUserContactMethodsDevicesGet(xVOApiId, xVOApiKey, user);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserContactMethodsApi.ApiPublicV1UserUserContactMethodsDevicesGet: " + e.Message );
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

[**List&lt;ContactDevice&gt;**](ContactDevice.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The list of contact devices for the user |  -  |
| **401** | Authentication parameters missing |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **404** | User not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apipublicv1userusercontactmethodsemailscontactiddelete"></a>
# **ApiPublicV1UserUserContactMethodsEmailsContactIdDelete**
> UserContact ApiPublicV1UserUserContactMethodsEmailsContactIdDelete (string xVOApiId, string xVOApiKey, string user, string contactId)

Delete a contact email for a user

Delete the indicated contact email for the user  This API may be called a maximum of 60 times per minute. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1UserUserContactMethodsEmailsContactIdDeleteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new UserContactMethodsApi(Configuration.Default);
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key
            var user = user_example;  // string | The VictorOps user ID
            var contactId = contactId_example;  // string | The unique contact identifier

            try
            {
                // Delete a contact email for a user
                UserContact result = apiInstance.ApiPublicV1UserUserContactMethodsEmailsContactIdDelete(xVOApiId, xVOApiKey, user, contactId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserContactMethodsApi.ApiPublicV1UserUserContactMethodsEmailsContactIdDelete: " + e.Message );
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
 **contactId** | **string**| The unique contact identifier | 

### Return type

[**UserContact**](UserContact.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Deleted contact email for the user |  -  |
| **400** | Problem with the request arguments.  The response payload may include an error message. |  -  |
| **401** | Authentication parameters missing |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **404** | User not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apipublicv1userusercontactmethodsemailscontactidget"></a>
# **ApiPublicV1UserUserContactMethodsEmailsContactIdGet**
> List&lt;UserContact&gt; ApiPublicV1UserUserContactMethodsEmailsContactIdGet (string xVOApiId, string xVOApiKey, string user, string contactId)

Get the indicated contact email for a user

Get the indicated contact email for a user  This API may be called a maximum of 60 times per minute. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1UserUserContactMethodsEmailsContactIdGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new UserContactMethodsApi(Configuration.Default);
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key
            var user = user_example;  // string | The VictorOps user ID
            var contactId = contactId_example;  // string | The unique contact identifier

            try
            {
                // Get the indicated contact email for a user
                List<UserContact> result = apiInstance.ApiPublicV1UserUserContactMethodsEmailsContactIdGet(xVOApiId, xVOApiKey, user, contactId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserContactMethodsApi.ApiPublicV1UserUserContactMethodsEmailsContactIdGet: " + e.Message );
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
 **contactId** | **string**| The unique contact identifier | 

### Return type

[**List&lt;UserContact&gt;**](UserContact.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The indicated contact email for the user |  -  |
| **401** | Authentication parameters missing |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **404** | User not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apipublicv1userusercontactmethodsemailsget"></a>
# **ApiPublicV1UserUserContactMethodsEmailsGet**
> List&lt;UserContact&gt; ApiPublicV1UserUserContactMethodsEmailsGet (string xVOApiId, string xVOApiKey, string user)

Get a list of all contact emails for a user

Get the contact emails for a user  This API may be called a maximum of 60 times per minute. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1UserUserContactMethodsEmailsGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new UserContactMethodsApi(Configuration.Default);
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key
            var user = user_example;  // string | The VictorOps user ID

            try
            {
                // Get a list of all contact emails for a user
                List<UserContact> result = apiInstance.ApiPublicV1UserUserContactMethodsEmailsGet(xVOApiId, xVOApiKey, user);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserContactMethodsApi.ApiPublicV1UserUserContactMethodsEmailsGet: " + e.Message );
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

[**List&lt;UserContact&gt;**](UserContact.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The list of contact emails for the user |  -  |
| **401** | Authentication parameters missing |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **404** | User not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apipublicv1userusercontactmethodsemailspost"></a>
# **ApiPublicV1UserUserContactMethodsEmailsPost**
> UserContact ApiPublicV1UserUserContactMethodsEmailsPost (string xVOApiId, string xVOApiKey, string user, ContactEmailAdd body)

Create a contact emails for a user

Create a contact email for a user  This API may be called a maximum of 60 times per minute. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1UserUserContactMethodsEmailsPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new UserContactMethodsApi(Configuration.Default);
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key
            var user = user_example;  // string | The VictorOps user ID
            var body = new ContactEmailAdd(); // ContactEmailAdd | The contact email

            try
            {
                // Create a contact emails for a user
                UserContact result = apiInstance.ApiPublicV1UserUserContactMethodsEmailsPost(xVOApiId, xVOApiKey, user, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserContactMethodsApi.ApiPublicV1UserUserContactMethodsEmailsPost: " + e.Message );
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
 **body** | [**ContactEmailAdd**](ContactEmailAdd.md)| The contact email | 

### Return type

[**UserContact**](UserContact.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The list of contact emails for the user |  -  |
| **400** | Problem with the request arguments.  The response payload may include an error message. |  -  |
| **401** | Authentication parameters missing |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **404** | User not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apipublicv1userusercontactmethodsget"></a>
# **ApiPublicV1UserUserContactMethodsGet**
> InlineResponse2006 ApiPublicV1UserUserContactMethodsGet (string xVOApiId, string xVOApiKey, string user)

Get a list of all contact methods for a user

Get the contact methods for a user  This API may be called a maximum of 60 times per minute. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1UserUserContactMethodsGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new UserContactMethodsApi(Configuration.Default);
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key
            var user = user_example;  // string | The VictorOps user ID

            try
            {
                // Get a list of all contact methods for a user
                InlineResponse2006 result = apiInstance.ApiPublicV1UserUserContactMethodsGet(xVOApiId, xVOApiKey, user);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserContactMethodsApi.ApiPublicV1UserUserContactMethodsGet: " + e.Message );
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

[**InlineResponse2006**](InlineResponse2006.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | All available contact methods for the user |  -  |
| **400** | Problem with the request arguments.  The response payload may include an error message. |  -  |
| **401** | Authentication parameters missing |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **404** | User not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apipublicv1userusercontactmethodsphonescontactiddelete"></a>
# **ApiPublicV1UserUserContactMethodsPhonesContactIdDelete**
> UserContact ApiPublicV1UserUserContactMethodsPhonesContactIdDelete (string xVOApiId, string xVOApiKey, string user, string contactId)

Delete a contact phone for a user

Delete the indicated contact phone for the user  This API may be called a maximum of 60 times per minute. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1UserUserContactMethodsPhonesContactIdDeleteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new UserContactMethodsApi(Configuration.Default);
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key
            var user = user_example;  // string | The VictorOps user ID
            var contactId = contactId_example;  // string | The unique contact identifier

            try
            {
                // Delete a contact phone for a user
                UserContact result = apiInstance.ApiPublicV1UserUserContactMethodsPhonesContactIdDelete(xVOApiId, xVOApiKey, user, contactId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserContactMethodsApi.ApiPublicV1UserUserContactMethodsPhonesContactIdDelete: " + e.Message );
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
 **contactId** | **string**| The unique contact identifier | 

### Return type

[**UserContact**](UserContact.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Deleted contact phone for the user |  -  |
| **400** | Problem with the request arguments.  The response payload may include an error message. |  -  |
| **401** | Authentication parameters missing |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **404** | User not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apipublicv1userusercontactmethodsphonescontactidget"></a>
# **ApiPublicV1UserUserContactMethodsPhonesContactIdGet**
> List&lt;UserContact&gt; ApiPublicV1UserUserContactMethodsPhonesContactIdGet (string xVOApiId, string xVOApiKey, string user, string contactId)

Get the indicated contact phone for a user

Get the indicated contact phone for a user  This API may be called a maximum of 60 times per minute. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1UserUserContactMethodsPhonesContactIdGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new UserContactMethodsApi(Configuration.Default);
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key
            var user = user_example;  // string | The VictorOps user ID
            var contactId = contactId_example;  // string | The unique contact identifier

            try
            {
                // Get the indicated contact phone for a user
                List<UserContact> result = apiInstance.ApiPublicV1UserUserContactMethodsPhonesContactIdGet(xVOApiId, xVOApiKey, user, contactId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserContactMethodsApi.ApiPublicV1UserUserContactMethodsPhonesContactIdGet: " + e.Message );
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
 **contactId** | **string**| The unique contact identifier | 

### Return type

[**List&lt;UserContact&gt;**](UserContact.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The indicated contact phone for the user |  -  |
| **401** | Authentication parameters missing |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **404** | User not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apipublicv1userusercontactmethodsphonesget"></a>
# **ApiPublicV1UserUserContactMethodsPhonesGet**
> List&lt;UserContact&gt; ApiPublicV1UserUserContactMethodsPhonesGet (string xVOApiId, string xVOApiKey, string user)

Get a list of all contact phones for a user

Get the contact phones for a user  This API may be called a maximum of 60 times per minute. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1UserUserContactMethodsPhonesGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new UserContactMethodsApi(Configuration.Default);
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key
            var user = user_example;  // string | The VictorOps user ID

            try
            {
                // Get a list of all contact phones for a user
                List<UserContact> result = apiInstance.ApiPublicV1UserUserContactMethodsPhonesGet(xVOApiId, xVOApiKey, user);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserContactMethodsApi.ApiPublicV1UserUserContactMethodsPhonesGet: " + e.Message );
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

[**List&lt;UserContact&gt;**](UserContact.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The list of contact phones for the user |  -  |
| **401** | Authentication parameters missing |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **404** | User not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apipublicv1userusercontactmethodsphonespost"></a>
# **ApiPublicV1UserUserContactMethodsPhonesPost**
> UserContact ApiPublicV1UserUserContactMethodsPhonesPost (string xVOApiId, string xVOApiKey, string user, ContactPhoneAdd body)

Create a contact phones for a user

Create a contact phone for a user  This API may be called a maximum of 60 times per minute. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ApiPublicV1UserUserContactMethodsPhonesPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.victorops.com";
            var apiInstance = new UserContactMethodsApi(Configuration.Default);
            var xVOApiId = xVOApiId_example;  // string | Your API ID
            var xVOApiKey = xVOApiKey_example;  // string | Your API Key
            var user = user_example;  // string | The VictorOps user ID
            var body = new ContactPhoneAdd(); // ContactPhoneAdd | The contact phone

            try
            {
                // Create a contact phones for a user
                UserContact result = apiInstance.ApiPublicV1UserUserContactMethodsPhonesPost(xVOApiId, xVOApiKey, user, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserContactMethodsApi.ApiPublicV1UserUserContactMethodsPhonesPost: " + e.Message );
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
 **body** | [**ContactPhoneAdd**](ContactPhoneAdd.md)| The contact phone | 

### Return type

[**UserContact**](UserContact.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The list of contact phones for the user |  -  |
| **400** | Problem with the request arguments.  The response payload may include an error message. |  -  |
| **401** | Authentication parameters missing |  -  |
| **403** | Authentication failed or rate-limit reached |  -  |
| **404** | User not found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

