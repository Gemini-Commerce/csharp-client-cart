# cart.Api.AddressesApi

All URIs are relative to *https://cart.api.gogemini.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SetBillingAddress**](AddressesApi.md#setbillingaddress) | **POST** /cart.Cart/SetBillingAddress | Set Billing Address |
| [**SetShipmentAddress**](AddressesApi.md#setshipmentaddress) | **POST** /cart.Cart/SetShipmentAddress | Set Shipment Address |

<a id="setbillingaddress"></a>
# **SetBillingAddress**
> Object SetBillingAddress (CartSetBillingAddressRequest body)

Set Billing Address

Set billing address

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cart.Api;
using cart.Client;
using cart.Model;

namespace Example
{
    public class SetBillingAddressExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://cart.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AddressesApi(config);
            var body = new CartSetBillingAddressRequest(); // CartSetBillingAddressRequest | 

            try
            {
                // Set Billing Address
                Object result = apiInstance.SetBillingAddress(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressesApi.SetBillingAddress: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetBillingAddressWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set Billing Address
    ApiResponse<Object> response = apiInstance.SetBillingAddressWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AddressesApi.SetBillingAddressWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**CartSetBillingAddressRequest**](CartSetBillingAddressRequest.md) |  |  |

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
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="setshipmentaddress"></a>
# **SetShipmentAddress**
> Object SetShipmentAddress (CartSetShipmentAddressRequest body)

Set Shipment Address

Set shipment address

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cart.Api;
using cart.Client;
using cart.Model;

namespace Example
{
    public class SetShipmentAddressExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://cart.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AddressesApi(config);
            var body = new CartSetShipmentAddressRequest(); // CartSetShipmentAddressRequest | 

            try
            {
                // Set Shipment Address
                Object result = apiInstance.SetShipmentAddress(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressesApi.SetShipmentAddress: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetShipmentAddressWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set Shipment Address
    ApiResponse<Object> response = apiInstance.SetShipmentAddressWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AddressesApi.SetShipmentAddressWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**CartSetShipmentAddressRequest**](CartSetShipmentAddressRequest.md) |  |  |

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
| **404** | Not Found |  -  |
| **409** | Conflict |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

