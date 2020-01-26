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
    ///  Class for testing EditTextApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class EditTextApiTests
    {
        private EditTextApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new EditTextApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of EditTextApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' EditTextApi
            //Assert.IsInstanceOfType(typeof(EditTextApi), instance, "instance is a EditTextApi");
        }

        
        /// <summary>
        /// Test EditTextBase64Decode
        /// </summary>
        [Test]
        public void EditTextBase64DecodeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Base64DecodeRequest request = null;
            //var response = instance.EditTextBase64Decode(request);
            //Assert.IsInstanceOf<Base64DecodeResponse> (response, "response is Base64DecodeResponse");
        }
        
        /// <summary>
        /// Test EditTextBase64Detect
        /// </summary>
        [Test]
        public void EditTextBase64DetectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Base64DetectRequest request = null;
            //var response = instance.EditTextBase64Detect(request);
            //Assert.IsInstanceOf<Base64DetectResponse> (response, "response is Base64DetectResponse");
        }
        
        /// <summary>
        /// Test EditTextBase64Encode
        /// </summary>
        [Test]
        public void EditTextBase64EncodeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Base64EncodeRequest request = null;
            //var response = instance.EditTextBase64Encode(request);
            //Assert.IsInstanceOf<Base64EncodeResponse> (response, "response is Base64EncodeResponse");
        }
        
        /// <summary>
        /// Test EditTextChangeLineEndings
        /// </summary>
        [Test]
        public void EditTextChangeLineEndingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string lineEndingType = null;
            //System.IO.Stream inputFile = null;
            //var response = instance.EditTextChangeLineEndings(lineEndingType, inputFile);
            //Assert.IsInstanceOf<ChangeLineEndingResponse> (response, "response is ChangeLineEndingResponse");
        }
        
        /// <summary>
        /// Test EditTextDetectLineEndings
        /// </summary>
        [Test]
        public void EditTextDetectLineEndingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.EditTextDetectLineEndings(inputFile);
            //Assert.IsInstanceOf<DetectLineEndingsResponse> (response, "response is DetectLineEndingsResponse");
        }
        
        /// <summary>
        /// Test EditTextRemoveAllWhitespace
        /// </summary>
        [Test]
        public void EditTextRemoveAllWhitespaceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RemoveWhitespaceFromTextRequest request = null;
            //var response = instance.EditTextRemoveAllWhitespace(request);
            //Assert.IsInstanceOf<RemoveWhitespaceFromTextResponse> (response, "response is RemoveWhitespaceFromTextResponse");
        }
        
        /// <summary>
        /// Test EditTextRemoveHtml
        /// </summary>
        [Test]
        public void EditTextRemoveHtmlTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RemoveHtmlFromTextRequest request = null;
            //var response = instance.EditTextRemoveHtml(request);
            //Assert.IsInstanceOf<RemoveHtmlFromTextResponse> (response, "response is RemoveHtmlFromTextResponse");
        }
        
        /// <summary>
        /// Test EditTextTextEncodingDetect
        /// </summary>
        [Test]
        public void EditTextTextEncodingDetectTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //System.IO.Stream inputFile = null;
            //var response = instance.EditTextTextEncodingDetect(inputFile);
            //Assert.IsInstanceOf<TextEncodingDetectResponse> (response, "response is TextEncodingDetectResponse");
        }
        
        /// <summary>
        /// Test EditTextTrimWhitespace
        /// </summary>
        [Test]
        public void EditTextTrimWhitespaceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //RemoveWhitespaceFromTextRequest request = null;
            //var response = instance.EditTextTrimWhitespace(request);
            //Assert.IsInstanceOf<RemoveWhitespaceFromTextResponse> (response, "response is RemoveWhitespaceFromTextResponse");
        }
        
    }

}
