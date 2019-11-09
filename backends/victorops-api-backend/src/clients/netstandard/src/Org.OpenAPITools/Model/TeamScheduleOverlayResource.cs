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
    /// TeamScheduleOverlayResource
    /// </summary>
    [DataContract]
    public partial class TeamScheduleOverlayResource :  IEquatable<TeamScheduleOverlayResource>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamScheduleOverlayResource" /> class.
        /// </summary>
        /// <param name="orig">The user scheduled on call (if any).</param>
        /// <param name="over">The user overriding the scheduled on call user (if any).</param>
        /// <param name="start">The time the override is scheduled to start.</param>
        /// <param name="end">The time the override is scheduled to end.</param>
        public TeamScheduleOverlayResource(string orig = default(string), string over = default(string), decimal start = default(decimal), decimal end = default(decimal))
        {
            this.Orig = orig;
            this.Over = over;
            this.Start = start;
            this.End = end;
        }
        
        /// <summary>
        /// The user scheduled on call (if any)
        /// </summary>
        /// <value>The user scheduled on call (if any)</value>
        [DataMember(Name="orig", EmitDefaultValue=false)]
        public string Orig { get; set; }

        /// <summary>
        /// The user overriding the scheduled on call user (if any)
        /// </summary>
        /// <value>The user overriding the scheduled on call user (if any)</value>
        [DataMember(Name="over", EmitDefaultValue=false)]
        public string Over { get; set; }

        /// <summary>
        /// The time the override is scheduled to start
        /// </summary>
        /// <value>The time the override is scheduled to start</value>
        [DataMember(Name="start", EmitDefaultValue=false)]
        public decimal Start { get; set; }

        /// <summary>
        /// The time the override is scheduled to end
        /// </summary>
        /// <value>The time the override is scheduled to end</value>
        [DataMember(Name="end", EmitDefaultValue=false)]
        public decimal End { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeamScheduleOverlayResource {\n");
            sb.Append("  Orig: ").Append(Orig).Append("\n");
            sb.Append("  Over: ").Append(Over).Append("\n");
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
            return this.Equals(input as TeamScheduleOverlayResource);
        }

        /// <summary>
        /// Returns true if TeamScheduleOverlayResource instances are equal
        /// </summary>
        /// <param name="input">Instance of TeamScheduleOverlayResource to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeamScheduleOverlayResource input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Orig == input.Orig ||
                    (this.Orig != null &&
                    this.Orig.Equals(input.Orig))
                ) && 
                (
                    this.Over == input.Over ||
                    (this.Over != null &&
                    this.Over.Equals(input.Over))
                ) && 
                (
                    this.Start == input.Start ||
                    this.Start.Equals(input.Start)
                ) && 
                (
                    this.End == input.End ||
                    this.End.Equals(input.End)
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
                if (this.Orig != null)
                    hashCode = hashCode * 59 + this.Orig.GetHashCode();
                if (this.Over != null)
                    hashCode = hashCode * 59 + this.Over.GetHashCode();
                hashCode = hashCode * 59 + this.Start.GetHashCode();
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
