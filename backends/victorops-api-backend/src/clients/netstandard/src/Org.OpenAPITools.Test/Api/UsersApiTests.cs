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
    ///  Class for testing UsersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class UsersApiTests : IDisposable
    {
        private UsersApi instance;

        public UsersApiTests()
        {
            instance = new UsersApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UsersApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' UsersApi
            //Assert.IsType(typeof(UsersApi), instance, "instance is a UsersApi");
        }

        
        /// <summary>
        /// Test ApiPublicV1UserGet
        /// </summary>
        [Fact]
        public void ApiPublicV1UserGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xVOApiId = null;
            //string xVOApiKey = null;
            //var response = instance.ApiPublicV1UserGet(xVOApiId, xVOApiKey);
            //Assert.IsType<ListUserResponse> (response, "response is ListUserResponse");
        }
        
        /// <summary>
        /// Test ApiPublicV1UserPost
        /// </summary>
        [Fact]
        public void ApiPublicV1UserPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xVOApiId = null;
            //string xVOApiKey = null;
            //AddUserPayload body = null;
            //var response = instance.ApiPublicV1UserPost(xVOApiId, xVOApiKey, body);
            //Assert.IsType<V1User> (response, "response is V1User");
        }
        
        /// <summary>
        /// Test ApiPublicV1UserUserDelete
        /// </summary>
        [Fact]
        public void ApiPublicV1UserUserDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xVOApiId = null;
            //string xVOApiKey = null;
            //string user = null;
            //DeleteUserPayload body = null;
            //instance.ApiPublicV1UserUserDelete(xVOApiId, xVOApiKey, user, body);
            
        }
        
        /// <summary>
        /// Test ApiPublicV1UserUserGet
        /// </summary>
        [Fact]
        public void ApiPublicV1UserUserGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xVOApiId = null;
            //string xVOApiKey = null;
            //string user = null;
            //var response = instance.ApiPublicV1UserUserGet(xVOApiId, xVOApiKey, user);
            //Assert.IsType<V1User> (response, "response is V1User");
        }
        
        /// <summary>
        /// Test ApiPublicV1UserUserPut
        /// </summary>
        [Fact]
        public void ApiPublicV1UserUserPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xVOApiId = null;
            //string xVOApiKey = null;
            //string user = null;
            //AddUserPayload body = null;
            //var response = instance.ApiPublicV1UserUserPut(xVOApiId, xVOApiKey, user, body);
            //Assert.IsType<V1User> (response, "response is V1User");
        }
        
        /// <summary>
        /// Test ApiPublicV1UserUserTeamsGet
        /// </summary>
        [Fact]
        public void ApiPublicV1UserUserTeamsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xVOApiId = null;
            //string xVOApiKey = null;
            //string user = null;
            //var response = instance.ApiPublicV1UserUserTeamsGet(xVOApiId, xVOApiKey, user);
            //Assert.IsType<UserTeamsResponse> (response, "response is UserTeamsResponse");
        }
        
    }

}
