/* 
 * CyberSource Flex API
 *
 * Simple PAN tokenization service
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Linq;
using RestSharp;
using CyberSource.Client;

namespace CyberSource.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPurchaseAndRefundDetailsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get Purchase and Refund details
        /// </summary>
        /// <remarks>
        /// Purchase And Refund Details Description
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX </param>
        /// <param name="endTime">Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX </param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <param name="paymentSubtype">Payment Subtypes.   - **ALL**:  All Payment Subtypes   - **VI** :  Visa   - **MC** :  Master Card   - **AX** :  American Express   - **DI** :  Discover   - **DP** :  Pinless Debit  (optional, default to ALL)</param>
        /// <param name="viewBy">View results by Request Date or Submission Date.   - **requestDate** : Request Date   - **submissionDate**: Submission Date  (optional, default to requestDate)</param>
        /// <param name="groupName">Valid CyberSource Group Name.User can define groups using CBAPI and Group Management Module in EBC2. Groups are collection of organizationIds (optional)</param>
        /// <param name="offset">Offset of the Purchase and Refund Results. (optional)</param>
        /// <param name="limit">Results count per page. Range(1-2000) (optional, default to 2000)</param>
        /// <returns></returns>
        void GetPurchaseAndRefundDetails (DateTime? startTime, DateTime? endTime, string organizationId = null, string paymentSubtype = null, string viewBy = null, string groupName = null, int? offset = null, int? limit = null);

        /// <summary>
        /// Get Purchase and Refund details
        /// </summary>
        /// <remarks>
        /// Purchase And Refund Details Description
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX </param>
        /// <param name="endTime">Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX </param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <param name="paymentSubtype">Payment Subtypes.   - **ALL**:  All Payment Subtypes   - **VI** :  Visa   - **MC** :  Master Card   - **AX** :  American Express   - **DI** :  Discover   - **DP** :  Pinless Debit  (optional, default to ALL)</param>
        /// <param name="viewBy">View results by Request Date or Submission Date.   - **requestDate** : Request Date   - **submissionDate**: Submission Date  (optional, default to requestDate)</param>
        /// <param name="groupName">Valid CyberSource Group Name.User can define groups using CBAPI and Group Management Module in EBC2. Groups are collection of organizationIds (optional)</param>
        /// <param name="offset">Offset of the Purchase and Refund Results. (optional)</param>
        /// <param name="limit">Results count per page. Range(1-2000) (optional, default to 2000)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetPurchaseAndRefundDetailsWithHttpInfo (DateTime? startTime, DateTime? endTime, string organizationId = null, string paymentSubtype = null, string viewBy = null, string groupName = null, int? offset = null, int? limit = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get Purchase and Refund details
        /// </summary>
        /// <remarks>
        /// Purchase And Refund Details Description
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX </param>
        /// <param name="endTime">Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX </param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <param name="paymentSubtype">Payment Subtypes.   - **ALL**:  All Payment Subtypes   - **VI** :  Visa   - **MC** :  Master Card   - **AX** :  American Express   - **DI** :  Discover   - **DP** :  Pinless Debit  (optional, default to ALL)</param>
        /// <param name="viewBy">View results by Request Date or Submission Date.   - **requestDate** : Request Date   - **submissionDate**: Submission Date  (optional, default to requestDate)</param>
        /// <param name="groupName">Valid CyberSource Group Name.User can define groups using CBAPI and Group Management Module in EBC2. Groups are collection of organizationIds (optional)</param>
        /// <param name="offset">Offset of the Purchase and Refund Results. (optional)</param>
        /// <param name="limit">Results count per page. Range(1-2000) (optional, default to 2000)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetPurchaseAndRefundDetailsAsync (DateTime? startTime, DateTime? endTime, string organizationId = null, string paymentSubtype = null, string viewBy = null, string groupName = null, int? offset = null, int? limit = null);

        /// <summary>
        /// Get Purchase and Refund details
        /// </summary>
        /// <remarks>
        /// Purchase And Refund Details Description
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX </param>
        /// <param name="endTime">Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX </param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <param name="paymentSubtype">Payment Subtypes.   - **ALL**:  All Payment Subtypes   - **VI** :  Visa   - **MC** :  Master Card   - **AX** :  American Express   - **DI** :  Discover   - **DP** :  Pinless Debit  (optional, default to ALL)</param>
        /// <param name="viewBy">View results by Request Date or Submission Date.   - **requestDate** : Request Date   - **submissionDate**: Submission Date  (optional, default to requestDate)</param>
        /// <param name="groupName">Valid CyberSource Group Name.User can define groups using CBAPI and Group Management Module in EBC2. Groups are collection of organizationIds (optional)</param>
        /// <param name="offset">Offset of the Purchase and Refund Results. (optional)</param>
        /// <param name="limit">Results count per page. Range(1-2000) (optional, default to 2000)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetPurchaseAndRefundDetailsAsyncWithHttpInfo (DateTime? startTime, DateTime? endTime, string organizationId = null, string paymentSubtype = null, string viewBy = null, string groupName = null, int? offset = null, int? limit = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PurchaseAndRefundDetailsApi : IPurchaseAndRefundDetailsApi
    {
        private CyberSource.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseAndRefundDetailsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PurchaseAndRefundDetailsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = CyberSource.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseAndRefundDetailsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PurchaseAndRefundDetailsApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = CyberSource.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public CyberSource.Client.ExceptionFactory ExceptionFactory
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
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Get Purchase and Refund details Purchase And Refund Details Description
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX </param>
        /// <param name="endTime">Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX </param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <param name="paymentSubtype">Payment Subtypes.   - **ALL**:  All Payment Subtypes   - **VI** :  Visa   - **MC** :  Master Card   - **AX** :  American Express   - **DI** :  Discover   - **DP** :  Pinless Debit  (optional, default to ALL)</param>
        /// <param name="viewBy">View results by Request Date or Submission Date.   - **requestDate** : Request Date   - **submissionDate**: Submission Date  (optional, default to requestDate)</param>
        /// <param name="groupName">Valid CyberSource Group Name.User can define groups using CBAPI and Group Management Module in EBC2. Groups are collection of organizationIds (optional)</param>
        /// <param name="offset">Offset of the Purchase and Refund Results. (optional)</param>
        /// <param name="limit">Results count per page. Range(1-2000) (optional, default to 2000)</param>
        /// <returns></returns>
        public void GetPurchaseAndRefundDetails (DateTime? startTime, DateTime? endTime, string organizationId = null, string paymentSubtype = null, string viewBy = null, string groupName = null, int? offset = null, int? limit = null)
        {
             GetPurchaseAndRefundDetailsWithHttpInfo(startTime, endTime, organizationId, paymentSubtype, viewBy, groupName, offset, limit);
        }

        /// <summary>
        /// Get Purchase and Refund details Purchase And Refund Details Description
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX </param>
        /// <param name="endTime">Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX </param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <param name="paymentSubtype">Payment Subtypes.   - **ALL**:  All Payment Subtypes   - **VI** :  Visa   - **MC** :  Master Card   - **AX** :  American Express   - **DI** :  Discover   - **DP** :  Pinless Debit  (optional, default to ALL)</param>
        /// <param name="viewBy">View results by Request Date or Submission Date.   - **requestDate** : Request Date   - **submissionDate**: Submission Date  (optional, default to requestDate)</param>
        /// <param name="groupName">Valid CyberSource Group Name.User can define groups using CBAPI and Group Management Module in EBC2. Groups are collection of organizationIds (optional)</param>
        /// <param name="offset">Offset of the Purchase and Refund Results. (optional)</param>
        /// <param name="limit">Results count per page. Range(1-2000) (optional, default to 2000)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetPurchaseAndRefundDetailsWithHttpInfo (DateTime? startTime, DateTime? endTime, string organizationId = null, string paymentSubtype = null, string viewBy = null, string groupName = null, int? offset = null, int? limit = null)
        {
            // verify the required parameter 'startTime' is set
            if (startTime == null)
                throw new ApiException(400, "Missing required parameter 'startTime' when calling PurchaseAndRefundDetailsApi->GetPurchaseAndRefundDetails");
            // verify the required parameter 'endTime' is set
            if (endTime == null)
                throw new ApiException(400, "Missing required parameter 'endTime' when calling PurchaseAndRefundDetailsApi->GetPurchaseAndRefundDetails");

            var localVarPath = $"/reporting/v3/purchase-refund-details";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/hal+json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (startTime != null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime)); // query parameter
            if (endTime != null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime)); // query parameter
            if (organizationId != null) localVarQueryParams.Add("organizationId", Configuration.ApiClient.ParameterToString(organizationId)); // query parameter
            if (paymentSubtype != null) localVarQueryParams.Add("paymentSubtype", Configuration.ApiClient.ParameterToString(paymentSubtype)); // query parameter
            if (viewBy != null) localVarQueryParams.Add("viewBy", Configuration.ApiClient.ParameterToString(viewBy)); // query parameter
            if (groupName != null) localVarQueryParams.Add("groupName", Configuration.ApiClient.ParameterToString(groupName)); // query parameter
            if (offset != null) localVarQueryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetPurchaseAndRefundDetails", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Get Purchase and Refund details Purchase And Refund Details Description
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX </param>
        /// <param name="endTime">Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX </param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <param name="paymentSubtype">Payment Subtypes.   - **ALL**:  All Payment Subtypes   - **VI** :  Visa   - **MC** :  Master Card   - **AX** :  American Express   - **DI** :  Discover   - **DP** :  Pinless Debit  (optional, default to ALL)</param>
        /// <param name="viewBy">View results by Request Date or Submission Date.   - **requestDate** : Request Date   - **submissionDate**: Submission Date  (optional, default to requestDate)</param>
        /// <param name="groupName">Valid CyberSource Group Name.User can define groups using CBAPI and Group Management Module in EBC2. Groups are collection of organizationIds (optional)</param>
        /// <param name="offset">Offset of the Purchase and Refund Results. (optional)</param>
        /// <param name="limit">Results count per page. Range(1-2000) (optional, default to 2000)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetPurchaseAndRefundDetailsAsync (DateTime? startTime, DateTime? endTime, string organizationId = null, string paymentSubtype = null, string viewBy = null, string groupName = null, int? offset = null, int? limit = null)
        {
             await GetPurchaseAndRefundDetailsAsyncWithHttpInfo(startTime, endTime, organizationId, paymentSubtype, viewBy, groupName, offset, limit);

        }

        /// <summary>
        /// Get Purchase and Refund details Purchase And Refund Details Description
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="startTime">Valid report Start Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX </param>
        /// <param name="endTime">Valid report End Time in **ISO 8601 format** Please refer the following link to know more about ISO 8601 format. - https://xml2rfc.tools.ietf.org/public/rfc/html/rfc3339.html#anchor14   **Example date format:**   - yyyy-MM-dd&#39;T&#39;HH:mm:ssXXX </param>
        /// <param name="organizationId">Valid Cybersource Organization Id (optional)</param>
        /// <param name="paymentSubtype">Payment Subtypes.   - **ALL**:  All Payment Subtypes   - **VI** :  Visa   - **MC** :  Master Card   - **AX** :  American Express   - **DI** :  Discover   - **DP** :  Pinless Debit  (optional, default to ALL)</param>
        /// <param name="viewBy">View results by Request Date or Submission Date.   - **requestDate** : Request Date   - **submissionDate**: Submission Date  (optional, default to requestDate)</param>
        /// <param name="groupName">Valid CyberSource Group Name.User can define groups using CBAPI and Group Management Module in EBC2. Groups are collection of organizationIds (optional)</param>
        /// <param name="offset">Offset of the Purchase and Refund Results. (optional)</param>
        /// <param name="limit">Results count per page. Range(1-2000) (optional, default to 2000)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetPurchaseAndRefundDetailsAsyncWithHttpInfo (DateTime? startTime, DateTime? endTime, string organizationId = null, string paymentSubtype = null, string viewBy = null, string groupName = null, int? offset = null, int? limit = null)
        {
            // verify the required parameter 'startTime' is set
            if (startTime == null)
                throw new ApiException(400, "Missing required parameter 'startTime' when calling PurchaseAndRefundDetailsApi->GetPurchaseAndRefundDetails");
            // verify the required parameter 'endTime' is set
            if (endTime == null)
                throw new ApiException(400, "Missing required parameter 'endTime' when calling PurchaseAndRefundDetailsApi->GetPurchaseAndRefundDetails");

            var localVarPath = $"/reporting/v3/purchase-refund-details";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/hal+json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (startTime != null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime)); // query parameter
            if (endTime != null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime)); // query parameter
            if (organizationId != null) localVarQueryParams.Add("organizationId", Configuration.ApiClient.ParameterToString(organizationId)); // query parameter
            if (paymentSubtype != null) localVarQueryParams.Add("paymentSubtype", Configuration.ApiClient.ParameterToString(paymentSubtype)); // query parameter
            if (viewBy != null) localVarQueryParams.Add("viewBy", Configuration.ApiClient.ParameterToString(viewBy)); // query parameter
            if (groupName != null) localVarQueryParams.Add("groupName", Configuration.ApiClient.ParameterToString(groupName)); // query parameter
            if (offset != null) localVarQueryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetPurchaseAndRefundDetails", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

    }
}
