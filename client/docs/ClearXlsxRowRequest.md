# Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.Model.ClearXlsxRowRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InputFileBytes** | **byte[]** | Optional: Bytes of the input file to operate on | [optional] 
**InputFileUrl** | **string** | Optional: URL of a file to operate on as input.  This can be a public URL, or you can also use the begin-editing API to upload a document and pass in the secure URL result from that operation as the URL here (this URL is not public). | [optional] 
**WorksheetToEdit** | [**XlsxWorksheet**](XlsxWorksheet.md) | Optional; Worksheet (tab) within the spreadsheet to get the specific row from; leave blank to default to the first worksheet | [optional] 
**RowIndex** | **int?** | Required; Index for the desired row to be cleared | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

