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
    /// Defines SortSortField
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SortSortField
    {
        /// <summary>
        /// Enum UNKNOWN for value: UNKNOWN
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        /// <summary>
        /// Enum DATE for value: DATE
        /// </summary>
        [EnumMember(Value = "DATE")]
        DATE,

        /// <summary>
        /// Enum CARTTOTAL for value: CART_TOTAL
        /// </summary>
        [EnumMember(Value = "CART_TOTAL")]
        CARTTOTAL
    }

}
