/*
 * FINBOURNE Insights API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.313
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
    /// Holds logged information about an access check performed on an API.
    /// </summary>
    [DataContract(Name = "AccessEvaluationLog")]
    public partial class AccessEvaluationLog : IEquatable<AccessEvaluationLog>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessEvaluationLog" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccessEvaluationLog() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessEvaluationLog" /> class.
        /// </summary>
        /// <param name="timestamp">The timestamp of the access evaluation. (required).</param>
        /// <param name="application">The name of the application that the request was made from. (required).</param>
        /// <param name="id">The ID of the access evaluation. (required).</param>
        /// <param name="requestId">The identifier of the request..</param>
        /// <param name="sessionId">The identifier of the session that the request was made in..</param>
        /// <param name="user">The user who made the request. (required).</param>
        /// <param name="userType">The type of the user who made the request..</param>
        /// <param name="duration">The duration of the access evaluation. (required).</param>
        /// <param name="result">The result of the access evaluation..</param>
        /// <param name="authoritativeRoleId">The role that matched the access evaluation to provide a result..</param>
        /// <param name="authoritativePolicyId">The policy that matched the access evaluation to provide a result..</param>
        /// <param name="authoritativeSelector">The selector that matched the access evaluation to provide a result..</param>
        /// <param name="resourceType">The type of the resource that the access evaluation is for..</param>
        /// <param name="action">The action key of the access evaluation..</param>
        /// <param name="resource">The ID of the resource that the access evaluation is for. If the ResourceID could not be converted to a dictionary, it will return a single-value dictionary with the key \&quot;resourceId\&quot;..</param>
        /// <param name="resourceFromEffectiveDate">The From effective date of the resource..</param>
        /// <param name="resourceToEffectiveDate">The To effective date of the resource..</param>
        /// <param name="resourceFromAsAt">The From AsAt date of the resource..</param>
        /// <param name="resourceToAsAt">The To AsAt date of the resource..</param>
        /// <param name="accessExecutionTime">The execution time of the entitlement..</param>
        /// <param name="accessAsAtTime">The AsAt time of the entitlement..</param>
        /// <param name="requiredLicencePolicyId">ID of the required licence policy..</param>
        /// <param name="links">links.</param>
        public AccessEvaluationLog(DateTimeOffset timestamp = default(DateTimeOffset), string application = default(string), string id = default(string), string requestId = default(string), string sessionId = default(string), string user = default(string), string userType = default(string), decimal duration = default(decimal), string result = default(string), string authoritativeRoleId = default(string), string authoritativePolicyId = default(string), string authoritativeSelector = default(string), string resourceType = default(string), string action = default(string), Dictionary<string, string> resource = default(Dictionary<string, string>), string resourceFromEffectiveDate = default(string), string resourceToEffectiveDate = default(string), string resourceFromAsAt = default(string), string resourceToAsAt = default(string), string accessExecutionTime = default(string), string accessAsAtTime = default(string), string requiredLicencePolicyId = default(string), List<Link> links = default(List<Link>))
        {
            this.Timestamp = timestamp;
            // to ensure "application" is required (not null)
            this.Application = application ?? throw new ArgumentNullException("application is a required property for AccessEvaluationLog and cannot be null");
            // to ensure "id" is required (not null)
            this.Id = id ?? throw new ArgumentNullException("id is a required property for AccessEvaluationLog and cannot be null");
            // to ensure "user" is required (not null)
            this.User = user ?? throw new ArgumentNullException("user is a required property for AccessEvaluationLog and cannot be null");
            this.Duration = duration;
            this.RequestId = requestId;
            this.SessionId = sessionId;
            this.UserType = userType;
            this.Result = result;
            this.AuthoritativeRoleId = authoritativeRoleId;
            this.AuthoritativePolicyId = authoritativePolicyId;
            this.AuthoritativeSelector = authoritativeSelector;
            this.ResourceType = resourceType;
            this.Action = action;
            this.Resource = resource;
            this.ResourceFromEffectiveDate = resourceFromEffectiveDate;
            this.ResourceToEffectiveDate = resourceToEffectiveDate;
            this.ResourceFromAsAt = resourceFromAsAt;
            this.ResourceToAsAt = resourceToAsAt;
            this.AccessExecutionTime = accessExecutionTime;
            this.AccessAsAtTime = accessAsAtTime;
            this.RequiredLicencePolicyId = requiredLicencePolicyId;
            this.Links = links;
        }

        /// <summary>
        /// The timestamp of the access evaluation.
        /// </summary>
        /// <value>The timestamp of the access evaluation.</value>
        [DataMember(Name = "timestamp", IsRequired = true, EmitDefaultValue = false)]
        public DateTimeOffset Timestamp { get; set; }

        /// <summary>
        /// The name of the application that the request was made from.
        /// </summary>
        /// <value>The name of the application that the request was made from.</value>
        [DataMember(Name = "application", IsRequired = true, EmitDefaultValue = false)]
        public string Application { get; set; }

        /// <summary>
        /// The ID of the access evaluation.
        /// </summary>
        /// <value>The ID of the access evaluation.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The identifier of the request.
        /// </summary>
        /// <value>The identifier of the request.</value>
        [DataMember(Name = "requestId", EmitDefaultValue = true)]
        public string RequestId { get; set; }

        /// <summary>
        /// The identifier of the session that the request was made in.
        /// </summary>
        /// <value>The identifier of the session that the request was made in.</value>
        [DataMember(Name = "sessionId", EmitDefaultValue = true)]
        public string SessionId { get; set; }

        /// <summary>
        /// The user who made the request.
        /// </summary>
        /// <value>The user who made the request.</value>
        [DataMember(Name = "user", IsRequired = true, EmitDefaultValue = false)]
        public string User { get; set; }

        /// <summary>
        /// The type of the user who made the request.
        /// </summary>
        /// <value>The type of the user who made the request.</value>
        [DataMember(Name = "userType", EmitDefaultValue = true)]
        public string UserType { get; set; }

        /// <summary>
        /// The duration of the access evaluation.
        /// </summary>
        /// <value>The duration of the access evaluation.</value>
        [DataMember(Name = "duration", IsRequired = true, EmitDefaultValue = true)]
        public decimal Duration { get; set; }

        /// <summary>
        /// The result of the access evaluation.
        /// </summary>
        /// <value>The result of the access evaluation.</value>
        [DataMember(Name = "result", EmitDefaultValue = true)]
        public string Result { get; set; }

        /// <summary>
        /// The role that matched the access evaluation to provide a result.
        /// </summary>
        /// <value>The role that matched the access evaluation to provide a result.</value>
        [DataMember(Name = "authoritativeRoleId", EmitDefaultValue = true)]
        public string AuthoritativeRoleId { get; set; }

        /// <summary>
        /// The policy that matched the access evaluation to provide a result.
        /// </summary>
        /// <value>The policy that matched the access evaluation to provide a result.</value>
        [DataMember(Name = "authoritativePolicyId", EmitDefaultValue = true)]
        public string AuthoritativePolicyId { get; set; }

        /// <summary>
        /// The selector that matched the access evaluation to provide a result.
        /// </summary>
        /// <value>The selector that matched the access evaluation to provide a result.</value>
        [DataMember(Name = "authoritativeSelector", EmitDefaultValue = true)]
        public string AuthoritativeSelector { get; set; }

        /// <summary>
        /// The type of the resource that the access evaluation is for.
        /// </summary>
        /// <value>The type of the resource that the access evaluation is for.</value>
        [DataMember(Name = "resourceType", EmitDefaultValue = true)]
        public string ResourceType { get; set; }

        /// <summary>
        /// The action key of the access evaluation.
        /// </summary>
        /// <value>The action key of the access evaluation.</value>
        [DataMember(Name = "action", EmitDefaultValue = true)]
        public string Action { get; set; }

        /// <summary>
        /// The ID of the resource that the access evaluation is for. If the ResourceID could not be converted to a dictionary, it will return a single-value dictionary with the key \&quot;resourceId\&quot;.
        /// </summary>
        /// <value>The ID of the resource that the access evaluation is for. If the ResourceID could not be converted to a dictionary, it will return a single-value dictionary with the key \&quot;resourceId\&quot;.</value>
        [DataMember(Name = "resource", EmitDefaultValue = true)]
        public Dictionary<string, string> Resource { get; set; }

        /// <summary>
        /// The From effective date of the resource.
        /// </summary>
        /// <value>The From effective date of the resource.</value>
        [DataMember(Name = "resourceFromEffectiveDate", EmitDefaultValue = true)]
        public string ResourceFromEffectiveDate { get; set; }

        /// <summary>
        /// The To effective date of the resource.
        /// </summary>
        /// <value>The To effective date of the resource.</value>
        [DataMember(Name = "resourceToEffectiveDate", EmitDefaultValue = true)]
        public string ResourceToEffectiveDate { get; set; }

        /// <summary>
        /// The From AsAt date of the resource.
        /// </summary>
        /// <value>The From AsAt date of the resource.</value>
        [DataMember(Name = "resourceFromAsAt", EmitDefaultValue = true)]
        public string ResourceFromAsAt { get; set; }

        /// <summary>
        /// The To AsAt date of the resource.
        /// </summary>
        /// <value>The To AsAt date of the resource.</value>
        [DataMember(Name = "resourceToAsAt", EmitDefaultValue = true)]
        public string ResourceToAsAt { get; set; }

        /// <summary>
        /// The execution time of the entitlement.
        /// </summary>
        /// <value>The execution time of the entitlement.</value>
        [DataMember(Name = "accessExecutionTime", EmitDefaultValue = true)]
        public string AccessExecutionTime { get; set; }

        /// <summary>
        /// The AsAt time of the entitlement.
        /// </summary>
        /// <value>The AsAt time of the entitlement.</value>
        [DataMember(Name = "accessAsAtTime", EmitDefaultValue = true)]
        public string AccessAsAtTime { get; set; }

        /// <summary>
        /// ID of the required licence policy.
        /// </summary>
        /// <value>ID of the required licence policy.</value>
        [DataMember(Name = "requiredLicencePolicyId", EmitDefaultValue = true)]
        public string RequiredLicencePolicyId { get; set; }

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
            sb.Append("class AccessEvaluationLog {\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Application: ").Append(Application).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  UserType: ").Append(UserType).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  AuthoritativeRoleId: ").Append(AuthoritativeRoleId).Append("\n");
            sb.Append("  AuthoritativePolicyId: ").Append(AuthoritativePolicyId).Append("\n");
            sb.Append("  AuthoritativeSelector: ").Append(AuthoritativeSelector).Append("\n");
            sb.Append("  ResourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Resource: ").Append(Resource).Append("\n");
            sb.Append("  ResourceFromEffectiveDate: ").Append(ResourceFromEffectiveDate).Append("\n");
            sb.Append("  ResourceToEffectiveDate: ").Append(ResourceToEffectiveDate).Append("\n");
            sb.Append("  ResourceFromAsAt: ").Append(ResourceFromAsAt).Append("\n");
            sb.Append("  ResourceToAsAt: ").Append(ResourceToAsAt).Append("\n");
            sb.Append("  AccessExecutionTime: ").Append(AccessExecutionTime).Append("\n");
            sb.Append("  AccessAsAtTime: ").Append(AccessAsAtTime).Append("\n");
            sb.Append("  RequiredLicencePolicyId: ").Append(RequiredLicencePolicyId).Append("\n");
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
            return this.Equals(input as AccessEvaluationLog);
        }

        /// <summary>
        /// Returns true if AccessEvaluationLog instances are equal
        /// </summary>
        /// <param name="input">Instance of AccessEvaluationLog to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccessEvaluationLog input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.Application == input.Application ||
                    (this.Application != null &&
                    this.Application.Equals(input.Application))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
                ) && 
                (
                    this.SessionId == input.SessionId ||
                    (this.SessionId != null &&
                    this.SessionId.Equals(input.SessionId))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.UserType == input.UserType ||
                    (this.UserType != null &&
                    this.UserType.Equals(input.UserType))
                ) && 
                (
                    this.Duration == input.Duration ||
                    this.Duration.Equals(input.Duration)
                ) && 
                (
                    this.Result == input.Result ||
                    (this.Result != null &&
                    this.Result.Equals(input.Result))
                ) && 
                (
                    this.AuthoritativeRoleId == input.AuthoritativeRoleId ||
                    (this.AuthoritativeRoleId != null &&
                    this.AuthoritativeRoleId.Equals(input.AuthoritativeRoleId))
                ) && 
                (
                    this.AuthoritativePolicyId == input.AuthoritativePolicyId ||
                    (this.AuthoritativePolicyId != null &&
                    this.AuthoritativePolicyId.Equals(input.AuthoritativePolicyId))
                ) && 
                (
                    this.AuthoritativeSelector == input.AuthoritativeSelector ||
                    (this.AuthoritativeSelector != null &&
                    this.AuthoritativeSelector.Equals(input.AuthoritativeSelector))
                ) && 
                (
                    this.ResourceType == input.ResourceType ||
                    (this.ResourceType != null &&
                    this.ResourceType.Equals(input.ResourceType))
                ) && 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.Resource == input.Resource ||
                    this.Resource != null &&
                    input.Resource != null &&
                    this.Resource.SequenceEqual(input.Resource)
                ) && 
                (
                    this.ResourceFromEffectiveDate == input.ResourceFromEffectiveDate ||
                    (this.ResourceFromEffectiveDate != null &&
                    this.ResourceFromEffectiveDate.Equals(input.ResourceFromEffectiveDate))
                ) && 
                (
                    this.ResourceToEffectiveDate == input.ResourceToEffectiveDate ||
                    (this.ResourceToEffectiveDate != null &&
                    this.ResourceToEffectiveDate.Equals(input.ResourceToEffectiveDate))
                ) && 
                (
                    this.ResourceFromAsAt == input.ResourceFromAsAt ||
                    (this.ResourceFromAsAt != null &&
                    this.ResourceFromAsAt.Equals(input.ResourceFromAsAt))
                ) && 
                (
                    this.ResourceToAsAt == input.ResourceToAsAt ||
                    (this.ResourceToAsAt != null &&
                    this.ResourceToAsAt.Equals(input.ResourceToAsAt))
                ) && 
                (
                    this.AccessExecutionTime == input.AccessExecutionTime ||
                    (this.AccessExecutionTime != null &&
                    this.AccessExecutionTime.Equals(input.AccessExecutionTime))
                ) && 
                (
                    this.AccessAsAtTime == input.AccessAsAtTime ||
                    (this.AccessAsAtTime != null &&
                    this.AccessAsAtTime.Equals(input.AccessAsAtTime))
                ) && 
                (
                    this.RequiredLicencePolicyId == input.RequiredLicencePolicyId ||
                    (this.RequiredLicencePolicyId != null &&
                    this.RequiredLicencePolicyId.Equals(input.RequiredLicencePolicyId))
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
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.Application != null)
                    hashCode = hashCode * 59 + this.Application.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.RequestId != null)
                    hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                if (this.SessionId != null)
                    hashCode = hashCode * 59 + this.SessionId.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.UserType != null)
                    hashCode = hashCode * 59 + this.UserType.GetHashCode();
                hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.Result != null)
                    hashCode = hashCode * 59 + this.Result.GetHashCode();
                if (this.AuthoritativeRoleId != null)
                    hashCode = hashCode * 59 + this.AuthoritativeRoleId.GetHashCode();
                if (this.AuthoritativePolicyId != null)
                    hashCode = hashCode * 59 + this.AuthoritativePolicyId.GetHashCode();
                if (this.AuthoritativeSelector != null)
                    hashCode = hashCode * 59 + this.AuthoritativeSelector.GetHashCode();
                if (this.ResourceType != null)
                    hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.Resource != null)
                    hashCode = hashCode * 59 + this.Resource.GetHashCode();
                if (this.ResourceFromEffectiveDate != null)
                    hashCode = hashCode * 59 + this.ResourceFromEffectiveDate.GetHashCode();
                if (this.ResourceToEffectiveDate != null)
                    hashCode = hashCode * 59 + this.ResourceToEffectiveDate.GetHashCode();
                if (this.ResourceFromAsAt != null)
                    hashCode = hashCode * 59 + this.ResourceFromAsAt.GetHashCode();
                if (this.ResourceToAsAt != null)
                    hashCode = hashCode * 59 + this.ResourceToAsAt.GetHashCode();
                if (this.AccessExecutionTime != null)
                    hashCode = hashCode * 59 + this.AccessExecutionTime.GetHashCode();
                if (this.AccessAsAtTime != null)
                    hashCode = hashCode * 59 + this.AccessAsAtTime.GetHashCode();
                if (this.RequiredLicencePolicyId != null)
                    hashCode = hashCode * 59 + this.RequiredLicencePolicyId.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }

    }
}
