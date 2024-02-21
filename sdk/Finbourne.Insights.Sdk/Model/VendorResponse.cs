/*
 * FINBOURNE Insights API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.758
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
    /// Details of a response to a request made to a vendor service.
    /// </summary>
    [DataContract(Name = "VendorResponse")]
    public partial class VendorResponse : IEquatable<VendorResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VendorResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VendorResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VendorResponse" /> class.
        /// </summary>
        /// <param name="id">The ID of the log. (required).</param>
        /// <param name="response">The body of the response. (required).</param>
        /// <param name="links">links.</param>
        public VendorResponse(string id = default(string), string response = default(string), List<Link> links = default(List<Link>))
        {
            // to ensure "id" is required (not null)
            this.Id = id ?? throw new ArgumentNullException("id is a required property for VendorResponse and cannot be null");
            // to ensure "response" is required (not null)
            this.Response = response ?? throw new ArgumentNullException("response is a required property for VendorResponse and cannot be null");
            this.Links = links;
        }

        /// <summary>
        /// The ID of the log.
        /// </summary>
        /// <value>The ID of the log.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The body of the response.
        /// </summary>
        /// <value>The body of the response.</value>
        [DataMember(Name = "response", IsRequired = true, EmitDefaultValue = false)]
        public string Response { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = true)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VendorResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Response: ").Append(Response).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(input as VendorResponse);
        }

        /// <summary>
        /// Returns true if VendorResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of VendorResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VendorResponse input)
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
                    this.Response == input.Response ||
                    (this.Response != null &&
                    this.Response.Equals(input.Response))
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
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
                if (this.Response != null)
                    hashCode = hashCode * 59 + this.Response.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }

    }
}
