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
    /// Result of base 64 decoding
    /// </summary>
    [DataContract]
    public partial class Base64DecodeResponse :  IEquatable<Base64DecodeResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Base64DecodeResponse" /> class.
        /// </summary>
        /// <param name="successful">True if successful, false otherwise.</param>
        /// <param name="contentResult">Result of performing a base 64 decode operation, binary file content.</param>
        public Base64DecodeResponse(bool? successful = default(bool?), byte[] contentResult = default(byte[]))
        {
            this.Successful = successful;
            this.ContentResult = contentResult;
        }
        
        /// <summary>
        /// True if successful, false otherwise
        /// </summary>
        /// <value>True if successful, false otherwise</value>
        [DataMember(Name="Successful", EmitDefaultValue=false)]
        public bool? Successful { get; set; }

        /// <summary>
        /// Result of performing a base 64 decode operation, binary file content
        /// </summary>
        /// <value>Result of performing a base 64 decode operation, binary file content</value>
        [DataMember(Name="ContentResult", EmitDefaultValue=false)]
        public byte[] ContentResult { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Base64DecodeResponse {\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
            sb.Append("  ContentResult: ").Append(ContentResult).Append("\n");
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
            return this.Equals(input as Base64DecodeResponse);
        }

        /// <summary>
        /// Returns true if Base64DecodeResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of Base64DecodeResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Base64DecodeResponse input)
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
                    this.ContentResult == input.ContentResult ||
                    (this.ContentResult != null &&
                    this.ContentResult.Equals(input.ContentResult))
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
                if (this.ContentResult != null)
                    hashCode = hashCode * 59 + this.ContentResult.GetHashCode();
                return hashCode;
            }
        }
    }

}
