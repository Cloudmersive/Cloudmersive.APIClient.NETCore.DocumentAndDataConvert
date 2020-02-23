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
    /// Result of base 64 detection
    /// </summary>
    [DataContract]
    public partial class Base64DetectResponse :  IEquatable<Base64DetectResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Base64DetectResponse" /> class.
        /// </summary>
        /// <param name="Successful">True if successful, false otherwise.</param>
        /// <param name="IsBase64Encoded">True if the input string is base 64 encoded, false otherwise.</param>
        public Base64DetectResponse(bool? Successful = default(bool?), bool? IsBase64Encoded = default(bool?))
        {
            this.Successful = Successful;
            this.IsBase64Encoded = IsBase64Encoded;
        }
        
        /// <summary>
        /// True if successful, false otherwise
        /// </summary>
        /// <value>True if successful, false otherwise</value>
        [DataMember(Name="Successful", EmitDefaultValue=false)]
        public bool? Successful { get; set; }

        /// <summary>
        /// True if the input string is base 64 encoded, false otherwise
        /// </summary>
        /// <value>True if the input string is base 64 encoded, false otherwise</value>
        [DataMember(Name="IsBase64Encoded", EmitDefaultValue=false)]
        public bool? IsBase64Encoded { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Base64DetectResponse {\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
            sb.Append("  IsBase64Encoded: ").Append(IsBase64Encoded).Append("\n");
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
            return this.Equals(input as Base64DetectResponse);
        }

        /// <summary>
        /// Returns true if Base64DetectResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of Base64DetectResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Base64DetectResponse input)
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
                    this.IsBase64Encoded == input.IsBase64Encoded ||
                    (this.IsBase64Encoded != null &&
                    this.IsBase64Encoded.Equals(input.IsBase64Encoded))
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
                if (this.IsBase64Encoded != null)
                    hashCode = hashCode * 59 + this.IsBase64Encoded.GetHashCode();
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