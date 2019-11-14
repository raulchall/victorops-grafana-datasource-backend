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
    ///  Class for testing UserPagingPoliciesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class UserPagingPoliciesApiTests : IDisposable
    {
        private UserPagingPoliciesApi instance;

        public UserPagingPoliciesApiTests()
        {
            instance = new UserPagingPoliciesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UserPagingPoliciesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' UserPagingPoliciesApi
            //Assert.IsType(typeof(UserPagingPoliciesApi), instance, "instance is a UserPagingPoliciesApi");
        }

        
        /// <summary>
        /// Test ApiPublicV1UserUserPoliciesGet
        /// </summary>
        [Fact]
        public void ApiPublicV1UserUserPoliciesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xVOApiId = null;
            //string xVOApiKey = null;
            //string user = null;
            //var response = instance.ApiPublicV1UserUserPoliciesGet(xVOApiId, xVOApiKey, user);
            //Assert.IsType<Policies> (response, "response is Policies");
        }
        
    }

}
