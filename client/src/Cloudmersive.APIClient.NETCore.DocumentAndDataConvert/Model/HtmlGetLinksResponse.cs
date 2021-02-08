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
    /// Result of extracting links from an HTML file
    /// </summary>
    [DataContract]
    public partial class HtmlGetLinksResponse :  IEquatable<HtmlGetLinksResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlGetLinksResponse" /> class.
        /// </summary>
        /// <param name="successful">True if the operation was successful, false otherwise.</param>
        /// <param name="links">All hyperlinks in the HTML document.</param>
        public HtmlGetLinksResponse(bool? successful = default(bool?), List<HtmlHyperlink> links = default(List<HtmlHyperlink>))
        {
            this.Successful = successful;
            this.Links = links;
        }
        
        /// <summary>
        /// True if the operation was successful, false otherwise
        /// </summary>
        /// <value>True if the operation was successful, false otherwise</value>
        [DataMember(Name="Successful", EmitDefaultValue=false)]
        public bool? Successful { get; set; }

        /// <summary>
        /// All hyperlinks in the HTML document
        /// </summary>
        /// <value>All hyperlinks in the HTML document</value>
        [DataMember(Name="Links", EmitDefaultValue=false)]
        public List<HtmlHyperlink> Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HtmlGetLinksResponse {\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(input as HtmlGetLinksResponse);
        }

        /// <summary>
        /// Returns true if HtmlGetLinksResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of HtmlGetLinksResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HtmlGetLinksResponse input)
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
                    this.Links == input.Links ||
                    this.Links != null &&
                    this.Links.SequenceEqual(input.Links)
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
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }
    }

}
