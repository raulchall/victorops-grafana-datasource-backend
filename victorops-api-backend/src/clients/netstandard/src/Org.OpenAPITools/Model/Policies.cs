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
    /// Paging policies accociated which this user
    /// </summary>
    [DataContract]
    public partial class Policies :  IEquatable<Policies>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Policies" /> class.
        /// </summary>
        /// <param name="username">username.</param>
        /// <param name="userId">userId.</param>
        /// <param name="policies">policies.</param>
        public Policies(string username = default(string), int userId = default(int), List<PagingPolicy> policies = default(List<PagingPolicy>))
        {
            this.Username = username;
            this.UserId = userId;
            this._Policies = policies;
        }
        
        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public int UserId { get; set; }

        /// <summary>
        /// Gets or Sets _Policies
        /// </summary>
        [DataMember(Name="policies", EmitDefaultValue=false)]
        public List<PagingPolicy> _Policies { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Policies {\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  _Policies: ").Append(_Policies).Append("\n");
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
            return this.Equals(input as Policies);
        }

        /// <summary>
        /// Returns true if Policies instances are equal
        /// </summary>
        /// <param name="input">Instance of Policies to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Policies input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.UserId == input.UserId ||
                    this.UserId.Equals(input.UserId)
                ) && 
                (
                    this._Policies == input._Policies ||
                    this._Policies != null &&
                    input._Policies != null &&
                    this._Policies.SequenceEqual(input._Policies)
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
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this._Policies != null)
                    hashCode = hashCode * 59 + this._Policies.GetHashCode();
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