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
    /// Document validation result
    /// </summary>
    [DataContract]
    public partial class AutodetectDocumentValidationResult :  IEquatable<AutodetectDocumentValidationResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AutodetectDocumentValidationResult" /> class.
        /// </summary>
        /// <param name="fileFormatExtension">fileFormatExtension.</param>
        /// <param name="documentIsValid">True if the document is valid and has no errors, false otherwise.</param>
        /// <param name="errorCount">Number of validation errors found in the document.</param>
        /// <param name="warningCount">Number of validation warnings found in the document.</param>
        /// <param name="errorsAndWarnings">Details of errors and warnings found.</param>
        public AutodetectDocumentValidationResult(string fileFormatExtension = default(string), bool? documentIsValid = default(bool?), int? errorCount = default(int?), int? warningCount = default(int?), List<DocumentValidationError> errorsAndWarnings = default(List<DocumentValidationError>))
        {
            this.FileFormatExtension = fileFormatExtension;
            this.DocumentIsValid = documentIsValid;
            this.ErrorCount = errorCount;
            this.WarningCount = warningCount;
            this.ErrorsAndWarnings = errorsAndWarnings;
        }
        
        /// <summary>
        /// Gets or Sets FileFormatExtension
        /// </summary>
        [DataMember(Name="FileFormatExtension", EmitDefaultValue=false)]
        public string FileFormatExtension { get; set; }

        /// <summary>
        /// True if the document is valid and has no errors, false otherwise
        /// </summary>
        /// <value>True if the document is valid and has no errors, false otherwise</value>
        [DataMember(Name="DocumentIsValid", EmitDefaultValue=false)]
        public bool? DocumentIsValid { get; set; }

        /// <summary>
        /// Number of validation errors found in the document
        /// </summary>
        /// <value>Number of validation errors found in the document</value>
        [DataMember(Name="ErrorCount", EmitDefaultValue=false)]
        public int? ErrorCount { get; set; }

        /// <summary>
        /// Number of validation warnings found in the document
        /// </summary>
        /// <value>Number of validation warnings found in the document</value>
        [DataMember(Name="WarningCount", EmitDefaultValue=false)]
        public int? WarningCount { get; set; }

        /// <summary>
        /// Details of errors and warnings found
        /// </summary>
        /// <value>Details of errors and warnings found</value>
        [DataMember(Name="ErrorsAndWarnings", EmitDefaultValue=false)]
        public List<DocumentValidationError> ErrorsAndWarnings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AutodetectDocumentValidationResult {\n");
            sb.Append("  FileFormatExtension: ").Append(FileFormatExtension).Append("\n");
            sb.Append("  DocumentIsValid: ").Append(DocumentIsValid).Append("\n");
            sb.Append("  ErrorCount: ").Append(ErrorCount).Append("\n");
            sb.Append("  WarningCount: ").Append(WarningCount).Append("\n");
            sb.Append("  ErrorsAndWarnings: ").Append(ErrorsAndWarnings).Append("\n");
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
            return this.Equals(input as AutodetectDocumentValidationResult);
        }

        /// <summary>
        /// Returns true if AutodetectDocumentValidationResult instances are equal
        /// </summary>
        /// <param name="input">Instance of AutodetectDocumentValidationResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AutodetectDocumentValidationResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FileFormatExtension == input.FileFormatExtension ||
                    (this.FileFormatExtension != null &&
                    this.FileFormatExtension.Equals(input.FileFormatExtension))
                ) && 
                (
                    this.DocumentIsValid == input.DocumentIsValid ||
                    (this.DocumentIsValid != null &&
                    this.DocumentIsValid.Equals(input.DocumentIsValid))
                ) && 
                (
                    this.ErrorCount == input.ErrorCount ||
                    (this.ErrorCount != null &&
                    this.ErrorCount.Equals(input.ErrorCount))
                ) && 
                (
                    this.WarningCount == input.WarningCount ||
                    (this.WarningCount != null &&
                    this.WarningCount.Equals(input.WarningCount))
                ) && 
                (
                    this.ErrorsAndWarnings == input.ErrorsAndWarnings ||
                    this.ErrorsAndWarnings != null &&
                    this.ErrorsAndWarnings.SequenceEqual(input.ErrorsAndWarnings)
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
                if (this.FileFormatExtension != null)
                    hashCode = hashCode * 59 + this.FileFormatExtension.GetHashCode();
                if (this.DocumentIsValid != null)
                    hashCode = hashCode * 59 + this.DocumentIsValid.GetHashCode();
                if (this.ErrorCount != null)
                    hashCode = hashCode * 59 + this.ErrorCount.GetHashCode();
                if (this.WarningCount != null)
                    hashCode = hashCode * 59 + this.WarningCount.GetHashCode();
                if (this.ErrorsAndWarnings != null)
                    hashCode = hashCode * 59 + this.ErrorsAndWarnings.GetHashCode();
                return hashCode;
            }
        }
    }

}
