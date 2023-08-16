/*
 * FINBOURNE Insights API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.724
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
    /// AuditEntryNote
    /// </summary>
    [DataContract(Name = "AuditEntryNote")]
    public partial class AuditEntryNote : IEquatable<AuditEntryNote>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditEntryNote" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AuditEntryNote() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditEntryNote" /> class.
        /// </summary>
        /// <param name="userId">userId (required).</param>
        /// <param name="text">text (required).</param>
        /// <param name="date">date (required).</param>
        public AuditEntryNote(string userId = default(string), string text = default(string), DateTimeOffset date = default(DateTimeOffset))
        {
            // to ensure "userId" is required (not null)
            this.UserId = userId ?? throw new ArgumentNullException("userId is a required property for AuditEntryNote and cannot be null");
            // to ensure "text" is required (not null)
            this.Text = text ?? throw new ArgumentNullException("text is a required property for AuditEntryNote and cannot be null");
            this.Date = date;
        }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name = "userId", IsRequired = true, EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name = "text", IsRequired = true, EmitDefaultValue = false)]
        public string Text { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name = "date", IsRequired = true, EmitDefaultValue = false)]
        public DateTimeOffset Date { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuditEntryNote {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
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
            return this.Equals(input as AuditEntryNote);
        }

        /// <summary>
        /// Returns true if AuditEntryNote instances are equal
        /// </summary>
        /// <param name="input">Instance of AuditEntryNote to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuditEntryNote input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
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
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                return hashCode;
            }
        }

    }
}
