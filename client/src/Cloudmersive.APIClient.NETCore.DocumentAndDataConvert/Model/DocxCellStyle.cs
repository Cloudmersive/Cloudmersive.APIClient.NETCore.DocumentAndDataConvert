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
    /// Style in an Excel spreadsheet
    /// </summary>
    [DataContract]
    public partial class DocxCellStyle :  IEquatable<DocxCellStyle>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocxCellStyle" /> class.
        /// </summary>
        /// <param name="Path">The Path of the location of this object; leave blank for new rows.</param>
        /// <param name="Name">Name of the style.</param>
        /// <param name="FormatID">Format ID of the cell style.</param>
        /// <param name="BuiltInID">Built&#x3D;in ID of the cell style.</param>
        public DocxCellStyle(string Path = default(string), string Name = default(string), int? FormatID = default(int?), int? BuiltInID = default(int?))
        {
            this.Path = Path;
            this.Name = Name;
            this.FormatID = FormatID;
            this.BuiltInID = BuiltInID;
        }
        
        /// <summary>
        /// The Path of the location of this object; leave blank for new rows
        /// </summary>
        /// <value>The Path of the location of this object; leave blank for new rows</value>
        [DataMember(Name="Path", EmitDefaultValue=false)]
        public string Path { get; set; }

        /// <summary>
        /// Name of the style
        /// </summary>
        /// <value>Name of the style</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Format ID of the cell style
        /// </summary>
        /// <value>Format ID of the cell style</value>
        [DataMember(Name="FormatID", EmitDefaultValue=false)]
        public int? FormatID { get; set; }

        /// <summary>
        /// Built&#x3D;in ID of the cell style
        /// </summary>
        /// <value>Built&#x3D;in ID of the cell style</value>
        [DataMember(Name="BuiltInID", EmitDefaultValue=false)]
        public int? BuiltInID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocxCellStyle {\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  FormatID: ").Append(FormatID).Append("\n");
            sb.Append("  BuiltInID: ").Append(BuiltInID).Append("\n");
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
            return this.Equals(input as DocxCellStyle);
        }

        /// <summary>
        /// Returns true if DocxCellStyle instances are equal
        /// </summary>
        /// <param name="input">Instance of DocxCellStyle to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocxCellStyle input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Path == input.Path ||
                    (this.Path != null &&
                    this.Path.Equals(input.Path))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.FormatID == input.FormatID ||
                    (this.FormatID != null &&
                    this.FormatID.Equals(input.FormatID))
                ) && 
                (
                    this.BuiltInID == input.BuiltInID ||
                    (this.BuiltInID != null &&
                    this.BuiltInID.Equals(input.BuiltInID))
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
                if (this.Path != null)
                    hashCode = hashCode * 59 + this.Path.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.FormatID != null)
                    hashCode = hashCode * 59 + this.FormatID.GetHashCode();
                if (this.BuiltInID != null)
                    hashCode = hashCode * 59 + this.BuiltInID.GetHashCode();
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