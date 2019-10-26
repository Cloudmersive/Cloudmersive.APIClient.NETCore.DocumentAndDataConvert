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
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.Client.SwaggerDateConverter;

namespace Cloudmersive.APIClient.NETCore.DocumentAndDataConvert.Model
{
    /// <summary>
    /// Result of an autodetect/get-info operation
    /// </summary>
    [DataContract]
    public partial class AutodetectGetInfoResult :  IEquatable<AutodetectGetInfoResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutodetectGetInfoResult" /> class.
        /// </summary>
        /// <param name="Successful">True if the operation was successful, false otherwise.</param>
        /// <param name="DetectedFileExtension">Detected file extension of the file format, with a leading period.</param>
        /// <param name="DetectedMimeType">MIME type of this file extension.</param>
        /// <param name="PageCount">Number of pages in a page-based document; for presentations, this is the number of slides and for a spreadsheet this is the number of worksheets.  Contains 0 when the page count cannot be determined, or if the concept of page count does not apply (e.g. for an image).</param>
        /// <param name="Author">User name of the creator/author of the document, if available, null if not available.</param>
        /// <param name="DateModified">The timestamp that the document was last modified, if available, null if not available.</param>
        /// <param name="AlternateFileTypeCandidates">Alternate file type options and their probability.</param>
        public AutodetectGetInfoResult(bool? Successful = default(bool?), string DetectedFileExtension = default(string), string DetectedMimeType = default(string), long? PageCount = default(long?), string Author = default(string), DateTime? DateModified = default(DateTime?), List<AlternateFileFormatCandidate> AlternateFileTypeCandidates = default(List<AlternateFileFormatCandidate>))
        {
            this.Successful = Successful;
            this.DetectedFileExtension = DetectedFileExtension;
            this.DetectedMimeType = DetectedMimeType;
            this.PageCount = PageCount;
            this.Author = Author;
            this.DateModified = DateModified;
            this.AlternateFileTypeCandidates = AlternateFileTypeCandidates;
        }
        
        /// <summary>
        /// True if the operation was successful, false otherwise
        /// </summary>
        /// <value>True if the operation was successful, false otherwise</value>
        [DataMember(Name="Successful", EmitDefaultValue=false)]
        public bool? Successful { get; set; }

        /// <summary>
        /// Detected file extension of the file format, with a leading period
        /// </summary>
        /// <value>Detected file extension of the file format, with a leading period</value>
        [DataMember(Name="DetectedFileExtension", EmitDefaultValue=false)]
        public string DetectedFileExtension { get; set; }

        /// <summary>
        /// MIME type of this file extension
        /// </summary>
        /// <value>MIME type of this file extension</value>
        [DataMember(Name="DetectedMimeType", EmitDefaultValue=false)]
        public string DetectedMimeType { get; set; }

        /// <summary>
        /// Number of pages in a page-based document; for presentations, this is the number of slides and for a spreadsheet this is the number of worksheets.  Contains 0 when the page count cannot be determined, or if the concept of page count does not apply (e.g. for an image)
        /// </summary>
        /// <value>Number of pages in a page-based document; for presentations, this is the number of slides and for a spreadsheet this is the number of worksheets.  Contains 0 when the page count cannot be determined, or if the concept of page count does not apply (e.g. for an image)</value>
        [DataMember(Name="PageCount", EmitDefaultValue=false)]
        public long? PageCount { get; set; }

        /// <summary>
        /// User name of the creator/author of the document, if available, null if not available
        /// </summary>
        /// <value>User name of the creator/author of the document, if available, null if not available</value>
        [DataMember(Name="Author", EmitDefaultValue=false)]
        public string Author { get; set; }

        /// <summary>
        /// The timestamp that the document was last modified, if available, null if not available
        /// </summary>
        /// <value>The timestamp that the document was last modified, if available, null if not available</value>
        [DataMember(Name="DateModified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }

        /// <summary>
        /// Alternate file type options and their probability
        /// </summary>
        /// <value>Alternate file type options and their probability</value>
        [DataMember(Name="AlternateFileTypeCandidates", EmitDefaultValue=false)]
        public List<AlternateFileFormatCandidate> AlternateFileTypeCandidates { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AutodetectGetInfoResult {\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
            sb.Append("  DetectedFileExtension: ").Append(DetectedFileExtension).Append("\n");
            sb.Append("  DetectedMimeType: ").Append(DetectedMimeType).Append("\n");
            sb.Append("  PageCount: ").Append(PageCount).Append("\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  AlternateFileTypeCandidates: ").Append(AlternateFileTypeCandidates).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as AutodetectGetInfoResult);
        }

        /// <summary>
        /// Returns true if AutodetectGetInfoResult instances are equal
        /// </summary>
        /// <param name="input">Instance of AutodetectGetInfoResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AutodetectGetInfoResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Successful == input.Successful ||
                    (this.Successful != null &&
                    this.Successful.Equals(input.Successful))
                ) && 
                (
                    this.DetectedFileExtension == input.DetectedFileExtension ||
                    (this.DetectedFileExtension != null &&
                    this.DetectedFileExtension.Equals(input.DetectedFileExtension))
                ) && 
                (
                    this.DetectedMimeType == input.DetectedMimeType ||
                    (this.DetectedMimeType != null &&
                    this.DetectedMimeType.Equals(input.DetectedMimeType))
                ) && 
                (
                    this.PageCount == input.PageCount ||
                    (this.PageCount != null &&
                    this.PageCount.Equals(input.PageCount))
                ) && 
                (
                    this.Author == input.Author ||
                    (this.Author != null &&
                    this.Author.Equals(input.Author))
                ) && 
                (
                    this.DateModified == input.DateModified ||
                    (this.DateModified != null &&
                    this.DateModified.Equals(input.DateModified))
                ) && 
                (
                    this.AlternateFileTypeCandidates == input.AlternateFileTypeCandidates ||
                    this.AlternateFileTypeCandidates != null &&
                    this.AlternateFileTypeCandidates.SequenceEqual(input.AlternateFileTypeCandidates)
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
                if (this.Successful != null)
                    hashCode = hashCode * 59 + this.Successful.GetHashCode();
                if (this.DetectedFileExtension != null)
                    hashCode = hashCode * 59 + this.DetectedFileExtension.GetHashCode();
                if (this.DetectedMimeType != null)
                    hashCode = hashCode * 59 + this.DetectedMimeType.GetHashCode();
                if (this.PageCount != null)
                    hashCode = hashCode * 59 + this.PageCount.GetHashCode();
                if (this.Author != null)
                    hashCode = hashCode * 59 + this.Author.GetHashCode();
                if (this.DateModified != null)
                    hashCode = hashCode * 59 + this.DateModified.GetHashCode();
                if (this.AlternateFileTypeCandidates != null)
                    hashCode = hashCode * 59 + this.AlternateFileTypeCandidates.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
