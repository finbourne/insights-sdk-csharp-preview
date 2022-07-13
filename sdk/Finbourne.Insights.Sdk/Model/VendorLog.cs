/*
 * FINBOURNE Insights API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.312
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
    /// Holds logged information about a request made to an external vendor.
    /// </summary>
    [DataContract(Name = "VendorLog")]
    public partial class VendorLog : IEquatable<VendorLog>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VendorLog" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VendorLog() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VendorLog" /> class.
        /// </summary>
        /// <param name="id">The identifier of a log entry. (required).</param>
        /// <param name="provider">The provider or service name. (required).</param>
        /// <param name="timestamp">Timestamp of when the log was generated. (required).</param>
        /// <param name="type">Type of log. Possible values: HttpResponse. (required).</param>
        /// <param name="destinationUrl">The destination URL of the task. (required).</param>
        /// <param name="operation">The operation performed. Possible values: Evaluate. (required).</param>
        /// <param name="outcome">The outcome of the operation. Possible values: Success, Failure. (required).</param>
        /// <param name="duration">The duration of the operation in ms. (required).</param>
        /// <param name="httpStatusCode">The status code of the operation. (required).</param>
        /// <param name="userId">The user that made the request to LUSID. (required).</param>
        /// <param name="requestId">The ID of the request to LUSID. (required).</param>
        /// <param name="links">links.</param>
        public VendorLog(string id = default(string), string provider = default(string), DateTimeOffset timestamp = default(DateTimeOffset), string type = default(string), string destinationUrl = default(string), string operation = default(string), string outcome = default(string), decimal duration = default(decimal), int httpStatusCode = default(int), string userId = default(string), string requestId = default(string), List<Link> links = default(List<Link>))
        {
            // to ensure "id" is required (not null)
            this.Id = id ?? throw new ArgumentNullException("id is a required property for VendorLog and cannot be null");
            // to ensure "provider" is required (not null)
            this.Provider = provider ?? throw new ArgumentNullException("provider is a required property for VendorLog and cannot be null");
            this.Timestamp = timestamp;
            // to ensure "type" is required (not null)
            this.Type = type ?? throw new ArgumentNullException("type is a required property for VendorLog and cannot be null");
            // to ensure "destinationUrl" is required (not null)
            this.DestinationUrl = destinationUrl ?? throw new ArgumentNullException("destinationUrl is a required property for VendorLog and cannot be null");
            // to ensure "operation" is required (not null)
            this.Operation = operation ?? throw new ArgumentNullException("operation is a required property for VendorLog and cannot be null");
            // to ensure "outcome" is required (not null)
            this.Outcome = outcome ?? throw new ArgumentNullException("outcome is a required property for VendorLog and cannot be null");
            this.Duration = duration;
            this.HttpStatusCode = httpStatusCode;
            // to ensure "userId" is required (not null)
            this.UserId = userId ?? throw new ArgumentNullException("userId is a required property for VendorLog and cannot be null");
            // to ensure "requestId" is required (not null)
            this.RequestId = requestId ?? throw new ArgumentNullException("requestId is a required property for VendorLog and cannot be null");
            this.Links = links;
        }

        /// <summary>
        /// The identifier of a log entry.
        /// </summary>
        /// <value>The identifier of a log entry.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The provider or service name.
        /// </summary>
        /// <value>The provider or service name.</value>
        [DataMember(Name = "provider", IsRequired = true, EmitDefaultValue = false)]
        public string Provider { get; set; }

        /// <summary>
        /// Timestamp of when the log was generated.
        /// </summary>
        /// <value>Timestamp of when the log was generated.</value>
        [DataMember(Name = "timestamp", IsRequired = true, EmitDefaultValue = false)]
        public DateTimeOffset Timestamp { get; set; }

        /// <summary>
        /// Type of log. Possible values: HttpResponse.
        /// </summary>
        /// <value>Type of log. Possible values: HttpResponse.</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// The destination URL of the task.
        /// </summary>
        /// <value>The destination URL of the task.</value>
        [DataMember(Name = "destinationUrl", IsRequired = true, EmitDefaultValue = false)]
        public string DestinationUrl { get; set; }

        /// <summary>
        /// The operation performed. Possible values: Evaluate.
        /// </summary>
        /// <value>The operation performed. Possible values: Evaluate.</value>
        [DataMember(Name = "operation", IsRequired = true, EmitDefaultValue = false)]
        public string Operation { get; set; }

        /// <summary>
        /// The outcome of the operation. Possible values: Success, Failure.
        /// </summary>
        /// <value>The outcome of the operation. Possible values: Success, Failure.</value>
        [DataMember(Name = "outcome", IsRequired = true, EmitDefaultValue = false)]
        public string Outcome { get; set; }

        /// <summary>
        /// The duration of the operation in ms.
        /// </summary>
        /// <value>The duration of the operation in ms.</value>
        [DataMember(Name = "duration", IsRequired = true, EmitDefaultValue = true)]
        public decimal Duration { get; set; }

        /// <summary>
        /// The status code of the operation.
        /// </summary>
        /// <value>The status code of the operation.</value>
        [DataMember(Name = "httpStatusCode", IsRequired = true, EmitDefaultValue = true)]
        public int HttpStatusCode { get; set; }

        /// <summary>
        /// The user that made the request to LUSID.
        /// </summary>
        /// <value>The user that made the request to LUSID.</value>
        [DataMember(Name = "userId", IsRequired = true, EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// The ID of the request to LUSID.
        /// </summary>
        /// <value>The ID of the request to LUSID.</value>
        [DataMember(Name = "requestId", IsRequired = true, EmitDefaultValue = false)]
        public string RequestId { get; set; }

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
            sb.Append("class VendorLog {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  DestinationUrl: ").Append(DestinationUrl).Append("\n");
            sb.Append("  Operation: ").Append(Operation).Append("\n");
            sb.Append("  Outcome: ").Append(Outcome).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  HttpStatusCode: ").Append(HttpStatusCode).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
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
            return this.Equals(input as VendorLog);
        }

        /// <summary>
        /// Returns true if VendorLog instances are equal
        /// </summary>
        /// <param name="input">Instance of VendorLog to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VendorLog input)
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
                    this.Provider == input.Provider ||
                    (this.Provider != null &&
                    this.Provider.Equals(input.Provider))
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.DestinationUrl == input.DestinationUrl ||
                    (this.DestinationUrl != null &&
                    this.DestinationUrl.Equals(input.DestinationUrl))
                ) && 
                (
                    this.Operation == input.Operation ||
                    (this.Operation != null &&
                    this.Operation.Equals(input.Operation))
                ) && 
                (
                    this.Outcome == input.Outcome ||
                    (this.Outcome != null &&
                    this.Outcome.Equals(input.Outcome))
                ) && 
                (
                    this.Duration == input.Duration ||
                    this.Duration.Equals(input.Duration)
                ) && 
                (
                    this.HttpStatusCode == input.HttpStatusCode ||
                    this.HttpStatusCode.Equals(input.HttpStatusCode)
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
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
                if (this.Provider != null)
                    hashCode = hashCode * 59 + this.Provider.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.DestinationUrl != null)
                    hashCode = hashCode * 59 + this.DestinationUrl.GetHashCode();
                if (this.Operation != null)
                    hashCode = hashCode * 59 + this.Operation.GetHashCode();
                if (this.Outcome != null)
                    hashCode = hashCode * 59 + this.Outcome.GetHashCode();
                hashCode = hashCode * 59 + this.Duration.GetHashCode();
                hashCode = hashCode * 59 + this.HttpStatusCode.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.RequestId != null)
                    hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }

    }
}
