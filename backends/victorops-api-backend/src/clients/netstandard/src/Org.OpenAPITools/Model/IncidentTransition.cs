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
    /// A transition of incident state
    /// </summary>
    [DataContract]
    public partial class IncidentTransition :  IEquatable<IncidentTransition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IncidentTransition" /> class.
        /// </summary>
        /// <param name="name">The transition name.</param>
        /// <param name="at">The time of the transition.</param>
        /// <param name="by">The user that caused the transition (if any).</param>
        /// <param name="message">The message entered by that user (if any).</param>
        /// <param name="manually">If the incident transition was caused by a person.</param>
        /// <param name="alertId">The unique alert ID that caused the transition.</param>
        /// <param name="alertUrl">A URL to retrieve the details of the alert that caused the transition.</param>
        public IncidentTransition(string name = default(string), string at = default(string), string by = default(string), string message = default(string), bool manually = default(bool), string alertId = default(string), string alertUrl = default(string))
        {
            this.Name = name;
            this.At = at;
            this.By = by;
            this.Message = message;
            this.Manually = manually;
            this.AlertId = alertId;
            this.AlertUrl = alertUrl;
        }
        
        /// <summary>
        /// The transition name
        /// </summary>
        /// <value>The transition name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The time of the transition
        /// </summary>
        /// <value>The time of the transition</value>
        [DataMember(Name="at", EmitDefaultValue=false)]
        public string At { get; set; }

        /// <summary>
        /// The user that caused the transition (if any)
        /// </summary>
        /// <value>The user that caused the transition (if any)</value>
        [DataMember(Name="by", EmitDefaultValue=false)]
        public string By { get; set; }

        /// <summary>
        /// The message entered by that user (if any)
        /// </summary>
        /// <value>The message entered by that user (if any)</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// If the incident transition was caused by a person
        /// </summary>
        /// <value>If the incident transition was caused by a person</value>
        [DataMember(Name="manually", EmitDefaultValue=false)]
        public bool Manually { get; set; }

        /// <summary>
        /// The unique alert ID that caused the transition
        /// </summary>
        /// <value>The unique alert ID that caused the transition</value>
        [DataMember(Name="alertId", EmitDefaultValue=false)]
        public string AlertId { get; set; }

        /// <summary>
        /// A URL to retrieve the details of the alert that caused the transition
        /// </summary>
        /// <value>A URL to retrieve the details of the alert that caused the transition</value>
        [DataMember(Name="alertUrl", EmitDefaultValue=false)]
        public string AlertUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IncidentTransition {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  At: ").Append(At).Append("\n");
            sb.Append("  By: ").Append(By).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Manually: ").Append(Manually).Append("\n");
            sb.Append("  AlertId: ").Append(AlertId).Append("\n");
            sb.Append("  AlertUrl: ").Append(AlertUrl).Append("\n");
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
            return this.Equals(input as IncidentTransition);
        }

        /// <summary>
        /// Returns true if IncidentTransition instances are equal
        /// </summary>
        /// <param name="input">Instance of IncidentTransition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IncidentTransition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.At == input.At ||
                    (this.At != null &&
                    this.At.Equals(input.At))
                ) && 
                (
                    this.By == input.By ||
                    (this.By != null &&
                    this.By.Equals(input.By))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Manually == input.Manually ||
                    this.Manually.Equals(input.Manually)
                ) && 
                (
                    this.AlertId == input.AlertId ||
                    (this.AlertId != null &&
                    this.AlertId.Equals(input.AlertId))
                ) && 
                (
                    this.AlertUrl == input.AlertUrl ||
                    (this.AlertUrl != null &&
                    this.AlertUrl.Equals(input.AlertUrl))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.At != null)
                    hashCode = hashCode * 59 + this.At.GetHashCode();
                if (this.By != null)
                    hashCode = hashCode * 59 + this.By.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                hashCode = hashCode * 59 + this.Manually.GetHashCode();
                if (this.AlertId != null)
                    hashCode = hashCode * 59 + this.AlertId.GetHashCode();
                if (this.AlertUrl != null)
                    hashCode = hashCode * 59 + this.AlertUrl.GetHashCode();
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
