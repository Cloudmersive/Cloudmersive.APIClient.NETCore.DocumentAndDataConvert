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
    /// Details of the HTML to Office request
    /// </summary>
    [DataContract]
    public partial class HtmlToOfficeRequest :  IEquatable<HtmlToOfficeRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlToOfficeRequest" /> class.
        /// </summary>
        /// <param name="Html">Html.</param>
        public HtmlToOfficeRequest(string Html = default(string))
        {
            this.Html = Html;
        }
        
        /// <summary>
        /// Gets or Sets Html
        /// </summary>
        [DataMember(Name="Html", EmitDefaultValue=false)]
        public string Html { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HtmlToOfficeRequest {\n");
            sb.Append("  Html: ").Append(Html).Append("\n");
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
            return this.Equals(input as HtmlToOfficeRequest);
        }

        /// <summary>
        /// Returns true if HtmlToOfficeRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of HtmlToOfficeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HtmlToOfficeRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Html == input.Html ||
                    (this.Html != null &&
                    this.Html.Equals(input.Html))
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