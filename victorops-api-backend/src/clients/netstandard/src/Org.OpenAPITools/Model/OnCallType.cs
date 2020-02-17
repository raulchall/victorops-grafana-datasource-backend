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
    /// Defines OnCallType
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum OnCallType
    {
        /// <summary>
        /// Enum User for value: user
        /// </summary>
        [EnumMember(Value = "user")]
        User = 1,

        /// <summary>
        /// Enum Rotationgroup for value: rotation_group
        /// </summary>
        [EnumMember(Value = "rotation_group")]
        Rotationgroup = 2,

        /// <summary>
        /// Enum Rotationgroupnext for value: rotation_group_next
        /// </summary>
        [EnumMember(Value = "rotation_group_next")]
        Rotationgroupnext = 3,

        /// <summary>
        /// Enum Rotationgroupprevious for value: rotation_group_previous
        /// </summary>
        [EnumMember(Value = "rotation_group_previous")]
        Rotationgroupprevious = 4,

        /// <summary>
        /// Enum Team for value: team
        /// </summary>
        [EnumMember(Value = "team")]
        Team = 5,

        /// <summary>
        /// Enum Teamrouting for value: team_routing
        /// </summary>
        [EnumMember(Value = "team_routing")]
        Teamrouting = 6,

        /// <summary>
        /// Enum Webhook for value: webhook
        /// </summary>
        [EnumMember(Value = "webhook")]
        Webhook = 7,

        /// <summary>
        /// Enum Email for value: email
        /// </summary>
        [EnumMember(Value = "email")]
        Email = 8,

        /// <summary>
        /// Enum Policyrouting for value: policy_routing
        /// </summary>
        [EnumMember(Value = "policy_routing")]
        Policyrouting = 9

    }

}