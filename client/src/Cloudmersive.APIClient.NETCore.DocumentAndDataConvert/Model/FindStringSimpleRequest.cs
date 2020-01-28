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
    /// Request to find a string in a string
    /// </summary>
    [DataContract]
    public partial class FindStringSimpleRequest :  IEquatable<FindStringSimpleRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FindStringSimpleRequest" /> class.
        /// </summary>
        /// <param name="TextContent">Input text content.</param>
        /// <param name="TargetString">Target input string to find.</param>
        public FindStringSimpleRequest(string TextContent = default(string), string TargetString = default(string))
        {
            this.TextContent = TextContent;
            this.TargetString = TargetString;
        }
        
        /// <summary>
        /// Input text content
        /// </summary>
        /// <value>Input text content</value>
        [DataMember(Name="TextContent", EmitDefaultValue=false)]
        public string TextContent { get; set; }

        /// <summary>
        /// Target input string to find
        /// </summary>
        /// <value>Target input string to find</value>
        [DataMember(Name="TargetString", EmitDefaultValue=false)]
        public string TargetString { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FindStringSimpleRequest {\n");
            sb.Append("  TextContent: ").Append(TextContent).Append("\n");
            sb.Append("  TargetString: ").Append(TargetString).Append("\n");
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
            return this.Equals(input as FindStringSimpleRequest);
        }

        /// <summary>
        /// Returns true if FindStringSimpleRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of FindStringSimpleRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FindStringSimpleRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TextContent == input.TextContent ||
                    (this.TextContent != null &&
                    this.TextContent.Equals(input.TextContent))
                ) && 
                (
                    this.TargetString == input.TargetString ||
                    (this.TargetString != null &&
                    this.TargetString.Equals(input.TargetString))
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
                if (this.TextContent != null)
                    hashCode = hashCode * 59 + this.TextContent.GetHashCode();
                if (this.TargetString != null)
                    hashCode = hashCode * 59 + this.TargetString.GetHashCode();
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
