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
    /// Result of converting a multi-page image into individual pages with a different format
    /// </summary>
    [DataContract]
    public partial class MultipageImageFormatConversionResult :  IEquatable<MultipageImageFormatConversionResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultipageImageFormatConversionResult" /> class.
        /// </summary>
        /// <param name="Successful">Successful.</param>
        /// <param name="PageCount">PageCount.</param>
        /// <param name="Pages">Pages.</param>
        public MultipageImageFormatConversionResult(bool? Successful = default(bool?), int? PageCount = default(int?), List<PageConversionResult> Pages = default(List<PageConversionResult>))
        {
            this.Successful = Successful;
            this.PageCount = PageCount;
            this.Pages = Pages;
        }
        
        /// <summary>
        /// Gets or Sets Successful
        /// </summary>
        [DataMember(Name="Successful", EmitDefaultValue=false)]
        public bool? Successful { get; set; }

        /// <summary>
        /// Gets or Sets PageCount
        /// </summary>
        [DataMember(Name="PageCount", EmitDefaultValue=false)]
        public int? PageCount { get; set; }

        /// <summary>
        /// Gets or Sets Pages
        /// </summary>
        [DataMember(Name="Pages", EmitDefaultValue=false)]
        public List<PageConversionResult> Pages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MultipageImageFormatConversionResult {\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
            sb.Append("  PageCount: ").Append(PageCount).Append("\n");
            sb.Append("  Pages: ").Append(Pages).Append("\n");
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
            return this.Equals(input as MultipageImageFormatConversionResult);
        }

        /// <summary>
        /// Returns true if MultipageImageFormatConversionResult instances are equal
        /// </summary>
        /// <param name="input">Instance of MultipageImageFormatConversionResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MultipageImageFormatConversionResult input)
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
                    this.PageCount == input.PageCount ||
                    (this.PageCount != null &&
                    this.PageCount.Equals(input.PageCount))
                ) && 
                (
                    this.Pages == input.Pages ||
                    this.Pages != null &&
                    this.Pages.SequenceEqual(input.Pages)
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
                if (this.PageCount != null)
                    hashCode = hashCode * 59 + this.PageCount.GetHashCode();
                if (this.Pages != null)
                    hashCode = hashCode * 59 + this.Pages.GetHashCode();
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