# Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.Api.SplitDocumentApi

All URIs are relative to *https://api.cloudmersive.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SplitDocumentXlsx**](SplitDocumentApi.md#splitdocumentxlsx) | **POST** /convert/split/xlsx | Split a single Excel XLSX into Separate Worksheets


<a name="splitdocumentxlsx"></a>
# **SplitDocumentXlsx**
> SplitXlsxWorksheetResult SplitDocumentXlsx (System.IO.Stream inputFile)

Split a single Excel XLSX into Separate Worksheets

Split an Excel XLSX Spreadsheet, comprised of multiple Worksheets (or Tabs) into separate Excel XLSX spreadsheet files, with each containing exactly one Worksheet.

### Example
```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.Model;

namespace Example
{
    public class SplitDocumentXlsxExample
    {
        public void main()
        {
            // Configure API key authorization: Apikey
            Configuration.Default.AddApiKey("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Apikey", "Bearer");

            var apiInstance = new SplitDocumentApi();
            var inputFile = new System.IO.Stream(); // System.IO.Stream | Input file to perform the operation on.

            try
            {
                // Split a single Excel XLSX into Separate Worksheets
                SplitXlsxWorksheetResult result = apiInstance.SplitDocumentXlsx(inputFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SplitDocumentApi.SplitDocumentXlsx: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **inputFile** | **System.IO.Stream**| Input file to perform the operation on. | 

### Return type

[**SplitXlsxWorksheetResult**](SplitXlsxWorksheetResult.md)

### Authorization

[Apikey](../README.md#Apikey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/octet-stream

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

