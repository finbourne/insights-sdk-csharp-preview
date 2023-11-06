/*
 * FINBOURNE Insights API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.745
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
    /// AuditEntry
    /// </summary>
    [DataContract(Name = "AuditEntry")]
    public partial class AuditEntry : IEquatable<AuditEntry>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditEntry" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AuditEntry() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditEntry" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="date">date (required).</param>
        /// <param name="process">process (required).</param>
        /// <param name="data">data (required).</param>
        /// <param name="notes">notes.</param>
        public AuditEntry(string id = default(string), DateTimeOffset date = default(DateTimeOffset), AuditProcess process = default(AuditProcess), AuditData data = default(AuditData), List<AuditEntryNote> notes = default(List<AuditEntryNote>))
        {
            // to ensure "id" is required (not null)
            this.Id = id ?? throw new ArgumentNullException("id is a required property for AuditEntry and cannot be null");
            this.Date = date;
            // to ensure "process" is required (not null)
            this.Process = process ?? throw new ArgumentNullException("process is a required property for AuditEntry and cannot be null");
            // to ensure "data" is required (not null)
            this.Data = data ?? throw new ArgumentNullException("data is a required property for AuditEntry and cannot be null");
            this.Notes = notes;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name = "date", IsRequired = true, EmitDefaultValue = false)]
        public DateTimeOffset Date { get; set; }

        /// <summary>
        /// Gets or Sets Process
        /// </summary>
        [DataMember(Name = "process", IsRequired = true, EmitDefaultValue = false)]
        public AuditProcess Process { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", IsRequired = true, EmitDefaultValue = false)]
        public AuditData Data { get; set; }

        /// <summary>
        /// Gets or Sets Notes
        /// </summary>
        [DataMember(Name = "notes", EmitDefaultValue = true)]
        public List<AuditEntryNote> Notes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuditEntry {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Process: ").Append(Process).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
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
            return this.Equals(input as AuditEntry);
        }

        /// <summary>
        /// Returns true if AuditEntry instances are equal
        /// </summary>
        /// <param name="input">Instance of AuditEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuditEntry input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.Process == input.Process ||
                    (this.Process != null &&
                    this.Process.Equals(input.Process))
                ) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.Notes == input.Notes ||
                    this.Notes != null &&
                    input.Notes != null &&
                    this.Notes.SequenceEqual(input.Notes)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.Process != null)
                    hashCode = hashCode * 59 + this.Process.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.Notes != null)
                    hashCode = hashCode * 59 + this.Notes.GetHashCode();
                return hashCode;
            }
        }

    }
}
