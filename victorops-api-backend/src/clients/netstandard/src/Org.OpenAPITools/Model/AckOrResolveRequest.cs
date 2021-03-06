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
    /// AckOrResolveRequest
    /// </summary>
    [DataContract]
    public partial class AckOrResolveRequest :  IEquatable<AckOrResolveRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AckOrResolveRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AckOrResolveRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AckOrResolveRequest" /> class.
        /// </summary>
        /// <param name="userName">userName (required).</param>
        /// <param name="incidentNames">incidentNames (required).</param>
        /// <param name="message">message.</param>
        public AckOrResolveRequest(string userName = default(string), List<string> incidentNames = default(List<string>), string message = default(string))
        {
            // to ensure "userName" is required (not null)
            if (userName == null)
            {
                throw new InvalidDataException("userName is a required property for AckOrResolveRequest and cannot be null");
            }
            else
            {
                this.UserName = userName;
            }

            // to ensure "incidentNames" is required (not null)
            if (incidentNames == null)
            {
                throw new InvalidDataException("incidentNames is a required property for AckOrResolveRequest and cannot be null");
            }
            else
            {
                this.IncidentNames = incidentNames;
            }

            this.Message = message;
        }
        
        /// <summary>
        /// Gets or Sets UserName
        /// </summary>
        [DataMember(Name="userName", EmitDefaultValue=false)]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or Sets IncidentNames
        /// </summary>
        [DataMember(Name="incidentNames", EmitDefaultValue=false)]
        public List<string> IncidentNames { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AckOrResolveRequest {\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  IncidentNames: ").Append(IncidentNames).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(input as AckOrResolveRequest);
        }

        /// <summary>
        /// Returns true if AckOrResolveRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AckOrResolveRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AckOrResolveRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
                ) && 
                (
                    this.IncidentNames == input.IncidentNames ||
                    this.IncidentNames != null &&
                    input.IncidentNames != null &&
                    this.IncidentNames.SequenceEqual(input.IncidentNames)
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.IncidentNames != null)
                    hashCode = hashCode * 59 + this.IncidentNames.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
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
