# Cloudmersive.APIClient.NETCore.DocumentAndDataConvert - the C# library for the convertapi

Convert API lets you effortlessly convert file formats and types.

This C# SDK is for the [Cloudmersive Document and Data Conversion API](https://www.cloudmersive.com/convert-api):

- API version: v1
- SDK version: 1.7.8
- Build package: io.swagger.codegen.languages.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet] (https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            // Configure API key authorization: Apikey
            Configuration.Default.ApiKey.Add("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Apikey", "Bearer");

            var apiInstance = new CompareDocumentApi();
            var inputFile1 = new System.IO.Stream(); // System.IO.Stream | First input file to perform the operation on.
            var inputFile2 = new System.IO.Stream(); // System.IO.Stream | Second input file to perform the operation on (more than 2 can be supplied).

            try
            {
                // Compare Two Word DOCX
                byte[] result = apiInstance.CompareDocumentDocx(inputFile1, inputFile2);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompareDocumentApi.CompareDocumentDocx: " + e.Message );
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.cloudmersive.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*CompareDocumentApi* | [**CompareDocumentDocx**](docs/CompareDocumentApi.md#comparedocumentdocx) | **POST** /convert/compare/docx | Compare Two Word DOCX
*ConvertDataApi* | [**ConvertDataCsvToJson**](docs/ConvertDataApi.md#convertdatacsvtojson) | **POST** /convert/csv/to/json | Convert CSV to JSON conversion
*ConvertDataApi* | [**ConvertDataJsonToXml**](docs/ConvertDataApi.md#convertdatajsontoxml) | **POST** /convert/json/to/xml | Convert JSON to XML conversion
*ConvertDataApi* | [**ConvertDataXlsToJson**](docs/ConvertDataApi.md#convertdataxlstojson) | **POST** /convert/xls/to/json | Convert Excel (97-2003) XLS to JSON conversion
*ConvertDataApi* | [**ConvertDataXlsxToJson**](docs/ConvertDataApi.md#convertdataxlsxtojson) | **POST** /convert/xlsx/to/json | Convert Excel XLSX to JSON conversion
*ConvertDataApi* | [**ConvertDataXmlEditAddAttributeWithXPath**](docs/ConvertDataApi.md#convertdataxmleditaddattributewithxpath) | **POST** /convert/xml/edit/xpath/add-attribute | Adds an attribute to all XML nodes matching XPath expression
*ConvertDataApi* | [**ConvertDataXmlEditAddChildWithXPath**](docs/ConvertDataApi.md#convertdataxmleditaddchildwithxpath) | **POST** /convert/xml/edit/xpath/add-child | Adds an XML node as a child to XML nodes matching XPath expression
*ConvertDataApi* | [**ConvertDataXmlEditRemoveAllChildNodesWithXPath**](docs/ConvertDataApi.md#convertdataxmleditremoveallchildnodeswithxpath) | **POST** /convert/xml/edit/xpath/remove-all-children | Removes, deletes all children of nodes matching XPath expression, but does not remove the nodes
*ConvertDataApi* | [**ConvertDataXmlEditReplaceWithXPath**](docs/ConvertDataApi.md#convertdataxmleditreplacewithxpath) | **POST** /convert/xml/edit/xpath/replace | Replaces XML nodes matching XPath expression with new node
*ConvertDataApi* | [**ConvertDataXmlEditSetValueWithXPath**](docs/ConvertDataApi.md#convertdataxmleditsetvaluewithxpath) | **POST** /convert/xml/edit/xpath/set-value | Sets the value contents of XML nodes matching XPath expression
*ConvertDataApi* | [**ConvertDataXmlFilterWithXPath**](docs/ConvertDataApi.md#convertdataxmlfilterwithxpath) | **POST** /convert/xml/select/xpath | Filter, select XML nodes using XPath expression, get results
*ConvertDataApi* | [**ConvertDataXmlQueryWithXQuery**](docs/ConvertDataApi.md#convertdataxmlquerywithxquery) | **POST** /convert/xml/query/xquery | Query an XML file using XQuery query, get results
*ConvertDataApi* | [**ConvertDataXmlQueryWithXQueryMulti**](docs/ConvertDataApi.md#convertdataxmlquerywithxquerymulti) | **POST** /convert/xml/query/xquery/multi | Query multiple XML files using XQuery query, get results
*ConvertDataApi* | [**ConvertDataXmlRemoveWithXPath**](docs/ConvertDataApi.md#convertdataxmlremovewithxpath) | **POST** /convert/xml/edit/xpath/remove | Remove, delete XML nodes and items matching XPath expression
*ConvertDataApi* | [**ConvertDataXmlToJson**](docs/ConvertDataApi.md#convertdataxmltojson) | **POST** /convert/xml/to/json | Convert XML to JSON conversion
*ConvertDataApi* | [**ConvertDataXmlTransformWithXsltToXml**](docs/ConvertDataApi.md#convertdataxmltransformwithxslttoxml) | **POST** /convert/xml/transform/xslt/to/xml | Transform XML document file with XSLT into a new XML document
*ConvertDocumentApi* | [**ConvertDocumentAutodetectGetInfo**](docs/ConvertDocumentApi.md#convertdocumentautodetectgetinfo) | **POST** /convert/autodetect/get-info | Get document type information
*ConvertDocumentApi* | [**ConvertDocumentAutodetectToPdf**](docs/ConvertDocumentApi.md#convertdocumentautodetecttopdf) | **POST** /convert/autodetect/to/pdf | Convert Document to PDF
*ConvertDocumentApi* | [**ConvertDocumentAutodetectToPngArray**](docs/ConvertDocumentApi.md#convertdocumentautodetecttopngarray) | **POST** /convert/autodetect/to/png | Convert Document to PNG array
*ConvertDocumentApi* | [**ConvertDocumentAutodetectToTxt**](docs/ConvertDocumentApi.md#convertdocumentautodetecttotxt) | **POST** /convert/autodetect/to/txt | Convert Document to Text (txt)
*ConvertDocumentApi* | [**ConvertDocumentCsvToXlsx**](docs/ConvertDocumentApi.md#convertdocumentcsvtoxlsx) | **POST** /convert/csv/to/xlsx | Convert CSV to Excel XLSX Spreadsheet
*ConvertDocumentApi* | [**ConvertDocumentDocToDocx**](docs/ConvertDocumentApi.md#convertdocumentdoctodocx) | **POST** /convert/doc/to/docx | Convert Word DOC (97-03) Document to DOCX
*ConvertDocumentApi* | [**ConvertDocumentDocToPdf**](docs/ConvertDocumentApi.md#convertdocumentdoctopdf) | **POST** /convert/doc/to/pdf | Convert Word DOC (97-03) Document to PDF
*ConvertDocumentApi* | [**ConvertDocumentDocxToPdf**](docs/ConvertDocumentApi.md#convertdocumentdocxtopdf) | **POST** /convert/docx/to/pdf | Convert Word DOCX Document to PDF
*ConvertDocumentApi* | [**ConvertDocumentDocxToTxt**](docs/ConvertDocumentApi.md#convertdocumentdocxtotxt) | **POST** /convert/docx/to/txt | Convert Word DOCX Document to Text (txt)
*ConvertDocumentApi* | [**ConvertDocumentHtmlToPdf**](docs/ConvertDocumentApi.md#convertdocumenthtmltopdf) | **POST** /convert/html/to/pdf | Convert HTML document file to PDF Document
*ConvertDocumentApi* | [**ConvertDocumentHtmlToPng**](docs/ConvertDocumentApi.md#convertdocumenthtmltopng) | **POST** /convert/html/to/png | Convert HTML document file to PNG image array
*ConvertDocumentApi* | [**ConvertDocumentHtmlToTxt**](docs/ConvertDocumentApi.md#convertdocumenthtmltotxt) | **POST** /convert/html/to/txt | HTML Document file to Text (txt)
*ConvertDocumentApi* | [**ConvertDocumentPdfToDocx**](docs/ConvertDocumentApi.md#convertdocumentpdftodocx) | **POST** /convert/pdf/to/docx | Convert PDF to Word DOCX Document
*ConvertDocumentApi* | [**ConvertDocumentPdfToDocxRasterize**](docs/ConvertDocumentApi.md#convertdocumentpdftodocxrasterize) | **POST** /convert/pdf/to/docx/rasterize | Convert PDF to Word DOCX Document based on rasterized version of the PDF
*ConvertDocumentApi* | [**ConvertDocumentPdfToPngArray**](docs/ConvertDocumentApi.md#convertdocumentpdftopngarray) | **POST** /convert/pdf/to/png | Convert PDF to PNG Image Array
*ConvertDocumentApi* | [**ConvertDocumentPdfToPngSingle**](docs/ConvertDocumentApi.md#convertdocumentpdftopngsingle) | **POST** /convert/pdf/to/png/merge-single | Convert PDF to Single PNG image
*ConvertDocumentApi* | [**ConvertDocumentPdfToPptx**](docs/ConvertDocumentApi.md#convertdocumentpdftopptx) | **POST** /convert/pdf/to/pptx | Convert PDF to PowerPoint PPTX Presentation
*ConvertDocumentApi* | [**ConvertDocumentPdfToTxt**](docs/ConvertDocumentApi.md#convertdocumentpdftotxt) | **POST** /convert/pdf/to/txt | Convert PDF Document to Text (txt)
*ConvertDocumentApi* | [**ConvertDocumentPngArrayToPdf**](docs/ConvertDocumentApi.md#convertdocumentpngarraytopdf) | **POST** /convert/png/to/pdf | Convert PNG Array to PDF
*ConvertDocumentApi* | [**ConvertDocumentPptToPdf**](docs/ConvertDocumentApi.md#convertdocumentppttopdf) | **POST** /convert/ppt/to/pdf | Convert PowerPoint PPT (97-03) Presentation to PDF
*ConvertDocumentApi* | [**ConvertDocumentPptToPptx**](docs/ConvertDocumentApi.md#convertdocumentppttopptx) | **POST** /convert/ppt/to/pptx | Convert PowerPoint PPT (97-03) Presentation to PPTX
*ConvertDocumentApi* | [**ConvertDocumentPptxToPdf**](docs/ConvertDocumentApi.md#convertdocumentpptxtopdf) | **POST** /convert/pptx/to/pdf | Convert PowerPoint PPTX Presentation to PDF
*ConvertDocumentApi* | [**ConvertDocumentPptxToTxt**](docs/ConvertDocumentApi.md#convertdocumentpptxtotxt) | **POST** /convert/pptx/to/txt | Convert PowerPoint PPTX Presentation to Text (txt)
*ConvertDocumentApi* | [**ConvertDocumentXlsToCsv**](docs/ConvertDocumentApi.md#convertdocumentxlstocsv) | **POST** /convert/xls/to/csv | Convert Excel XLS (97-03) Spreadsheet to CSV
*ConvertDocumentApi* | [**ConvertDocumentXlsToPdf**](docs/ConvertDocumentApi.md#convertdocumentxlstopdf) | **POST** /convert/xls/to/pdf | Convert Excel XLS (97-03) Spreadsheet to PDF
*ConvertDocumentApi* | [**ConvertDocumentXlsToXlsx**](docs/ConvertDocumentApi.md#convertdocumentxlstoxlsx) | **POST** /convert/xls/to/xlsx | Convert Excel XLS (97-03) Spreadsheet to XLSX
*ConvertDocumentApi* | [**ConvertDocumentXlsxToCsv**](docs/ConvertDocumentApi.md#convertdocumentxlsxtocsv) | **POST** /convert/xlsx/to/csv | Convert Excel XLSX Spreadsheet to CSV
*ConvertDocumentApi* | [**ConvertDocumentXlsxToPdf**](docs/ConvertDocumentApi.md#convertdocumentxlsxtopdf) | **POST** /convert/xlsx/to/pdf | Convert Excel XLSX Spreadsheet to PDF
*ConvertDocumentApi* | [**ConvertDocumentXlsxToTxt**](docs/ConvertDocumentApi.md#convertdocumentxlsxtotxt) | **POST** /convert/xlsx/to/txt | Convert Excel XLSX Spreadsheet to Text (txt)
*ConvertImageApi* | [**ConvertImageGetImageInfo**](docs/ConvertImageApi.md#convertimagegetimageinfo) | **POST** /convert/image/get-info | Get information about an image
*ConvertImageApi* | [**ConvertImageImageFormatConvert**](docs/ConvertImageApi.md#convertimageimageformatconvert) | **POST** /convert/image/{format1}/to/{format2} | Image format conversion
*ConvertImageApi* | [**ConvertImageImageSetDPI**](docs/ConvertImageApi.md#convertimageimagesetdpi) | **POST** /convert/image/set-dpi/{dpi} | Change image DPI
*ConvertImageApi* | [**ConvertImageMultipageImageFormatConvert**](docs/ConvertImageApi.md#convertimagemultipageimageformatconvert) | **POST** /convert/image-multipage/{format1}/to/{format2} | Multi-page image format conversion
*ConvertTemplateApi* | [**ConvertTemplateApplyDocxTemplate**](docs/ConvertTemplateApi.md#converttemplateapplydocxtemplate) | **POST** /convert/template/docx/apply | Apply Word DOCX template
*ConvertTemplateApi* | [**ConvertTemplateApplyHtmlTemplate**](docs/ConvertTemplateApi.md#converttemplateapplyhtmltemplate) | **POST** /convert/template/html/apply | Apply HTML template
*ConvertWebApi* | [**ConvertWebHtmlToDocx**](docs/ConvertWebApi.md#convertwebhtmltodocx) | **POST** /convert/html/to/docx | Convert HTML to Word DOCX Document
*ConvertWebApi* | [**ConvertWebHtmlToPdf**](docs/ConvertWebApi.md#convertwebhtmltopdf) | **POST** /convert/web/html/to/pdf | Convert HTML string to PDF
*ConvertWebApi* | [**ConvertWebHtmlToPng**](docs/ConvertWebApi.md#convertwebhtmltopng) | **POST** /convert/web/html/to/png | Convert HTML string to PNG screenshot
*ConvertWebApi* | [**ConvertWebHtmlToTxt**](docs/ConvertWebApi.md#convertwebhtmltotxt) | **POST** /convert/web/url/to/txt | Convert website URL page to text (txt)
*ConvertWebApi* | [**ConvertWebHtmlToTxt_0**](docs/ConvertWebApi.md#convertwebhtmltotxt_0) | **POST** /convert/web/html/to/txt | Convert HTML string to text (txt)
*ConvertWebApi* | [**ConvertWebMdToHtml**](docs/ConvertWebApi.md#convertwebmdtohtml) | **POST** /convert/web/md/to/html | Convert Markdown to HTML
*ConvertWebApi* | [**ConvertWebUrlToPdf**](docs/ConvertWebApi.md#convertweburltopdf) | **POST** /convert/web/url/to/pdf | Convert a URL to PDF
*ConvertWebApi* | [**ConvertWebUrlToScreenshot**](docs/ConvertWebApi.md#convertweburltoscreenshot) | **POST** /convert/web/url/to/screenshot | Take screenshot of URL
*EditDocumentApi* | [**EditDocumentBeginEditing**](docs/EditDocumentApi.md#editdocumentbeginediting) | **POST** /convert/edit/begin-editing | Begin editing a document
*EditDocumentApi* | [**EditDocumentDocxBody**](docs/EditDocumentApi.md#editdocumentdocxbody) | **POST** /convert/edit/docx/get-body | Get body from a Word DOCX document
*EditDocumentApi* | [**EditDocumentDocxCreateBlankDocument**](docs/EditDocumentApi.md#editdocumentdocxcreateblankdocument) | **POST** /convert/edit/docx/create/blank | Create a blank Word DOCX document
*EditDocumentApi* | [**EditDocumentDocxDeletePages**](docs/EditDocumentApi.md#editdocumentdocxdeletepages) | **POST** /convert/edit/docx/delete-pages | Delete, remove pages from a Word DOCX document
*EditDocumentApi* | [**EditDocumentDocxDeleteTableRow**](docs/EditDocumentApi.md#editdocumentdocxdeletetablerow) | **POST** /convert/edit/docx/delete-table-row | Deletes a table row in an existing table in a Word DOCX document
*EditDocumentApi* | [**EditDocumentDocxGetHeadersAndFooters**](docs/EditDocumentApi.md#editdocumentdocxgetheadersandfooters) | **POST** /convert/edit/docx/get-headers-and-footers | Get content of a footer from a Word DOCX document
*EditDocumentApi* | [**EditDocumentDocxGetImages**](docs/EditDocumentApi.md#editdocumentdocxgetimages) | **POST** /convert/edit/docx/get-images | Get images from a Word DOCX document
*EditDocumentApi* | [**EditDocumentDocxGetSections**](docs/EditDocumentApi.md#editdocumentdocxgetsections) | **POST** /convert/edit/docx/get-sections | Get sections from a Word DOCX document
*EditDocumentApi* | [**EditDocumentDocxGetStyles**](docs/EditDocumentApi.md#editdocumentdocxgetstyles) | **POST** /convert/edit/docx/get-styles | Get styles from a Word DOCX document
*EditDocumentApi* | [**EditDocumentDocxGetTableByIndex**](docs/EditDocumentApi.md#editdocumentdocxgettablebyindex) | **POST** /convert/edit/docx/get-table/by-index | Get a specific table by index in a Word DOCX document
*EditDocumentApi* | [**EditDocumentDocxGetTableRow**](docs/EditDocumentApi.md#editdocumentdocxgettablerow) | **POST** /convert/edit/docx/get-table-row | Gets the contents of an existing table row in an existing table in a Word DOCX document
*EditDocumentApi* | [**EditDocumentDocxGetTables**](docs/EditDocumentApi.md#editdocumentdocxgettables) | **POST** /convert/edit/docx/get-tables | Get all tables in Word DOCX document
*EditDocumentApi* | [**EditDocumentDocxInsertImage**](docs/EditDocumentApi.md#editdocumentdocxinsertimage) | **POST** /convert/edit/docx/insert-image | Insert image into a Word DOCX document
*EditDocumentApi* | [**EditDocumentDocxInsertParagraph**](docs/EditDocumentApi.md#editdocumentdocxinsertparagraph) | **POST** /convert/edit/docx/insert-paragraph | Insert a new paragraph into a Word DOCX document
*EditDocumentApi* | [**EditDocumentDocxInsertTable**](docs/EditDocumentApi.md#editdocumentdocxinserttable) | **POST** /convert/edit/docx/insert-table | Insert a new table into a Word DOCX document
*EditDocumentApi* | [**EditDocumentDocxInsertTableRow**](docs/EditDocumentApi.md#editdocumentdocxinserttablerow) | **POST** /convert/edit/docx/insert-table-row | Insert a new row into an existing table in a Word DOCX document
*EditDocumentApi* | [**EditDocumentDocxPages**](docs/EditDocumentApi.md#editdocumentdocxpages) | **POST** /convert/edit/docx/get-pages | Get pages and content from a Word DOCX document
*EditDocumentApi* | [**EditDocumentDocxRemoveHeadersAndFooters**](docs/EditDocumentApi.md#editdocumentdocxremoveheadersandfooters) | **POST** /convert/edit/docx/remove-headers-and-footers | Remove headers and footers from Word DOCX document
*EditDocumentApi* | [**EditDocumentDocxRemoveObject**](docs/EditDocumentApi.md#editdocumentdocxremoveobject) | **POST** /convert/edit/docx/remove-object | Delete any object in a Word DOCX document
*EditDocumentApi* | [**EditDocumentDocxReplace**](docs/EditDocumentApi.md#editdocumentdocxreplace) | **POST** /convert/edit/docx/replace-all | Replace string in Word DOCX document
*EditDocumentApi* | [**EditDocumentDocxSetFooter**](docs/EditDocumentApi.md#editdocumentdocxsetfooter) | **POST** /convert/edit/docx/set-footer | Set the footer in a Word DOCX document
*EditDocumentApi* | [**EditDocumentDocxSetFooterAddPageNumber**](docs/EditDocumentApi.md#editdocumentdocxsetfooteraddpagenumber) | **POST** /convert/edit/docx/set-footer/add-page-number | Add page number to footer in a Word DOCX document
*EditDocumentApi* | [**EditDocumentDocxSetHeader**](docs/EditDocumentApi.md#editdocumentdocxsetheader) | **POST** /convert/edit/docx/set-header | Set the header in a Word DOCX document
*EditDocumentApi* | [**EditDocumentDocxUpdateTableCell**](docs/EditDocumentApi.md#editdocumentdocxupdatetablecell) | **POST** /convert/edit/docx/update-table-cell | Update, set contents of a table cell in an existing table in a Word DOCX document
*EditDocumentApi* | [**EditDocumentDocxUpdateTableRow**](docs/EditDocumentApi.md#editdocumentdocxupdatetablerow) | **POST** /convert/edit/docx/update-table-row | Update, set contents of a table row in an existing table in a Word DOCX document
*EditDocumentApi* | [**EditDocumentFinishEditing**](docs/EditDocumentApi.md#editdocumentfinishediting) | **POST** /convert/edit/finish-editing | Download result from document editing
*EditDocumentApi* | [**EditDocumentPptxDeleteSlides**](docs/EditDocumentApi.md#editdocumentpptxdeleteslides) | **POST** /convert/edit/pptx/delete-slides | Delete, remove slides from a PowerPoint PPTX presentation document
*EditDocumentApi* | [**EditDocumentPptxReplace**](docs/EditDocumentApi.md#editdocumentpptxreplace) | **POST** /convert/edit/pptx/replace-all | Replace string in PowerPoint PPTX presentation
*EditDocumentApi* | [**EditDocumentXlsxCreateBlankSpreadsheet**](docs/EditDocumentApi.md#editdocumentxlsxcreateblankspreadsheet) | **POST** /convert/edit/xlsx/create/blank | Create a blank Excel XLSX spreadsheet
*EditDocumentApi* | [**EditDocumentXlsxGetCellByIndex**](docs/EditDocumentApi.md#editdocumentxlsxgetcellbyindex) | **POST** /convert/edit/xlsx/get-cell/by-index | Get cell from an Excel XLSX spreadsheet, worksheet by index
*EditDocumentApi* | [**EditDocumentXlsxGetColumns**](docs/EditDocumentApi.md#editdocumentxlsxgetcolumns) | **POST** /convert/edit/xlsx/get-columns | Get rows and cells from a Excel XLSX spreadsheet, worksheet
*EditDocumentApi* | [**EditDocumentXlsxGetImages**](docs/EditDocumentApi.md#editdocumentxlsxgetimages) | **POST** /convert/edit/xlsx/get-images | Get images from a Excel XLSX spreadsheet, worksheet
*EditDocumentApi* | [**EditDocumentXlsxGetRowsAndCells**](docs/EditDocumentApi.md#editdocumentxlsxgetrowsandcells) | **POST** /convert/edit/xlsx/get-rows-and-cells | Get rows and cells from a Excel XLSX spreadsheet, worksheet
*EditDocumentApi* | [**EditDocumentXlsxGetStyles**](docs/EditDocumentApi.md#editdocumentxlsxgetstyles) | **POST** /convert/edit/xlsx/get-styles | Get styles from a Excel XLSX spreadsheet, worksheet
*EditDocumentApi* | [**EditDocumentXlsxGetWorksheets**](docs/EditDocumentApi.md#editdocumentxlsxgetworksheets) | **POST** /convert/edit/xlsx/get-worksheets | Get worksheets from a Excel XLSX spreadsheet
*EditDocumentApi* | [**EditDocumentXlsxInsertWorksheet**](docs/EditDocumentApi.md#editdocumentxlsxinsertworksheet) | **POST** /convert/edit/xlsx/insert-worksheet | Insert a new worksheet into an Excel XLSX spreadsheet
*EditPdfApi* | [**EditPdfAddAnnotations**](docs/EditPdfApi.md#editpdfaddannotations) | **POST** /convert/edit/pdf/annotations/add-item | Add one or more PDF annotations, comments in the PDF document
*EditPdfApi* | [**EditPdfDecrypt**](docs/EditPdfApi.md#editpdfdecrypt) | **POST** /convert/edit/pdf/decrypt | Decrypt and password-protect a PDF
*EditPdfApi* | [**EditPdfDeletePages**](docs/EditPdfApi.md#editpdfdeletepages) | **POST** /convert/edit/pdf/pages/delete | Remove / delete pages from a PDF document
*EditPdfApi* | [**EditPdfEncrypt**](docs/EditPdfApi.md#editpdfencrypt) | **POST** /convert/edit/pdf/encrypt | Encrypt and password-protect a PDF
*EditPdfApi* | [**EditPdfGetAnnotations**](docs/EditPdfApi.md#editpdfgetannotations) | **POST** /convert/edit/pdf/annotations/list | Get PDF annotations, including comments in the document
*EditPdfApi* | [**EditPdfGetFormFields**](docs/EditPdfApi.md#editpdfgetformfields) | **POST** /convert/edit/pdf/form/get-fields | Gets PDF Form fields and values
*EditPdfApi* | [**EditPdfGetMetadata**](docs/EditPdfApi.md#editpdfgetmetadata) | **POST** /convert/edit/pdf/get-metadata | Get PDF document metadata
*EditPdfApi* | [**EditPdfGetPdfTextByPages**](docs/EditPdfApi.md#editpdfgetpdftextbypages) | **POST** /convert/edit/pdf/pages/get-text | Get text in a PDF document by page
*EditPdfApi* | [**EditPdfInsertPages**](docs/EditPdfApi.md#editpdfinsertpages) | **POST** /convert/edit/pdf/pages/insert | Insert / copy pages from one PDF document into another
*EditPdfApi* | [**EditPdfRasterize**](docs/EditPdfApi.md#editpdfrasterize) | **POST** /convert/edit/pdf/rasterize | Rasterize a PDF to an image-based PDF
*EditPdfApi* | [**EditPdfRemoveAllAnnotations**](docs/EditPdfApi.md#editpdfremoveallannotations) | **POST** /convert/edit/pdf/annotations/remove-all | Remove all PDF annotations, including comments in the document
*EditPdfApi* | [**EditPdfRemoveAnnotationItem**](docs/EditPdfApi.md#editpdfremoveannotationitem) | **POST** /convert/edit/pdf/annotations/remove-item | Remove a specific PDF annotation, comment in the document
*EditPdfApi* | [**EditPdfRotateAllPages**](docs/EditPdfApi.md#editpdfrotateallpages) | **POST** /convert/edit/pdf/pages/rotate/all | Rotate all pages in a PDF document
*EditPdfApi* | [**EditPdfRotatePageRange**](docs/EditPdfApi.md#editpdfrotatepagerange) | **POST** /convert/edit/pdf/pages/rotate/page-range | Rotate a range, subset of pages in a PDF document
*EditPdfApi* | [**EditPdfSetFormFields**](docs/EditPdfApi.md#editpdfsetformfields) | **POST** /convert/edit/pdf/form/set-fields | Sets ands fills PDF Form field values
*EditPdfApi* | [**EditPdfSetMetadata**](docs/EditPdfApi.md#editpdfsetmetadata) | **POST** /convert/edit/pdf/set-metadata | Sets PDF document metadata
*EditPdfApi* | [**EditPdfSetPermissions**](docs/EditPdfApi.md#editpdfsetpermissions) | **POST** /convert/edit/pdf/encrypt/set-permissions | Encrypt, password-protect and set restricted permissions on a PDF
*EditPdfApi* | [**EditPdfWatermarkText**](docs/EditPdfApi.md#editpdfwatermarktext) | **POST** /convert/edit/pdf/watermark/text | Add a text watermark to a PDF
*MergeDocumentApi* | [**MergeDocumentDocx**](docs/MergeDocumentApi.md#mergedocumentdocx) | **POST** /convert/merge/docx | Merge Two Word DOCX Together
*MergeDocumentApi* | [**MergeDocumentDocxMulti**](docs/MergeDocumentApi.md#mergedocumentdocxmulti) | **POST** /convert/merge/docx/multi | Merge Multple Word DOCX Together
*MergeDocumentApi* | [**MergeDocumentPdf**](docs/MergeDocumentApi.md#mergedocumentpdf) | **POST** /convert/merge/pdf | Merge Two PDF Files Together
*MergeDocumentApi* | [**MergeDocumentPdfMulti**](docs/MergeDocumentApi.md#mergedocumentpdfmulti) | **POST** /convert/merge/pdf/multi | Merge Multple PDF Files Together
*MergeDocumentApi* | [**MergeDocumentPng**](docs/MergeDocumentApi.md#mergedocumentpng) | **POST** /convert/merge/png/vertical | Merge Multple PNG Files Together
*MergeDocumentApi* | [**MergeDocumentPptx**](docs/MergeDocumentApi.md#mergedocumentpptx) | **POST** /convert/merge/pptx | Merge Two PowerPoint PPTX Together
*MergeDocumentApi* | [**MergeDocumentPptxMulti**](docs/MergeDocumentApi.md#mergedocumentpptxmulti) | **POST** /convert/merge/pptx/multi | Merge Multple PowerPoint PPTX Together
*MergeDocumentApi* | [**MergeDocumentXlsx**](docs/MergeDocumentApi.md#mergedocumentxlsx) | **POST** /convert/merge/xlsx | Merge Two Excel XLSX Together
*MergeDocumentApi* | [**MergeDocumentXlsxMulti**](docs/MergeDocumentApi.md#mergedocumentxlsxmulti) | **POST** /convert/merge/xlsx/multi | Merge Multple Excel XLSX Together
*SplitDocumentApi* | [**SplitDocumentPdfByPage**](docs/SplitDocumentApi.md#splitdocumentpdfbypage) | **POST** /convert/split/pdf | Split a PDF file into separate PDF files, one per page
*SplitDocumentApi* | [**SplitDocumentPptx**](docs/SplitDocumentApi.md#splitdocumentpptx) | **POST** /convert/split/pptx | Split a single PowerPoint Presentation PPTX into Separate Slides
*SplitDocumentApi* | [**SplitDocumentXlsx**](docs/SplitDocumentApi.md#splitdocumentxlsx) | **POST** /convert/split/xlsx | Split a single Excel XLSX into Separate Worksheets
*ValidateDocumentApi* | [**ValidateDocumentAutodetectValidation**](docs/ValidateDocumentApi.md#validatedocumentautodetectvalidation) | **POST** /convert/validate/autodetect | Autodetect content type and validate
*ValidateDocumentApi* | [**ValidateDocumentDocxValidation**](docs/ValidateDocumentApi.md#validatedocumentdocxvalidation) | **POST** /convert/validate/docx | Validate a Word document (DOCX)
*ValidateDocumentApi* | [**ValidateDocumentExecutableValidation**](docs/ValidateDocumentApi.md#validatedocumentexecutablevalidation) | **POST** /convert/validate/executable | Validate if a file is executable
*ValidateDocumentApi* | [**ValidateDocumentJsonValidation**](docs/ValidateDocumentApi.md#validatedocumentjsonvalidation) | **POST** /convert/validate/json | Validate a JSON file
*ValidateDocumentApi* | [**ValidateDocumentPdfValidation**](docs/ValidateDocumentApi.md#validatedocumentpdfvalidation) | **POST** /convert/validate/pdf | Validate a PDF document file
*ValidateDocumentApi* | [**ValidateDocumentPptxValidation**](docs/ValidateDocumentApi.md#validatedocumentpptxvalidation) | **POST** /convert/validate/pptx | Validate a PowerPoint presentation (PPTX)
*ValidateDocumentApi* | [**ValidateDocumentXlsxValidation**](docs/ValidateDocumentApi.md#validatedocumentxlsxvalidation) | **POST** /convert/validate/xlsx | Validate a Excel document (XLSX)
*ValidateDocumentApi* | [**ValidateDocumentXmlValidation**](docs/ValidateDocumentApi.md#validatedocumentxmlvalidation) | **POST** /convert/validate/xml | Validate an XML file
*ViewerToolsApi* | [**ViewerToolsCreateSimple**](docs/ViewerToolsApi.md#viewertoolscreatesimple) | **POST** /convert/viewer/create/web/simple | Create a web-based viewer


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AddPdfAnnotationRequest](docs/AddPdfAnnotationRequest.md)
 - [Model.AlternateFileFormatCandidate](docs/AlternateFileFormatCandidate.md)
 - [Model.AutodetectDocumentValidationResult](docs/AutodetectDocumentValidationResult.md)
 - [Model.AutodetectGetInfoResult](docs/AutodetectGetInfoResult.md)
 - [Model.AutodetectToPngResult](docs/AutodetectToPngResult.md)
 - [Model.ConvertedPngPage](docs/ConvertedPngPage.md)
 - [Model.CreateBlankDocxRequest](docs/CreateBlankDocxRequest.md)
 - [Model.CreateBlankDocxResponse](docs/CreateBlankDocxResponse.md)
 - [Model.CreateBlankSpreadsheetRequest](docs/CreateBlankSpreadsheetRequest.md)
 - [Model.CreateBlankSpreadsheetResponse](docs/CreateBlankSpreadsheetResponse.md)
 - [Model.DeleteDocxTableRowRequest](docs/DeleteDocxTableRowRequest.md)
 - [Model.DeleteDocxTableRowResponse](docs/DeleteDocxTableRowResponse.md)
 - [Model.DocumentValidationError](docs/DocumentValidationError.md)
 - [Model.DocumentValidationResult](docs/DocumentValidationResult.md)
 - [Model.DocxBody](docs/DocxBody.md)
 - [Model.DocxCellStyle](docs/DocxCellStyle.md)
 - [Model.DocxFooter](docs/DocxFooter.md)
 - [Model.DocxHeader](docs/DocxHeader.md)
 - [Model.DocxImage](docs/DocxImage.md)
 - [Model.DocxInsertImageRequest](docs/DocxInsertImageRequest.md)
 - [Model.DocxInsertImageResponse](docs/DocxInsertImageResponse.md)
 - [Model.DocxPage](docs/DocxPage.md)
 - [Model.DocxParagraph](docs/DocxParagraph.md)
 - [Model.DocxRemoveObjectRequest](docs/DocxRemoveObjectRequest.md)
 - [Model.DocxRemoveObjectResponse](docs/DocxRemoveObjectResponse.md)
 - [Model.DocxRun](docs/DocxRun.md)
 - [Model.DocxSection](docs/DocxSection.md)
 - [Model.DocxSetFooterAddPageNumberRequest](docs/DocxSetFooterAddPageNumberRequest.md)
 - [Model.DocxSetFooterRequest](docs/DocxSetFooterRequest.md)
 - [Model.DocxSetFooterResponse](docs/DocxSetFooterResponse.md)
 - [Model.DocxSetHeaderRequest](docs/DocxSetHeaderRequest.md)
 - [Model.DocxSetHeaderResponse](docs/DocxSetHeaderResponse.md)
 - [Model.DocxStyle](docs/DocxStyle.md)
 - [Model.DocxTable](docs/DocxTable.md)
 - [Model.DocxTableCell](docs/DocxTableCell.md)
 - [Model.DocxTableRow](docs/DocxTableRow.md)
 - [Model.DocxTemplateApplicationRequest](docs/DocxTemplateApplicationRequest.md)
 - [Model.DocxTemplateOperation](docs/DocxTemplateOperation.md)
 - [Model.DocxText](docs/DocxText.md)
 - [Model.ExifValue](docs/ExifValue.md)
 - [Model.FinishEditingRequest](docs/FinishEditingRequest.md)
 - [Model.GetDocxBodyRequest](docs/GetDocxBodyRequest.md)
 - [Model.GetDocxBodyResponse](docs/GetDocxBodyResponse.md)
 - [Model.GetDocxHeadersAndFootersRequest](docs/GetDocxHeadersAndFootersRequest.md)
 - [Model.GetDocxHeadersAndFootersResponse](docs/GetDocxHeadersAndFootersResponse.md)
 - [Model.GetDocxImagesRequest](docs/GetDocxImagesRequest.md)
 - [Model.GetDocxImagesResponse](docs/GetDocxImagesResponse.md)
 - [Model.GetDocxPagesRequest](docs/GetDocxPagesRequest.md)
 - [Model.GetDocxPagesResponse](docs/GetDocxPagesResponse.md)
 - [Model.GetDocxSectionsRequest](docs/GetDocxSectionsRequest.md)
 - [Model.GetDocxSectionsResponse](docs/GetDocxSectionsResponse.md)
 - [Model.GetDocxStylesRequest](docs/GetDocxStylesRequest.md)
 - [Model.GetDocxStylesResponse](docs/GetDocxStylesResponse.md)
 - [Model.GetDocxTableByIndexRequest](docs/GetDocxTableByIndexRequest.md)
 - [Model.GetDocxTableByIndexResponse](docs/GetDocxTableByIndexResponse.md)
 - [Model.GetDocxTableRowRequest](docs/GetDocxTableRowRequest.md)
 - [Model.GetDocxTableRowResponse](docs/GetDocxTableRowResponse.md)
 - [Model.GetDocxTablesRequest](docs/GetDocxTablesRequest.md)
 - [Model.GetDocxTablesResponse](docs/GetDocxTablesResponse.md)
 - [Model.GetImageInfoResult](docs/GetImageInfoResult.md)
 - [Model.GetPdfAnnotationsResult](docs/GetPdfAnnotationsResult.md)
 - [Model.GetXlsxCellRequest](docs/GetXlsxCellRequest.md)
 - [Model.GetXlsxCellResponse](docs/GetXlsxCellResponse.md)
 - [Model.GetXlsxColumnsRequest](docs/GetXlsxColumnsRequest.md)
 - [Model.GetXlsxColumnsResponse](docs/GetXlsxColumnsResponse.md)
 - [Model.GetXlsxImagesRequest](docs/GetXlsxImagesRequest.md)
 - [Model.GetXlsxImagesResponse](docs/GetXlsxImagesResponse.md)
 - [Model.GetXlsxRowsAndCellsRequest](docs/GetXlsxRowsAndCellsRequest.md)
 - [Model.GetXlsxRowsAndCellsResponse](docs/GetXlsxRowsAndCellsResponse.md)
 - [Model.GetXlsxStylesRequest](docs/GetXlsxStylesRequest.md)
 - [Model.GetXlsxStylesResponse](docs/GetXlsxStylesResponse.md)
 - [Model.GetXlsxWorksheetsRequest](docs/GetXlsxWorksheetsRequest.md)
 - [Model.GetXlsxWorksheetsResponse](docs/GetXlsxWorksheetsResponse.md)
 - [Model.HtmlMdResult](docs/HtmlMdResult.md)
 - [Model.HtmlTemplateApplicationRequest](docs/HtmlTemplateApplicationRequest.md)
 - [Model.HtmlTemplateApplicationResponse](docs/HtmlTemplateApplicationResponse.md)
 - [Model.HtmlTemplateOperation](docs/HtmlTemplateOperation.md)
 - [Model.HtmlToOfficeRequest](docs/HtmlToOfficeRequest.md)
 - [Model.HtmlToPdfRequest](docs/HtmlToPdfRequest.md)
 - [Model.HtmlToPngRequest](docs/HtmlToPngRequest.md)
 - [Model.HtmlToTextRequest](docs/HtmlToTextRequest.md)
 - [Model.HtmlToTextResponse](docs/HtmlToTextResponse.md)
 - [Model.InsertDocxInsertParagraphRequest](docs/InsertDocxInsertParagraphRequest.md)
 - [Model.InsertDocxInsertParagraphResponse](docs/InsertDocxInsertParagraphResponse.md)
 - [Model.InsertDocxTableRowRequest](docs/InsertDocxTableRowRequest.md)
 - [Model.InsertDocxTableRowResponse](docs/InsertDocxTableRowResponse.md)
 - [Model.InsertDocxTablesRequest](docs/InsertDocxTablesRequest.md)
 - [Model.InsertDocxTablesResponse](docs/InsertDocxTablesResponse.md)
 - [Model.InsertXlsxWorksheetRequest](docs/InsertXlsxWorksheetRequest.md)
 - [Model.InsertXlsxWorksheetResponse](docs/InsertXlsxWorksheetResponse.md)
 - [Model.MultipageImageFormatConversionResult](docs/MultipageImageFormatConversionResult.md)
 - [Model.PageConversionResult](docs/PageConversionResult.md)
 - [Model.PdfAnnotation](docs/PdfAnnotation.md)
 - [Model.PdfDocument](docs/PdfDocument.md)
 - [Model.PdfFormField](docs/PdfFormField.md)
 - [Model.PdfFormFields](docs/PdfFormFields.md)
 - [Model.PdfMetadata](docs/PdfMetadata.md)
 - [Model.PdfPageText](docs/PdfPageText.md)
 - [Model.PdfTextByPageResult](docs/PdfTextByPageResult.md)
 - [Model.PdfToPngResult](docs/PdfToPngResult.md)
 - [Model.PresentationResult](docs/PresentationResult.md)
 - [Model.RemoveDocxHeadersAndFootersRequest](docs/RemoveDocxHeadersAndFootersRequest.md)
 - [Model.RemoveDocxHeadersAndFootersResponse](docs/RemoveDocxHeadersAndFootersResponse.md)
 - [Model.RemoveDocxPagesRequest](docs/RemoveDocxPagesRequest.md)
 - [Model.RemovePptxSlidesRequest](docs/RemovePptxSlidesRequest.md)
 - [Model.ReplaceStringRequest](docs/ReplaceStringRequest.md)
 - [Model.ScreenshotRequest](docs/ScreenshotRequest.md)
 - [Model.SetFormFieldValue](docs/SetFormFieldValue.md)
 - [Model.SetPdfFormFieldsRequest](docs/SetPdfFormFieldsRequest.md)
 - [Model.SetPdfMetadataRequest](docs/SetPdfMetadataRequest.md)
 - [Model.SplitPdfResult](docs/SplitPdfResult.md)
 - [Model.SplitPptxPresentationResult](docs/SplitPptxPresentationResult.md)
 - [Model.SplitXlsxWorksheetResult](docs/SplitXlsxWorksheetResult.md)
 - [Model.TextConversionResult](docs/TextConversionResult.md)
 - [Model.UpdateDocxTableCellRequest](docs/UpdateDocxTableCellRequest.md)
 - [Model.UpdateDocxTableCellResponse](docs/UpdateDocxTableCellResponse.md)
 - [Model.UpdateDocxTableRowRequest](docs/UpdateDocxTableRowRequest.md)
 - [Model.UpdateDocxTableRowResponse](docs/UpdateDocxTableRowResponse.md)
 - [Model.UrlToTextRequest](docs/UrlToTextRequest.md)
 - [Model.UrlToTextResponse](docs/UrlToTextResponse.md)
 - [Model.ViewerResponse](docs/ViewerResponse.md)
 - [Model.WorksheetResult](docs/WorksheetResult.md)
 - [Model.XlsxImage](docs/XlsxImage.md)
 - [Model.XlsxSpreadsheetCell](docs/XlsxSpreadsheetCell.md)
 - [Model.XlsxSpreadsheetColumn](docs/XlsxSpreadsheetColumn.md)
 - [Model.XlsxSpreadsheetRow](docs/XlsxSpreadsheetRow.md)
 - [Model.XlsxWorksheet](docs/XlsxWorksheet.md)
 - [Model.XmlAddAttributeWithXPathResult](docs/XmlAddAttributeWithXPathResult.md)
 - [Model.XmlAddChildWithXPathResult](docs/XmlAddChildWithXPathResult.md)
 - [Model.XmlFilterWithXPathResult](docs/XmlFilterWithXPathResult.md)
 - [Model.XmlQueryWithXQueryMultiResult](docs/XmlQueryWithXQueryMultiResult.md)
 - [Model.XmlQueryWithXQueryResult](docs/XmlQueryWithXQueryResult.md)
 - [Model.XmlRemoveAllChildrenWithXPathResult](docs/XmlRemoveAllChildrenWithXPathResult.md)
 - [Model.XmlRemoveWithXPathResult](docs/XmlRemoveWithXPathResult.md)
 - [Model.XmlReplaceWithXPathResult](docs/XmlReplaceWithXPathResult.md)
 - [Model.XmlSetValueWithXPathResult](docs/XmlSetValueWithXPathResult.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="Apikey"></a>
### Apikey

- **Type**: API key
- **API key parameter name**: Apikey
- **Location**: HTTP header

