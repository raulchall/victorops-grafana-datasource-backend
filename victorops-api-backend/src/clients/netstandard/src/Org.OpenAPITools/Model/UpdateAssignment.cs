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
    /// UpdateAssignment
    /// </summary>
    [DataContract]
    public partial class UpdateAssignment :  IEquatable<UpdateAssignment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAssignment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateAssignment() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAssignment" /> class.
        /// </summary>
        /// <param name="policy">The policy slug (required).</param>
        /// <param name="username">The username being assinged.</param>
        public UpdateAssignment(string policy = default(string), string username = default(string))
        {
            // to ensure "policy" is required (not null)
            if (policy == null)
            {
                throw new InvalidDataException("policy is a required property for UpdateAssignment and cannot be null");
            }
            else
            {
                this.Policy = policy;
            }

            this.Username = username;
        }
        
        /// <summary>
        /// The policy slug
        /// </summary>
        /// <value>The policy slug</value>
        [DataMember(Name="policy", EmitDefaultValue=false)]
        public string Policy { get; set; }

        /// <summary>
        /// The username being assinged
        /// </summary>
        /// <value>The username being assinged</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateAssignment {\n");
            sb.Append("  Policy: ").Append(Policy).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
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
            return this.Equals(input as UpdateAssignment);
        }

        /// <summary>
        /// Returns true if UpdateAssignment instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateAssignment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateAssignment input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Policy == input.Policy ||
                    (this.Policy != null &&
                    this.Policy.Equals(input.Policy))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
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
                if (this.Policy != null)
                    hashCode = hashCode * 59 + this.Policy.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
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
