# cart.Api.BasicOperationsApi

All URIs are relative to *https://cart.api.gogemini.io*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddProducts**](BasicOperationsApi.md#addproducts) | **POST** /cart.Cart/AddProducts | Add Products |
| [**CreateCart**](BasicOperationsApi.md#createcart) | **POST** /cart.Cart/CreateCart | Create Cart |
| [**GetActiveCartByCustomer**](BasicOperationsApi.md#getactivecartbycustomer) | **POST** /cart.Cart/GetActiveCartByCustomer | Get Active Cart By Customer |
| [**GetCart**](BasicOperationsApi.md#getcart) | **POST** /cart.Cart/GetCart | Get Cart |
| [**ListCarts**](BasicOperationsApi.md#listcarts) | **POST** /cart.Cart/ListCarts | List Carts |
| [**MergeCarts**](BasicOperationsApi.md#mergecarts) | **POST** /cart.Cart/MergeCarts | Merge Carts |
| [**RemoveProducts**](BasicOperationsApi.md#removeproducts) | **POST** /cart.Cart/RemoveProducts | Remove Products |
| [**SetAdditionalInfo**](BasicOperationsApi.md#setadditionalinfo) | **POST** /cart.Cart/SetAdditionalInfo | Set Additional Info |
| [**SetNotes**](BasicOperationsApi.md#setnotes) | **POST** /cart.Cart/SetNotes | Set Notes |
| [**TriggerRealignment**](BasicOperationsApi.md#triggerrealignment) | **POST** /cart.Cart/TriggerRealignment | Trigger Realignment |
| [**UpdateCart**](BasicOperationsApi.md#updatecart) | **POST** /cart.Cart/UpdateCart | Update Cart |
| [**UpdateProducts**](BasicOperationsApi.md#updateproducts) | **POST** /cart.Cart/UpdateProducts | Update Products |

<a id="addproducts"></a>
# **AddProducts**
> CartAddProductsResponse AddProducts (CartAddProductsRequest body)

Add Products

This endpoint allows you to add products to a shopping cart. The AddProducts method enables you to specify the tenantId and cartId to identify the target shopping cart, and provide a list of items to be added.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cart.Api;
using cart.Client;
using cart.Model;

namespace Example
{
    public class AddProductsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://cart.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BasicOperationsApi(config);
            var body = new CartAddProductsRequest(); // CartAddProductsRequest | 

            try
            {
                // Add Products
                CartAddProductsResponse result = apiInstance.AddProducts(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasicOperationsApi.AddProducts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddProductsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add Products
    ApiResponse<CartAddProductsResponse> response = apiInstance.AddProductsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasicOperationsApi.AddProductsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**CartAddProductsRequest**](CartAddProductsRequest.md) |  |  |

### Return type

[**CartAddProductsResponse**](CartAddProductsResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createcart"></a>
# **CreateCart**
> CartCreateCartResponse CreateCart (CartCreateCartRequest body)

Create Cart

The CreateCart endpoint allows users to create a new cart for their shopping session. By making a request to this endpoint, users can initiate a new cart and obtain a unique identifier for future cart operations. This endpoint enables seamless cart management and provides a foundation for adding products and performing checkout operations.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cart.Api;
using cart.Client;
using cart.Model;

namespace Example
{
    public class CreateCartExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://cart.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BasicOperationsApi(config);
            var body = new CartCreateCartRequest(); // CartCreateCartRequest | 

            try
            {
                // Create Cart
                CartCreateCartResponse result = apiInstance.CreateCart(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasicOperationsApi.CreateCart: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateCartWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Cart
    ApiResponse<CartCreateCartResponse> response = apiInstance.CreateCartWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasicOperationsApi.CreateCartWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**CartCreateCartRequest**](CartCreateCartRequest.md) |  |  |

### Return type

[**CartCreateCartResponse**](CartCreateCartResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getactivecartbycustomer"></a>
# **GetActiveCartByCustomer**
> CartGetActiveCartByCustomerResponse GetActiveCartByCustomer (CartGetActiveCartByCustomerRequest body)

Get Active Cart By Customer

Get the active cart by customer

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cart.Api;
using cart.Client;
using cart.Model;

namespace Example
{
    public class GetActiveCartByCustomerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://cart.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BasicOperationsApi(config);
            var body = new CartGetActiveCartByCustomerRequest(); // CartGetActiveCartByCustomerRequest | 

            try
            {
                // Get Active Cart By Customer
                CartGetActiveCartByCustomerResponse result = apiInstance.GetActiveCartByCustomer(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasicOperationsApi.GetActiveCartByCustomer: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetActiveCartByCustomerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Active Cart By Customer
    ApiResponse<CartGetActiveCartByCustomerResponse> response = apiInstance.GetActiveCartByCustomerWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasicOperationsApi.GetActiveCartByCustomerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**CartGetActiveCartByCustomerRequest**](CartGetActiveCartByCustomerRequest.md) |  |  |

### Return type

[**CartGetActiveCartByCustomerResponse**](CartGetActiveCartByCustomerResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcart"></a>
# **GetCart**
> CartGetCartResponse GetCart (CartGetCartRequest body)

Get Cart

Get the cart

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cart.Api;
using cart.Client;
using cart.Model;

namespace Example
{
    public class GetCartExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://cart.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BasicOperationsApi(config);
            var body = new CartGetCartRequest(); // CartGetCartRequest | Get cart request

            try
            {
                // Get Cart
                CartGetCartResponse result = apiInstance.GetCart(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasicOperationsApi.GetCart: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCartWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Cart
    ApiResponse<CartGetCartResponse> response = apiInstance.GetCartWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasicOperationsApi.GetCartWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**CartGetCartRequest**](CartGetCartRequest.md) | Get cart request |  |

### Return type

[**CartGetCartResponse**](CartGetCartResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listcarts"></a>
# **ListCarts**
> CartListCartsResponse ListCarts (CartListCartsRequest body)

List Carts

List all carts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cart.Api;
using cart.Client;
using cart.Model;

namespace Example
{
    public class ListCartsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://cart.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BasicOperationsApi(config);
            var body = new CartListCartsRequest(); // CartListCartsRequest | 

            try
            {
                // List Carts
                CartListCartsResponse result = apiInstance.ListCarts(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasicOperationsApi.ListCarts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListCartsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Carts
    ApiResponse<CartListCartsResponse> response = apiInstance.ListCartsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasicOperationsApi.ListCartsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**CartListCartsRequest**](CartListCartsRequest.md) |  |  |

### Return type

[**CartListCartsResponse**](CartListCartsResponse.md)

### Authorization

[Authorization](../README.md#Authorization)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="mergecarts"></a>
# **MergeCarts**
> CartMergeCartsResponse MergeCarts (CartMergeCartsRequest body)

Merge Carts

Merge carts

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cart.Api;
using cart.Client;
using cart.Model;

namespace Example
{
    public class MergeCartsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://cart.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BasicOperationsApi(config);
            var body = new CartMergeCartsRequest(); // CartMergeCartsRequest | 

            try
            {
                // Merge Carts
                CartMergeCartsResponse result = apiInstance.MergeCarts(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasicOperationsApi.MergeCarts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MergeCartsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Merge Carts
    ApiResponse<CartMergeCartsResponse> response = apiInstance.MergeCartsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasicOperationsApi.MergeCartsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**CartMergeCartsRequest**](CartMergeCartsRequest.md) |  |  |

### Return type

[**CartMergeCartsResponse**](CartMergeCartsResponse.md)

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

<a id="removeproducts"></a>
# **RemoveProducts**
> Object RemoveProducts (CartRemoveProductsRequest body)

Remove Products

Remove products from the cart

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cart.Api;
using cart.Client;
using cart.Model;

namespace Example
{
    public class RemoveProductsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://cart.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BasicOperationsApi(config);
            var body = new CartRemoveProductsRequest(); // CartRemoveProductsRequest | 

            try
            {
                // Remove Products
                Object result = apiInstance.RemoveProducts(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasicOperationsApi.RemoveProducts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveProductsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove Products
    ApiResponse<Object> response = apiInstance.RemoveProductsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasicOperationsApi.RemoveProductsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**CartRemoveProductsRequest**](CartRemoveProductsRequest.md) |  |  |

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
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="setadditionalinfo"></a>
# **SetAdditionalInfo**
> Object SetAdditionalInfo (CartSetAdditionalInfoRequest body)

Set Additional Info

Set additional info

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cart.Api;
using cart.Client;
using cart.Model;

namespace Example
{
    public class SetAdditionalInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://cart.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BasicOperationsApi(config);
            var body = new CartSetAdditionalInfoRequest(); // CartSetAdditionalInfoRequest | 

            try
            {
                // Set Additional Info
                Object result = apiInstance.SetAdditionalInfo(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasicOperationsApi.SetAdditionalInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetAdditionalInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set Additional Info
    ApiResponse<Object> response = apiInstance.SetAdditionalInfoWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasicOperationsApi.SetAdditionalInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**CartSetAdditionalInfoRequest**](CartSetAdditionalInfoRequest.md) |  |  |

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

<a id="setnotes"></a>
# **SetNotes**
> Object SetNotes (CartSetNotesRequest body)

Set Notes

Set notes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cart.Api;
using cart.Client;
using cart.Model;

namespace Example
{
    public class SetNotesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://cart.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BasicOperationsApi(config);
            var body = new CartSetNotesRequest(); // CartSetNotesRequest | 

            try
            {
                // Set Notes
                Object result = apiInstance.SetNotes(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasicOperationsApi.SetNotes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetNotesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set Notes
    ApiResponse<Object> response = apiInstance.SetNotesWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasicOperationsApi.SetNotesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**CartSetNotesRequest**](CartSetNotesRequest.md) |  |  |

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

<a id="triggerrealignment"></a>
# **TriggerRealignment**
> CartTriggerRealignmentResponse TriggerRealignment (CartTriggerRealignmentRequest body)

Trigger Realignment

Trigger realignment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cart.Api;
using cart.Client;
using cart.Model;

namespace Example
{
    public class TriggerRealignmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://cart.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BasicOperationsApi(config);
            var body = new CartTriggerRealignmentRequest(); // CartTriggerRealignmentRequest | 

            try
            {
                // Trigger Realignment
                CartTriggerRealignmentResponse result = apiInstance.TriggerRealignment(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasicOperationsApi.TriggerRealignment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TriggerRealignmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Trigger Realignment
    ApiResponse<CartTriggerRealignmentResponse> response = apiInstance.TriggerRealignmentWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasicOperationsApi.TriggerRealignmentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**CartTriggerRealignmentRequest**](CartTriggerRealignmentRequest.md) |  |  |

### Return type

[**CartTriggerRealignmentResponse**](CartTriggerRealignmentResponse.md)

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

<a id="updatecart"></a>
# **UpdateCart**
> Object UpdateCart (CartUpdateCartRequest body)

Update Cart

Update the cart

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cart.Api;
using cart.Client;
using cart.Model;

namespace Example
{
    public class UpdateCartExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://cart.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BasicOperationsApi(config);
            var body = new CartUpdateCartRequest(); // CartUpdateCartRequest | 

            try
            {
                // Update Cart
                Object result = apiInstance.UpdateCart(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasicOperationsApi.UpdateCart: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateCartWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Cart
    ApiResponse<Object> response = apiInstance.UpdateCartWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasicOperationsApi.UpdateCartWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**CartUpdateCartRequest**](CartUpdateCartRequest.md) |  |  |

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
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateproducts"></a>
# **UpdateProducts**
> Object UpdateProducts (CartUpdateProductsRequest body)

Update Products

Update products in the cart

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cart.Api;
using cart.Client;
using cart.Model;

namespace Example
{
    public class UpdateProductsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://cart.api.gogemini.io";
            // Configure API key authorization: Authorization
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BasicOperationsApi(config);
            var body = new CartUpdateProductsRequest(); // CartUpdateProductsRequest | 

            try
            {
                // Update Products
                Object result = apiInstance.UpdateProducts(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BasicOperationsApi.UpdateProducts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateProductsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Products
    ApiResponse<Object> response = apiInstance.UpdateProductsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BasicOperationsApi.UpdateProductsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**CartUpdateProductsRequest**](CartUpdateProductsRequest.md) |  |  |

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
| **500** | An internal error occurred is thrown when an incompatible payload is sent |  -  |
| **0** | An unexpected error response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

