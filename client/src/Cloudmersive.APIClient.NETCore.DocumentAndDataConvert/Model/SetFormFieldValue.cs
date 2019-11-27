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
    /// Individual field value to set in a PDF form
    /// </summary>
    [DataContract]
    public partial class SetFormFieldValue :  IEquatable<SetFormFieldValue>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SetFormFieldValue" /> class.
        /// </summary>
        /// <param name="FieldName">Name of the field to set; you can call /convert/edit/pdf/form/get-fields to enumerate field names in a form.</param>
        /// <param name="TextValue">For fields of type Text, the text value to put into the field.</param>
        /// <param name="CheckboxValue">For fields of type Checkbox, the value to put into the field.</param>
        /// <param name="ComboBoxSelectedIndex">For fields of type ComboBox; specifies the selected index of the combo box selection.</param>
        public SetFormFieldValue(string FieldName = default(string), string TextValue = default(string), bool? CheckboxValue = default(bool?), int? ComboBoxSelectedIndex = default(int?))
        {
            this.FieldName = FieldName;
            this.TextValue = TextValue;
            this.CheckboxValue = CheckboxValue;
            this.ComboBoxSelectedIndex = ComboBoxSelectedIndex;
        }
        
        /// <summary>
        /// Name of the field to set; you can call /convert/edit/pdf/form/get-fields to enumerate field names in a form
        /// </summary>
        /// <value>Name of the field to set; you can call /convert/edit/pdf/form/get-fields to enumerate field names in a form</value>
        [DataMember(Name="FieldName", EmitDefaultValue=false)]
        public string FieldName { get; set; }

        /// <summary>
        /// For fields of type Text, the text value to put into the field
        /// </summary>
        /// <value>For fields of type Text, the text value to put into the field</value>
        [DataMember(Name="TextValue", EmitDefaultValue=false)]
        public string TextValue { get; set; }

        /// <summary>
        /// For fields of type Checkbox, the value to put into the field
        /// </summary>
        /// <value>For fields of type Checkbox, the value to put into the field</value>
        [DataMember(Name="CheckboxValue", EmitDefaultValue=false)]
        public bool? CheckboxValue { get; set; }

        /// <summary>
        /// For fields of type ComboBox; specifies the selected index of the combo box selection
        /// </summary>
        /// <value>For fields of type ComboBox; specifies the selected index of the combo box selection</value>
        [DataMember(Name="ComboBoxSelectedIndex", EmitDefaultValue=false)]
        public int? ComboBoxSelectedIndex { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetFormFieldValue {\n");
            sb.Append("  FieldName: ").Append(FieldName).Append("\n");
            sb.Append("  TextValue: ").Append(TextValue).Append("\n");
            sb.Append("  CheckboxValue: ").Append(CheckboxValue).Append("\n");
            sb.Append("  ComboBoxSelectedIndex: ").Append(ComboBoxSelectedIndex).Append("\n");
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
            return this.Equals(input as SetFormFieldValue);
        }

        /// <summary>
        /// Returns true if SetFormFieldValue instances are equal
        /// </summary>
        /// <param name="input">Instance of SetFormFieldValue to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SetFormFieldValue input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FieldName == input.FieldName ||
                    (this.FieldName != null &&
                    this.FieldName.Equals(input.FieldName))
                ) && 
                (
                    this.TextValue == input.TextValue ||
                    (this.TextValue != null &&
                    this.TextValue.Equals(input.TextValue))
                ) && 
                (
                    this.CheckboxValue == input.CheckboxValue ||
                    (this.CheckboxValue != null &&
                    this.CheckboxValue.Equals(input.CheckboxValue))
                ) && 
                (
                    this.ComboBoxSelectedIndex == input.ComboBoxSelectedIndex ||
                    (this.ComboBoxSelectedIndex != null &&
                    this.ComboBoxSelectedIndex.Equals(input.ComboBoxSelectedIndex))
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
                if (this.FieldName != null)
                    hashCode = hashCode * 59 + this.FieldName.GetHashCode();
                if (this.TextValue != null)
                    hashCode = hashCode * 59 + this.TextValue.GetHashCode();
                if (this.CheckboxValue != null)
                    hashCode = hashCode * 59 + this.CheckboxValue.GetHashCode();
                if (this.ComboBoxSelectedIndex != null)
                    hashCode = hashCode * 59 + this.ComboBoxSelectedIndex.GetHashCode();
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
