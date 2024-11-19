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
    /// ListCartsRequestSort
    /// </summary>
    [DataContract(Name = "ListCartsRequestSort")]
    public partial class ListCartsRequestSort : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Field
        /// </summary>
        [DataMember(Name = "field", EmitDefaultValue = false)]
        public SortSortField? Field { get; set; }

        /// <summary>
        /// Gets or Sets Order
        /// </summary>
        [DataMember(Name = "order", EmitDefaultValue = false)]
        public CartSortOrder? Order { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListCartsRequestSort" /> class.
        /// </summary>
        /// <param name="evaluationOrder">evaluation_order is the order in which the sort will be applied. The lower the number, the earlier the sort will be applied..</param>
        /// <param name="field">field.</param>
        /// <param name="order">order.</param>
        public ListCartsRequestSort(long evaluationOrder = default(long), SortSortField? field = default(SortSortField?), CartSortOrder? order = default(CartSortOrder?))
        {
            this.EvaluationOrder = evaluationOrder;
            this.Field = field;
            this.Order = order;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// evaluation_order is the order in which the sort will be applied. The lower the number, the earlier the sort will be applied.
        /// </summary>
        /// <value>evaluation_order is the order in which the sort will be applied. The lower the number, the earlier the sort will be applied.</value>
        [DataMember(Name = "evaluationOrder", EmitDefaultValue = false)]
        public long EvaluationOrder { get; set; }

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
            sb.Append("class ListCartsRequestSort {\n");
            sb.Append("  EvaluationOrder: ").Append(EvaluationOrder).Append("\n");
            sb.Append("  Field: ").Append(Field).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
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
