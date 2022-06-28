/*
 * FINBOURNE Insights API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.298
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
    /// ResourceList with additional aggregation data about the values.
    /// </summary>
    [DataContract(Name = "ResourceListWithHistogramOfRequestLog")]
    public partial class ResourceListWithHistogramOfRequestLog : IEquatable<ResourceListWithHistogramOfRequestLog>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceListWithHistogramOfRequestLog" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ResourceListWithHistogramOfRequestLog() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResourceListWithHistogramOfRequestLog" /> class.
        /// </summary>
        /// <param name="histogram">histogram.</param>
        /// <param name="values">values (required).</param>
        /// <param name="href">href.</param>
        /// <param name="nextPage">nextPage.</param>
        /// <param name="previousPage">previousPage.</param>
        /// <param name="links">links.</param>
        public ResourceListWithHistogramOfRequestLog(Histogram histogram = default(Histogram), List<RequestLog> values = default(List<RequestLog>), string href = default(string), string nextPage = default(string), string previousPage = default(string), List<Link> links = default(List<Link>))
        {
            // to ensure "values" is required (not null)
            this.Values = values ?? throw new ArgumentNullException("values is a required property for ResourceListWithHistogramOfRequestLog and cannot be null");
            this.Histogram = histogram;
            this.Href = href;
            this.NextPage = nextPage;
            this.PreviousPage = previousPage;
            this.Links = links;
        }

        /// <summary>
        /// Gets or Sets Histogram
        /// </summary>
        [DataMember(Name = "histogram", EmitDefaultValue = false)]
        public Histogram Histogram { get; set; }

        /// <summary>
        /// Gets or Sets Values
        /// </summary>
        [DataMember(Name = "values", IsRequired = true, EmitDefaultValue = false)]
        public List<RequestLog> Values { get; set; }

        /// <summary>
        /// Gets or Sets Href
        /// </summary>
        [DataMember(Name = "href", EmitDefaultValue = true)]
        public string Href { get; set; }

        /// <summary>
        /// Gets or Sets NextPage
        /// </summary>
        [DataMember(Name = "nextPage", EmitDefaultValue = true)]
        public string NextPage { get; set; }

        /// <summary>
        /// Gets or Sets PreviousPage
        /// </summary>
        [DataMember(Name = "previousPage", EmitDefaultValue = true)]
        public string PreviousPage { get; set; }

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
            sb.Append("class ResourceListWithHistogramOfRequestLog {\n");
            sb.Append("  Histogram: ").Append(Histogram).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  NextPage: ").Append(NextPage).Append("\n");
            sb.Append("  PreviousPage: ").Append(PreviousPage).Append("\n");
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
            return this.Equals(input as ResourceListWithHistogramOfRequestLog);
        }

        /// <summary>
        /// Returns true if ResourceListWithHistogramOfRequestLog instances are equal
        /// </summary>
        /// <param name="input">Instance of ResourceListWithHistogramOfRequestLog to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResourceListWithHistogramOfRequestLog input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Histogram == input.Histogram ||
                    (this.Histogram != null &&
                    this.Histogram.Equals(input.Histogram))
                ) && 
                (
                    this.Values == input.Values ||
                    this.Values != null &&
                    input.Values != null &&
                    this.Values.SequenceEqual(input.Values)
                ) && 
                (
                    this.Href == input.Href ||
                    (this.Href != null &&
                    this.Href.Equals(input.Href))
                ) && 
                (
                    this.NextPage == input.NextPage ||
                    (this.NextPage != null &&
                    this.NextPage.Equals(input.NextPage))
                ) && 
                (
                    this.PreviousPage == input.PreviousPage ||
                    (this.PreviousPage != null &&
                    this.PreviousPage.Equals(input.PreviousPage))
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
                if (this.Histogram != null)
                    hashCode = hashCode * 59 + this.Histogram.GetHashCode();
                if (this.Values != null)
                    hashCode = hashCode * 59 + this.Values.GetHashCode();
                if (this.Href != null)
                    hashCode = hashCode * 59 + this.Href.GetHashCode();
                if (this.NextPage != null)
                    hashCode = hashCode * 59 + this.NextPage.GetHashCode();
                if (this.PreviousPage != null)
                    hashCode = hashCode * 59 + this.PreviousPage.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }

    }
}
