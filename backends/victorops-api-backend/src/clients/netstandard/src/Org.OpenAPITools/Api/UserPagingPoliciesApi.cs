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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUserPagingPoliciesApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get a list of paging policies for a user
        /// </summary>
        /// <remarks>
        /// Get paging policies for a user  This API may be called a maximum of 60 times per minute. 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xVOApiId">Your API ID</param>
        /// <param name="xVOApiKey">Your API Key</param>
        /// <param name="user">The VictorOps user ID</param>
        /// <returns>Policies</returns>
        Policies ApiPublicV1UserUserPoliciesGet (string xVOApiId, string xVOApiKey, string user);

        /// <summary>
        /// Get a list of paging policies for a user
        /// </summary>
        /// <remarks>
        /// Get paging policies for a user  This API may be called a maximum of 60 times per minute. 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xVOApiId">Your API ID</param>
        /// <param name="xVOApiKey">Your API Key</param>
        /// <param name="user">The VictorOps user ID</param>
        /// <returns>ApiResponse of Policies</returns>
        ApiResponse<Policies> ApiPublicV1UserUserPoliciesGetWithHttpInfo (string xVOApiId, string xVOApiKey, string user);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUserPagingPoliciesApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get a list of paging policies for a user
        /// </summary>
        /// <remarks>
        /// Get paging policies for a user  This API may be called a maximum of 60 times per minute. 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xVOApiId">Your API ID</param>
        /// <param name="xVOApiKey">Your API Key</param>
        /// <param name="user">The VictorOps user ID</param>
        /// <returns>Task of Policies</returns>
        System.Threading.Tasks.Task<Policies> ApiPublicV1UserUserPoliciesGetAsync (string xVOApiId, string xVOApiKey, string user);

        /// <summary>
        /// Get a list of paging policies for a user
        /// </summary>
        /// <remarks>
        /// Get paging policies for a user  This API may be called a maximum of 60 times per minute. 
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xVOApiId">Your API ID</param>
        /// <param name="xVOApiKey">Your API Key</param>
        /// <param name="user">The VictorOps user ID</param>
        /// <returns>Task of ApiResponse (Policies)</returns>
        System.Threading.Tasks.Task<ApiResponse<Policies>> ApiPublicV1UserUserPoliciesGetAsyncWithHttpInfo (string xVOApiId, string xVOApiKey, string user);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUserPagingPoliciesApi : IUserPagingPoliciesApiSync, IUserPagingPoliciesApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class UserPagingPoliciesApi : IUserPagingPoliciesApi
    {
        private Org.OpenAPITools.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserPagingPoliciesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserPagingPoliciesApi() : this((string) null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserPagingPoliciesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserPagingPoliciesApi(String basePath)
        {
            this.Configuration = Org.OpenAPITools.Client.Configuration.MergeConfigurations(
                Org.OpenAPITools.Client.GlobalConfiguration.Instance,
                new Org.OpenAPITools.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserPagingPoliciesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UserPagingPoliciesApi(Org.OpenAPITools.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Org.OpenAPITools.Client.Configuration.MergeConfigurations(
                Org.OpenAPITools.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserPagingPoliciesApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public UserPagingPoliciesApi(Org.OpenAPITools.Client.ISynchronousClient client,Org.OpenAPITools.Client.IAsynchronousClient asyncClient, Org.OpenAPITools.Client.IReadableConfiguration configuration)
        {
            if(client == null) throw new ArgumentNullException("client");
            if(asyncClient == null) throw new ArgumentNullException("asyncClient");
            if(configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Org.OpenAPITools.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Org.OpenAPITools.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Org.OpenAPITools.Client.IReadableConfiguration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Org.OpenAPITools.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Get a list of paging policies for a user Get paging policies for a user  This API may be called a maximum of 60 times per minute. 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xVOApiId">Your API ID</param>
        /// <param name="xVOApiKey">Your API Key</param>
        /// <param name="user">The VictorOps user ID</param>
        /// <returns>Policies</returns>
        public Policies ApiPublicV1UserUserPoliciesGet (string xVOApiId, string xVOApiKey, string user)
        {
             Org.OpenAPITools.Client.ApiResponse<Policies> localVarResponse = ApiPublicV1UserUserPoliciesGetWithHttpInfo(xVOApiId, xVOApiKey, user);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of paging policies for a user Get paging policies for a user  This API may be called a maximum of 60 times per minute. 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xVOApiId">Your API ID</param>
        /// <param name="xVOApiKey">Your API Key</param>
        /// <param name="user">The VictorOps user ID</param>
        /// <returns>ApiResponse of Policies</returns>
        public Org.OpenAPITools.Client.ApiResponse< Policies > ApiPublicV1UserUserPoliciesGetWithHttpInfo (string xVOApiId, string xVOApiKey, string user)
        {
            // verify the required parameter 'xVOApiId' is set
            if (xVOApiId == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'xVOApiId' when calling UserPagingPoliciesApi->ApiPublicV1UserUserPoliciesGet");

            // verify the required parameter 'xVOApiKey' is set
            if (xVOApiKey == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'xVOApiKey' when calling UserPagingPoliciesApi->ApiPublicV1UserUserPoliciesGet");

            // verify the required parameter 'user' is set
            if (user == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'user' when calling UserPagingPoliciesApi->ApiPublicV1UserUserPoliciesGet");

            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (user != null)
                localVarRequestOptions.PathParameters.Add("user", Org.OpenAPITools.Client.ClientUtils.ParameterToString(user)); // path parameter
            if (xVOApiId != null)
                localVarRequestOptions.HeaderParameters.Add("X-VO-Api-Id", Org.OpenAPITools.Client.ClientUtils.ParameterToString(xVOApiId)); // header parameter
            if (xVOApiKey != null)
                localVarRequestOptions.HeaderParameters.Add("X-VO-Api-Key", Org.OpenAPITools.Client.ClientUtils.ParameterToString(xVOApiKey)); // header parameter


            // make the HTTP request
            var localVarResponse = this.Client.Get< Policies >("/api-public/v1/user/{user}/policies", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiPublicV1UserUserPoliciesGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get a list of paging policies for a user Get paging policies for a user  This API may be called a maximum of 60 times per minute. 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xVOApiId">Your API ID</param>
        /// <param name="xVOApiKey">Your API Key</param>
        /// <param name="user">The VictorOps user ID</param>
        /// <returns>Task of Policies</returns>
        public async System.Threading.Tasks.Task<Policies> ApiPublicV1UserUserPoliciesGetAsync (string xVOApiId, string xVOApiKey, string user)
        {
             Org.OpenAPITools.Client.ApiResponse<Policies> localVarResponse = await ApiPublicV1UserUserPoliciesGetAsyncWithHttpInfo(xVOApiId, xVOApiKey, user);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of paging policies for a user Get paging policies for a user  This API may be called a maximum of 60 times per minute. 
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xVOApiId">Your API ID</param>
        /// <param name="xVOApiKey">Your API Key</param>
        /// <param name="user">The VictorOps user ID</param>
        /// <returns>Task of ApiResponse (Policies)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<Policies>> ApiPublicV1UserUserPoliciesGetAsyncWithHttpInfo (string xVOApiId, string xVOApiKey, string user)
        {
            // verify the required parameter 'xVOApiId' is set
            if (xVOApiId == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'xVOApiId' when calling UserPagingPoliciesApi->ApiPublicV1UserUserPoliciesGet");

            // verify the required parameter 'xVOApiKey' is set
            if (xVOApiKey == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'xVOApiKey' when calling UserPagingPoliciesApi->ApiPublicV1UserUserPoliciesGet");

            // verify the required parameter 'user' is set
            if (user == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'user' when calling UserPagingPoliciesApi->ApiPublicV1UserUserPoliciesGet");


            Org.OpenAPITools.Client.RequestOptions localVarRequestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };
            
            foreach (var _contentType in _contentTypes)
                localVarRequestOptions.HeaderParameters.Add("Content-Type", _contentType);
            
            foreach (var _accept in _accepts)
                localVarRequestOptions.HeaderParameters.Add("Accept", _accept);
            
            if (user != null)
                localVarRequestOptions.PathParameters.Add("user", Org.OpenAPITools.Client.ClientUtils.ParameterToString(user)); // path parameter
            if (xVOApiId != null)
                localVarRequestOptions.HeaderParameters.Add("X-VO-Api-Id", Org.OpenAPITools.Client.ClientUtils.ParameterToString(xVOApiId)); // header parameter
            if (xVOApiKey != null)
                localVarRequestOptions.HeaderParameters.Add("X-VO-Api-Key", Org.OpenAPITools.Client.ClientUtils.ParameterToString(xVOApiKey)); // header parameter


            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<Policies>("/api-public/v1/user/{user}/policies", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ApiPublicV1UserUserPoliciesGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
