# Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.Model.InsertDocxTableRowRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InputFileBytes** | **byte[]** | Optional: Bytes of the input file to operate on | [optional] 
**InputFileUrl** | **string** | Optional: URL of a file to operate on as input.  This can be a public URL, or you can also use the begin-editing API to upload a document and pass in the secure URL result from that operation as the URL here (this URL is not public). | [optional] 
**RowToInsert** | [**DocxTableRow**](DocxTableRow.md) | Table you would like to insert | [optional] 
**InsertPlacement** | **string** | Optional; default is TableEnd.  Placement Type of the insert; possible values are: TableStart (very beginning of the table), TableEnd (very end of the document), or a 0-based row index number as an integer, 0 being the first row in the table, 1 being the second row in the table, 2 being the third row in the table, etc. to insert this row after | [optional] 
**ExistingTablePath** | **string** | Required; the path to the existing table to modify | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

