/*
 * FINBOURNE Insights API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.288
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Finbourne.Insights.Sdk.Client;
using Finbourne.Insights.Sdk.Model;

namespace Finbourne.Insights.Sdk.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAccessEvaluationsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// [EXPERIMENTAL] GetAccessEvaluationLog: Get the log for a specific access evaluation.
        /// </summary>
        /// <exception cref="Finbourne.Insights.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the access evaluation to obtain the log for.</param>
        /// <returns>AccessEvaluationLog</returns>
        AccessEvaluationLog GetAccessEvaluationLog(string id);

        /// <summary>
        /// [EXPERIMENTAL] GetAccessEvaluationLog: Get the log for a specific access evaluation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Finbourne.Insights.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the access evaluation to obtain the log for.</param>
        /// <returns>ApiResponse of AccessEvaluationLog</returns>
        ApiResponse<AccessEvaluationLog> GetAccessEvaluationLogWithHttpInfo(string id);
        /// <summary>
        /// [EXPERIMENTAL] ListAccessEvaluationLogs: List the logs for access evaluations.
        /// </summary>
        /// <exception cref="Finbourne.Insights.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Expression to filter the result set. Read more about &lt;see href&#x3D;\&quot;https://support.lusid.com/filtering-results-from-lusid\&quot;&gt; filtering results from LUSID&lt;/see&gt;. (optional)</param>
        /// <param name="sortBy">Order the results by these fields. Use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName. Multiple fields can be denoted by a comma e.g. -MyFieldName,AnotherFieldName,-AFurtherFieldName (optional)</param>
        /// <param name="limit">When paginating, only return this number of records. The minimum value is 0 and the maximum is 10000. (optional)</param>
        /// <param name="page">Encoded page string returned from a previous search result that will retrieve the next page of data. When this field is supplied, filter and sortby fields should not be supplied. (optional)</param>
        /// <param name="histogramInterval">The interval for an included histogram of the logs (optional)</param>
        /// <returns>ResourceListWithHistogramOfAccessEvaluationLog</returns>
        ResourceListWithHistogramOfAccessEvaluationLog ListAccessEvaluationLogs(string filter = default(string), string sortBy = default(string), int? limit = default(int?), string page = default(string), string histogramInterval = default(string));

        /// <summary>
        /// [EXPERIMENTAL] ListAccessEvaluationLogs: List the logs for access evaluations.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Finbourne.Insights.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Expression to filter the result set. Read more about &lt;see href&#x3D;\&quot;https://support.lusid.com/filtering-results-from-lusid\&quot;&gt; filtering results from LUSID&lt;/see&gt;. (optional)</param>
        /// <param name="sortBy">Order the results by these fields. Use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName. Multiple fields can be denoted by a comma e.g. -MyFieldName,AnotherFieldName,-AFurtherFieldName (optional)</param>
        /// <param name="limit">When paginating, only return this number of records. The minimum value is 0 and the maximum is 10000. (optional)</param>
        /// <param name="page">Encoded page string returned from a previous search result that will retrieve the next page of data. When this field is supplied, filter and sortby fields should not be supplied. (optional)</param>
        /// <param name="histogramInterval">The interval for an included histogram of the logs (optional)</param>
        /// <returns>ApiResponse of ResourceListWithHistogramOfAccessEvaluationLog</returns>
        ApiResponse<ResourceListWithHistogramOfAccessEvaluationLog> ListAccessEvaluationLogsWithHttpInfo(string filter = default(string), string sortBy = default(string), int? limit = default(int?), string page = default(string), string histogramInterval = default(string));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAccessEvaluationsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// [EXPERIMENTAL] GetAccessEvaluationLog: Get the log for a specific access evaluation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Finbourne.Insights.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the access evaluation to obtain the log for.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AccessEvaluationLog</returns>
        System.Threading.Tasks.Task<AccessEvaluationLog> GetAccessEvaluationLogAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EXPERIMENTAL] GetAccessEvaluationLog: Get the log for a specific access evaluation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Finbourne.Insights.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the access evaluation to obtain the log for.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AccessEvaluationLog)</returns>
        System.Threading.Tasks.Task<ApiResponse<AccessEvaluationLog>> GetAccessEvaluationLogWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EXPERIMENTAL] ListAccessEvaluationLogs: List the logs for access evaluations.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Finbourne.Insights.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Expression to filter the result set. Read more about &lt;see href&#x3D;\&quot;https://support.lusid.com/filtering-results-from-lusid\&quot;&gt; filtering results from LUSID&lt;/see&gt;. (optional)</param>
        /// <param name="sortBy">Order the results by these fields. Use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName. Multiple fields can be denoted by a comma e.g. -MyFieldName,AnotherFieldName,-AFurtherFieldName (optional)</param>
        /// <param name="limit">When paginating, only return this number of records. The minimum value is 0 and the maximum is 10000. (optional)</param>
        /// <param name="page">Encoded page string returned from a previous search result that will retrieve the next page of data. When this field is supplied, filter and sortby fields should not be supplied. (optional)</param>
        /// <param name="histogramInterval">The interval for an included histogram of the logs (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ResourceListWithHistogramOfAccessEvaluationLog</returns>
        System.Threading.Tasks.Task<ResourceListWithHistogramOfAccessEvaluationLog> ListAccessEvaluationLogsAsync(string filter = default(string), string sortBy = default(string), int? limit = default(int?), string page = default(string), string histogramInterval = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EXPERIMENTAL] ListAccessEvaluationLogs: List the logs for access evaluations.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Finbourne.Insights.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Expression to filter the result set. Read more about &lt;see href&#x3D;\&quot;https://support.lusid.com/filtering-results-from-lusid\&quot;&gt; filtering results from LUSID&lt;/see&gt;. (optional)</param>
        /// <param name="sortBy">Order the results by these fields. Use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName. Multiple fields can be denoted by a comma e.g. -MyFieldName,AnotherFieldName,-AFurtherFieldName (optional)</param>
        /// <param name="limit">When paginating, only return this number of records. The minimum value is 0 and the maximum is 10000. (optional)</param>
        /// <param name="page">Encoded page string returned from a previous search result that will retrieve the next page of data. When this field is supplied, filter and sortby fields should not be supplied. (optional)</param>
        /// <param name="histogramInterval">The interval for an included histogram of the logs (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ResourceListWithHistogramOfAccessEvaluationLog)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResourceListWithHistogramOfAccessEvaluationLog>> ListAccessEvaluationLogsWithHttpInfoAsync(string filter = default(string), string sortBy = default(string), int? limit = default(int?), string page = default(string), string histogramInterval = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAccessEvaluationsApi : IAccessEvaluationsApiSync, IAccessEvaluationsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AccessEvaluationsApi : IAccessEvaluationsApi
    {
        private Finbourne.Insights.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessEvaluationsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AccessEvaluationsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessEvaluationsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AccessEvaluationsApi(String basePath)
        {
            this.Configuration = Finbourne.Insights.Sdk.Client.Configuration.MergeConfigurations(
                Finbourne.Insights.Sdk.Client.GlobalConfiguration.Instance,
                new Finbourne.Insights.Sdk.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Finbourne.Insights.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Finbourne.Insights.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Finbourne.Insights.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessEvaluationsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AccessEvaluationsApi(Finbourne.Insights.Sdk.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = configuration;
            this.Client = new Finbourne.Insights.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Finbourne.Insights.Sdk.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Finbourne.Insights.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessEvaluationsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AccessEvaluationsApi(Finbourne.Insights.Sdk.Client.ISynchronousClient client, Finbourne.Insights.Sdk.Client.IAsynchronousClient asyncClient, Finbourne.Insights.Sdk.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Finbourne.Insights.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Finbourne.Insights.Sdk.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Finbourne.Insights.Sdk.Client.ISynchronousClient Client { get; set; }

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
        public Finbourne.Insights.Sdk.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Finbourne.Insights.Sdk.Client.ExceptionFactory ExceptionFactory
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
        /// [EXPERIMENTAL] GetAccessEvaluationLog: Get the log for a specific access evaluation. 
        /// </summary>
        /// <exception cref="Finbourne.Insights.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the access evaluation to obtain the log for.</param>
        /// <returns>AccessEvaluationLog</returns>
        public AccessEvaluationLog GetAccessEvaluationLog(string id)
        {
            Finbourne.Insights.Sdk.Client.ApiResponse<AccessEvaluationLog> localVarResponse = GetAccessEvaluationLogWithHttpInfo(id);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EXPERIMENTAL] GetAccessEvaluationLog: Get the log for a specific access evaluation. 
        /// </summary>
        /// <exception cref="Finbourne.Insights.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the access evaluation to obtain the log for.</param>
        /// <returns>ApiResponse of AccessEvaluationLog</returns>
        public Finbourne.Insights.Sdk.Client.ApiResponse<AccessEvaluationLog> GetAccessEvaluationLogWithHttpInfo(string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new Finbourne.Insights.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling AccessEvaluationsApi->GetAccessEvaluationLog");

            Finbourne.Insights.Sdk.Client.RequestOptions localVarRequestOptions = new Finbourne.Insights.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Finbourne.Insights.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Finbourne.Insights.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Finbourne.Insights.Sdk.Client.ClientUtils.ParameterToString(id)); // path parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.0.288");

            // make the HTTP request
            var localVarResponse = this.Client.Get<AccessEvaluationLog>("/api/access/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetAccessEvaluationLog", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EXPERIMENTAL] GetAccessEvaluationLog: Get the log for a specific access evaluation. 
        /// </summary>
        /// <exception cref="Finbourne.Insights.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the access evaluation to obtain the log for.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AccessEvaluationLog</returns>
        public async System.Threading.Tasks.Task<AccessEvaluationLog> GetAccessEvaluationLogAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Finbourne.Insights.Sdk.Client.ApiResponse<AccessEvaluationLog> localVarResponse = await GetAccessEvaluationLogWithHttpInfoAsync(id, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EXPERIMENTAL] GetAccessEvaluationLog: Get the log for a specific access evaluation. 
        /// </summary>
        /// <exception cref="Finbourne.Insights.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The identifier of the access evaluation to obtain the log for.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AccessEvaluationLog)</returns>
        public async System.Threading.Tasks.Task<Finbourne.Insights.Sdk.Client.ApiResponse<AccessEvaluationLog>> GetAccessEvaluationLogWithHttpInfoAsync(string id, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new Finbourne.Insights.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling AccessEvaluationsApi->GetAccessEvaluationLog");


            Finbourne.Insights.Sdk.Client.RequestOptions localVarRequestOptions = new Finbourne.Insights.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };


            var localVarContentType = Finbourne.Insights.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Finbourne.Insights.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Finbourne.Insights.Sdk.Client.ClientUtils.ParameterToString(id)); // path parameter

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.0.288");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<AccessEvaluationLog>("/api/access/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetAccessEvaluationLog", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EXPERIMENTAL] ListAccessEvaluationLogs: List the logs for access evaluations. 
        /// </summary>
        /// <exception cref="Finbourne.Insights.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Expression to filter the result set. Read more about &lt;see href&#x3D;\&quot;https://support.lusid.com/filtering-results-from-lusid\&quot;&gt; filtering results from LUSID&lt;/see&gt;. (optional)</param>
        /// <param name="sortBy">Order the results by these fields. Use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName. Multiple fields can be denoted by a comma e.g. -MyFieldName,AnotherFieldName,-AFurtherFieldName (optional)</param>
        /// <param name="limit">When paginating, only return this number of records. The minimum value is 0 and the maximum is 10000. (optional)</param>
        /// <param name="page">Encoded page string returned from a previous search result that will retrieve the next page of data. When this field is supplied, filter and sortby fields should not be supplied. (optional)</param>
        /// <param name="histogramInterval">The interval for an included histogram of the logs (optional)</param>
        /// <returns>ResourceListWithHistogramOfAccessEvaluationLog</returns>
        public ResourceListWithHistogramOfAccessEvaluationLog ListAccessEvaluationLogs(string filter = default(string), string sortBy = default(string), int? limit = default(int?), string page = default(string), string histogramInterval = default(string))
        {
            Finbourne.Insights.Sdk.Client.ApiResponse<ResourceListWithHistogramOfAccessEvaluationLog> localVarResponse = ListAccessEvaluationLogsWithHttpInfo(filter, sortBy, limit, page, histogramInterval);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EXPERIMENTAL] ListAccessEvaluationLogs: List the logs for access evaluations. 
        /// </summary>
        /// <exception cref="Finbourne.Insights.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Expression to filter the result set. Read more about &lt;see href&#x3D;\&quot;https://support.lusid.com/filtering-results-from-lusid\&quot;&gt; filtering results from LUSID&lt;/see&gt;. (optional)</param>
        /// <param name="sortBy">Order the results by these fields. Use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName. Multiple fields can be denoted by a comma e.g. -MyFieldName,AnotherFieldName,-AFurtherFieldName (optional)</param>
        /// <param name="limit">When paginating, only return this number of records. The minimum value is 0 and the maximum is 10000. (optional)</param>
        /// <param name="page">Encoded page string returned from a previous search result that will retrieve the next page of data. When this field is supplied, filter and sortby fields should not be supplied. (optional)</param>
        /// <param name="histogramInterval">The interval for an included histogram of the logs (optional)</param>
        /// <returns>ApiResponse of ResourceListWithHistogramOfAccessEvaluationLog</returns>
        public Finbourne.Insights.Sdk.Client.ApiResponse<ResourceListWithHistogramOfAccessEvaluationLog> ListAccessEvaluationLogsWithHttpInfo(string filter = default(string), string sortBy = default(string), int? limit = default(int?), string page = default(string), string histogramInterval = default(string))
        {
            Finbourne.Insights.Sdk.Client.RequestOptions localVarRequestOptions = new Finbourne.Insights.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Finbourne.Insights.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Finbourne.Insights.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (filter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Insights.Sdk.Client.ClientUtils.ParameterToMultiMap("", "filter", filter));
            }
            if (sortBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Insights.Sdk.Client.ClientUtils.ParameterToMultiMap("", "sortBy", sortBy));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Insights.Sdk.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }
            if (page != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Insights.Sdk.Client.ClientUtils.ParameterToMultiMap("", "page", page));
            }
            if (histogramInterval != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Insights.Sdk.Client.ClientUtils.ParameterToMultiMap("", "histogramInterval", histogramInterval));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.0.288");

            // make the HTTP request
            var localVarResponse = this.Client.Get<ResourceListWithHistogramOfAccessEvaluationLog>("/api/access", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListAccessEvaluationLogs", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EXPERIMENTAL] ListAccessEvaluationLogs: List the logs for access evaluations. 
        /// </summary>
        /// <exception cref="Finbourne.Insights.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Expression to filter the result set. Read more about &lt;see href&#x3D;\&quot;https://support.lusid.com/filtering-results-from-lusid\&quot;&gt; filtering results from LUSID&lt;/see&gt;. (optional)</param>
        /// <param name="sortBy">Order the results by these fields. Use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName. Multiple fields can be denoted by a comma e.g. -MyFieldName,AnotherFieldName,-AFurtherFieldName (optional)</param>
        /// <param name="limit">When paginating, only return this number of records. The minimum value is 0 and the maximum is 10000. (optional)</param>
        /// <param name="page">Encoded page string returned from a previous search result that will retrieve the next page of data. When this field is supplied, filter and sortby fields should not be supplied. (optional)</param>
        /// <param name="histogramInterval">The interval for an included histogram of the logs (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ResourceListWithHistogramOfAccessEvaluationLog</returns>
        public async System.Threading.Tasks.Task<ResourceListWithHistogramOfAccessEvaluationLog> ListAccessEvaluationLogsAsync(string filter = default(string), string sortBy = default(string), int? limit = default(int?), string page = default(string), string histogramInterval = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Finbourne.Insights.Sdk.Client.ApiResponse<ResourceListWithHistogramOfAccessEvaluationLog> localVarResponse = await ListAccessEvaluationLogsWithHttpInfoAsync(filter, sortBy, limit, page, histogramInterval, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EXPERIMENTAL] ListAccessEvaluationLogs: List the logs for access evaluations. 
        /// </summary>
        /// <exception cref="Finbourne.Insights.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">Expression to filter the result set. Read more about &lt;see href&#x3D;\&quot;https://support.lusid.com/filtering-results-from-lusid\&quot;&gt; filtering results from LUSID&lt;/see&gt;. (optional)</param>
        /// <param name="sortBy">Order the results by these fields. Use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName. Multiple fields can be denoted by a comma e.g. -MyFieldName,AnotherFieldName,-AFurtherFieldName (optional)</param>
        /// <param name="limit">When paginating, only return this number of records. The minimum value is 0 and the maximum is 10000. (optional)</param>
        /// <param name="page">Encoded page string returned from a previous search result that will retrieve the next page of data. When this field is supplied, filter and sortby fields should not be supplied. (optional)</param>
        /// <param name="histogramInterval">The interval for an included histogram of the logs (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ResourceListWithHistogramOfAccessEvaluationLog)</returns>
        public async System.Threading.Tasks.Task<Finbourne.Insights.Sdk.Client.ApiResponse<ResourceListWithHistogramOfAccessEvaluationLog>> ListAccessEvaluationLogsWithHttpInfoAsync(string filter = default(string), string sortBy = default(string), int? limit = default(int?), string page = default(string), string histogramInterval = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Finbourne.Insights.Sdk.Client.RequestOptions localVarRequestOptions = new Finbourne.Insights.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };


            var localVarContentType = Finbourne.Insights.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Finbourne.Insights.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (filter != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Insights.Sdk.Client.ClientUtils.ParameterToMultiMap("", "filter", filter));
            }
            if (sortBy != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Insights.Sdk.Client.ClientUtils.ParameterToMultiMap("", "sortBy", sortBy));
            }
            if (limit != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Insights.Sdk.Client.ClientUtils.ParameterToMultiMap("", "limit", limit));
            }
            if (page != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Insights.Sdk.Client.ClientUtils.ParameterToMultiMap("", "page", page));
            }
            if (histogramInterval != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Insights.Sdk.Client.ClientUtils.ParameterToMultiMap("", "histogramInterval", histogramInterval));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.0.288");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<ResourceListWithHistogramOfAccessEvaluationLog>("/api/access", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListAccessEvaluationLogs", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}