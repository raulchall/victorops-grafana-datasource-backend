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
    ///  Class for testing ScheduledOverridesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ScheduledOverridesApiTests : IDisposable
    {
        private ScheduledOverridesApi instance;

        public ScheduledOverridesApiTests()
        {
            instance = new ScheduledOverridesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ScheduledOverridesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ScheduledOverridesApi
            //Assert.IsType(typeof(ScheduledOverridesApi), instance, "instance is a ScheduledOverridesApi");
        }

        
        /// <summary>
        /// Test ApiPublicV1OverridesGet
        /// </summary>
        [Fact]
        public void ApiPublicV1OverridesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xVOApiId = null;
            //string xVOApiKey = null;
            //var response = instance.ApiPublicV1OverridesGet(xVOApiId, xVOApiKey);
            //Assert.IsType<InlineResponse2008> (response, "response is InlineResponse2008");
        }
        
        /// <summary>
        /// Test ApiPublicV1OverridesPost
        /// </summary>
        [Fact]
        public void ApiPublicV1OverridesPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xVOApiId = null;
            //string xVOApiKey = null;
            //ScheduledOverridePayload body = null;
            //var response = instance.ApiPublicV1OverridesPost(xVOApiId, xVOApiKey, body);
            //Assert.IsType<InlineResponse2009> (response, "response is InlineResponse2009");
        }
        
        /// <summary>
        /// Test ApiPublicV1OverridesPublicIdAssignmentsGet
        /// </summary>
        [Fact]
        public void ApiPublicV1OverridesPublicIdAssignmentsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xVOApiId = null;
            //string xVOApiKey = null;
            //string publicId = null;
            //var response = instance.ApiPublicV1OverridesPublicIdAssignmentsGet(xVOApiId, xVOApiKey, publicId);
            //Assert.IsType<List<Assignment>> (response, "response is List<Assignment>");
        }
        
        /// <summary>
        /// Test ApiPublicV1OverridesPublicIdAssignmentsPolicySlugDelete
        /// </summary>
        [Fact]
        public void ApiPublicV1OverridesPublicIdAssignmentsPolicySlugDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xVOApiId = null;
            //string xVOApiKey = null;
            //string publicId = null;
            //string policySlug = null;
            //var response = instance.ApiPublicV1OverridesPublicIdAssignmentsPolicySlugDelete(xVOApiId, xVOApiKey, publicId, policySlug);
            //Assert.IsType<Assignment> (response, "response is Assignment");
        }
        
        /// <summary>
        /// Test ApiPublicV1OverridesPublicIdAssignmentsPolicySlugGet
        /// </summary>
        [Fact]
        public void ApiPublicV1OverridesPublicIdAssignmentsPolicySlugGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xVOApiId = null;
            //string xVOApiKey = null;
            //string publicId = null;
            //string policySlug = null;
            //var response = instance.ApiPublicV1OverridesPublicIdAssignmentsPolicySlugGet(xVOApiId, xVOApiKey, publicId, policySlug);
            //Assert.IsType<Assignment> (response, "response is Assignment");
        }
        
        /// <summary>
        /// Test ApiPublicV1OverridesPublicIdAssignmentsPolicySlugPut
        /// </summary>
        [Fact]
        public void ApiPublicV1OverridesPublicIdAssignmentsPolicySlugPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xVOApiId = null;
            //string xVOApiKey = null;
            //string publicId = null;
            //string policySlug = null;
            //UpdateAssignment body = null;
            //var response = instance.ApiPublicV1OverridesPublicIdAssignmentsPolicySlugPut(xVOApiId, xVOApiKey, publicId, policySlug, body);
            //Assert.IsType<Assignment> (response, "response is Assignment");
        }
        
        /// <summary>
        /// Test ApiPublicV1OverridesPublicIdDelete
        /// </summary>
        [Fact]
        public void ApiPublicV1OverridesPublicIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xVOApiId = null;
            //string xVOApiKey = null;
            //string publicId = null;
            //instance.ApiPublicV1OverridesPublicIdDelete(xVOApiId, xVOApiKey, publicId);
            
        }
        
        /// <summary>
        /// Test ApiPublicV1OverridesPublicIdGet
        /// </summary>
        [Fact]
        public void ApiPublicV1OverridesPublicIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xVOApiId = null;
            //string xVOApiKey = null;
            //string publicId = null;
            //var response = instance.ApiPublicV1OverridesPublicIdGet(xVOApiId, xVOApiKey, publicId);
            //Assert.IsType<InlineResponse20010> (response, "response is InlineResponse20010");
        }
        
    }

}
