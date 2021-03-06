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
    /// CSV file result
    /// </summary>
    [DataContract]
    public partial class CsvFileResult :  IEquatable<CsvFileResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CsvFileResult" /> class.
        /// </summary>
        /// <param name="title">Title of the CSV file.</param>
        /// <param name="fileContents">Contents of the CSV file.</param>
        public CsvFileResult(string title = default(string), byte[] fileContents = default(byte[]))
        {
            this.Title = title;
            this.FileContents = fileContents;
        }
        
        /// <summary>
        /// Title of the CSV file
        /// </summary>
        /// <value>Title of the CSV file</value>
        [DataMember(Name="Title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Contents of the CSV file
        /// </summary>
        /// <value>Contents of the CSV file</value>
        [DataMember(Name="FileContents", EmitDefaultValue=false)]
        public byte[] FileContents { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CsvFileResult {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  FileContents: ").Append(FileContents).Append("\n");
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
            return this.Equals(input as CsvFileResult);
        }

        /// <summary>
        /// Returns true if CsvFileResult instances are equal
        /// </summary>
        /// <param name="input">Instance of CsvFileResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CsvFileResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.FileContents == input.FileContents ||
                    (this.FileContents != null &&
                    this.FileContents.Equals(input.FileContents))
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
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.FileContents != null)
                    hashCode = hashCode * 59 + this.FileContents.GetHashCode();
                return hashCode;
            }
        }
    }

}
