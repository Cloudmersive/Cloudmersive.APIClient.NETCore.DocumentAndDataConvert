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
    /// Request to detect if input content is base 64 encoded
    /// </summary>
    [DataContract]
    public partial class Base64DetectRequest :  IEquatable<Base64DetectRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Base64DetectRequest" /> class.
        /// </summary>
        /// <param name="Base64ContentToDetect">Input content text to detect if it is base 64 encoded.</param>
        public Base64DetectRequest(string Base64ContentToDetect = default(string))
        {
            this.Base64ContentToDetect = Base64ContentToDetect;
        }
        
        /// <summary>
        /// Input content text to detect if it is base 64 encoded
        /// </summary>
        /// <value>Input content text to detect if it is base 64 encoded</value>
        [DataMember(Name="Base64ContentToDetect", EmitDefaultValue=false)]
        public string Base64ContentToDetect { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Base64DetectRequest {\n");
            sb.Append("  Base64ContentToDetect: ").Append(Base64ContentToDetect).Append("\n");
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
            return this.Equals(input as Base64DetectRequest);
        }

        /// <summary>
        /// Returns true if Base64DetectRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of Base64DetectRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Base64DetectRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Base64ContentToDetect == input.Base64ContentToDetect ||
                    (this.Base64ContentToDetect != null &&
                    this.Base64ContentToDetect.Equals(input.Base64ContentToDetect))
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
                if (this.Base64ContentToDetect != null)
                    hashCode = hashCode * 59 + this.Base64ContentToDetect.GetHashCode();
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
