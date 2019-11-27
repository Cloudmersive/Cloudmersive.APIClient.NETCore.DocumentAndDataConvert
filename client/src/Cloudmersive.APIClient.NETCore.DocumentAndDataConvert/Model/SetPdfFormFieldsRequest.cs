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
    /// Request to set the fields in a PDF form
    /// </summary>
    [DataContract]
    public partial class SetPdfFormFieldsRequest :  IEquatable<SetPdfFormFieldsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetPdfFormFieldsRequest" /> class.
        /// </summary>
        /// <param name="FieldValues">Field values to set.</param>
        /// <param name="InputFileBytes">Contents of the input file to set the fields on.</param>
        public SetPdfFormFieldsRequest(List<SetFormFieldValue> FieldValues = default(List<SetFormFieldValue>), byte[] InputFileBytes = default(byte[]))
        {
            this.FieldValues = FieldValues;
            this.InputFileBytes = InputFileBytes;
        }
        
        /// <summary>
        /// Field values to set
        /// </summary>
        /// <value>Field values to set</value>
        [DataMember(Name="FieldValues", EmitDefaultValue=false)]
        public List<SetFormFieldValue> FieldValues { get; set; }

        /// <summary>
        /// Contents of the input file to set the fields on
        /// </summary>
        /// <value>Contents of the input file to set the fields on</value>
        [DataMember(Name="InputFileBytes", EmitDefaultValue=false)]
        public byte[] InputFileBytes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetPdfFormFieldsRequest {\n");
            sb.Append("  FieldValues: ").Append(FieldValues).Append("\n");
            sb.Append("  InputFileBytes: ").Append(InputFileBytes).Append("\n");
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
            return this.Equals(input as SetPdfFormFieldsRequest);
        }

        /// <summary>
        /// Returns true if SetPdfFormFieldsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SetPdfFormFieldsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SetPdfFormFieldsRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FieldValues == input.FieldValues ||
                    this.FieldValues != null &&
                    this.FieldValues.SequenceEqual(input.FieldValues)
                ) && 
                (
                    this.InputFileBytes == input.InputFileBytes ||
                    (this.InputFileBytes != null &&
                    this.InputFileBytes.Equals(input.InputFileBytes))
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
                if (this.FieldValues != null)
                    hashCode = hashCode * 59 + this.FieldValues.GetHashCode();
                if (this.InputFileBytes != null)
                    hashCode = hashCode * 59 + this.InputFileBytes.GetHashCode();
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
