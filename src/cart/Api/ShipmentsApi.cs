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
    public interface IShipmentsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// List Shipment Methods
        /// </summary>
        /// <remarks>
        /// List shipment methods
        /// </remarks>
        /// <exception cref="cart.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>CartListShipmentMethodsResponse</returns>
        CartListShipmentMethodsResponse ListShipmentMethods(CartListShipmentMethodsRequest body, int operationIndex = 0);

        /// <summary>
        /// List Shipment Methods
        /// </summary>
        /// <remarks>
        /// List shipment methods
        /// </remarks>
        /// <exception cref="cart.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of CartListShipmentMethodsResponse</returns>
        ApiResponse<CartListShipmentMethodsResponse> ListShipmentMethodsWithHttpInfo(CartListShipmentMethodsRequest body, int operationIndex = 0);
        /// <summary>
        /// Set Shipments
        /// </summary>
        /// <remarks>
        /// Set shipments
        /// </remarks>
        /// <exception cref="cart.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Object</returns>
        Object SetShipments(CartSetShipmentsRequest body, int operationIndex = 0);

        /// <summary>
        /// Set Shipments
        /// </summary>
        /// <remarks>
        /// Set shipments
        /// </remarks>
        /// <exception cref="cart.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> SetShipmentsWithHttpInfo(CartSetShipmentsRequest body, int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IShipmentsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// List Shipment Methods
        /// </summary>
        /// <remarks>
        /// List shipment methods
        /// </remarks>
        /// <exception cref="cart.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CartListShipmentMethodsResponse</returns>
        System.Threading.Tasks.Task<CartListShipmentMethodsResponse> ListShipmentMethodsAsync(CartListShipmentMethodsRequest body, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));

        /// <summary>
        /// List Shipment Methods
        /// </summary>
        /// <remarks>
        /// List shipment methods
        /// </remarks>
        /// <exception cref="cart.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CartListShipmentMethodsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CartListShipmentMethodsResponse>> ListShipmentMethodsWithHttpInfoAsync(CartListShipmentMethodsRequest body, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));
        /// <summary>
        /// Set Shipments
        /// </summary>
        /// <remarks>
        /// Set shipments
        /// </remarks>
        /// <exception cref="cart.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> SetShipmentsAsync(CartSetShipmentsRequest body, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));

        /// <summary>
        /// Set Shipments
        /// </summary>
        /// <remarks>
        /// Set shipments
        /// </remarks>
        /// <exception cref="cart.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> SetShipmentsWithHttpInfoAsync(CartSetShipmentsRequest body, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IShipmentsApi : IShipmentsApiSync, IShipmentsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ShipmentsApi : IShipmentsApi
    {
        private cart.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ShipmentsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ShipmentsApi(string basePath)
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
        /// Initializes a new instance of the <see cref="ShipmentsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ShipmentsApi(cart.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="ShipmentsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ShipmentsApi(cart.Client.ISynchronousClient client, cart.Client.IAsynchronousClient asyncClient, cart.Client.IReadableConfiguration configuration)
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
        /// List Shipment Methods List shipment methods
        /// </summary>
        /// <exception cref="cart.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>CartListShipmentMethodsResponse</returns>
        public CartListShipmentMethodsResponse ListShipmentMethods(CartListShipmentMethodsRequest body, int operationIndex = 0)
        {
            cart.Client.ApiResponse<CartListShipmentMethodsResponse> localVarResponse = ListShipmentMethodsWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List Shipment Methods List shipment methods
        /// </summary>
        /// <exception cref="cart.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of CartListShipmentMethodsResponse</returns>
        public cart.Client.ApiResponse<CartListShipmentMethodsResponse> ListShipmentMethodsWithHttpInfo(CartListShipmentMethodsRequest body, int operationIndex = 0)
        {
            // verify the required parameter 'body' is set
            if (body == null)
            {
                throw new cart.Client.ApiException(400, "Missing required parameter 'body' when calling ShipmentsApi->ListShipmentMethods");
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

            localVarRequestOptions.Operation = "ShipmentsApi.ListShipmentMethods";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (Authorization) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<CartListShipmentMethodsResponse>("/cart.Cart/ListShipmentMethods", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListShipmentMethods", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// List Shipment Methods List shipment methods
        /// </summary>
        /// <exception cref="cart.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CartListShipmentMethodsResponse</returns>
        public async System.Threading.Tasks.Task<CartListShipmentMethodsResponse> ListShipmentMethodsAsync(CartListShipmentMethodsRequest body, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            cart.Client.ApiResponse<CartListShipmentMethodsResponse> localVarResponse = await ListShipmentMethodsWithHttpInfoAsync(body, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// List Shipment Methods List shipment methods
        /// </summary>
        /// <exception cref="cart.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CartListShipmentMethodsResponse)</returns>
        public async System.Threading.Tasks.Task<cart.Client.ApiResponse<CartListShipmentMethodsResponse>> ListShipmentMethodsWithHttpInfoAsync(CartListShipmentMethodsRequest body, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            // verify the required parameter 'body' is set
            if (body == null)
            {
                throw new cart.Client.ApiException(400, "Missing required parameter 'body' when calling ShipmentsApi->ListShipmentMethods");
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

            localVarRequestOptions.Operation = "ShipmentsApi.ListShipmentMethods";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (Authorization) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<CartListShipmentMethodsResponse>("/cart.Cart/ListShipmentMethods", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListShipmentMethods", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set Shipments Set shipments
        /// </summary>
        /// <exception cref="cart.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>Object</returns>
        public Object SetShipments(CartSetShipmentsRequest body, int operationIndex = 0)
        {
            cart.Client.ApiResponse<Object> localVarResponse = SetShipmentsWithHttpInfo(body);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set Shipments Set shipments
        /// </summary>
        /// <exception cref="cart.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of Object</returns>
        public cart.Client.ApiResponse<Object> SetShipmentsWithHttpInfo(CartSetShipmentsRequest body, int operationIndex = 0)
        {
            // verify the required parameter 'body' is set
            if (body == null)
            {
                throw new cart.Client.ApiException(400, "Missing required parameter 'body' when calling ShipmentsApi->SetShipments");
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

            localVarRequestOptions.Operation = "ShipmentsApi.SetShipments";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (Authorization) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<Object>("/cart.Cart/SetShipments", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SetShipments", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Set Shipments Set shipments
        /// </summary>
        /// <exception cref="cart.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> SetShipmentsAsync(CartSetShipmentsRequest body, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            cart.Client.ApiResponse<Object> localVarResponse = await SetShipmentsWithHttpInfoAsync(body, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Set Shipments Set shipments
        /// </summary>
        /// <exception cref="cart.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<cart.Client.ApiResponse<Object>> SetShipmentsWithHttpInfoAsync(CartSetShipmentsRequest body, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            // verify the required parameter 'body' is set
            if (body == null)
            {
                throw new cart.Client.ApiException(400, "Missing required parameter 'body' when calling ShipmentsApi->SetShipments");
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

            localVarRequestOptions.Operation = "ShipmentsApi.SetShipments";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (Authorization) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/cart.Cart/SetShipments", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SetShipments", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
