/*
 * FINBOURNE Insights API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.499
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
    public interface IAuditingApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// [EARLY ACCESS] CreateEntry: Create (persist) and audit entry..
        /// </summary>
        /// <exception cref="Finbourne.Insights.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createAuditEntry">Information about the entry to be created. (optional)</param>
        /// <returns>AuditEntry</returns>
        AuditEntry CreateEntry(CreateAuditEntry createAuditEntry = default(CreateAuditEntry));

        /// <summary>
        /// [EARLY ACCESS] CreateEntry: Create (persist) and audit entry..
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Finbourne.Insights.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createAuditEntry">Information about the entry to be created. (optional)</param>
        /// <returns>ApiResponse of AuditEntry</returns>
        ApiResponse<AuditEntry> CreateEntryWithHttpInfo(CreateAuditEntry createAuditEntry = default(CreateAuditEntry));
        /// <summary>
        /// [EARLY ACCESS] GetProcesses: Get the latest audit entry for each process.
        /// </summary>
        /// <remarks>
        /// This will never be &#x60;null&#x60;, though it may be empty.
        /// </remarks>
        /// <exception cref="Finbourne.Insights.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ResourceListOfAuditProcessSummary</returns>
        ResourceListOfAuditProcessSummary GetProcesses();

        /// <summary>
        /// [EARLY ACCESS] GetProcesses: Get the latest audit entry for each process.
        /// </summary>
        /// <remarks>
        /// This will never be &#x60;null&#x60;, though it may be empty.
        /// </remarks>
        /// <exception cref="Finbourne.Insights.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ResourceListOfAuditProcessSummary</returns>
        ApiResponse<ResourceListOfAuditProcessSummary> GetProcessesWithHttpInfo();
        /// <summary>
        /// [EARLY ACCESS] ListEntries: Get the audit entries.
        /// </summary>
        /// <remarks>
        /// This will never be &#x60;null&#x60;, though it may be empty.
        /// </remarks>
        /// <exception cref="Finbourne.Insights.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">The filter to be applied to the results. (optional)</param>
        /// <param name="sortBy">The order to return the entries in. (optional)</param>
        /// <param name="size">The maximum number of entries to return. (optional, default to 1000)</param>
        /// <param name="state">The scrolling state, used to iterate through the data set. (optional)</param>
        /// <returns>ScrollableCollectionOfAuditEntry</returns>
        ScrollableCollectionOfAuditEntry ListEntries(string filter = default(string), string sortBy = default(string), int? size = default(int?), string state = default(string));

        /// <summary>
        /// [EARLY ACCESS] ListEntries: Get the audit entries.
        /// </summary>
        /// <remarks>
        /// This will never be &#x60;null&#x60;, though it may be empty.
        /// </remarks>
        /// <exception cref="Finbourne.Insights.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">The filter to be applied to the results. (optional)</param>
        /// <param name="sortBy">The order to return the entries in. (optional)</param>
        /// <param name="size">The maximum number of entries to return. (optional, default to 1000)</param>
        /// <param name="state">The scrolling state, used to iterate through the data set. (optional)</param>
        /// <returns>ApiResponse of ScrollableCollectionOfAuditEntry</returns>
        ApiResponse<ScrollableCollectionOfAuditEntry> ListEntriesWithHttpInfo(string filter = default(string), string sortBy = default(string), int? size = default(int?), string state = default(string));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuditingApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// [EARLY ACCESS] CreateEntry: Create (persist) and audit entry..
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Finbourne.Insights.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createAuditEntry">Information about the entry to be created. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AuditEntry</returns>
        System.Threading.Tasks.Task<AuditEntry> CreateEntryAsync(CreateAuditEntry createAuditEntry = default(CreateAuditEntry), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] CreateEntry: Create (persist) and audit entry..
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Finbourne.Insights.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createAuditEntry">Information about the entry to be created. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AuditEntry)</returns>
        System.Threading.Tasks.Task<ApiResponse<AuditEntry>> CreateEntryWithHttpInfoAsync(CreateAuditEntry createAuditEntry = default(CreateAuditEntry), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] GetProcesses: Get the latest audit entry for each process.
        /// </summary>
        /// <remarks>
        /// This will never be &#x60;null&#x60;, though it may be empty.
        /// </remarks>
        /// <exception cref="Finbourne.Insights.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ResourceListOfAuditProcessSummary</returns>
        System.Threading.Tasks.Task<ResourceListOfAuditProcessSummary> GetProcessesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] GetProcesses: Get the latest audit entry for each process.
        /// </summary>
        /// <remarks>
        /// This will never be &#x60;null&#x60;, though it may be empty.
        /// </remarks>
        /// <exception cref="Finbourne.Insights.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ResourceListOfAuditProcessSummary)</returns>
        System.Threading.Tasks.Task<ApiResponse<ResourceListOfAuditProcessSummary>> GetProcessesWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EARLY ACCESS] ListEntries: Get the audit entries.
        /// </summary>
        /// <remarks>
        /// This will never be &#x60;null&#x60;, though it may be empty.
        /// </remarks>
        /// <exception cref="Finbourne.Insights.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">The filter to be applied to the results. (optional)</param>
        /// <param name="sortBy">The order to return the entries in. (optional)</param>
        /// <param name="size">The maximum number of entries to return. (optional, default to 1000)</param>
        /// <param name="state">The scrolling state, used to iterate through the data set. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ScrollableCollectionOfAuditEntry</returns>
        System.Threading.Tasks.Task<ScrollableCollectionOfAuditEntry> ListEntriesAsync(string filter = default(string), string sortBy = default(string), int? size = default(int?), string state = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EARLY ACCESS] ListEntries: Get the audit entries.
        /// </summary>
        /// <remarks>
        /// This will never be &#x60;null&#x60;, though it may be empty.
        /// </remarks>
        /// <exception cref="Finbourne.Insights.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">The filter to be applied to the results. (optional)</param>
        /// <param name="sortBy">The order to return the entries in. (optional)</param>
        /// <param name="size">The maximum number of entries to return. (optional, default to 1000)</param>
        /// <param name="state">The scrolling state, used to iterate through the data set. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ScrollableCollectionOfAuditEntry)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScrollableCollectionOfAuditEntry>> ListEntriesWithHttpInfoAsync(string filter = default(string), string sortBy = default(string), int? size = default(int?), string state = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuditingApi : IAuditingApiSync, IAuditingApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AuditingApi : IAuditingApi
    {
        private Finbourne.Insights.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuditingApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuditingApi(String basePath)
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
        /// Initializes a new instance of the <see cref="AuditingApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AuditingApi(Finbourne.Insights.Sdk.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = configuration;
            this.Client = new Finbourne.Insights.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Finbourne.Insights.Sdk.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Finbourne.Insights.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditingApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AuditingApi(Finbourne.Insights.Sdk.Client.ISynchronousClient client, Finbourne.Insights.Sdk.Client.IAsynchronousClient asyncClient, Finbourne.Insights.Sdk.Client.IReadableConfiguration configuration)
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
        /// [EARLY ACCESS] CreateEntry: Create (persist) and audit entry.. 
        /// </summary>
        /// <exception cref="Finbourne.Insights.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createAuditEntry">Information about the entry to be created. (optional)</param>
        /// <returns>AuditEntry</returns>
        public AuditEntry CreateEntry(CreateAuditEntry createAuditEntry = default(CreateAuditEntry))
        {
            Finbourne.Insights.Sdk.Client.ApiResponse<AuditEntry> localVarResponse = CreateEntryWithHttpInfo(createAuditEntry);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] CreateEntry: Create (persist) and audit entry.. 
        /// </summary>
        /// <exception cref="Finbourne.Insights.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createAuditEntry">Information about the entry to be created. (optional)</param>
        /// <returns>ApiResponse of AuditEntry</returns>
        public Finbourne.Insights.Sdk.Client.ApiResponse<AuditEntry> CreateEntryWithHttpInfo(CreateAuditEntry createAuditEntry = default(CreateAuditEntry))
        {
            Finbourne.Insights.Sdk.Client.RequestOptions localVarRequestOptions = new Finbourne.Insights.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json",
                "application/json-patch+json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Finbourne.Insights.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Finbourne.Insights.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = createAuditEntry;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.0.499");

            // make the HTTP request
            var localVarResponse = this.Client.Post<AuditEntry>("/api/auditing/entries", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateEntry", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] CreateEntry: Create (persist) and audit entry.. 
        /// </summary>
        /// <exception cref="Finbourne.Insights.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createAuditEntry">Information about the entry to be created. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AuditEntry</returns>
        public async System.Threading.Tasks.Task<AuditEntry> CreateEntryAsync(CreateAuditEntry createAuditEntry = default(CreateAuditEntry), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Finbourne.Insights.Sdk.Client.ApiResponse<AuditEntry> localVarResponse = await CreateEntryWithHttpInfoAsync(createAuditEntry, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] CreateEntry: Create (persist) and audit entry.. 
        /// </summary>
        /// <exception cref="Finbourne.Insights.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createAuditEntry">Information about the entry to be created. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AuditEntry)</returns>
        public async System.Threading.Tasks.Task<Finbourne.Insights.Sdk.Client.ApiResponse<AuditEntry>> CreateEntryWithHttpInfoAsync(CreateAuditEntry createAuditEntry = default(CreateAuditEntry), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Finbourne.Insights.Sdk.Client.RequestOptions localVarRequestOptions = new Finbourne.Insights.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json", 
                "application/json-patch+json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = Finbourne.Insights.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Finbourne.Insights.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = createAuditEntry;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.0.499");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<AuditEntry>("/api/auditing/entries", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateEntry", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] GetProcesses: Get the latest audit entry for each process. This will never be &#x60;null&#x60;, though it may be empty.
        /// </summary>
        /// <exception cref="Finbourne.Insights.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ResourceListOfAuditProcessSummary</returns>
        public ResourceListOfAuditProcessSummary GetProcesses()
        {
            Finbourne.Insights.Sdk.Client.ApiResponse<ResourceListOfAuditProcessSummary> localVarResponse = GetProcessesWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] GetProcesses: Get the latest audit entry for each process. This will never be &#x60;null&#x60;, though it may be empty.
        /// </summary>
        /// <exception cref="Finbourne.Insights.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of ResourceListOfAuditProcessSummary</returns>
        public Finbourne.Insights.Sdk.Client.ApiResponse<ResourceListOfAuditProcessSummary> GetProcessesWithHttpInfo()
        {
            Finbourne.Insights.Sdk.Client.RequestOptions localVarRequestOptions = new Finbourne.Insights.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Finbourne.Insights.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Finbourne.Insights.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.0.499");

            // make the HTTP request
            var localVarResponse = this.Client.Get<ResourceListOfAuditProcessSummary>("/api/auditing/processes", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetProcesses", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] GetProcesses: Get the latest audit entry for each process. This will never be &#x60;null&#x60;, though it may be empty.
        /// </summary>
        /// <exception cref="Finbourne.Insights.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ResourceListOfAuditProcessSummary</returns>
        public async System.Threading.Tasks.Task<ResourceListOfAuditProcessSummary> GetProcessesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Finbourne.Insights.Sdk.Client.ApiResponse<ResourceListOfAuditProcessSummary> localVarResponse = await GetProcessesWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] GetProcesses: Get the latest audit entry for each process. This will never be &#x60;null&#x60;, though it may be empty.
        /// </summary>
        /// <exception cref="Finbourne.Insights.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ResourceListOfAuditProcessSummary)</returns>
        public async System.Threading.Tasks.Task<Finbourne.Insights.Sdk.Client.ApiResponse<ResourceListOfAuditProcessSummary>> GetProcessesWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Finbourne.Insights.Sdk.Client.RequestOptions localVarRequestOptions = new Finbourne.Insights.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = Finbourne.Insights.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Finbourne.Insights.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.0.499");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<ResourceListOfAuditProcessSummary>("/api/auditing/processes", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetProcesses", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] ListEntries: Get the audit entries. This will never be &#x60;null&#x60;, though it may be empty.
        /// </summary>
        /// <exception cref="Finbourne.Insights.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">The filter to be applied to the results. (optional)</param>
        /// <param name="sortBy">The order to return the entries in. (optional)</param>
        /// <param name="size">The maximum number of entries to return. (optional, default to 1000)</param>
        /// <param name="state">The scrolling state, used to iterate through the data set. (optional)</param>
        /// <returns>ScrollableCollectionOfAuditEntry</returns>
        public ScrollableCollectionOfAuditEntry ListEntries(string filter = default(string), string sortBy = default(string), int? size = default(int?), string state = default(string))
        {
            Finbourne.Insights.Sdk.Client.ApiResponse<ScrollableCollectionOfAuditEntry> localVarResponse = ListEntriesWithHttpInfo(filter, sortBy, size, state);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] ListEntries: Get the audit entries. This will never be &#x60;null&#x60;, though it may be empty.
        /// </summary>
        /// <exception cref="Finbourne.Insights.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">The filter to be applied to the results. (optional)</param>
        /// <param name="sortBy">The order to return the entries in. (optional)</param>
        /// <param name="size">The maximum number of entries to return. (optional, default to 1000)</param>
        /// <param name="state">The scrolling state, used to iterate through the data set. (optional)</param>
        /// <returns>ApiResponse of ScrollableCollectionOfAuditEntry</returns>
        public Finbourne.Insights.Sdk.Client.ApiResponse<ScrollableCollectionOfAuditEntry> ListEntriesWithHttpInfo(string filter = default(string), string sortBy = default(string), int? size = default(int?), string state = default(string))
        {
            Finbourne.Insights.Sdk.Client.RequestOptions localVarRequestOptions = new Finbourne.Insights.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
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
            if (size != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Insights.Sdk.Client.ClientUtils.ParameterToMultiMap("", "size", size));
            }
            if (state != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Insights.Sdk.Client.ClientUtils.ParameterToMultiMap("", "state", state));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.0.499");

            // make the HTTP request
            var localVarResponse = this.Client.Get<ScrollableCollectionOfAuditEntry>("/api/auditing/entries", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListEntries", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EARLY ACCESS] ListEntries: Get the audit entries. This will never be &#x60;null&#x60;, though it may be empty.
        /// </summary>
        /// <exception cref="Finbourne.Insights.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">The filter to be applied to the results. (optional)</param>
        /// <param name="sortBy">The order to return the entries in. (optional)</param>
        /// <param name="size">The maximum number of entries to return. (optional, default to 1000)</param>
        /// <param name="state">The scrolling state, used to iterate through the data set. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ScrollableCollectionOfAuditEntry</returns>
        public async System.Threading.Tasks.Task<ScrollableCollectionOfAuditEntry> ListEntriesAsync(string filter = default(string), string sortBy = default(string), int? size = default(int?), string state = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Finbourne.Insights.Sdk.Client.ApiResponse<ScrollableCollectionOfAuditEntry> localVarResponse = await ListEntriesWithHttpInfoAsync(filter, sortBy, size, state, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EARLY ACCESS] ListEntries: Get the audit entries. This will never be &#x60;null&#x60;, though it may be empty.
        /// </summary>
        /// <exception cref="Finbourne.Insights.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filter">The filter to be applied to the results. (optional)</param>
        /// <param name="sortBy">The order to return the entries in. (optional)</param>
        /// <param name="size">The maximum number of entries to return. (optional, default to 1000)</param>
        /// <param name="state">The scrolling state, used to iterate through the data set. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (ScrollableCollectionOfAuditEntry)</returns>
        public async System.Threading.Tasks.Task<Finbourne.Insights.Sdk.Client.ApiResponse<ScrollableCollectionOfAuditEntry>> ListEntriesWithHttpInfoAsync(string filter = default(string), string sortBy = default(string), int? size = default(int?), string state = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Finbourne.Insights.Sdk.Client.RequestOptions localVarRequestOptions = new Finbourne.Insights.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
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
            if (size != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Insights.Sdk.Client.ClientUtils.ParameterToMultiMap("", "size", size));
            }
            if (state != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Insights.Sdk.Client.ClientUtils.ParameterToMultiMap("", "state", state));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.0.499");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<ScrollableCollectionOfAuditEntry>("/api/auditing/entries", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListEntries", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}