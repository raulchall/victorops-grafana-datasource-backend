/* 
 * VictorOps API
 *
 * This API allows you to interact with the VictorOps platform in various ways. Your account may be limited to a total number of API calls per month. Also, some of these API calls have rate limits.  NOTE: In this documentation when creating a sample curl request (clicking the TRY IT OUT! button), in some API viewing interfaces, the '@' in an email address may be encoded. Please note that the REST endpoints will not process the encoded version. Make sure that the encoded character '%40' is changed to its unencoded form before submitting the curl request. 
 *
 * The version of the OpenAPI document: 0.0.3
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// CreateIncidentRequest
    /// </summary>
    [DataContract]
    public partial class CreateIncidentRequest :  IEquatable<CreateIncidentRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIncidentRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateIncidentRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIncidentRequest" /> class.
        /// </summary>
        /// <param name="summary">summary (required).</param>
        /// <param name="details">details (required).</param>
        /// <param name="userName">userName (required).</param>
        /// <param name="targets">targets (required).</param>
        /// <param name="isMultiResponder">isMultiResponder.</param>
        public CreateIncidentRequest(string summary = default(string), string details = default(string), string userName = default(string), List<IncidentTarget> targets = default(List<IncidentTarget>), bool isMultiResponder = default(bool))
        {
            // to ensure "summary" is required (not null)
            if (summary == null)
            {
                throw new InvalidDataException("summary is a required property for CreateIncidentRequest and cannot be null");
            }
            else
            {
                this.Summary = summary;
            }

            // to ensure "details" is required (not null)
            if (details == null)
            {
                throw new InvalidDataException("details is a required property for CreateIncidentRequest and cannot be null");
            }
            else
            {
                this.Details = details;
            }

            // to ensure "userName" is required (not null)
            if (userName == null)
            {
                throw new InvalidDataException("userName is a required property for CreateIncidentRequest and cannot be null");
            }
            else
            {
                this.UserName = userName;
            }

            // to ensure "targets" is required (not null)
            if (targets == null)
            {
                throw new InvalidDataException("targets is a required property for CreateIncidentRequest and cannot be null");
            }
            else
            {
                this.Targets = targets;
            }

            this.IsMultiResponder = isMultiResponder;
        }
        
        /// <summary>
        /// Gets or Sets Summary
        /// </summary>
        [DataMember(Name="summary", EmitDefaultValue=false)]
        public string Summary { get; set; }

        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public string Details { get; set; }

        /// <summary>
        /// Gets or Sets UserName
        /// </summary>
        [DataMember(Name="userName", EmitDefaultValue=false)]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or Sets Targets
        /// </summary>
        [DataMember(Name="targets", EmitDefaultValue=false)]
        public List<IncidentTarget> Targets { get; set; }

        /// <summary>
        /// Gets or Sets IsMultiResponder
        /// </summary>
        [DataMember(Name="isMultiResponder", EmitDefaultValue=false)]
        public bool IsMultiResponder { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateIncidentRequest {\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  Targets: ").Append(Targets).Append("\n");
            sb.Append("  IsMultiResponder: ").Append(IsMultiResponder).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateIncidentRequest);
        }

        /// <summary>
        /// Returns true if CreateIncidentRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateIncidentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateIncidentRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Summary == input.Summary ||
                    (this.Summary != null &&
                    this.Summary.Equals(input.Summary))
                ) && 
                (
                    this.Details == input.Details ||
                    (this.Details != null &&
                    this.Details.Equals(input.Details))
                ) && 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
                ) && 
                (
                    this.Targets == input.Targets ||
                    this.Targets != null &&
                    input.Targets != null &&
                    this.Targets.SequenceEqual(input.Targets)
                ) && 
                (
                    this.IsMultiResponder == input.IsMultiResponder ||
                    this.IsMultiResponder.Equals(input.IsMultiResponder)
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
                if (this.Summary != null)
                    hashCode = hashCode * 59 + this.Summary.GetHashCode();
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.Targets != null)
                    hashCode = hashCode * 59 + this.Targets.GetHashCode();
                hashCode = hashCode * 59 + this.IsMultiResponder.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
