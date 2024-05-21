# cart.Api.PromotionsApi

All URIs are relative to *https://cart.api.gogemini.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ApplyCoupons**](PromotionsApi.md#applycoupons) | **POST** /cart.Cart/ApplyCoupons | Apply Coupons |
| [**RemoveCoupons**](PromotionsApi.md#removecoupons) | **POST** /cart.Cart/RemoveCoupons | Remove Coupons |

<a id="applycoupons"></a>
# **ApplyCoupons**
> Object ApplyCoupons (CartApplyCouponsRequest body)

Apply Coupons

Apply coupons to the cart

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cart.Api;
using cart.Client;
using cart.Model;

namespace Example
{
    public class ApplyCouponsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://cart.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PromotionsApi(config);
            var body = new CartApplyCouponsRequest(); // CartApplyCouponsRequest | 

            try
            {
                // Apply Coupons
                Object result = apiInstance.ApplyCoupons(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PromotionsApi.ApplyCoupons: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ApplyCouponsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Apply Coupons
    ApiResponse<Object> response = apiInstance.ApplyCouponsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PromotionsApi.ApplyCouponsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**CartApplyCouponsRequest**](CartApplyCouponsRequest.md) |  |  |

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="removecoupons"></a>
# **RemoveCoupons**
> Object RemoveCoupons (CartRemoveCouponsRequest body)

Remove Coupons

Remove coupons from the cart

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cart.Api;
using cart.Client;
using cart.Model;

namespace Example
{
    public class RemoveCouponsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://cart.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PromotionsApi(config);
            var body = new CartRemoveCouponsRequest(); // CartRemoveCouponsRequest | 

            try
            {
                // Remove Coupons
                Object result = apiInstance.RemoveCoupons(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PromotionsApi.RemoveCoupons: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveCouponsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove Coupons
    ApiResponse<Object> response = apiInstance.RemoveCouponsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PromotionsApi.RemoveCouponsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**CartRemoveCouponsRequest**](CartRemoveCouponsRequest.md) |  |  |

### Return type

**Object**

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

