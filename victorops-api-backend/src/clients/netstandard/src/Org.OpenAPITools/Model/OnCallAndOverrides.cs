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
    /// OnCallAndOverrides
    /// </summary>
    [DataContract]
    public partial class OnCallAndOverrides :  IEquatable<OnCallAndOverrides>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OnCallAndOverrides" /> class.
        /// </summary>
        /// <param name="team">team.</param>
        /// <param name="schedule">schedule.</param>
        /// <param name="overrides">overrides.</param>
        public OnCallAndOverrides(string team = default(string), List<TeamScheduleResource> schedule = default(List<TeamScheduleResource>), List<TeamScheduleOverlayResource> overrides = default(List<TeamScheduleOverlayResource>))
        {
            this.Team = team;
            this.Schedule = schedule;
            this.Overrides = overrides;
        }
        
        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name="team", EmitDefaultValue=false)]
        public string Team { get; set; }

        /// <summary>
        /// Gets or Sets Schedule
        /// </summary>
        [DataMember(Name="schedule", EmitDefaultValue=false)]
        public List<TeamScheduleResource> Schedule { get; set; }

        /// <summary>
        /// Gets or Sets Overrides
        /// </summary>
        [DataMember(Name="overrides", EmitDefaultValue=false)]
        public List<TeamScheduleOverlayResource> Overrides { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OnCallAndOverrides {\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  Overrides: ").Append(Overrides).Append("\n");
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
            return this.Equals(input as OnCallAndOverrides);
        }

        /// <summary>
        /// Returns true if OnCallAndOverrides instances are equal
        /// </summary>
        /// <param name="input">Instance of OnCallAndOverrides to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OnCallAndOverrides input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Team == input.Team ||
                    (this.Team != null &&
                    this.Team.Equals(input.Team))
                ) && 
                (
                    this.Schedule == input.Schedule ||
                    this.Schedule != null &&
                    input.Schedule != null &&
                    this.Schedule.SequenceEqual(input.Schedule)
                ) && 
                (
                    this.Overrides == input.Overrides ||
                    this.Overrides != null &&
                    input.Overrides != null &&
                    this.Overrides.SequenceEqual(input.Overrides)
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
                if (this.Team != null)
                    hashCode = hashCode * 59 + this.Team.GetHashCode();
                if (this.Schedule != null)
                    hashCode = hashCode * 59 + this.Schedule.GetHashCode();
                if (this.Overrides != null)
                    hashCode = hashCode * 59 + this.Overrides.GetHashCode();
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
