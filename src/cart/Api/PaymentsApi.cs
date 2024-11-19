/*
 * Cart Service
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: info@gemini-commerce.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using cart.Client;
using cart.Client.Auth;
using cart.Model;

namespace cart.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPaymentsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// List Payment Methods
        /// </summary>
        /// <remarks>
        /// List payment methods
        /// </remarks>
        /// <exception cref="cart.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>CartListPaymentMethodsResponse</returns>
        CartListPaymentMethodsResponse ListPaymentMethods(CartListPaymentMethodsRequest body, int operationIndex = 0);

        /// <summary>
        /// List Payment Methods
        /// </summary>
        /// <remarks>
        /// List payment methods
        /// </remarks>
        /// <exception cref="cart.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of CartListPaymentMethodsResponse</returns>
        ApiResponse<CartListPaymentMethodsResponse> ListPaymentMethodsWithHttpInfo(CartListPaymentMethodsRequest body, int operationIndex = 0);
        /// <summary>
        /// Set SetPayments
        /// </summary>
        /// <remarks>
        /// Set SetPayments
        /// </remarks>
        /// <exception cref="cart.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>CartSetPaymentsResponse</returns>
        CartSetPaymentsResponse SetSetPayments(CartSetPaymentsRequest body, int operationIndex = 0);

        /// <summary>
        /// Set SetPayments
        /// </summary>
        /// <remarks>
        /// Set SetPayments
        /// </remarks>
        /// <exception cref="cart.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of CartSetPaymentsResponse</returns>
        ApiResponse<CartSetPaymentsResponse> SetSetPaymentsWithHttpInfo(CartSetPaymentsRequest body, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPaymentsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// List Payment Methods
        /// </summary>
        /// <remarks>
        /// List payment methods
        /// </remarks>
        /// <exception cref="cart.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CartListPaymentMethodsResponse</returns>
        System.Threading.Tasks.Task<CartListPaymentMethodsResponse> ListPaymentMethodsAsync(CartListPaymentMethodsRequest body, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));

        /// <summary>
        /// List Payment Methods
        /// </summary>
        /// <remarks>
        /// List payment methods
        /// </remarks>
        /// <exception cref="cart.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CartListPaymentMethodsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartListPaymentMethodsResponse>> ListPaymentMethodsWithHttpInfoAsync(CartListPaymentMethodsRequest body, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));
        /// <summary>
        /// Set SetPayments
        /// </summary>
        /// <remarks>
        /// Set SetPayments
        /// </remarks>
        /// <exception cref="cart.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CartSetPaymentsResponse</returns>
        System.Threading.Tasks.Task<CartSetPaymentsResponse> SetSetPaymentsAsync(CartSetPaymentsRequest body, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));

        /// <summary>
        /// Set SetPayments
        /// </summary>
        /// <remarks>
        /// Set SetPayments
        /// </remarks>
        /// <exception cref="cart.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CartSetPaymentsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartSetPaymentsResponse>> SetSetPaymentsWithHttpInfoAsync(CartSetPaymentsRequest body, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPaymentsApi : IPaymentsApiSync, IPaymentsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PaymentsApi : IPaymentsApi
    {
        private cart.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PaymentsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PaymentsApi(string basePath)
        {
            this.Configuration = cart.Client.Configuration.MergeConfigurations(
                cart.Client.GlobalConfiguration.Instance,
                new cart.Client.Configuration { BasePath = basePath }
            );
            this.Client = new cart.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new cart.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = cart.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PaymentsApi(cart.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = cart.Client.Configuration.MergeConfigurations(
                cart.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new cart.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new cart.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = cart.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public PaymentsApi(cart.Client.ISynchronousClient client, cart.Client.IAsynchronousClient asyncClient, cart.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = cart.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public cart.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public cart.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public cart.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public cart.Client.ExceptionFactory ExceptionFactory
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
        /// List Payment Methods List payment methods
        /// </summary>
        /// <exception cref="cart.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>CartListPaymentMethodsResponse</returns>
        public CartListPaymentMethodsResponse ListPaymentMethods(CartListPaymentMethodsRequest body, int operationIndex = 0)
        {
            cart.Client.ApiResponse<CartListPaymentMethodsResponse> localVarResponse = ListPaymentMethodsWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List Payment Methods List payment methods
        /// </summary>
        /// <exception cref="cart.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of CartListPaymentMethodsResponse</returns>
        public cart.Client.ApiResponse<CartListPaymentMethodsResponse> ListPaymentMethodsWithHttpInfo(CartListPaymentMethodsRequest body, int operationIndex = 0)
        {
            // verify the required parameter 'body' is set
            if (body == null)
            {
                throw new cart.Client.ApiException(400, "Missing required parameter 'body' when calling PaymentsApi->ListPaymentMethods");
            }

            cart.Client.RequestOptions localVarRequestOptions = new cart.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = cart.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = cart.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = body;

            localVarRequestOptions.Operation = "PaymentsApi.ListPaymentMethods";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (Authorization) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<CartListPaymentMethodsResponse>("/cart.Cart/ListPaymentMethods", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListPaymentMethods", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List Payment Methods List payment methods
        /// </summary>
        /// <exception cref="cart.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CartListPaymentMethodsResponse</returns>
        public async System.Threading.Tasks.Task<CartListPaymentMethodsResponse> ListPaymentMethodsAsync(CartListPaymentMethodsRequest body, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            cart.Client.ApiResponse<CartListPaymentMethodsResponse> localVarResponse = await ListPaymentMethodsWithHttpInfoAsync(body, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List Payment Methods List payment methods
        /// </summary>
        /// <exception cref="cart.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CartListPaymentMethodsResponse)</returns>
        public async System.Threading.Tasks.Task<cart.Client.ApiResponse<CartListPaymentMethodsResponse>> ListPaymentMethodsWithHttpInfoAsync(CartListPaymentMethodsRequest body, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            // verify the required parameter 'body' is set
            if (body == null)
            {
                throw new cart.Client.ApiException(400, "Missing required parameter 'body' when calling PaymentsApi->ListPaymentMethods");
            }


            cart.Client.RequestOptions localVarRequestOptions = new cart.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = cart.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = cart.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = body;

            localVarRequestOptions.Operation = "PaymentsApi.ListPaymentMethods";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (Authorization) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<CartListPaymentMethodsResponse>("/cart.Cart/ListPaymentMethods", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListPaymentMethods", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set SetPayments Set SetPayments
        /// </summary>
        /// <exception cref="cart.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>CartSetPaymentsResponse</returns>
        public CartSetPaymentsResponse SetSetPayments(CartSetPaymentsRequest body, int operationIndex = 0)
        {
            cart.Client.ApiResponse<CartSetPaymentsResponse> localVarResponse = SetSetPaymentsWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set SetPayments Set SetPayments
        /// </summary>
        /// <exception cref="cart.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of CartSetPaymentsResponse</returns>
        public cart.Client.ApiResponse<CartSetPaymentsResponse> SetSetPaymentsWithHttpInfo(CartSetPaymentsRequest body, int operationIndex = 0)
        {
            // verify the required parameter 'body' is set
            if (body == null)
            {
                throw new cart.Client.ApiException(400, "Missing required parameter 'body' when calling PaymentsApi->SetSetPayments");
            }

            cart.Client.RequestOptions localVarRequestOptions = new cart.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = cart.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = cart.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = body;

            localVarRequestOptions.Operation = "PaymentsApi.SetSetPayments";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (Authorization) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<CartSetPaymentsResponse>("/cart.Cart/SetPayments", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SetSetPayments", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set SetPayments Set SetPayments
        /// </summary>
        /// <exception cref="cart.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CartSetPaymentsResponse</returns>
        public async System.Threading.Tasks.Task<CartSetPaymentsResponse> SetSetPaymentsAsync(CartSetPaymentsRequest body, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            cart.Client.ApiResponse<CartSetPaymentsResponse> localVarResponse = await SetSetPaymentsWithHttpInfoAsync(body, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set SetPayments Set SetPayments
        /// </summary>
        /// <exception cref="cart.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CartSetPaymentsResponse)</returns>
        public async System.Threading.Tasks.Task<cart.Client.ApiResponse<CartSetPaymentsResponse>> SetSetPaymentsWithHttpInfoAsync(CartSetPaymentsRequest body, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            // verify the required parameter 'body' is set
            if (body == null)
            {
                throw new cart.Client.ApiException(400, "Missing required parameter 'body' when calling PaymentsApi->SetSetPayments");
            }


            cart.Client.RequestOptions localVarRequestOptions = new cart.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = cart.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = cart.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = body;

            localVarRequestOptions.Operation = "PaymentsApi.SetSetPayments";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (Authorization) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<CartSetPaymentsResponse>("/cart.Cart/SetPayments", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SetSetPayments", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
