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
    /// ListCartsRequestFilter
    /// </summary>
    [DataContract(Name = "ListCartsRequestFilter")]
    public partial class ListCartsRequestFilter : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets CartStatus
        /// </summary>
        [DataMember(Name = "cartStatus", EmitDefaultValue = false)]
        public ListCartsRequestFilterCartStatus? CartStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListCartsRequestFilter" /> class.
        /// </summary>
        /// <param name="searchTerms">searchTerms.</param>
        /// <param name="customerEmails">customerEmails.</param>
        /// <param name="customerFirstnames">customerFirstnames.</param>
        /// <param name="customerLastnames">customerLastnames.</param>
        /// <param name="customerPhones">customerPhones.</param>
        /// <param name="cartIds">cartIds.</param>
        /// <param name="cartStatus">cartStatus.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="agentGrn">agentGrn.</param>
        public ListCartsRequestFilter(List<string> searchTerms = default(List<string>), List<string> customerEmails = default(List<string>), List<string> customerFirstnames = default(List<string>), List<string> customerLastnames = default(List<string>), List<string> customerPhones = default(List<string>), List<string> cartIds = default(List<string>), ListCartsRequestFilterCartStatus? cartStatus = default(ListCartsRequestFilterCartStatus?), List<ListCartsRequestFilterDate> createdAt = default(List<ListCartsRequestFilterDate>), string agentGrn = default(string))
        {
            this.SearchTerms = searchTerms;
            this.CustomerEmails = customerEmails;
            this.CustomerFirstnames = customerFirstnames;
            this.CustomerLastnames = customerLastnames;
            this.CustomerPhones = customerPhones;
            this.CartIds = cartIds;
            this.CartStatus = cartStatus;
            this.CreatedAt = createdAt;
            this.AgentGrn = agentGrn;
        }

        /// <summary>
        /// Gets or Sets SearchTerms
        /// </summary>
        [DataMember(Name = "searchTerms", EmitDefaultValue = false)]
        public List<string> SearchTerms { get; set; }

        /// <summary>
        /// Gets or Sets CustomerEmails
        /// </summary>
        [DataMember(Name = "customerEmails", EmitDefaultValue = false)]
        public List<string> CustomerEmails { get; set; }

        /// <summary>
        /// Gets or Sets CustomerFirstnames
        /// </summary>
        [DataMember(Name = "customerFirstnames", EmitDefaultValue = false)]
        public List<string> CustomerFirstnames { get; set; }

        /// <summary>
        /// Gets or Sets CustomerLastnames
        /// </summary>
        [DataMember(Name = "customerLastnames", EmitDefaultValue = false)]
        public List<string> CustomerLastnames { get; set; }

        /// <summary>
        /// Gets or Sets CustomerPhones
        /// </summary>
        [DataMember(Name = "customerPhones", EmitDefaultValue = false)]
        public List<string> CustomerPhones { get; set; }

        /// <summary>
        /// Gets or Sets CartIds
        /// </summary>
        [DataMember(Name = "cartIds", EmitDefaultValue = false)]
        public List<string> CartIds { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public List<ListCartsRequestFilterDate> CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets AgentGrn
        /// </summary>
        [DataMember(Name = "agentGrn", EmitDefaultValue = false)]
        public string AgentGrn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListCartsRequestFilter {\n");
            sb.Append("  SearchTerms: ").Append(SearchTerms).Append("\n");
            sb.Append("  CustomerEmails: ").Append(CustomerEmails).Append("\n");
            sb.Append("  CustomerFirstnames: ").Append(CustomerFirstnames).Append("\n");
            sb.Append("  CustomerLastnames: ").Append(CustomerLastnames).Append("\n");
            sb.Append("  CustomerPhones: ").Append(CustomerPhones).Append("\n");
            sb.Append("  CartIds: ").Append(CartIds).Append("\n");
            sb.Append("  CartStatus: ").Append(CartStatus).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  AgentGrn: ").Append(AgentGrn).Append("\n");
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
