/*
 * FINBOURNE Insights API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.287
 * Contact: info@finbourne.com
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
using OpenAPIDateConverter = Finbourne.Insights.Sdk.Client.OpenAPIDateConverter;

namespace Finbourne.Insights.Sdk.Model
{
    /// <summary>
    /// AuditData
    /// </summary>
    [DataContract(Name = "AuditData")]
    public partial class AuditData : IEquatable<AuditData>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AuditData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditData" /> class.
        /// </summary>
        /// <param name="action">action (required).</param>
        /// <param name="category">category (required).</param>
        /// <param name="userId">userId.</param>
        /// <param name="message">message.</param>
        /// <param name="resource">resource.</param>
        /// <param name="detailsType">detailsType.</param>
        /// <param name="details">details.</param>
        public AuditData(string action = default(string), string category = default(string), string userId = default(string), string message = default(string), Resource resource = default(Resource), string detailsType = default(string), Object details = default(Object))
        {
            // to ensure "action" is required (not null)
            this.Action = action ?? throw new ArgumentNullException("action is a required property for AuditData and cannot be null");
            // to ensure "category" is required (not null)
            this.Category = category ?? throw new ArgumentNullException("category is a required property for AuditData and cannot be null");
            this.UserId = userId;
            this.Message = message;
            this.Resource = resource;
            this.DetailsType = detailsType;
            this.Details = details;
        }

        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name = "action", IsRequired = true, EmitDefaultValue = false)]
        public string Action { get; set; }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name = "category", IsRequired = true, EmitDefaultValue = false)]
        public string Category { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name = "userId", EmitDefaultValue = true)]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets Resource
        /// </summary>
        [DataMember(Name = "resource", EmitDefaultValue = false)]
        public Resource Resource { get; set; }

        /// <summary>
        /// Gets or Sets DetailsType
        /// </summary>
        [DataMember(Name = "detailsType", EmitDefaultValue = true)]
        public string DetailsType { get; set; }

        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name = "details", EmitDefaultValue = true)]
        public Object Details { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuditData {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Resource: ").Append(Resource).Append("\n");
            sb.Append("  DetailsType: ").Append(DetailsType).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AuditData);
        }

        /// <summary>
        /// Returns true if AuditData instances are equal
        /// </summary>
        /// <param name="input">Instance of AuditData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuditData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Resource == input.Resource ||
                    (this.Resource != null &&
                    this.Resource.Equals(input.Resource))
                ) && 
                (
                    this.DetailsType == input.DetailsType ||
                    (this.DetailsType != null &&
                    this.DetailsType.Equals(input.DetailsType))
                ) && 
                (
                    this.Details == input.Details ||
                    (this.Details != null &&
                    this.Details.Equals(input.Details))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Resource != null)
                    hashCode = hashCode * 59 + this.Resource.GetHashCode();
                if (this.DetailsType != null)
                    hashCode = hashCode * 59 + this.DetailsType.GetHashCode();
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
                return hashCode;
            }
        }

    }
}
