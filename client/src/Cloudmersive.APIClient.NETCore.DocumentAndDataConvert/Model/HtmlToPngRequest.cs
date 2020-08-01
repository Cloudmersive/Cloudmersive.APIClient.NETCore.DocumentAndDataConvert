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
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.Client.SwaggerDateConverter;

namespace Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.Model
{
    /// <summary>
    /// Details of the HTML to PNG request
    /// </summary>
    [DataContract]
    public partial class HtmlToPngRequest :  IEquatable<HtmlToPngRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlToPngRequest" /> class.
        /// </summary>
        /// <param name="html">HTML to render to PNG (screenshot).</param>
        /// <param name="extraLoadingWait">Optional: Additional number of milliseconds to wait once the web page has finished loading before taking the screenshot.  Can be helpful for highly asynchronous websites. Provide a value of 0 for the default of 5000 milliseconds (5 seconds). Maximum is 30000 milliseconds (30 seconds)..</param>
        /// <param name="screenshotWidth">Optional: Width of the screenshot in pixels; supply 0 to default to 1280 x 1024, supply -1 to measure the full screen height of the page and attempt to take a screen-height screenshot.</param>
        /// <param name="screenshotHeight">Optional: Height of the screenshot in pixels; supply 0 to default to 1280 x 1024, supply -1 to measure the full screen height of the page and attempt to take a screen-height screenshot.</param>
        public HtmlToPngRequest(string html = default(string), int? extraLoadingWait = default(int?), int? screenshotWidth = default(int?), int? screenshotHeight = default(int?))
        {
            this.Html = html;
            this.ExtraLoadingWait = extraLoadingWait;
            this.ScreenshotWidth = screenshotWidth;
            this.ScreenshotHeight = screenshotHeight;
        }
        
        /// <summary>
        /// HTML to render to PNG (screenshot)
        /// </summary>
        /// <value>HTML to render to PNG (screenshot)</value>
        [DataMember(Name="Html", EmitDefaultValue=false)]
        public string Html { get; set; }

        /// <summary>
        /// Optional: Additional number of milliseconds to wait once the web page has finished loading before taking the screenshot.  Can be helpful for highly asynchronous websites. Provide a value of 0 for the default of 5000 milliseconds (5 seconds). Maximum is 30000 milliseconds (30 seconds).
        /// </summary>
        /// <value>Optional: Additional number of milliseconds to wait once the web page has finished loading before taking the screenshot.  Can be helpful for highly asynchronous websites. Provide a value of 0 for the default of 5000 milliseconds (5 seconds). Maximum is 30000 milliseconds (30 seconds).</value>
        [DataMember(Name="ExtraLoadingWait", EmitDefaultValue=false)]
        public int? ExtraLoadingWait { get; set; }

        /// <summary>
        /// Optional: Width of the screenshot in pixels; supply 0 to default to 1280 x 1024, supply -1 to measure the full screen height of the page and attempt to take a screen-height screenshot
        /// </summary>
        /// <value>Optional: Width of the screenshot in pixels; supply 0 to default to 1280 x 1024, supply -1 to measure the full screen height of the page and attempt to take a screen-height screenshot</value>
        [DataMember(Name="ScreenshotWidth", EmitDefaultValue=false)]
        public int? ScreenshotWidth { get; set; }

        /// <summary>
        /// Optional: Height of the screenshot in pixels; supply 0 to default to 1280 x 1024, supply -1 to measure the full screen height of the page and attempt to take a screen-height screenshot
        /// </summary>
        /// <value>Optional: Height of the screenshot in pixels; supply 0 to default to 1280 x 1024, supply -1 to measure the full screen height of the page and attempt to take a screen-height screenshot</value>
        [DataMember(Name="ScreenshotHeight", EmitDefaultValue=false)]
        public int? ScreenshotHeight { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HtmlToPngRequest {\n");
            sb.Append("  Html: ").Append(Html).Append("\n");
            sb.Append("  ExtraLoadingWait: ").Append(ExtraLoadingWait).Append("\n");
            sb.Append("  ScreenshotWidth: ").Append(ScreenshotWidth).Append("\n");
            sb.Append("  ScreenshotHeight: ").Append(ScreenshotHeight).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as HtmlToPngRequest);
        }

        /// <summary>
        /// Returns true if HtmlToPngRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of HtmlToPngRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HtmlToPngRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Html == input.Html ||
                    (this.Html != null &&
                    this.Html.Equals(input.Html))
                ) && 
                (
                    this.ExtraLoadingWait == input.ExtraLoadingWait ||
                    (this.ExtraLoadingWait != null &&
                    this.ExtraLoadingWait.Equals(input.ExtraLoadingWait))
                ) && 
                (
                    this.ScreenshotWidth == input.ScreenshotWidth ||
                    (this.ScreenshotWidth != null &&
                    this.ScreenshotWidth.Equals(input.ScreenshotWidth))
                ) && 
                (
                    this.ScreenshotHeight == input.ScreenshotHeight ||
                    (this.ScreenshotHeight != null &&
                    this.ScreenshotHeight.Equals(input.ScreenshotHeight))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Html != null)
                    hashCode = hashCode * 59 + this.Html.GetHashCode();
                if (this.ExtraLoadingWait != null)
                    hashCode = hashCode * 59 + this.ExtraLoadingWait.GetHashCode();
                if (this.ScreenshotWidth != null)
                    hashCode = hashCode * 59 + this.ScreenshotWidth.GetHashCode();
                if (this.ScreenshotHeight != null)
                    hashCode = hashCode * 59 + this.ScreenshotHeight.GetHashCode();
                return hashCode;
            }
        }
    }

}
