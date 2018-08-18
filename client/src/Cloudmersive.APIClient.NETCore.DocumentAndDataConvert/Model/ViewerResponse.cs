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
    /// Result of creating a viewer
    /// </summary>
    [DataContract]
    public partial class ViewerResponse :  IEquatable<ViewerResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewerResponse" /> class.
        /// </summary>
        /// <param name="HtmlEmbed">HtmlEmbed.</param>
        /// <param name="Successful">Successful.</param>
        public ViewerResponse(string HtmlEmbed = default(string), bool? Successful = default(bool?))
        {
            this.HtmlEmbed = HtmlEmbed;
            this.Successful = Successful;
        }
        
        /// <summary>
        /// Gets or Sets HtmlEmbed
        /// </summary>
        [DataMember(Name="HtmlEmbed", EmitDefaultValue=false)]
        public string HtmlEmbed { get; set; }

        /// <summary>
        /// Gets or Sets Successful
        /// </summary>
        [DataMember(Name="Successful", EmitDefaultValue=false)]
        public bool? Successful { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ViewerResponse {\n");
            sb.Append("  HtmlEmbed: ").Append(HtmlEmbed).Append("\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
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
            return this.Equals(input as ViewerResponse);
        }

        /// <summary>
        /// Returns true if ViewerResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ViewerResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ViewerResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HtmlEmbed == input.HtmlEmbed ||
                    (this.HtmlEmbed != null &&
                    this.HtmlEmbed.Equals(input.HtmlEmbed))
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
                if (this.HtmlEmbed != null)
                    hashCode = hashCode * 59 + this.HtmlEmbed.GetHashCode();
                if (this.Successful != null)
                    hashCode = hashCode * 59 + this.Successful.GetHashCode();
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
