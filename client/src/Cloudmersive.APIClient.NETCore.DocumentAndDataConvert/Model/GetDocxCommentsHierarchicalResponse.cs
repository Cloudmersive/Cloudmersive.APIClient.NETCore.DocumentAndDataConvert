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
    /// Result of getting comments hierarchically from a Word Document DOCX
    /// </summary>
    [DataContract]
    public partial class GetDocxCommentsHierarchicalResponse :  IEquatable<GetDocxCommentsHierarchicalResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocxCommentsHierarchicalResponse" /> class.
        /// </summary>
        /// <param name="successful">True if successful, false otherwise.</param>
        /// <param name="comments">Comments in the document.</param>
        /// <param name="topLevelCommentCount">The number of comments in the document.</param>
        public GetDocxCommentsHierarchicalResponse(bool? successful = default(bool?), List<DocxTopLevelComment> comments = default(List<DocxTopLevelComment>), int? topLevelCommentCount = default(int?))
        {
            this.Successful = successful;
            this.Comments = comments;
            this.TopLevelCommentCount = topLevelCommentCount;
        }
        
        /// <summary>
        /// True if successful, false otherwise
        /// </summary>
        /// <value>True if successful, false otherwise</value>
        [DataMember(Name="Successful", EmitDefaultValue=false)]
        public bool? Successful { get; set; }

        /// <summary>
        /// Comments in the document
        /// </summary>
        /// <value>Comments in the document</value>
        [DataMember(Name="Comments", EmitDefaultValue=false)]
        public List<DocxTopLevelComment> Comments { get; set; }

        /// <summary>
        /// The number of comments in the document
        /// </summary>
        /// <value>The number of comments in the document</value>
        [DataMember(Name="TopLevelCommentCount", EmitDefaultValue=false)]
        public int? TopLevelCommentCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetDocxCommentsHierarchicalResponse {\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  TopLevelCommentCount: ").Append(TopLevelCommentCount).Append("\n");
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
            return this.Equals(input as GetDocxCommentsHierarchicalResponse);
        }

        /// <summary>
        /// Returns true if GetDocxCommentsHierarchicalResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetDocxCommentsHierarchicalResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetDocxCommentsHierarchicalResponse input)
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
                    this.Comments == input.Comments ||
                    this.Comments != null &&
                    this.Comments.SequenceEqual(input.Comments)
                ) && 
                (
                    this.TopLevelCommentCount == input.TopLevelCommentCount ||
                    (this.TopLevelCommentCount != null &&
                    this.TopLevelCommentCount.Equals(input.TopLevelCommentCount))
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
                if (this.Comments != null)
                    hashCode = hashCode * 59 + this.Comments.GetHashCode();
                if (this.TopLevelCommentCount != null)
                    hashCode = hashCode * 59 + this.TopLevelCommentCount.GetHashCode();
                return hashCode;
            }
        }
    }

}
