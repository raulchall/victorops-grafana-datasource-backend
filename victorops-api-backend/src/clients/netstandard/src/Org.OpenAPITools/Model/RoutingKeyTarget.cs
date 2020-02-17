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
    /// Routing key target
    /// </summary>
    [DataContract]
    public partial class RoutingKeyTarget :  IEquatable<RoutingKeyTarget>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoutingKeyTarget" /> class.
        /// </summary>
        /// <param name="policyName">policyName.</param>
        /// <param name="policySlug">policySlug.</param>
        /// <param name="teamUrl">teamUrl.</param>
        public RoutingKeyTarget(string policyName = default(string), string policySlug = default(string), string teamUrl = default(string))
        {
            this.PolicyName = policyName;
            this.PolicySlug = policySlug;
            this.TeamUrl = teamUrl;
        }
        
        /// <summary>
        /// Gets or Sets PolicyName
        /// </summary>
        [DataMember(Name="policyName", EmitDefaultValue=false)]
        public string PolicyName { get; set; }

        /// <summary>
        /// Gets or Sets PolicySlug
        /// </summary>
        [DataMember(Name="policySlug", EmitDefaultValue=false)]
        public string PolicySlug { get; set; }

        /// <summary>
        /// Gets or Sets TeamUrl
        /// </summary>
        [DataMember(Name="_teamUrl", EmitDefaultValue=false)]
        public string TeamUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoutingKeyTarget {\n");
            sb.Append("  PolicyName: ").Append(PolicyName).Append("\n");
            sb.Append("  PolicySlug: ").Append(PolicySlug).Append("\n");
            sb.Append("  TeamUrl: ").Append(TeamUrl).Append("\n");
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
            return this.Equals(input as RoutingKeyTarget);
        }

        /// <summary>
        /// Returns true if RoutingKeyTarget instances are equal
        /// </summary>
        /// <param name="input">Instance of RoutingKeyTarget to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoutingKeyTarget input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PolicyName == input.PolicyName ||
                    (this.PolicyName != null &&
                    this.PolicyName.Equals(input.PolicyName))
                ) && 
                (
                    this.PolicySlug == input.PolicySlug ||
                    (this.PolicySlug != null &&
                    this.PolicySlug.Equals(input.PolicySlug))
                ) && 
                (
                    this.TeamUrl == input.TeamUrl ||
                    (this.TeamUrl != null &&
                    this.TeamUrl.Equals(input.TeamUrl))
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
                if (this.PolicyName != null)
                    hashCode = hashCode * 59 + this.PolicyName.GetHashCode();
                if (this.PolicySlug != null)
                    hashCode = hashCode * 59 + this.PolicySlug.GetHashCode();
                if (this.TeamUrl != null)
                    hashCode = hashCode * 59 + this.TeamUrl.GetHashCode();
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