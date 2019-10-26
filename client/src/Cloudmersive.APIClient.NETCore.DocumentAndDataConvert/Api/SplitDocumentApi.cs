/* 
 * convertapi
 *
 * Convert API lets you effortlessly convert file formats and types.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.Model;

namespace Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISplitDocumentApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Split a single Excel XLSX into Separate Worksheets
        /// </summary>
        /// <remarks>
        /// Split an Excel XLSX Spreadsheet, comprised of multiple Worksheets (or Tabs) into separate Excel XLSX spreadsheet files, with each containing exactly one Worksheet.
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inputFile">Input file to perform the operation on.</param>
        /// <returns>SplitXlsxWorksheetResult</returns>
        SplitXlsxWorksheetResult SplitDocumentXlsx (System.IO.Stream inputFile);

        /// <summary>
        /// Split a single Excel XLSX into Separate Worksheets
        /// </summary>
        /// <remarks>
        /// Split an Excel XLSX Spreadsheet, comprised of multiple Worksheets (or Tabs) into separate Excel XLSX spreadsheet files, with each containing exactly one Worksheet.
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inputFile">Input file to perform the operation on.</param>
        /// <returns>ApiResponse of SplitXlsxWorksheetResult</returns>
        ApiResponse<SplitXlsxWorksheetResult> SplitDocumentXlsxWithHttpInfo (System.IO.Stream inputFile);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Split a single Excel XLSX into Separate Worksheets
        /// </summary>
        /// <remarks>
        /// Split an Excel XLSX Spreadsheet, comprised of multiple Worksheets (or Tabs) into separate Excel XLSX spreadsheet files, with each containing exactly one Worksheet.
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inputFile">Input file to perform the operation on.</param>
        /// <returns>Task of SplitXlsxWorksheetResult</returns>
        System.Threading.Tasks.Task<SplitXlsxWorksheetResult> SplitDocumentXlsxAsync (System.IO.Stream inputFile);

        /// <summary>
        /// Split a single Excel XLSX into Separate Worksheets
        /// </summary>
        /// <remarks>
        /// Split an Excel XLSX Spreadsheet, comprised of multiple Worksheets (or Tabs) into separate Excel XLSX spreadsheet files, with each containing exactly one Worksheet.
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inputFile">Input file to perform the operation on.</param>
        /// <returns>Task of ApiResponse (SplitXlsxWorksheetResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<SplitXlsxWorksheetResult>> SplitDocumentXlsxAsyncWithHttpInfo (System.IO.Stream inputFile);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SplitDocumentApi : ISplitDocumentApi
    {
        private Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SplitDocumentApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SplitDocumentApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SplitDocumentApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SplitDocumentApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.Client.Configuration.DefaultExceptionFactory;
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
        public Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.Client.ExceptionFactory ExceptionFactory
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
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
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
        /// Split a single Excel XLSX into Separate Worksheets Split an Excel XLSX Spreadsheet, comprised of multiple Worksheets (or Tabs) into separate Excel XLSX spreadsheet files, with each containing exactly one Worksheet.
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inputFile">Input file to perform the operation on.</param>
        /// <returns>SplitXlsxWorksheetResult</returns>
        public SplitXlsxWorksheetResult SplitDocumentXlsx (System.IO.Stream inputFile)
        {
             ApiResponse<SplitXlsxWorksheetResult> localVarResponse = SplitDocumentXlsxWithHttpInfo(inputFile);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Split a single Excel XLSX into Separate Worksheets Split an Excel XLSX Spreadsheet, comprised of multiple Worksheets (or Tabs) into separate Excel XLSX spreadsheet files, with each containing exactly one Worksheet.
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inputFile">Input file to perform the operation on.</param>
        /// <returns>ApiResponse of SplitXlsxWorksheetResult</returns>
        public ApiResponse< SplitXlsxWorksheetResult > SplitDocumentXlsxWithHttpInfo (System.IO.Stream inputFile)
        {
            // verify the required parameter 'inputFile' is set
            if (inputFile == null)
                throw new ApiException(400, "Missing required parameter 'inputFile' when calling SplitDocumentApi->SplitDocumentXlsx");

            var localVarPath = "/convert/split/xlsx";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "multipart/form-data"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/octet-stream"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (inputFile != null) localVarFileParams.Add("inputFile", Configuration.ApiClient.ParameterToFile("inputFile", inputFile));

            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SplitDocumentXlsx", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SplitXlsxWorksheetResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SplitXlsxWorksheetResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SplitXlsxWorksheetResult)));
        }

        /// <summary>
        /// Split a single Excel XLSX into Separate Worksheets Split an Excel XLSX Spreadsheet, comprised of multiple Worksheets (or Tabs) into separate Excel XLSX spreadsheet files, with each containing exactly one Worksheet.
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inputFile">Input file to perform the operation on.</param>
        /// <returns>Task of SplitXlsxWorksheetResult</returns>
        public async System.Threading.Tasks.Task<SplitXlsxWorksheetResult> SplitDocumentXlsxAsync (System.IO.Stream inputFile)
        {
             ApiResponse<SplitXlsxWorksheetResult> localVarResponse = await SplitDocumentXlsxAsyncWithHttpInfo(inputFile);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Split a single Excel XLSX into Separate Worksheets Split an Excel XLSX Spreadsheet, comprised of multiple Worksheets (or Tabs) into separate Excel XLSX spreadsheet files, with each containing exactly one Worksheet.
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="inputFile">Input file to perform the operation on.</param>
        /// <returns>Task of ApiResponse (SplitXlsxWorksheetResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SplitXlsxWorksheetResult>> SplitDocumentXlsxAsyncWithHttpInfo (System.IO.Stream inputFile)
        {
            // verify the required parameter 'inputFile' is set
            if (inputFile == null)
                throw new ApiException(400, "Missing required parameter 'inputFile' when calling SplitDocumentApi->SplitDocumentXlsx");

            var localVarPath = "/convert/split/xlsx";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "multipart/form-data"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/octet-stream"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (inputFile != null) localVarFileParams.Add("inputFile", Configuration.ApiClient.ParameterToFile("inputFile", inputFile));

            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SplitDocumentXlsx", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SplitXlsxWorksheetResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SplitXlsxWorksheetResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SplitXlsxWorksheetResult)));
        }

    }
}