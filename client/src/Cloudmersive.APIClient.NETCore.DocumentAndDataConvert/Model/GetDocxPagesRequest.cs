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
    /// Input to a Get Word DOCX Document Pages request
    /// </summary>
    [DataContract]
    public partial class GetDocxPagesRequest :  IEquatable<GetDocxPagesRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocxPagesRequest" /> class.
        /// </summary>
        /// <param name="inputFileBytes">Optional: Bytes of the input file to operate on.</param>
        /// <param name="inputFileUrl">Optional: URL of a file to operate on as input.  This can be a public URL, or you can also use the begin-editing API to upload a document and pass in the secure URL result from that operation as the URL here (this URL is not public)..</param>
        /// <param name="maximumPages">Optional: Maximum number of pages to return; set to 0 or do not supply to return all pages.</param>
        public GetDocxPagesRequest(byte[] inputFileBytes = default(byte[]), string inputFileUrl = default(string), int? maximumPages = default(int?))
        {
            this.InputFileBytes = inputFileBytes;
            this.InputFileUrl = inputFileUrl;
            this.MaximumPages = maximumPages;
        }
        
        /// <summary>
        /// Optional: Bytes of the input file to operate on
        /// </summary>
        /// <value>Optional: Bytes of the input file to operate on</value>
        [DataMember(Name="InputFileBytes", EmitDefaultValue=false)]
        public byte[] InputFileBytes { get; set; }

        /// <summary>
        /// Optional: URL of a file to operate on as input.  This can be a public URL, or you can also use the begin-editing API to upload a document and pass in the secure URL result from that operation as the URL here (this URL is not public).
        /// </summary>
        /// <value>Optional: URL of a file to operate on as input.  This can be a public URL, or you can also use the begin-editing API to upload a document and pass in the secure URL result from that operation as the URL here (this URL is not public).</value>
        [DataMember(Name="InputFileUrl", EmitDefaultValue=false)]
        public string InputFileUrl { get; set; }

        /// <summary>
        /// Optional: Maximum number of pages to return; set to 0 or do not supply to return all pages
        /// </summary>
        /// <value>Optional: Maximum number of pages to return; set to 0 or do not supply to return all pages</value>
        [DataMember(Name="MaximumPages", EmitDefaultValue=false)]
        public int? MaximumPages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetDocxPagesRequest {\n");
            sb.Append("  InputFileBytes: ").Append(InputFileBytes).Append("\n");
            sb.Append("  InputFileUrl: ").Append(InputFileUrl).Append("\n");
            sb.Append("  MaximumPages: ").Append(MaximumPages).Append("\n");
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
            return this.Equals(input as GetDocxPagesRequest);
        }

        /// <summary>
        /// Returns true if GetDocxPagesRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetDocxPagesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetDocxPagesRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InputFileBytes == input.InputFileBytes ||
                    (this.InputFileBytes != null &&
                    this.InputFileBytes.Equals(input.InputFileBytes))
                ) && 
                (
                    this.InputFileUrl == input.InputFileUrl ||
                    (this.InputFileUrl != null &&
                    this.InputFileUrl.Equals(input.InputFileUrl))
                ) && 
                (
                    this.MaximumPages == input.MaximumPages ||
                    (this.MaximumPages != null &&
                    this.MaximumPages.Equals(input.MaximumPages))
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
                if (this.InputFileBytes != null)
                    hashCode = hashCode * 59 + this.InputFileBytes.GetHashCode();
                if (this.InputFileUrl != null)
                    hashCode = hashCode * 59 + this.InputFileUrl.GetHashCode();
                if (this.MaximumPages != null)
                    hashCode = hashCode * 59 + this.MaximumPages.GetHashCode();
                return hashCode;
            }
        }
    }

}
