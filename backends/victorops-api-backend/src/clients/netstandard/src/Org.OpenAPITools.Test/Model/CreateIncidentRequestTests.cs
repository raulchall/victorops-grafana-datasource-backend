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
    ///  Class for testing CreateIncidentRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CreateIncidentRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for CreateIncidentRequest
        //private CreateIncidentRequest instance;

        public CreateIncidentRequestTests()
        {
            // TODO uncomment below to create an instance of CreateIncidentRequest
            //instance = new CreateIncidentRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CreateIncidentRequest
        /// </summary>
        [Fact]
        public void CreateIncidentRequestInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" CreateIncidentRequest
            //Assert.IsInstanceOfType<CreateIncidentRequest> (instance, "variable 'instance' is a CreateIncidentRequest");
        }


        /// <summary>
        /// Test the property 'Summary'
        /// </summary>
        [Fact]
        public void SummaryTest()
        {
            // TODO unit test for the property 'Summary'
        }
        /// <summary>
        /// Test the property 'Details'
        /// </summary>
        [Fact]
        public void DetailsTest()
        {
            // TODO unit test for the property 'Details'
        }
        /// <summary>
        /// Test the property 'UserName'
        /// </summary>
        [Fact]
        public void UserNameTest()
        {
            // TODO unit test for the property 'UserName'
        }
        /// <summary>
        /// Test the property 'Targets'
        /// </summary>
        [Fact]
        public void TargetsTest()
        {
            // TODO unit test for the property 'Targets'
        }
        /// <summary>
        /// Test the property 'IsMultiResponder'
        /// </summary>
        [Fact]
        public void IsMultiResponderTest()
        {
            // TODO unit test for the property 'IsMultiResponder'
        }

    }

}
