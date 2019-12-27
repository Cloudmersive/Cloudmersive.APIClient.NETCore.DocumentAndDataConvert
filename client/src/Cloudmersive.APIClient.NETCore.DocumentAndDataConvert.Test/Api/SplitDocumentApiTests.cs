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
    ///  Class for testing SplitDocumentApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class SplitDocumentApiTests
    {
        private SplitDocumentApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SplitDocumentApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SplitDocumentApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' SplitDocumentApi
            //Assert.IsInstanceOfType(typeof(SplitDocumentApi), instance, "instance is a SplitDocumentApi");
        }

        
        /// <summary>
        /// Test SplitDocumentPdfByPage
        /// </summary>
        [Test]
        public void SplitDocumentPdfByPageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //bool? returnDocumentContents = null;
            //var response = instance.SplitDocumentPdfByPage(inputFile, returnDocumentContents);
            //Assert.IsInstanceOf<SplitPdfResult> (response, "response is SplitPdfResult");
        }
        
        /// <summary>
        /// Test SplitDocumentPptx
        /// </summary>
        [Test]
        public void SplitDocumentPptxTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //bool? returnDocumentContents = null;
            //var response = instance.SplitDocumentPptx(inputFile, returnDocumentContents);
            //Assert.IsInstanceOf<SplitPptxPresentationResult> (response, "response is SplitPptxPresentationResult");
        }
        
        /// <summary>
        /// Test SplitDocumentXlsx
        /// </summary>
        [Test]
        public void SplitDocumentXlsxTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //bool? returnDocumentContents = null;
            //var response = instance.SplitDocumentXlsx(inputFile, returnDocumentContents);
            //Assert.IsInstanceOf<SplitXlsxWorksheetResult> (response, "response is SplitXlsxWorksheetResult");
        }
        
    }

}
