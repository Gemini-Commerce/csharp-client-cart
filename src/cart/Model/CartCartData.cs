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
    /// CartCartData
    /// </summary>
    [DataContract(Name = "cartCartData")]
    public partial class CartCartData : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public CartCurrency? Currency { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public CartCartStatus? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CartCartData" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="grn">grn.</param>
        /// <param name="channel">channel.</param>
        /// <param name="market">market.</param>
        /// <param name="locale">locale.</param>
        /// <param name="items">items.</param>
        /// <param name="payments">payments.</param>
        /// <param name="shipments">shipments.</param>
        /// <param name="promotions">promotions.</param>
        /// <param name="currency">currency.</param>
        /// <param name="subtotals">subtotals.</param>
        /// <param name="total">total.</param>
        /// <param name="totalDue">totalDue.</param>
        /// <param name="vatIncluded">vatIncluded.</param>
        /// <param name="billingAddress">billingAddress.</param>
        /// <param name="shippingAddress">shippingAddress.</param>
        /// <param name="status">status.</param>
        /// <param name="customer">customer.</param>
        /// <param name="notes">notes.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        public CartCartData(string id = default(string), string grn = default(string), string channel = default(string), string market = default(string), string locale = default(string), List<CartCartItem> items = default(List<CartCartItem>), List<CartPaymentData> payments = default(List<CartPaymentData>), List<CartShipmentData> shipments = default(List<CartShipmentData>), List<CartPromotionData> promotions = default(List<CartPromotionData>), CartCurrency? currency = default(CartCurrency?), List<CartCartSubtotal> subtotals = default(List<CartCartSubtotal>), CartMoney total = default(CartMoney), CartMoney totalDue = default(CartMoney), bool vatIncluded = default(bool), CartPostalAddress billingAddress = default(CartPostalAddress), CartPostalAddress shippingAddress = default(CartPostalAddress), CartCartStatus? status = default(CartCartStatus?), CartCustomerData customer = default(CartCustomerData), string notes = default(string), DateTime createdAt = default(DateTime), DateTime updatedAt = default(DateTime))
        {
            this.Id = id;
            this.Grn = grn;
            this.Channel = channel;
            this.Market = market;
            this.Locale = locale;
            this.Items = items;
            this.Payments = payments;
            this.Shipments = shipments;
            this.Promotions = promotions;
            this.Currency = currency;
            this.Subtotals = subtotals;
            this.Total = total;
            this.TotalDue = totalDue;
            this.VatIncluded = vatIncluded;
            this.BillingAddress = billingAddress;
            this.ShippingAddress = shippingAddress;
            this.Status = status;
            this.Customer = customer;
            this.Notes = notes;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Grn
        /// </summary>
        [DataMember(Name = "grn", EmitDefaultValue = false)]
        public string Grn { get; set; }

        /// <summary>
        /// Gets or Sets Channel
        /// </summary>
        [DataMember(Name = "channel", EmitDefaultValue = false)]
        public string Channel { get; set; }

        /// <summary>
        /// Gets or Sets Market
        /// </summary>
        [DataMember(Name = "market", EmitDefaultValue = false)]
        public string Market { get; set; }

        /// <summary>
        /// Gets or Sets Locale
        /// </summary>
        [DataMember(Name = "locale", EmitDefaultValue = false)]
        public string Locale { get; set; }

        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name = "items", EmitDefaultValue = false)]
        public List<CartCartItem> Items { get; set; }

        /// <summary>
        /// Gets or Sets Payments
        /// </summary>
        [DataMember(Name = "payments", EmitDefaultValue = false)]
        public List<CartPaymentData> Payments { get; set; }

        /// <summary>
        /// Gets or Sets Shipments
        /// </summary>
        [DataMember(Name = "shipments", EmitDefaultValue = false)]
        public List<CartShipmentData> Shipments { get; set; }

        /// <summary>
        /// Gets or Sets Promotions
        /// </summary>
        [DataMember(Name = "promotions", EmitDefaultValue = false)]
        public List<CartPromotionData> Promotions { get; set; }

        /// <summary>
        /// Gets or Sets Subtotals
        /// </summary>
        [DataMember(Name = "subtotals", EmitDefaultValue = false)]
        public List<CartCartSubtotal> Subtotals { get; set; }

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name = "total", EmitDefaultValue = false)]
        public CartMoney Total { get; set; }

        /// <summary>
        /// Gets or Sets TotalDue
        /// </summary>
        [DataMember(Name = "totalDue", EmitDefaultValue = false)]
        public CartMoney TotalDue { get; set; }

        /// <summary>
        /// Gets or Sets VatIncluded
        /// </summary>
        [DataMember(Name = "vatIncluded", EmitDefaultValue = true)]
        public bool VatIncluded { get; set; }

        /// <summary>
        /// Gets or Sets BillingAddress
        /// </summary>
        [DataMember(Name = "billingAddress", EmitDefaultValue = false)]
        public CartPostalAddress BillingAddress { get; set; }

        /// <summary>
        /// Gets or Sets ShippingAddress
        /// </summary>
        [DataMember(Name = "shippingAddress", EmitDefaultValue = false)]
        public CartPostalAddress ShippingAddress { get; set; }

        /// <summary>
        /// Gets or Sets Customer
        /// </summary>
        [DataMember(Name = "customer", EmitDefaultValue = false)]
        public CartCustomerData Customer { get; set; }

        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [DataMember(Name = "notes", EmitDefaultValue = false)]
        public string Notes { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updatedAt", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CartCartData {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Grn: ").Append(Grn).Append("\n");
            sb.Append("  Channel: ").Append(Channel).Append("\n");
            sb.Append("  Market: ").Append(Market).Append("\n");
            sb.Append("  Locale: ").Append(Locale).Append("\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  Payments: ").Append(Payments).Append("\n");
            sb.Append("  Shipments: ").Append(Shipments).Append("\n");
            sb.Append("  Promotions: ").Append(Promotions).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Subtotals: ").Append(Subtotals).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  TotalDue: ").Append(TotalDue).Append("\n");
            sb.Append("  VatIncluded: ").Append(VatIncluded).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  ShippingAddress: ").Append(ShippingAddress).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Customer: ").Append(Customer).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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