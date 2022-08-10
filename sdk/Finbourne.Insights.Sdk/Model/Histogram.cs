/*
 * FINBOURNE Insights API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.340
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
    /// A histogram showing an item&#39;s count in buckets of equal timespans.
    /// </summary>
    [DataContract(Name = "Histogram")]
    public partial class Histogram : IEquatable<Histogram>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Histogram" /> class.
        /// </summary>
        /// <param name="buckets">An ordered list of the histogram buckets..</param>
        public Histogram(List<Bucket> buckets = default(List<Bucket>))
        {
            this.Buckets = buckets;
        }

        /// <summary>
        /// An ordered list of the histogram buckets.
        /// </summary>
        /// <value>An ordered list of the histogram buckets.</value>
        [DataMember(Name = "buckets", EmitDefaultValue = true)]
        public List<Bucket> Buckets { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Histogram {\n");
            sb.Append("  Buckets: ").Append(Buckets).Append("\n");
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
            return this.Equals(input as Histogram);
        }

        /// <summary>
        /// Returns true if Histogram instances are equal
        /// </summary>
        /// <param name="input">Instance of Histogram to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Histogram input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Buckets == input.Buckets ||
                    this.Buckets != null &&
                    input.Buckets != null &&
                    this.Buckets.SequenceEqual(input.Buckets)
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
                if (this.Buckets != null)
                    hashCode = hashCode * 59 + this.Buckets.GetHashCode();
                return hashCode;
            }
        }

    }
}
