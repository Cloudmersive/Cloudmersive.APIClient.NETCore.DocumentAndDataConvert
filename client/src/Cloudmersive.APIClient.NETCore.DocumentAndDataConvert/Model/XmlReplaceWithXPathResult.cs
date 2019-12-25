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
    /// Result of performing a replace node operation on XML input using XPath
    /// </summary>
    [DataContract]
    public partial class XmlReplaceWithXPathResult :  IEquatable<XmlReplaceWithXPathResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XmlReplaceWithXPathResult" /> class.
        /// </summary>
        /// <param name="Successful">True if the operation was successful, false otherwise.</param>
        /// <param name="ResultingXmlDocument">Resulting, modified XML document.</param>
        /// <param name="NodesEditedCount">Count of the matching results.</param>
        public XmlReplaceWithXPathResult(bool? Successful = default(bool?), string ResultingXmlDocument = default(string), int? NodesEditedCount = default(int?))
        {
            this.Successful = Successful;
            this.ResultingXmlDocument = ResultingXmlDocument;
            this.NodesEditedCount = NodesEditedCount;
        }
        
        /// <summary>
        /// True if the operation was successful, false otherwise
        /// </summary>
        /// <value>True if the operation was successful, false otherwise</value>
        [DataMember(Name="Successful", EmitDefaultValue=false)]
        public bool? Successful { get; set; }

        /// <summary>
        /// Resulting, modified XML document
        /// </summary>
        /// <value>Resulting, modified XML document</value>
        [DataMember(Name="ResultingXmlDocument", EmitDefaultValue=false)]
        public string ResultingXmlDocument { get; set; }

        /// <summary>
        /// Count of the matching results
        /// </summary>
        /// <value>Count of the matching results</value>
        [DataMember(Name="NodesEditedCount", EmitDefaultValue=false)]
        public int? NodesEditedCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class XmlReplaceWithXPathResult {\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
            sb.Append("  ResultingXmlDocument: ").Append(ResultingXmlDocument).Append("\n");
            sb.Append("  NodesEditedCount: ").Append(NodesEditedCount).Append("\n");
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
            return this.Equals(input as XmlReplaceWithXPathResult);
        }

        /// <summary>
        /// Returns true if XmlReplaceWithXPathResult instances are equal
        /// </summary>
        /// <param name="input">Instance of XmlReplaceWithXPathResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XmlReplaceWithXPathResult input)
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
                    this.ResultingXmlDocument == input.ResultingXmlDocument ||
                    (this.ResultingXmlDocument != null &&
                    this.ResultingXmlDocument.Equals(input.ResultingXmlDocument))
                ) && 
                (
                    this.NodesEditedCount == input.NodesEditedCount ||
                    (this.NodesEditedCount != null &&
                    this.NodesEditedCount.Equals(input.NodesEditedCount))
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
                if (this.ResultingXmlDocument != null)
                    hashCode = hashCode * 59 + this.ResultingXmlDocument.GetHashCode();
                if (this.NodesEditedCount != null)
                    hashCode = hashCode * 59 + this.NodesEditedCount.GetHashCode();
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