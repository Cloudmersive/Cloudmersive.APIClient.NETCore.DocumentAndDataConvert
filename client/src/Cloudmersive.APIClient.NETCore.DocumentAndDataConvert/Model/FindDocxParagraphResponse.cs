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
    /// Result of performing a find matching paragraphs operation on a Word Document
    /// </summary>
    [DataContract]
    public partial class FindDocxParagraphResponse :  IEquatable<FindDocxParagraphResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FindDocxParagraphResponse" /> class.
        /// </summary>
        /// <param name="successful">True if successful; false otherwise.</param>
        /// <param name="matchingParagraphs">Matching paragraphs.</param>
        /// <param name="count">Count of matching paragraphs.</param>
        public FindDocxParagraphResponse(bool? successful = default(bool?), List<DocxParagraph> matchingParagraphs = default(List<DocxParagraph>), int? count = default(int?))
        {
            this.Successful = successful;
            this.MatchingParagraphs = matchingParagraphs;
            this.Count = count;
        }
        
        /// <summary>
        /// True if successful; false otherwise
        /// </summary>
        /// <value>True if successful; false otherwise</value>
        [DataMember(Name="Successful", EmitDefaultValue=false)]
        public bool? Successful { get; set; }

        /// <summary>
        /// Matching paragraphs
        /// </summary>
        /// <value>Matching paragraphs</value>
        [DataMember(Name="MatchingParagraphs", EmitDefaultValue=false)]
        public List<DocxParagraph> MatchingParagraphs { get; set; }

        /// <summary>
        /// Count of matching paragraphs
        /// </summary>
        /// <value>Count of matching paragraphs</value>
        [DataMember(Name="Count", EmitDefaultValue=false)]
        public int? Count { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FindDocxParagraphResponse {\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
            sb.Append("  MatchingParagraphs: ").Append(MatchingParagraphs).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
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
            return this.Equals(input as FindDocxParagraphResponse);
        }

        /// <summary>
        /// Returns true if FindDocxParagraphResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of FindDocxParagraphResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FindDocxParagraphResponse input)
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
                    this.MatchingParagraphs == input.MatchingParagraphs ||
                    this.MatchingParagraphs != null &&
                    this.MatchingParagraphs.SequenceEqual(input.MatchingParagraphs)
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
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
                if (this.MatchingParagraphs != null)
                    hashCode = hashCode * 59 + this.MatchingParagraphs.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                return hashCode;
            }
        }
    }

}
