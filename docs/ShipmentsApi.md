# cart.Api.ShipmentsApi

All URIs are relative to *https://cart.api.gogemini.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ListShipmentMethods**](ShipmentsApi.md#listshipmentmethods) | **POST** /cart.Cart/ListShipmentMethods | List Shipment Methods |
| [**SetShipments**](ShipmentsApi.md#setshipments) | **POST** /cart.Cart/SetShipments | Set Shipments |

<a id="listshipmentmethods"></a>
# **ListShipmentMethods**
> CartListShipmentMethodsResponse ListShipmentMethods (CartListShipmentMethodsRequest body)

List Shipment Methods

List shipment methods

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cart.Api;
using cart.Client;
using cart.Model;

namespace Example
{
    public class ListShipmentMethodsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://cart.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ShipmentsApi(config);
            var body = new CartListShipmentMethodsRequest(); // CartListShipmentMethodsRequest | 

            try
            {
                // List Shipment Methods
                CartListShipmentMethodsResponse result = apiInstance.ListShipmentMethods(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShipmentsApi.ListShipmentMethods: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListShipmentMethodsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Shipment Methods
    ApiResponse<CartListShipmentMethodsResponse> response = apiInstance.ListShipmentMethodsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShipmentsApi.ListShipmentMethodsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**CartListShipmentMethodsRequest**](CartListShipmentMethodsRequest.md) |  |  |

### Return type

[**CartListShipmentMethodsResponse**](CartListShipmentMethodsResponse.md)

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

<a id="setshipments"></a>
# **SetShipments**
> Object SetShipments (CartSetShipmentsRequest body)

Set Shipments

Set shipments

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cart.Api;
using cart.Client;
using cart.Model;

namespace Example
{
    public class SetShipmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://cart.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ShipmentsApi(config);
            var body = new CartSetShipmentsRequest(); // CartSetShipmentsRequest | 

            try
            {
                // Set Shipments
                Object result = apiInstance.SetShipments(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShipmentsApi.SetShipments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetShipmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set Shipments
    ApiResponse<Object> response = apiInstance.SetShipmentsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShipmentsApi.SetShipmentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**CartSetShipmentsRequest**](CartSetShipmentsRequest.md) |  |  |

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

