/* 
 * VictorOps API
 *
 * This API allows you to interact with the VictorOps platform in various ways. Your account may be limited to a total number of API calls per month. Also, some of these API calls have rate limits.  NOTE: In this documentation when creating a sample curl request (clicking the TRY IT OUT! button), in some API viewing interfaces, the '@' in an email address may be encoded. Please note that the REST endpoints will not process the encoded version. Make sure that the encoded character '%40' is changed to its unencoded form before submitting the curl request. 
 *
 * The version of the OpenAPI document: 0.0.3
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;
using Org.OpenAPITools.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Test
{
    /// <summary>
    ///  Class for testing ListTeamMembersResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ListTeamMembersResponseTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ListTeamMembersResponse
        //private ListTeamMembersResponse instance;

        public ListTeamMembersResponseTests()
        {
            // TODO uncomment below to create an instance of ListTeamMembersResponse
            //instance = new ListTeamMembersResponse();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ListTeamMembersResponse
        /// </summary>
        [Fact]
        public void ListTeamMembersResponseInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ListTeamMembersResponse
            //Assert.IsInstanceOfType<ListTeamMembersResponse> (instance, "variable 'instance' is a ListTeamMembersResponse");
        }


        /// <summary>
        /// Test the property 'SelfUrl'
        /// </summary>
        [Fact]
        public void SelfUrlTest()
        {
            // TODO unit test for the property 'SelfUrl'
        }
        /// <summary>
        /// Test the property 'TeamUrl'
        /// </summary>
        [Fact]
        public void TeamUrlTest()
        {
            // TODO unit test for the property 'TeamUrl'
        }
        /// <summary>
        /// Test the property 'Members'
        /// </summary>
        [Fact]
        public void MembersTest()
        {
            // TODO unit test for the property 'Members'
        }

    }

}