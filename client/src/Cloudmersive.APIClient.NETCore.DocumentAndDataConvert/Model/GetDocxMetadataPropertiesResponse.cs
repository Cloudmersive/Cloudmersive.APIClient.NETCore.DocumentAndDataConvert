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
    /// Result of running a DocxGetMetadataProperties command
    /// </summary>
    [DataContract]
    public partial class GetDocxMetadataPropertiesResponse :  IEquatable<GetDocxMetadataPropertiesResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocxMetadataPropertiesResponse" /> class.
        /// </summary>
        /// <param name="company">Name of the Company that authored the document, if available.</param>
        /// <param name="manager">Name of the Manager that authored the document, if available.</param>
        /// <param name="applicationVersion">Application version that authored the document, if available.</param>
        /// <param name="wordCount">Word count of the document.</param>
        /// <param name="lineCount">Line count of the document.</param>
        /// <param name="paragraphCount">Paragraph count of the document.</param>
        /// <param name="pageCount">Page count of the document.</param>
        /// <param name="customProperties">Custom properties applied to the document.</param>
        /// <param name="successful">True if successful, false otherwise.</param>
        public GetDocxMetadataPropertiesResponse(string company = default(string), string manager = default(string), string applicationVersion = default(string), long? wordCount = default(long?), long? lineCount = default(long?), long? paragraphCount = default(long?), long? pageCount = default(long?), List<DocxMetadataCustomProperty> customProperties = default(List<DocxMetadataCustomProperty>), bool? successful = default(bool?))
        {
            this.Company = company;
            this.Manager = manager;
            this.ApplicationVersion = applicationVersion;
            this.WordCount = wordCount;
            this.LineCount = lineCount;
            this.ParagraphCount = paragraphCount;
            this.PageCount = pageCount;
            this.CustomProperties = customProperties;
            this.Successful = successful;
        }
        
        /// <summary>
        /// Name of the Company that authored the document, if available
        /// </summary>
        /// <value>Name of the Company that authored the document, if available</value>
        [DataMember(Name="Company", EmitDefaultValue=false)]
        public string Company { get; set; }

        /// <summary>
        /// Name of the Manager that authored the document, if available
        /// </summary>
        /// <value>Name of the Manager that authored the document, if available</value>
        [DataMember(Name="Manager", EmitDefaultValue=false)]
        public string Manager { get; set; }

        /// <summary>
        /// Application version that authored the document, if available
        /// </summary>
        /// <value>Application version that authored the document, if available</value>
        [DataMember(Name="ApplicationVersion", EmitDefaultValue=false)]
        public string ApplicationVersion { get; set; }

        /// <summary>
        /// Word count of the document
        /// </summary>
        /// <value>Word count of the document</value>
        [DataMember(Name="WordCount", EmitDefaultValue=false)]
        public long? WordCount { get; set; }

        /// <summary>
        /// Line count of the document
        /// </summary>
        /// <value>Line count of the document</value>
        [DataMember(Name="LineCount", EmitDefaultValue=false)]
        public long? LineCount { get; set; }

        /// <summary>
        /// Paragraph count of the document
        /// </summary>
        /// <value>Paragraph count of the document</value>
        [DataMember(Name="ParagraphCount", EmitDefaultValue=false)]
        public long? ParagraphCount { get; set; }

        /// <summary>
        /// Page count of the document
        /// </summary>
        /// <value>Page count of the document</value>
        [DataMember(Name="PageCount", EmitDefaultValue=false)]
        public long? PageCount { get; set; }

        /// <summary>
        /// Custom properties applied to the document
        /// </summary>
        /// <value>Custom properties applied to the document</value>
        [DataMember(Name="CustomProperties", EmitDefaultValue=false)]
        public List<DocxMetadataCustomProperty> CustomProperties { get; set; }

        /// <summary>
        /// True if successful, false otherwise
        /// </summary>
        /// <value>True if successful, false otherwise</value>
        [DataMember(Name="Successful", EmitDefaultValue=false)]
        public bool? Successful { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetDocxMetadataPropertiesResponse {\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  Manager: ").Append(Manager).Append("\n");
            sb.Append("  ApplicationVersion: ").Append(ApplicationVersion).Append("\n");
            sb.Append("  WordCount: ").Append(WordCount).Append("\n");
            sb.Append("  LineCount: ").Append(LineCount).Append("\n");
            sb.Append("  ParagraphCount: ").Append(ParagraphCount).Append("\n");
            sb.Append("  PageCount: ").Append(PageCount).Append("\n");
            sb.Append("  CustomProperties: ").Append(CustomProperties).Append("\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
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
            return this.Equals(input as GetDocxMetadataPropertiesResponse);
        }

        /// <summary>
        /// Returns true if GetDocxMetadataPropertiesResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetDocxMetadataPropertiesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetDocxMetadataPropertiesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Company == input.Company ||
                    (this.Company != null &&
                    this.Company.Equals(input.Company))
                ) && 
                (
                    this.Manager == input.Manager ||
                    (this.Manager != null &&
                    this.Manager.Equals(input.Manager))
                ) && 
                (
                    this.ApplicationVersion == input.ApplicationVersion ||
                    (this.ApplicationVersion != null &&
                    this.ApplicationVersion.Equals(input.ApplicationVersion))
                ) && 
                (
                    this.WordCount == input.WordCount ||
                    (this.WordCount != null &&
                    this.WordCount.Equals(input.WordCount))
                ) && 
                (
                    this.LineCount == input.LineCount ||
                    (this.LineCount != null &&
                    this.LineCount.Equals(input.LineCount))
                ) && 
                (
                    this.ParagraphCount == input.ParagraphCount ||
                    (this.ParagraphCount != null &&
                    this.ParagraphCount.Equals(input.ParagraphCount))
                ) && 
                (
                    this.PageCount == input.PageCount ||
                    (this.PageCount != null &&
                    this.PageCount.Equals(input.PageCount))
                ) && 
                (
                    this.CustomProperties == input.CustomProperties ||
                    this.CustomProperties != null &&
                    this.CustomProperties.SequenceEqual(input.CustomProperties)
                ) && 
                (
                    this.Successful == input.Successful ||
                    (this.Successful != null &&
                    this.Successful.Equals(input.Successful))
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
                if (this.Company != null)
                    hashCode = hashCode * 59 + this.Company.GetHashCode();
                if (this.Manager != null)
                    hashCode = hashCode * 59 + this.Manager.GetHashCode();
                if (this.ApplicationVersion != null)
                    hashCode = hashCode * 59 + this.ApplicationVersion.GetHashCode();
                if (this.WordCount != null)
                    hashCode = hashCode * 59 + this.WordCount.GetHashCode();
                if (this.LineCount != null)
                    hashCode = hashCode * 59 + this.LineCount.GetHashCode();
                if (this.ParagraphCount != null)
                    hashCode = hashCode * 59 + this.ParagraphCount.GetHashCode();
                if (this.PageCount != null)
                    hashCode = hashCode * 59 + this.PageCount.GetHashCode();
                if (this.CustomProperties != null)
                    hashCode = hashCode * 59 + this.CustomProperties.GetHashCode();
                if (this.Successful != null)
                    hashCode = hashCode * 59 + this.Successful.GetHashCode();
                return hashCode;
            }
        }
    }

}