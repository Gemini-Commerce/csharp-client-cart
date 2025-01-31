/*
 * Cart Service
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: info@gemini-commerce.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = cart.Client.OpenAPIDateConverter;

namespace cart.Model
{
    /// <summary>
    /// Defines CartSubtotalCode
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CartSubtotalCode
    {
        /// <summary>
        /// Enum UNKNOWN for value: UNKNOWN
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        /// <summary>
        /// Enum PAYMENT for value: PAYMENT
        /// </summary>
        [EnumMember(Value = "PAYMENT")]
        PAYMENT,

        /// <summary>
        /// Enum SHIPMENT for value: SHIPMENT
        /// </summary>
        [EnumMember(Value = "SHIPMENT")]
        SHIPMENT,

        /// <summary>
        /// Enum TAX for value: TAX
        /// </summary>
        [EnumMember(Value = "TAX")]
        TAX,

        /// <summary>
        /// Enum ITEMS for value: ITEMS
        /// </summary>
        [EnumMember(Value = "ITEMS")]
        ITEMS,

        /// <summary>
        /// Enum DISCOUNT for value: DISCOUNT
        /// </summary>
        [EnumMember(Value = "DISCOUNT")]
        DISCOUNT
    }

}
