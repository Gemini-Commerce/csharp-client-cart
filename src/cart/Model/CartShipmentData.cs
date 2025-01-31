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
    /// CartShipmentData
    /// </summary>
    [DataContract(Name = "cartShipmentData")]
    public partial class CartShipmentData : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CartShipmentData" /> class.
        /// </summary>
        /// <param name="code">code.</param>
        /// <param name="method">method.</param>
        /// <param name="shipmentGrn">shipmentGrn.</param>
        /// <param name="payload">payload.</param>
        /// <param name="cartItemIds">cartItemIds.</param>
        /// <param name="fee">fee.</param>
        /// <param name="label">label.</param>
        /// <param name="vatAmount">vatAmount.</param>
        /// <param name="vatPercentage">vatPercentage.</param>
        /// <param name="vatInaccurate">vatInaccurate.</param>
        /// <param name="vatCalculated">vatCalculated.</param>
        public CartShipmentData(string code = default(string), string method = default(string), string shipmentGrn = default(string), string payload = default(string), List<string> cartItemIds = default(List<string>), CartMoney fee = default(CartMoney), string label = default(string), CartMoney vatAmount = default(CartMoney), float vatPercentage = default(float), bool vatInaccurate = default(bool), bool vatCalculated = default(bool))
        {
            this.Code = code;
            this.Method = method;
            this.ShipmentGrn = shipmentGrn;
            this.Payload = payload;
            this.CartItemIds = cartItemIds;
            this.Fee = fee;
            this.Label = label;
            this.VatAmount = vatAmount;
            this.VatPercentage = vatPercentage;
            this.VatInaccurate = vatInaccurate;
            this.VatCalculated = vatCalculated;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets Method
        /// </summary>
        [DataMember(Name = "method", EmitDefaultValue = false)]
        public string Method { get; set; }

        /// <summary>
        /// Gets or Sets ShipmentGrn
        /// </summary>
        [DataMember(Name = "shipmentGrn", EmitDefaultValue = false)]
        public string ShipmentGrn { get; set; }

        /// <summary>
        /// Gets or Sets Payload
        /// </summary>
        [DataMember(Name = "payload", EmitDefaultValue = false)]
        public string Payload { get; set; }

        /// <summary>
        /// Gets or Sets CartItemIds
        /// </summary>
        [DataMember(Name = "cartItemIds", EmitDefaultValue = false)]
        public List<string> CartItemIds { get; set; }

        /// <summary>
        /// Gets or Sets Fee
        /// </summary>
        [DataMember(Name = "fee", EmitDefaultValue = false)]
        public CartMoney Fee { get; set; }

        /// <summary>
        /// Gets or Sets Label
        /// </summary>
        [DataMember(Name = "label", EmitDefaultValue = false)]
        public string Label { get; set; }

        /// <summary>
        /// Gets or Sets VatAmount
        /// </summary>
        [DataMember(Name = "vatAmount", EmitDefaultValue = false)]
        public CartMoney VatAmount { get; set; }

        /// <summary>
        /// Gets or Sets VatPercentage
        /// </summary>
        [DataMember(Name = "vatPercentage", EmitDefaultValue = false)]
        public float VatPercentage { get; set; }

        /// <summary>
        /// Gets or Sets VatInaccurate
        /// </summary>
        [DataMember(Name = "vatInaccurate", EmitDefaultValue = true)]
        public bool VatInaccurate { get; set; }

        /// <summary>
        /// Gets or Sets VatCalculated
        /// </summary>
        [DataMember(Name = "vatCalculated", EmitDefaultValue = true)]
        public bool VatCalculated { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CartShipmentData {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  ShipmentGrn: ").Append(ShipmentGrn).Append("\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
            sb.Append("  CartItemIds: ").Append(CartItemIds).Append("\n");
            sb.Append("  Fee: ").Append(Fee).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  VatAmount: ").Append(VatAmount).Append("\n");
            sb.Append("  VatPercentage: ").Append(VatPercentage).Append("\n");
            sb.Append("  VatInaccurate: ").Append(VatInaccurate).Append("\n");
            sb.Append("  VatCalculated: ").Append(VatCalculated).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
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
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
