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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Org.OpenAPITools.Client;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Test
{
    /// <summary>
    ///  Class for testing TeamsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TeamsApiTests : IDisposable
    {
        private TeamsApi instance;

        public TeamsApiTests()
        {
            instance = new TeamsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TeamsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' TeamsApi
            //Assert.IsType(typeof(TeamsApi), instance, "instance is a TeamsApi");
        }

        
        /// <summary>
        /// Test ApiPublicV1TeamGet
        /// </summary>
        [Fact]
        public void ApiPublicV1TeamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xVOApiId = null;
            //string xVOApiKey = null;
            //var response = instance.ApiPublicV1TeamGet(xVOApiId, xVOApiKey);
            //Assert.IsType<List<TeamDetail>> (response, "response is List<TeamDetail>");
        }
        
        /// <summary>
        /// Test ApiPublicV1TeamPost
        /// </summary>
        [Fact]
        public void ApiPublicV1TeamPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xVOApiId = null;
            //string xVOApiKey = null;
            //AddTeamPayload body = null;
            //var response = instance.ApiPublicV1TeamPost(xVOApiId, xVOApiKey, body);
            //Assert.IsType<TeamDetail> (response, "response is TeamDetail");
        }
        
        /// <summary>
        /// Test ApiPublicV1TeamTeamAdminsGet
        /// </summary>
        [Fact]
        public void ApiPublicV1TeamTeamAdminsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xVOApiId = null;
            //string xVOApiKey = null;
            //string team = null;
            //var response = instance.ApiPublicV1TeamTeamAdminsGet(xVOApiId, xVOApiKey, team);
            //Assert.IsType<TeamAdminsResponse> (response, "response is TeamAdminsResponse");
        }
        
        /// <summary>
        /// Test ApiPublicV1TeamTeamDelete
        /// </summary>
        [Fact]
        public void ApiPublicV1TeamTeamDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xVOApiId = null;
            //string xVOApiKey = null;
            //string team = null;
            //instance.ApiPublicV1TeamTeamDelete(xVOApiId, xVOApiKey, team);
            
        }
        
        /// <summary>
        /// Test ApiPublicV1TeamTeamGet
        /// </summary>
        [Fact]
        public void ApiPublicV1TeamTeamGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xVOApiId = null;
            //string xVOApiKey = null;
            //string team = null;
            //var response = instance.ApiPublicV1TeamTeamGet(xVOApiId, xVOApiKey, team);
            //Assert.IsType<TeamDetail> (response, "response is TeamDetail");
        }
        
        /// <summary>
        /// Test ApiPublicV1TeamTeamMembersGet
        /// </summary>
        [Fact]
        public void ApiPublicV1TeamTeamMembersGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xVOApiId = null;
            //string xVOApiKey = null;
            //string team = null;
            //var response = instance.ApiPublicV1TeamTeamMembersGet(xVOApiId, xVOApiKey, team);
            //Assert.IsType<ListTeamMembersResponse> (response, "response is ListTeamMembersResponse");
        }
        
        /// <summary>
        /// Test ApiPublicV1TeamTeamMembersPost
        /// </summary>
        [Fact]
        public void ApiPublicV1TeamTeamMembersPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xVOApiId = null;
            //string xVOApiKey = null;
            //string team = null;
            //AddTeamMemberPayload body = null;
            //var response = instance.ApiPublicV1TeamTeamMembersPost(xVOApiId, xVOApiKey, team, body);
            //Assert.IsType<ListTeamMembersResponse> (response, "response is ListTeamMembersResponse");
        }
        
        /// <summary>
        /// Test ApiPublicV1TeamTeamMembersUserDelete
        /// </summary>
        [Fact]
        public void ApiPublicV1TeamTeamMembersUserDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xVOApiId = null;
            //string xVOApiKey = null;
            //string team = null;
            //string user = null;
            //RemoveTeamMemberPayload body = null;
            //instance.ApiPublicV1TeamTeamMembersUserDelete(xVOApiId, xVOApiKey, team, user, body);
            
        }
        
        /// <summary>
        /// Test ApiPublicV1TeamTeamPoliciesGet
        /// </summary>
        [Fact]
        public void ApiPublicV1TeamTeamPoliciesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xVOApiId = null;
            //string xVOApiKey = null;
            //string team = null;
            //var response = instance.ApiPublicV1TeamTeamPoliciesGet(xVOApiId, xVOApiKey, team);
            //Assert.IsType<EscalationPolicyList> (response, "response is EscalationPolicyList");
        }
        
        /// <summary>
        /// Test ApiPublicV1TeamTeamPut
        /// </summary>
        [Fact]
        public void ApiPublicV1TeamTeamPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xVOApiId = null;
            //string xVOApiKey = null;
            //string team = null;
            //AddTeamPayload body = null;
            //var response = instance.ApiPublicV1TeamTeamPut(xVOApiId, xVOApiKey, team, body);
            //Assert.IsType<TeamDetail> (response, "response is TeamDetail");
        }
        
    }

}
