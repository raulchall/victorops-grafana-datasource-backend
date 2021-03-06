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
    /// IncidentTarget
    /// </summary>
    [DataContract]
    public partial class IncidentTarget :  IEquatable<IncidentTarget>, IValidatableObject
    {
        /// <summary>
        /// Type of target
        /// </summary>
        /// <value>Type of target</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum User for value: User
            /// </summary>
            [EnumMember(Value = "User")]
            User = 1,

            /// <summary>
            /// Enum EscalationPolicy for value: EscalationPolicy
            /// </summary>
            [EnumMember(Value = "EscalationPolicy")]
            EscalationPolicy = 2

        }

        /// <summary>
        /// Type of target
        /// </summary>
        /// <value>Type of target</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IncidentTarget" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IncidentTarget() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IncidentTarget" /> class.
        /// </summary>
        /// <param name="type">Type of target (required).</param>
        /// <param name="slug">User name or escalation policy slug (required).</param>
        public IncidentTarget(TypeEnum type = default(TypeEnum), string slug = default(string))
        {
            this.Type = type;
            // to ensure "slug" is required (not null)
            if (slug == null)
            {
                throw new InvalidDataException("slug is a required property for IncidentTarget and cannot be null");
            }
            else
            {
                this.Slug = slug;
            }

        }
        
        /// <summary>
        /// User name or escalation policy slug
        /// </summary>
        /// <value>User name or escalation policy slug</value>
        [DataMember(Name="slug", EmitDefaultValue=false)]
        public string Slug { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IncidentTarget {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Slug: ").Append(Slug).Append("\n");
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
            return this.Equals(input as IncidentTarget);
        }

        /// <summary>
        /// Returns true if IncidentTarget instances are equal
        /// </summary>
        /// <param name="input">Instance of IncidentTarget to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IncidentTarget input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Slug == input.Slug ||
                    (this.Slug != null &&
                    this.Slug.Equals(input.Slug))
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
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Slug != null)
                    hashCode = hashCode * 59 + this.Slug.GetHashCode();
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
