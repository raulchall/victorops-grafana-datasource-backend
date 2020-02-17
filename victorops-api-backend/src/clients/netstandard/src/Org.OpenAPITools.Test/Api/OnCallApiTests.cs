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
    ///  Class for testing OnCallApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class OnCallApiTests : IDisposable
    {
        private OnCallApi instance;

        public OnCallApiTests()
        {
            instance = new OnCallApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of OnCallApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' OnCallApi
            //Assert.IsType(typeof(OnCallApi), instance, "instance is a OnCallApi");
        }

        
        /// <summary>
        /// Test ApiPublicV1OncallCurrentGet
        /// </summary>
        [Fact]
        public void ApiPublicV1OncallCurrentGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xVOApiId = null;
            //string xVOApiKey = null;
            //var response = instance.ApiPublicV1OncallCurrentGet(xVOApiId, xVOApiKey);
            //Assert.IsType<InlineResponse2007> (response, "response is InlineResponse2007");
        }
        
        /// <summary>
        /// Test ApiPublicV1PoliciesPolicyOncallUserPatch
        /// </summary>
        [Fact]
        public void ApiPublicV1PoliciesPolicyOncallUserPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xVOApiId = null;
            //string xVOApiKey = null;
            //string policy = null;
            //TakeRequest body = null;
            //var response = instance.ApiPublicV1PoliciesPolicyOncallUserPatch(xVOApiId, xVOApiKey, policy, body);
            //Assert.IsType<TakeResult> (response, "response is TakeResult");
        }
        
        /// <summary>
        /// Test ApiPublicV1TeamTeamOncallScheduleGet
        /// </summary>
        [Fact]
        public void ApiPublicV1TeamTeamOncallScheduleGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xVOApiId = null;
            //string xVOApiKey = null;
            //string team = null;
            //decimal? daysForward = null;
            //decimal? daysSkip = null;
            //decimal? step = null;
            //var response = instance.ApiPublicV1TeamTeamOncallScheduleGet(xVOApiId, xVOApiKey, team, daysForward, daysSkip, step);
            //Assert.IsType<OnCallAndOverrides> (response, "response is OnCallAndOverrides");
        }
        
        /// <summary>
        /// Test ApiPublicV1TeamTeamOncallUserPatch
        /// </summary>
        [Fact]
        public void ApiPublicV1TeamTeamOncallUserPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xVOApiId = null;
            //string xVOApiKey = null;
            //string team = null;
            //TakeRequest body = null;
            //var response = instance.ApiPublicV1TeamTeamOncallUserPatch(xVOApiId, xVOApiKey, team, body);
            //Assert.IsType<TakeResult> (response, "response is TakeResult");
        }
        
        /// <summary>
        /// Test ApiPublicV1UserUserOncallScheduleGet
        /// </summary>
        [Fact]
        public void ApiPublicV1UserUserOncallScheduleGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xVOApiId = null;
            //string xVOApiKey = null;
            //string user = null;
            //decimal? daysForward = null;
            //decimal? daysSkip = null;
            //decimal? step = null;
            //var response = instance.ApiPublicV1UserUserOncallScheduleGet(xVOApiId, xVOApiKey, user, daysForward, daysSkip, step);
            //Assert.IsType<List<OnCallAndOverrides>> (response, "response is List<OnCallAndOverrides>");
        }
        
        /// <summary>
        /// Test ApiPublicV2TeamTeamOncallScheduleGet
        /// </summary>
        [Fact]
        public void ApiPublicV2TeamTeamOncallScheduleGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xVOApiId = null;
            //string xVOApiKey = null;
            //string team = null;
            //decimal? daysForward = null;
            //decimal? daysSkip = null;
            //decimal? step = null;
            //var response = instance.ApiPublicV2TeamTeamOncallScheduleGet(xVOApiId, xVOApiKey, team, daysForward, daysSkip, step);
            //Assert.IsType<TeamSchedule> (response, "response is TeamSchedule");
        }
        
        /// <summary>
        /// Test ApiPublicV2UserUserOncallScheduleGet
        /// </summary>
        [Fact]
        public void ApiPublicV2UserUserOncallScheduleGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xVOApiId = null;
            //string xVOApiKey = null;
            //string user = null;
            //decimal? daysForward = null;
            //decimal? daysSkip = null;
            //decimal? step = null;
            //var response = instance.ApiPublicV2UserUserOncallScheduleGet(xVOApiId, xVOApiKey, user, daysForward, daysSkip, step);
            //Assert.IsType<UserSchedule> (response, "response is UserSchedule");
        }
        
    }

}