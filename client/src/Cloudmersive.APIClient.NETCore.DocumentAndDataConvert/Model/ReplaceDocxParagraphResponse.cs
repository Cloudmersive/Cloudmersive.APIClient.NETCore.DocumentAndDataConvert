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
    /// Result of performing a replace matching paragraphs operation on a Word Document
    /// </summary>
    [DataContract]
    public partial class ReplaceDocxParagraphResponse :  IEquatable<ReplaceDocxParagraphResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReplaceDocxParagraphResponse" /> class.
        /// </summary>
        /// <param name="successful">True if successful; false otherwise.</param>
        /// <param name="editedDocumentURL">URL of the edited document.</param>
        public ReplaceDocxParagraphResponse(bool? successful = default(bool?), string editedDocumentURL = default(string))
        {
            this.Successful = successful;
            this.EditedDocumentURL = editedDocumentURL;
        }
        
        /// <summary>
        /// True if successful; false otherwise
        /// </summary>
        /// <value>True if successful; false otherwise</value>
        [DataMember(Name="Successful", EmitDefaultValue=false)]
        public bool? Successful { get; set; }

        /// <summary>
        /// URL of the edited document
        /// </summary>
        /// <value>URL of the edited document</value>
        [DataMember(Name="EditedDocumentURL", EmitDefaultValue=false)]
        public string EditedDocumentURL { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReplaceDocxParagraphResponse {\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
            sb.Append("  EditedDocumentURL: ").Append(EditedDocumentURL).Append("\n");
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
            return this.Equals(input as ReplaceDocxParagraphResponse);
        }

        /// <summary>
        /// Returns true if ReplaceDocxParagraphResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ReplaceDocxParagraphResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReplaceDocxParagraphResponse input)
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
                    this.EditedDocumentURL == input.EditedDocumentURL ||
                    (this.EditedDocumentURL != null &&
                    this.EditedDocumentURL.Equals(input.EditedDocumentURL))
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
                if (this.EditedDocumentURL != null)
                    hashCode = hashCode * 59 + this.EditedDocumentURL.GetHashCode();
                return hashCode;
            }
        }
    }

}
