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
    ///  Class for testing ReportingApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ReportingApiTests : IDisposable
    {
        private ReportingApi instance;

        public ReportingApiTests()
        {
            instance = new ReportingApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ReportingApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ReportingApi
            //Assert.IsType(typeof(ReportingApi), instance, "instance is a ReportingApi");
        }

        
        /// <summary>
        /// Test ApiReportingV1IncidentsGet
        /// </summary>
        [Fact]
        public void ApiReportingV1IncidentsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xVOApiId = null;
            //string xVOApiKey = null;
            //decimal? offset = null;
            //decimal? limit = null;
            //string entityId = null;
            //string incidentNumber = null;
            //string startedAfter = null;
            //string startedBefore = null;
            //string host = null;
            //string service = null;
            //string currentPhase = null;
            //var response = instance.ApiReportingV1IncidentsGet(xVOApiId, xVOApiKey, offset, limit, entityId, incidentNumber, startedAfter, startedBefore, host, service, currentPhase);
            //Assert.IsType<List<IncidentList>> (response, "response is List<IncidentList>");
        }
        
        /// <summary>
        /// Test ApiReportingV1TeamTeamOncallLogGet
        /// </summary>
        [Fact]
        public void ApiReportingV1TeamTeamOncallLogGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xVOApiId = null;
            //string xVOApiKey = null;
            //string team = null;
            //DateTime? start = null;
            //DateTime? end = null;
            //string userName = null;
            //var response = instance.ApiReportingV1TeamTeamOncallLogGet(xVOApiId, xVOApiKey, team, start, end, userName);
            //Assert.IsType<OnCallLog> (response, "response is OnCallLog");
        }
        
        /// <summary>
        /// Test ApiReportingV2IncidentsGet
        /// </summary>
        [Fact]
        public void ApiReportingV2IncidentsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xVOApiId = null;
            //string xVOApiKey = null;
            //decimal? offset = null;
            //decimal? limit = null;
            //string entityId = null;
            //string incidentNumber = null;
            //string startedAfter = null;
            //string startedBefore = null;
            //string host = null;
            //string service = null;
            //string currentPhase = null;
            //string routingKey = null;
            //var response = instance.ApiReportingV2IncidentsGet(xVOApiId, xVOApiKey, offset, limit, entityId, incidentNumber, startedAfter, startedBefore, host, service, currentPhase, routingKey);
            //Assert.IsType<ActiveIncidentList> (response, "response is ActiveIncidentList");
        }
        
    }

}