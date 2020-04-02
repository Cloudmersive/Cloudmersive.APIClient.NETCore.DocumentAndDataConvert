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
    /// Result of running a Get-Tables command
    /// </summary>
    [DataContract]
    public partial class GetDocxHeadersAndFootersResponse :  IEquatable<GetDocxHeadersAndFootersResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocxHeadersAndFootersResponse" /> class.
        /// </summary>
        /// <param name="successful">True if successful, false otherwise.</param>
        /// <param name="headers">headers.</param>
        /// <param name="footers">footers.</param>
        public GetDocxHeadersAndFootersResponse(bool? successful = default(bool?), List<DocxHeader> headers = default(List<DocxHeader>), List<DocxFooter> footers = default(List<DocxFooter>))
        {
            this.Successful = successful;
            this.Headers = headers;
            this.Footers = footers;
        }
        
        /// <summary>
        /// True if successful, false otherwise
        /// </summary>
        /// <value>True if successful, false otherwise</value>
        [DataMember(Name="Successful", EmitDefaultValue=false)]
        public bool? Successful { get; set; }

        /// <summary>
        /// Gets or Sets Headers
        /// </summary>
        [DataMember(Name="Headers", EmitDefaultValue=false)]
        public List<DocxHeader> Headers { get; set; }

        /// <summary>
        /// Gets or Sets Footers
        /// </summary>
        [DataMember(Name="Footers", EmitDefaultValue=false)]
        public List<DocxFooter> Footers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetDocxHeadersAndFootersResponse {\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
            sb.Append("  Headers: ").Append(Headers).Append("\n");
            sb.Append("  Footers: ").Append(Footers).Append("\n");
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
            return this.Equals(input as GetDocxHeadersAndFootersResponse);
        }

        /// <summary>
        /// Returns true if GetDocxHeadersAndFootersResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetDocxHeadersAndFootersResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetDocxHeadersAndFootersResponse input)
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
                    this.Headers == input.Headers ||
                    this.Headers != null &&
                    this.Headers.SequenceEqual(input.Headers)
                ) && 
                (
                    this.Footers == input.Footers ||
                    this.Footers != null &&
                    this.Footers.SequenceEqual(input.Footers)
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
                if (this.Headers != null)
                    hashCode = hashCode * 59 + this.Headers.GetHashCode();
                if (this.Footers != null)
                    hashCode = hashCode * 59 + this.Footers.GetHashCode();
                return hashCode;
            }
        }
    }

}
