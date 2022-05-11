/*
 * FINBOURNE Insights API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.286
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
    /// DTO of Finbourne.AspNetCore.Http.TrackingEntry.RequestInformation.
    /// </summary>
    [DataContract(Name = "Request")]
    public partial class Request : IEquatable<Request>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Request" /> class.
        /// </summary>
        /// <param name="headers">The headers.</param>
        /// <param name="contentLength">The actual length of the body, which may be larger than the data recorded in Finbourne.Insights.WebApi.Dtos.Request.Body  (e.g. if actual Body is large, or not convertible to a string).</param>
        /// <param name="contentType">The content type.</param>
        /// <param name="body">The recorded content..</param>
        /// <param name="bodyWasTruncated">Determines if the recorded body was truncated..</param>
        /// <param name="method">Method called by the request.</param>
        /// <param name="url">URL of the request.</param>
        /// <param name="links">links.</param>
        public Request(Dictionary<string, List<string>> headers = default(Dictionary<string, List<string>>), long? contentLength = default(long?), string contentType = default(string), string body = default(string), bool bodyWasTruncated = default(bool), string method = default(string), string url = default(string), List<Link> links = default(List<Link>))
        {
            this.Headers = headers;
            this.ContentLength = contentLength;
            this.ContentType = contentType;
            this.Body = body;
            this.BodyWasTruncated = bodyWasTruncated;
            this.Method = method;
            this.Url = url;
            this.Links = links;
        }

        /// <summary>
        /// The headers
        /// </summary>
        /// <value>The headers</value>
        [DataMember(Name = "headers", EmitDefaultValue = true)]
        public Dictionary<string, List<string>> Headers { get; set; }

        /// <summary>
        /// The actual length of the body, which may be larger than the data recorded in Finbourne.Insights.WebApi.Dtos.Request.Body  (e.g. if actual Body is large, or not convertible to a string)
        /// </summary>
        /// <value>The actual length of the body, which may be larger than the data recorded in Finbourne.Insights.WebApi.Dtos.Request.Body  (e.g. if actual Body is large, or not convertible to a string)</value>
        [DataMember(Name = "contentLength", EmitDefaultValue = true)]
        public long? ContentLength { get; set; }

        /// <summary>
        /// The content type
        /// </summary>
        /// <value>The content type</value>
        [DataMember(Name = "contentType", EmitDefaultValue = true)]
        public string ContentType { get; set; }

        /// <summary>
        /// The recorded content.
        /// </summary>
        /// <value>The recorded content.</value>
        [DataMember(Name = "body", EmitDefaultValue = true)]
        public string Body { get; set; }

        /// <summary>
        /// Determines if the recorded body was truncated.
        /// </summary>
        /// <value>Determines if the recorded body was truncated.</value>
        [DataMember(Name = "bodyWasTruncated", EmitDefaultValue = true)]
        public bool BodyWasTruncated { get; set; }

        /// <summary>
        /// Method called by the request
        /// </summary>
        /// <value>Method called by the request</value>
        [DataMember(Name = "method", EmitDefaultValue = true)]
        public string Method { get; set; }

        /// <summary>
        /// URL of the request
        /// </summary>
        /// <value>URL of the request</value>
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

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
            sb.Append("class Request {\n");
            sb.Append("  Headers: ").Append(Headers).Append("\n");
            sb.Append("  ContentLength: ").Append(ContentLength).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  BodyWasTruncated: ").Append(BodyWasTruncated).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as Request);
        }

        /// <summary>
        /// Returns true if Request instances are equal
        /// </summary>
        /// <param name="input">Instance of Request to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Request input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Headers == input.Headers ||
                    this.Headers != null &&
                    input.Headers != null &&
                    this.Headers.SequenceEqual(input.Headers)
                ) && 
                (
                    this.ContentLength == input.ContentLength ||
                    (this.ContentLength != null &&
                    this.ContentLength.Equals(input.ContentLength))
                ) && 
                (
                    this.ContentType == input.ContentType ||
                    (this.ContentType != null &&
                    this.ContentType.Equals(input.ContentType))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                ) && 
                (
                    this.BodyWasTruncated == input.BodyWasTruncated ||
                    this.BodyWasTruncated.Equals(input.BodyWasTruncated)
                ) && 
                (
                    this.Method == input.Method ||
                    (this.Method != null &&
                    this.Method.Equals(input.Method))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                if (this.Headers != null)
                    hashCode = hashCode * 59 + this.Headers.GetHashCode();
                if (this.ContentLength != null)
                    hashCode = hashCode * 59 + this.ContentLength.GetHashCode();
                if (this.ContentType != null)
                    hashCode = hashCode * 59 + this.ContentType.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                hashCode = hashCode * 59 + this.BodyWasTruncated.GetHashCode();
                if (this.Method != null)
                    hashCode = hashCode * 59 + this.Method.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }

    }
}
