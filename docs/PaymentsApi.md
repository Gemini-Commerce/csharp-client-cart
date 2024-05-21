# cart.Api.PaymentsApi

All URIs are relative to *https://cart.api.gogemini.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ListPaymentMethods**](PaymentsApi.md#listpaymentmethods) | **POST** /cart.Cart/ListPaymentMethods | List Payment Methods |
| [**SetSetPayments**](PaymentsApi.md#setsetpayments) | **POST** /cart.Cart/SetPayments | Set SetPayments |

<a id="listpaymentmethods"></a>
# **ListPaymentMethods**
> CartListPaymentMethodsResponse ListPaymentMethods (CartListPaymentMethodsRequest body)

List Payment Methods

List payment methods

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cart.Api;
using cart.Client;
using cart.Model;

namespace Example
{
    public class ListPaymentMethodsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://cart.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PaymentsApi(config);
            var body = new CartListPaymentMethodsRequest(); // CartListPaymentMethodsRequest | 

            try
            {
                // List Payment Methods
                CartListPaymentMethodsResponse result = apiInstance.ListPaymentMethods(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentsApi.ListPaymentMethods: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListPaymentMethodsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Payment Methods
    ApiResponse<CartListPaymentMethodsResponse> response = apiInstance.ListPaymentMethodsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentsApi.ListPaymentMethodsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**CartListPaymentMethodsRequest**](CartListPaymentMethodsRequest.md) |  |  |

### Return type

[**CartListPaymentMethodsResponse**](CartListPaymentMethodsResponse.md)

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
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="setsetpayments"></a>
# **SetSetPayments**
> CartSetPaymentsResponse SetSetPayments (CartSetPaymentsRequest body)

Set SetPayments

Set SetPayments

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cart.Api;
using cart.Client;
using cart.Model;

namespace Example
{
    public class SetSetPaymentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://cart.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PaymentsApi(config);
            var body = new CartSetPaymentsRequest(); // CartSetPaymentsRequest | 

            try
            {
                // Set SetPayments
                CartSetPaymentsResponse result = apiInstance.SetSetPayments(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentsApi.SetSetPayments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetSetPaymentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set SetPayments
    ApiResponse<CartSetPaymentsResponse> response = apiInstance.SetSetPaymentsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PaymentsApi.SetSetPaymentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**CartSetPaymentsRequest**](CartSetPaymentsRequest.md) |  |  |

### Return type

[**CartSetPaymentsResponse**](CartSetPaymentsResponse.md)

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

