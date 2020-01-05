# Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.Model.ClearXlsxCellRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InputFileBytes** | **byte[]** | Optional: Bytes of the input file to operate on | [optional] 
**InputFileUrl** | **string** | Optional: URL of a file to operate on as input.  This can be a public URL, or you can also use the begin-editing API to upload a document and pass in the secure URL result from that operation as the URL here (this URL is not public). | [optional] 
**WorksheetToUpdate** | [**XlsxWorksheet**](XlsxWorksheet.md) | Optional; Worksheet (tab) within the spreadsheet to update; leave blank to default to the first worksheet | [optional] 
**RowIndex** | **int?** | 0-based index of the row, 0, 1, 2, ... to clear | [optional] 
**CellIndex** | **int?** | 0-based index of the cell, 0, 1, 2, ... in the row to clear | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

