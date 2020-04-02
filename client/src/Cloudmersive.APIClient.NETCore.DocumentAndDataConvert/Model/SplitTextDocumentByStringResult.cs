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
    /// The result of splitting a Text document into separate elements
    /// </summary>
    [DataContract]
    public partial class SplitTextDocumentByStringResult :  IEquatable<SplitTextDocumentByStringResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SplitTextDocumentByStringResult" /> class.
        /// </summary>
        /// <param name="resultElements">resultElements.</param>
        /// <param name="successful">True if the operation was successful, false otherwise.</param>
        /// <param name="elementCount">The count of elements in the text file.</param>
        public SplitTextDocumentByStringResult(List<TextDocumentElement> resultElements = default(List<TextDocumentElement>), bool? successful = default(bool?), int? elementCount = default(int?))
        {
            this.ResultElements = resultElements;
            this.Successful = successful;
            this.ElementCount = elementCount;
        }
        
        /// <summary>
        /// Gets or Sets ResultElements
        /// </summary>
        [DataMember(Name="ResultElements", EmitDefaultValue=false)]
        public List<TextDocumentElement> ResultElements { get; set; }

        /// <summary>
        /// True if the operation was successful, false otherwise
        /// </summary>
        /// <value>True if the operation was successful, false otherwise</value>
        [DataMember(Name="Successful", EmitDefaultValue=false)]
        public bool? Successful { get; set; }

        /// <summary>
        /// The count of elements in the text file
        /// </summary>
        /// <value>The count of elements in the text file</value>
        [DataMember(Name="ElementCount", EmitDefaultValue=false)]
        public int? ElementCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SplitTextDocumentByStringResult {\n");
            sb.Append("  ResultElements: ").Append(ResultElements).Append("\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
            sb.Append("  ElementCount: ").Append(ElementCount).Append("\n");
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
            return this.Equals(input as SplitTextDocumentByStringResult);
        }

        /// <summary>
        /// Returns true if SplitTextDocumentByStringResult instances are equal
        /// </summary>
        /// <param name="input">Instance of SplitTextDocumentByStringResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SplitTextDocumentByStringResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResultElements == input.ResultElements ||
                    this.ResultElements != null &&
                    this.ResultElements.SequenceEqual(input.ResultElements)
                ) && 
                (
                    this.Successful == input.Successful ||
                    (this.Successful != null &&
                    this.Successful.Equals(input.Successful))
                ) && 
                (
                    this.ElementCount == input.ElementCount ||
                    (this.ElementCount != null &&
                    this.ElementCount.Equals(input.ElementCount))
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
                if (this.ResultElements != null)
                    hashCode = hashCode * 59 + this.ResultElements.GetHashCode();
                if (this.Successful != null)
                    hashCode = hashCode * 59 + this.Successful.GetHashCode();
                if (this.ElementCount != null)
                    hashCode = hashCode * 59 + this.ElementCount.GetHashCode();
                return hashCode;
            }
        }
    }

}
