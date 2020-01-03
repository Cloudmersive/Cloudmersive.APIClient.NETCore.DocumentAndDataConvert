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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.Client;
using Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.Api;
using Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.Model;

namespace Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.Test
{
    /// <summary>
    ///  Class for testing EditDocumentApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class EditDocumentApiTests
    {
        private EditDocumentApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new EditDocumentApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of EditDocumentApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' EditDocumentApi
            //Assert.IsInstanceOfType(typeof(EditDocumentApi), instance, "instance is a EditDocumentApi");
        }

        
        /// <summary>
        /// Test EditDocumentBeginEditing
        /// </summary>
        [Test]
        public void EditDocumentBeginEditingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.EditDocumentBeginEditing(inputFile);
            //Assert.IsInstanceOf<string> (response, "response is string");
        }
        
        /// <summary>
        /// Test EditDocumentDocxBody
        /// </summary>
        [Test]
        public void EditDocumentDocxBodyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GetDocxBodyRequest reqConfig = null;
            //var response = instance.EditDocumentDocxBody(reqConfig);
            //Assert.IsInstanceOf<GetDocxBodyResponse> (response, "response is GetDocxBodyResponse");
        }
        
        /// <summary>
        /// Test EditDocumentDocxCreateBlankDocument
        /// </summary>
        [Test]
        public void EditDocumentDocxCreateBlankDocumentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateBlankDocxRequest input = null;
            //var response = instance.EditDocumentDocxCreateBlankDocument(input);
            //Assert.IsInstanceOf<CreateBlankDocxResponse> (response, "response is CreateBlankDocxResponse");
        }
        
        /// <summary>
        /// Test EditDocumentDocxDeletePages
        /// </summary>
        [Test]
        public void EditDocumentDocxDeletePagesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RemoveDocxPagesRequest reqConfig = null;
            //var response = instance.EditDocumentDocxDeletePages(reqConfig);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test EditDocumentDocxDeleteTableRow
        /// </summary>
        [Test]
        public void EditDocumentDocxDeleteTableRowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DeleteDocxTableRowRequest reqConfig = null;
            //var response = instance.EditDocumentDocxDeleteTableRow(reqConfig);
            //Assert.IsInstanceOf<DeleteDocxTableRowResponse> (response, "response is DeleteDocxTableRowResponse");
        }
        
        /// <summary>
        /// Test EditDocumentDocxGetHeadersAndFooters
        /// </summary>
        [Test]
        public void EditDocumentDocxGetHeadersAndFootersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GetDocxHeadersAndFootersRequest reqConfig = null;
            //var response = instance.EditDocumentDocxGetHeadersAndFooters(reqConfig);
            //Assert.IsInstanceOf<GetDocxHeadersAndFootersResponse> (response, "response is GetDocxHeadersAndFootersResponse");
        }
        
        /// <summary>
        /// Test EditDocumentDocxGetImages
        /// </summary>
        [Test]
        public void EditDocumentDocxGetImagesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GetDocxImagesRequest reqConfig = null;
            //var response = instance.EditDocumentDocxGetImages(reqConfig);
            //Assert.IsInstanceOf<GetDocxImagesResponse> (response, "response is GetDocxImagesResponse");
        }
        
        /// <summary>
        /// Test EditDocumentDocxGetSections
        /// </summary>
        [Test]
        public void EditDocumentDocxGetSectionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GetDocxSectionsRequest reqConfig = null;
            //var response = instance.EditDocumentDocxGetSections(reqConfig);
            //Assert.IsInstanceOf<GetDocxSectionsResponse> (response, "response is GetDocxSectionsResponse");
        }
        
        /// <summary>
        /// Test EditDocumentDocxGetStyles
        /// </summary>
        [Test]
        public void EditDocumentDocxGetStylesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GetDocxStylesRequest reqConfig = null;
            //var response = instance.EditDocumentDocxGetStyles(reqConfig);
            //Assert.IsInstanceOf<GetDocxStylesResponse> (response, "response is GetDocxStylesResponse");
        }
        
        /// <summary>
        /// Test EditDocumentDocxGetTableByIndex
        /// </summary>
        [Test]
        public void EditDocumentDocxGetTableByIndexTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GetDocxTableByIndexRequest reqConfig = null;
            //var response = instance.EditDocumentDocxGetTableByIndex(reqConfig);
            //Assert.IsInstanceOf<GetDocxTableByIndexResponse> (response, "response is GetDocxTableByIndexResponse");
        }
        
        /// <summary>
        /// Test EditDocumentDocxGetTableRow
        /// </summary>
        [Test]
        public void EditDocumentDocxGetTableRowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GetDocxTableRowRequest reqConfig = null;
            //var response = instance.EditDocumentDocxGetTableRow(reqConfig);
            //Assert.IsInstanceOf<GetDocxTableRowResponse> (response, "response is GetDocxTableRowResponse");
        }
        
        /// <summary>
        /// Test EditDocumentDocxGetTables
        /// </summary>
        [Test]
        public void EditDocumentDocxGetTablesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GetDocxTablesRequest reqConfig = null;
            //var response = instance.EditDocumentDocxGetTables(reqConfig);
            //Assert.IsInstanceOf<GetDocxTablesResponse> (response, "response is GetDocxTablesResponse");
        }
        
        /// <summary>
        /// Test EditDocumentDocxInsertImage
        /// </summary>
        [Test]
        public void EditDocumentDocxInsertImageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DocxInsertImageRequest reqConfig = null;
            //var response = instance.EditDocumentDocxInsertImage(reqConfig);
            //Assert.IsInstanceOf<DocxInsertImageResponse> (response, "response is DocxInsertImageResponse");
        }
        
        /// <summary>
        /// Test EditDocumentDocxInsertParagraph
        /// </summary>
        [Test]
        public void EditDocumentDocxInsertParagraphTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //InsertDocxInsertParagraphRequest reqConfig = null;
            //var response = instance.EditDocumentDocxInsertParagraph(reqConfig);
            //Assert.IsInstanceOf<InsertDocxInsertParagraphResponse> (response, "response is InsertDocxInsertParagraphResponse");
        }
        
        /// <summary>
        /// Test EditDocumentDocxInsertTable
        /// </summary>
        [Test]
        public void EditDocumentDocxInsertTableTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //InsertDocxTablesRequest reqConfig = null;
            //var response = instance.EditDocumentDocxInsertTable(reqConfig);
            //Assert.IsInstanceOf<InsertDocxTablesResponse> (response, "response is InsertDocxTablesResponse");
        }
        
        /// <summary>
        /// Test EditDocumentDocxInsertTableRow
        /// </summary>
        [Test]
        public void EditDocumentDocxInsertTableRowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //InsertDocxTableRowRequest reqConfig = null;
            //var response = instance.EditDocumentDocxInsertTableRow(reqConfig);
            //Assert.IsInstanceOf<InsertDocxTableRowResponse> (response, "response is InsertDocxTableRowResponse");
        }
        
        /// <summary>
        /// Test EditDocumentDocxPages
        /// </summary>
        [Test]
        public void EditDocumentDocxPagesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GetDocxPagesRequest reqConfig = null;
            //var response = instance.EditDocumentDocxPages(reqConfig);
            //Assert.IsInstanceOf<GetDocxPagesResponse> (response, "response is GetDocxPagesResponse");
        }
        
        /// <summary>
        /// Test EditDocumentDocxRemoveHeadersAndFooters
        /// </summary>
        [Test]
        public void EditDocumentDocxRemoveHeadersAndFootersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RemoveDocxHeadersAndFootersRequest reqConfig = null;
            //var response = instance.EditDocumentDocxRemoveHeadersAndFooters(reqConfig);
            //Assert.IsInstanceOf<RemoveDocxHeadersAndFootersResponse> (response, "response is RemoveDocxHeadersAndFootersResponse");
        }
        
        /// <summary>
        /// Test EditDocumentDocxRemoveObject
        /// </summary>
        [Test]
        public void EditDocumentDocxRemoveObjectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DocxRemoveObjectRequest reqConfig = null;
            //var response = instance.EditDocumentDocxRemoveObject(reqConfig);
            //Assert.IsInstanceOf<DocxRemoveObjectResponse> (response, "response is DocxRemoveObjectResponse");
        }
        
        /// <summary>
        /// Test EditDocumentDocxReplace
        /// </summary>
        [Test]
        public void EditDocumentDocxReplaceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ReplaceStringRequest reqConfig = null;
            //var response = instance.EditDocumentDocxReplace(reqConfig);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test EditDocumentDocxSetFooter
        /// </summary>
        [Test]
        public void EditDocumentDocxSetFooterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DocxSetFooterRequest reqConfig = null;
            //var response = instance.EditDocumentDocxSetFooter(reqConfig);
            //Assert.IsInstanceOf<DocxSetFooterResponse> (response, "response is DocxSetFooterResponse");
        }
        
        /// <summary>
        /// Test EditDocumentDocxSetFooterAddPageNumber
        /// </summary>
        [Test]
        public void EditDocumentDocxSetFooterAddPageNumberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DocxSetFooterAddPageNumberRequest reqConfig = null;
            //var response = instance.EditDocumentDocxSetFooterAddPageNumber(reqConfig);
            //Assert.IsInstanceOf<DocxSetFooterResponse> (response, "response is DocxSetFooterResponse");
        }
        
        /// <summary>
        /// Test EditDocumentDocxSetHeader
        /// </summary>
        [Test]
        public void EditDocumentDocxSetHeaderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DocxSetHeaderRequest reqConfig = null;
            //var response = instance.EditDocumentDocxSetHeader(reqConfig);
            //Assert.IsInstanceOf<DocxSetHeaderResponse> (response, "response is DocxSetHeaderResponse");
        }
        
        /// <summary>
        /// Test EditDocumentDocxUpdateTableCell
        /// </summary>
        [Test]
        public void EditDocumentDocxUpdateTableCellTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UpdateDocxTableCellRequest reqConfig = null;
            //var response = instance.EditDocumentDocxUpdateTableCell(reqConfig);
            //Assert.IsInstanceOf<UpdateDocxTableCellResponse> (response, "response is UpdateDocxTableCellResponse");
        }
        
        /// <summary>
        /// Test EditDocumentDocxUpdateTableRow
        /// </summary>
        [Test]
        public void EditDocumentDocxUpdateTableRowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UpdateDocxTableRowRequest reqConfig = null;
            //var response = instance.EditDocumentDocxUpdateTableRow(reqConfig);
            //Assert.IsInstanceOf<UpdateDocxTableRowResponse> (response, "response is UpdateDocxTableRowResponse");
        }
        
        /// <summary>
        /// Test EditDocumentFinishEditing
        /// </summary>
        [Test]
        public void EditDocumentFinishEditingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //FinishEditingRequest reqConfig = null;
            //var response = instance.EditDocumentFinishEditing(reqConfig);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test EditDocumentPptxDeleteSlides
        /// </summary>
        [Test]
        public void EditDocumentPptxDeleteSlidesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RemovePptxSlidesRequest reqConfig = null;
            //var response = instance.EditDocumentPptxDeleteSlides(reqConfig);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test EditDocumentPptxReplace
        /// </summary>
        [Test]
        public void EditDocumentPptxReplaceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ReplaceStringRequest reqConfig = null;
            //var response = instance.EditDocumentPptxReplace(reqConfig);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test EditDocumentXlsxCreateBlankSpreadsheet
        /// </summary>
        [Test]
        public void EditDocumentXlsxCreateBlankSpreadsheetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateBlankSpreadsheetRequest input = null;
            //var response = instance.EditDocumentXlsxCreateBlankSpreadsheet(input);
            //Assert.IsInstanceOf<CreateBlankSpreadsheetResponse> (response, "response is CreateBlankSpreadsheetResponse");
        }
        
        /// <summary>
        /// Test EditDocumentXlsxCreateSpreadsheetFromData
        /// </summary>
        [Test]
        public void EditDocumentXlsxCreateSpreadsheetFromDataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateSpreadsheetFromDataRequest input = null;
            //var response = instance.EditDocumentXlsxCreateSpreadsheetFromData(input);
            //Assert.IsInstanceOf<CreateSpreadsheetFromDataResponse> (response, "response is CreateSpreadsheetFromDataResponse");
        }
        
        /// <summary>
        /// Test EditDocumentXlsxGetCellByIndex
        /// </summary>
        [Test]
        public void EditDocumentXlsxGetCellByIndexTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GetXlsxCellRequest input = null;
            //var response = instance.EditDocumentXlsxGetCellByIndex(input);
            //Assert.IsInstanceOf<GetXlsxCellResponse> (response, "response is GetXlsxCellResponse");
        }
        
        /// <summary>
        /// Test EditDocumentXlsxGetColumns
        /// </summary>
        [Test]
        public void EditDocumentXlsxGetColumnsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GetXlsxColumnsRequest input = null;
            //var response = instance.EditDocumentXlsxGetColumns(input);
            //Assert.IsInstanceOf<GetXlsxColumnsResponse> (response, "response is GetXlsxColumnsResponse");
        }
        
        /// <summary>
        /// Test EditDocumentXlsxGetImages
        /// </summary>
        [Test]
        public void EditDocumentXlsxGetImagesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GetXlsxImagesRequest input = null;
            //var response = instance.EditDocumentXlsxGetImages(input);
            //Assert.IsInstanceOf<GetXlsxImagesResponse> (response, "response is GetXlsxImagesResponse");
        }
        
        /// <summary>
        /// Test EditDocumentXlsxGetRowsAndCells
        /// </summary>
        [Test]
        public void EditDocumentXlsxGetRowsAndCellsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GetXlsxRowsAndCellsRequest input = null;
            //var response = instance.EditDocumentXlsxGetRowsAndCells(input);
            //Assert.IsInstanceOf<GetXlsxRowsAndCellsResponse> (response, "response is GetXlsxRowsAndCellsResponse");
        }
        
        /// <summary>
        /// Test EditDocumentXlsxGetStyles
        /// </summary>
        [Test]
        public void EditDocumentXlsxGetStylesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GetXlsxStylesRequest input = null;
            //var response = instance.EditDocumentXlsxGetStyles(input);
            //Assert.IsInstanceOf<GetXlsxStylesResponse> (response, "response is GetXlsxStylesResponse");
        }
        
        /// <summary>
        /// Test EditDocumentXlsxGetWorksheets
        /// </summary>
        [Test]
        public void EditDocumentXlsxGetWorksheetsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //GetXlsxWorksheetsRequest input = null;
            //var response = instance.EditDocumentXlsxGetWorksheets(input);
            //Assert.IsInstanceOf<GetXlsxWorksheetsResponse> (response, "response is GetXlsxWorksheetsResponse");
        }
        
        /// <summary>
        /// Test EditDocumentXlsxInsertWorksheet
        /// </summary>
        [Test]
        public void EditDocumentXlsxInsertWorksheetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //InsertXlsxWorksheetRequest input = null;
            //var response = instance.EditDocumentXlsxInsertWorksheet(input);
            //Assert.IsInstanceOf<InsertXlsxWorksheetResponse> (response, "response is InsertXlsxWorksheetResponse");
        }
        
    }

}
