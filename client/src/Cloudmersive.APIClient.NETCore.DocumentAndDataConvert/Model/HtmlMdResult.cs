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
    /// Result from converting a Markdown file to HTML
    /// </summary>
    [DataContract]
    public partial class HtmlMdResult :  IEquatable<HtmlMdResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlMdResult" /> class.
        /// </summary>
        /// <param name="successful">True if operation was successful, false otherwise.</param>
        /// <param name="html">Resulting HTML from the conversion.</param>
        public HtmlMdResult(bool? successful = default(bool?), string html = default(string))
        {
            this.Successful = successful;
            this.Html = html;
        }
        
        /// <summary>
        /// True if operation was successful, false otherwise
        /// </summary>
        /// <value>True if operation was successful, false otherwise</value>
        [DataMember(Name="Successful", EmitDefaultValue=false)]
        public bool? Successful { get; set; }

        /// <summary>
        /// Resulting HTML from the conversion
        /// </summary>
        /// <value>Resulting HTML from the conversion</value>
        [DataMember(Name="Html", EmitDefaultValue=false)]
        public string Html { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HtmlMdResult {\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
            sb.Append("  Html: ").Append(Html).Append("\n");
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
            return this.Equals(input as HtmlMdResult);
        }

        /// <summary>
        /// Returns true if HtmlMdResult instances are equal
        /// </summary>
        /// <param name="input">Instance of HtmlMdResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HtmlMdResult input)
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
                if (this.Successful != null)
                    hashCode = hashCode * 59 + this.Successful.GetHashCode();
                if (this.Html != null)
                    hashCode = hashCode * 59 + this.Html.GetHashCode();
                return hashCode;
            }
        }
    }

}
