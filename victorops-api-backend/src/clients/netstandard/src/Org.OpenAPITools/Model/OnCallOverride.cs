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
    /// OnCallOverride
    /// </summary>
    [DataContract]
    public partial class OnCallOverride :  IEquatable<OnCallOverride>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OnCallOverride" /> class.
        /// </summary>
        /// <param name="origOnCallUser">origOnCallUser.</param>
        /// <param name="overrideOnCallUser">overrideOnCallUser.</param>
        /// <param name="start">The override start time (ISO 8601).</param>
        /// <param name="end">The override end time (ISO 8601).</param>
        public OnCallOverride(User origOnCallUser = default(User), User overrideOnCallUser = default(User), string start = default(string), string end = default(string))
        {
            this.OrigOnCallUser = origOnCallUser;
            this.OverrideOnCallUser = overrideOnCallUser;
            this.Start = start;
            this.End = end;
        }
        
        /// <summary>
        /// Gets or Sets OrigOnCallUser
        /// </summary>
        [DataMember(Name="origOnCallUser", EmitDefaultValue=false)]
        public User OrigOnCallUser { get; set; }

        /// <summary>
        /// Gets or Sets OverrideOnCallUser
        /// </summary>
        [DataMember(Name="overrideOnCallUser", EmitDefaultValue=false)]
        public User OverrideOnCallUser { get; set; }

        /// <summary>
        /// The override start time (ISO 8601)
        /// </summary>
        /// <value>The override start time (ISO 8601)</value>
        [DataMember(Name="start", EmitDefaultValue=false)]
        public string Start { get; set; }

        /// <summary>
        /// The override end time (ISO 8601)
        /// </summary>
        /// <value>The override end time (ISO 8601)</value>
        [DataMember(Name="end", EmitDefaultValue=false)]
        public string End { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OnCallOverride {\n");
            sb.Append("  OrigOnCallUser: ").Append(OrigOnCallUser).Append("\n");
            sb.Append("  OverrideOnCallUser: ").Append(OverrideOnCallUser).Append("\n");
            sb.Append("  Start: ").Append(Start).Append("\n");
            sb.Append("  End: ").Append(End).Append("\n");
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
            return this.Equals(input as OnCallOverride);
        }

        /// <summary>
        /// Returns true if OnCallOverride instances are equal
        /// </summary>
        /// <param name="input">Instance of OnCallOverride to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OnCallOverride input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OrigOnCallUser == input.OrigOnCallUser ||
                    (this.OrigOnCallUser != null &&
                    this.OrigOnCallUser.Equals(input.OrigOnCallUser))
                ) && 
                (
                    this.OverrideOnCallUser == input.OverrideOnCallUser ||
                    (this.OverrideOnCallUser != null &&
                    this.OverrideOnCallUser.Equals(input.OverrideOnCallUser))
                ) && 
                (
                    this.Start == input.Start ||
                    (this.Start != null &&
                    this.Start.Equals(input.Start))
                ) && 
                (
                    this.End == input.End ||
                    (this.End != null &&
                    this.End.Equals(input.End))
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
                if (this.OrigOnCallUser != null)
                    hashCode = hashCode * 59 + this.OrigOnCallUser.GetHashCode();
                if (this.OverrideOnCallUser != null)
                    hashCode = hashCode * 59 + this.OverrideOnCallUser.GetHashCode();
                if (this.Start != null)
                    hashCode = hashCode * 59 + this.Start.GetHashCode();
                if (this.End != null)
                    hashCode = hashCode * 59 + this.End.GetHashCode();
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
