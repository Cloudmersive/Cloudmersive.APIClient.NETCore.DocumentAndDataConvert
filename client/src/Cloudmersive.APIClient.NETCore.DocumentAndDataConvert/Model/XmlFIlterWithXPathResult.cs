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
    /// Result of performing a filter operation on XML input using XPath
    /// </summary>
    [DataContract]
    public partial class XmlFIlterWithXPathResult :  IEquatable<XmlFIlterWithXPathResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XmlFIlterWithXPathResult" /> class.
        /// </summary>
        /// <param name="Successful">True if the operation was successful, false otherwise.</param>
        /// <param name="XmlNodes">Matching selected XML nodes as strings.</param>
        /// <param name="ResultCount">Count of the matching results.</param>
        public XmlFIlterWithXPathResult(bool? Successful = default(bool?), List<string> XmlNodes = default(List<string>), int? ResultCount = default(int?))
        {
            this.Successful = Successful;
            this.XmlNodes = XmlNodes;
            this.ResultCount = ResultCount;
        }
        
        /// <summary>
        /// True if the operation was successful, false otherwise
        /// </summary>
        /// <value>True if the operation was successful, false otherwise</value>
        [DataMember(Name="Successful", EmitDefaultValue=false)]
        public bool? Successful { get; set; }

        /// <summary>
        /// Matching selected XML nodes as strings
        /// </summary>
        /// <value>Matching selected XML nodes as strings</value>
        [DataMember(Name="XmlNodes", EmitDefaultValue=false)]
        public List<string> XmlNodes { get; set; }

        /// <summary>
        /// Count of the matching results
        /// </summary>
        /// <value>Count of the matching results</value>
        [DataMember(Name="ResultCount", EmitDefaultValue=false)]
        public int? ResultCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class XmlFIlterWithXPathResult {\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
            sb.Append("  XmlNodes: ").Append(XmlNodes).Append("\n");
            sb.Append("  ResultCount: ").Append(ResultCount).Append("\n");
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
            return this.Equals(input as XmlFIlterWithXPathResult);
        }

        /// <summary>
        /// Returns true if XmlFIlterWithXPathResult instances are equal
        /// </summary>
        /// <param name="input">Instance of XmlFIlterWithXPathResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XmlFIlterWithXPathResult input)
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
                    this.XmlNodes == input.XmlNodes ||
                    this.XmlNodes != null &&
                    this.XmlNodes.SequenceEqual(input.XmlNodes)
                ) && 
                (
                    this.ResultCount == input.ResultCount ||
                    (this.ResultCount != null &&
                    this.ResultCount.Equals(input.ResultCount))
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
                if (this.XmlNodes != null)
                    hashCode = hashCode * 59 + this.XmlNodes.GetHashCode();
                if (this.ResultCount != null)
                    hashCode = hashCode * 59 + this.ResultCount.GetHashCode();
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