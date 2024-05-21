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
    /// CartListShipmentMethodsResponse
    /// </summary>
    [DataContract(Name = "cartListShipmentMethodsResponse")]
    public partial class CartListShipmentMethodsResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CartListShipmentMethodsResponse" /> class.
        /// </summary>
        /// <param name="shipments">shipments.</param>
        public CartListShipmentMethodsResponse(List<CartShipmentData> shipments = default(List<CartShipmentData>))
        {
            this.Shipments = shipments;
        }

        /// <summary>
        /// Gets or Sets Shipments
        /// </summary>
        [DataMember(Name = "shipments", EmitDefaultValue = false)]
        public List<CartShipmentData> Shipments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CartListShipmentMethodsResponse {\n");
            sb.Append("  Shipments: ").Append(Shipments).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
