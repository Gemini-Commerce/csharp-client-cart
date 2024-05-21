# # CartCartData


## Properties 


Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id**| **string** |   | [optional]
**Grn**| **string** |   | [optional]
**Channel**| **string** |   | [optional]
**Market**| **string** |   | [optional]
**Locale**| **string** |   | [optional]
**Items**| [**List<CartCartItem>**](CartCartItem.md) |   | [optional]
**Payments**| [**List<CartPaymentData>**](CartPaymentData.md) |   | [optional]
**Shipments**| [**List<CartShipmentData>**](CartShipmentData.md) |   | [optional]
**Promotions**| [**List<CartPromotionData>**](CartPromotionData.md) |   | [optional]
**Currency**| **CartCurrency** |  for more information please, see Model/CartCurrency.php  | [optional]
**Subtotals**| [**List<CartCartSubtotal>**](CartCartSubtotal.md) |   | [optional]
**Total**| [**CartMoney**](CartMoney.md) |   | [optional]
**TotalDue**| [**CartMoney**](CartMoney.md) |   | [optional]
**VatIncluded**| **bool** |   | [optional]
**BillingAddress**| [**CartPostalAddress**](CartPostalAddress.md) |   | [optional]
**ShippingAddress**| [**CartPostalAddress**](CartPostalAddress.md) |   | [optional]
**Status**| **CartCartStatus** |  for more information please, see Model/CartCartStatus.php  | [optional]
**Customer**| [**CartCustomerData**](CartCustomerData.md) |   | [optional]
**Notes**| **string** |   | [optional]
**CreatedAt**| **DateTime** |   | [optional]
**UpdatedAt**| **DateTime** |   | [optional]


[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)

