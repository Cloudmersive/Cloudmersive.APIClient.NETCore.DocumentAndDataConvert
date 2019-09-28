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
    /// Text conversion result from converting a document to Plain Text (TXT) format
    /// </summary>
    [DataContract]
    public partial class TextConversionResult :  IEquatable<TextConversionResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TextConversionResult" /> class.
        /// </summary>
        /// <param name="Successful">True if the operation was successful, false otherwise.</param>
        /// <param name="TextResult">Plain Text (TXT) format conversion result of the input document.  The text result is returned as a string..</param>
        public TextConversionResult(bool? Successful = default(bool?), string TextResult = default(string))
        {
            this.Successful = Successful;
            this.TextResult = TextResult;
        }
        
        /// <summary>
        /// True if the operation was successful, false otherwise
        /// </summary>
        /// <value>True if the operation was successful, false otherwise</value>
        [DataMember(Name="Successful", EmitDefaultValue=false)]
        public bool? Successful { get; set; }

        /// <summary>
        /// Plain Text (TXT) format conversion result of the input document.  The text result is returned as a string.
        /// </summary>
        /// <value>Plain Text (TXT) format conversion result of the input document.  The text result is returned as a string.</value>
        [DataMember(Name="TextResult", EmitDefaultValue=false)]
        public string TextResult { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TextConversionResult {\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
            sb.Append("  TextResult: ").Append(TextResult).Append("\n");
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
            return this.Equals(input as TextConversionResult);
        }

        /// <summary>
        /// Returns true if TextConversionResult instances are equal
        /// </summary>
        /// <param name="input">Instance of TextConversionResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TextConversionResult input)
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
                    this.TextResult == input.TextResult ||
                    (this.TextResult != null &&
                    this.TextResult.Equals(input.TextResult))
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
                if (this.TextResult != null)
                    hashCode = hashCode * 59 + this.TextResult.GetHashCode();
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
