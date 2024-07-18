/*
 * FINBOURNE Insights API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.796
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
    /// A single histogram bucket.
    /// </summary>
    [DataContract(Name = "Bucket")]
    public partial class Bucket : IEquatable<Bucket>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Bucket" /> class.
        /// </summary>
        /// <param name="startTime">The bucket&#39;s start time as a DateTimeOffset..</param>
        /// <param name="itemCount">The number of items in the bucket..</param>
        public Bucket(DateTimeOffset startTime = default(DateTimeOffset), long itemCount = default(long))
        {
            this.StartTime = startTime;
            this.ItemCount = itemCount;
        }

        /// <summary>
        /// The bucket&#39;s start time as a DateTimeOffset.
        /// </summary>
        /// <value>The bucket&#39;s start time as a DateTimeOffset.</value>
        [DataMember(Name = "startTime", EmitDefaultValue = false)]
        public DateTimeOffset StartTime { get; set; }

        /// <summary>
        /// The number of items in the bucket.
        /// </summary>
        /// <value>The number of items in the bucket.</value>
        [DataMember(Name = "itemCount", EmitDefaultValue = false)]
        public long ItemCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Bucket {\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  ItemCount: ").Append(ItemCount).Append("\n");
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
            return this.Equals(input as Bucket);
        }

        /// <summary>
        /// Returns true if Bucket instances are equal
        /// </summary>
        /// <param name="input">Instance of Bucket to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Bucket input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.ItemCount == input.ItemCount ||
                    this.ItemCount.Equals(input.ItemCount)
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
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                hashCode = hashCode * 59 + this.ItemCount.GetHashCode();
                return hashCode;
            }
        }

    }
}
