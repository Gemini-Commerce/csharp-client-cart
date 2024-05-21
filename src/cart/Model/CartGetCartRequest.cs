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
    /// Get cart request
    /// </summary>
    [DataContract(Name = "cartGetCartRequest")]
    public partial class CartGetCartRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CartGetCartRequest" /> class.
        /// </summary>
        /// <param name="tenantId">The unique identifier for the tenant associated with the shopping cart..</param>
        /// <param name="cartId">cartId.</param>
        public CartGetCartRequest(string tenantId = default(string), string cartId = default(string))
        {
            this.TenantId = tenantId;
            this.CartId = cartId;
        }

        /// <summary>
        /// The unique identifier for the tenant associated with the shopping cart.
        /// </summary>
        /// <value>The unique identifier for the tenant associated with the shopping cart.</value>
        [DataMember(Name = "tenantId", EmitDefaultValue = false)]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or Sets CartId
        /// </summary>
        [DataMember(Name = "cartId", EmitDefaultValue = false)]
        public string CartId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CartGetCartRequest {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  CartId: ").Append(CartId).Append("\n");
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
            if (this.TenantId != null) {
                // TenantId (string) pattern
                Regex regexTenantId = new Regex(@"^[0-9a-f]{8}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{12}$", RegexOptions.CultureInvariant);
                if (!regexTenantId.Match(this.TenantId).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TenantId, must match a pattern of " + regexTenantId, new [] { "TenantId" });
                }
            }

            yield break;
        }
    }

}