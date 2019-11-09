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
    /// OnCallInterval
    /// </summary>
    [DataContract]
    public partial class OnCallInterval :  IEquatable<OnCallInterval>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OnCallInterval" /> class.
        /// </summary>
        /// <param name="_true">_true.</param>
        /// <param name="_false">_false.</param>
        /// <param name="duration">duration.</param>
        /// <param name="escalationPolicy">escalationPolicy.</param>
        public OnCallInterval(string _true = default(string), string _false = default(string), UserLogTotal duration = default(UserLogTotal), EscalationPolicy escalationPolicy = default(EscalationPolicy))
        {
            this.True = _true;
            this.False = _false;
            this.Duration = duration;
            this.EscalationPolicy = escalationPolicy;
        }
        
        /// <summary>
        /// Gets or Sets True
        /// </summary>
        [DataMember(Name="true", EmitDefaultValue=false)]
        public string True { get; set; }

        /// <summary>
        /// Gets or Sets False
        /// </summary>
        [DataMember(Name="false", EmitDefaultValue=false)]
        public string False { get; set; }

        /// <summary>
        /// Gets or Sets Duration
        /// </summary>
        [DataMember(Name="duration", EmitDefaultValue=false)]
        public UserLogTotal Duration { get; set; }

        /// <summary>
        /// Gets or Sets EscalationPolicy
        /// </summary>
        [DataMember(Name="escalationPolicy", EmitDefaultValue=false)]
        public EscalationPolicy EscalationPolicy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OnCallInterval {\n");
            sb.Append("  True: ").Append(True).Append("\n");
            sb.Append("  False: ").Append(False).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  EscalationPolicy: ").Append(EscalationPolicy).Append("\n");
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
            return this.Equals(input as OnCallInterval);
        }

        /// <summary>
        /// Returns true if OnCallInterval instances are equal
        /// </summary>
        /// <param name="input">Instance of OnCallInterval to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OnCallInterval input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.True == input.True ||
                    (this.True != null &&
                    this.True.Equals(input.True))
                ) && 
                (
                    this.False == input.False ||
                    (this.False != null &&
                    this.False.Equals(input.False))
                ) && 
                (
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
                ) && 
                (
                    this.EscalationPolicy == input.EscalationPolicy ||
                    (this.EscalationPolicy != null &&
                    this.EscalationPolicy.Equals(input.EscalationPolicy))
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
                if (this.True != null)
                    hashCode = hashCode * 59 + this.True.GetHashCode();
                if (this.False != null)
                    hashCode = hashCode * 59 + this.False.GetHashCode();
                if (this.Duration != null)
                    hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.EscalationPolicy != null)
                    hashCode = hashCode * 59 + this.EscalationPolicy.GetHashCode();
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