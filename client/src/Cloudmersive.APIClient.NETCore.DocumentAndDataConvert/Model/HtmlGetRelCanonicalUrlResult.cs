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
    /// Result of getting the canonical URL of the input HTML document
    /// </summary>
    [DataContract]
    public partial class HtmlGetRelCanonicalUrlResult :  IEquatable<HtmlGetRelCanonicalUrlResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlGetRelCanonicalUrlResult" /> class.
        /// </summary>
        /// <param name="successful">True if the operation was successful, false otherwise.</param>
        /// <param name="canonicalUrl">HTML canonical URL if present.</param>
        public HtmlGetRelCanonicalUrlResult(bool? successful = default(bool?), string canonicalUrl = default(string))
        {
            this.Successful = successful;
            this.CanonicalUrl = canonicalUrl;
        }
        
        /// <summary>
        /// True if the operation was successful, false otherwise
        /// </summary>
        /// <value>True if the operation was successful, false otherwise</value>
        [DataMember(Name="Successful", EmitDefaultValue=false)]
        public bool? Successful { get; set; }

        /// <summary>
        /// HTML canonical URL if present
        /// </summary>
        /// <value>HTML canonical URL if present</value>
        [DataMember(Name="CanonicalUrl", EmitDefaultValue=false)]
        public string CanonicalUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HtmlGetRelCanonicalUrlResult {\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
            sb.Append("  CanonicalUrl: ").Append(CanonicalUrl).Append("\n");
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
            return this.Equals(input as HtmlGetRelCanonicalUrlResult);
        }

        /// <summary>
        /// Returns true if HtmlGetRelCanonicalUrlResult instances are equal
        /// </summary>
        /// <param name="input">Instance of HtmlGetRelCanonicalUrlResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HtmlGetRelCanonicalUrlResult input)
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
                    this.CanonicalUrl == input.CanonicalUrl ||
                    (this.CanonicalUrl != null &&
                    this.CanonicalUrl.Equals(input.CanonicalUrl))
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
                if (this.CanonicalUrl != null)
                    hashCode = hashCode * 59 + this.CanonicalUrl.GetHashCode();
                return hashCode;
            }
        }
    }

}
