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
    /// Input to a delete DOCX table row range request
    /// </summary>
    [DataContract]
    public partial class DeleteDocxTableRowRangeRequest :  IEquatable<DeleteDocxTableRowRangeRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteDocxTableRowRangeRequest" /> class.
        /// </summary>
        /// <param name="InputFileBytes">Optional: Bytes of the input file to operate on.</param>
        /// <param name="InputFileUrl">Optional: URL of a file to operate on as input.  This can be a public URL, or you can also use the begin-editing API to upload a document and pass in the secure URL result from that operation as the URL here (this URL is not public)..</param>
        /// <param name="TablePath">Path to the table to delete the row from.</param>
        /// <param name="TableRowRowIndexStart">0-based index of the row to begin deleting rows (e.g. 0, 1, 2, ...) in the table.</param>
        /// <param name="TableRowRowIndexEnd">0-based index of the row to stop deleting rows (e.g. 0, 1, 2, ...) in the table.</param>
        public DeleteDocxTableRowRangeRequest(byte[] InputFileBytes = default(byte[]), string InputFileUrl = default(string), string TablePath = default(string), int? TableRowRowIndexStart = default(int?), int? TableRowRowIndexEnd = default(int?))
        {
            this.InputFileBytes = InputFileBytes;
            this.InputFileUrl = InputFileUrl;
            this.TablePath = TablePath;
            this.TableRowRowIndexStart = TableRowRowIndexStart;
            this.TableRowRowIndexEnd = TableRowRowIndexEnd;
        }
        
        /// <summary>
        /// Optional: Bytes of the input file to operate on
        /// </summary>
        /// <value>Optional: Bytes of the input file to operate on</value>
        [DataMember(Name="InputFileBytes", EmitDefaultValue=false)]
        public byte[] InputFileBytes { get; set; }

        /// <summary>
        /// Optional: URL of a file to operate on as input.  This can be a public URL, or you can also use the begin-editing API to upload a document and pass in the secure URL result from that operation as the URL here (this URL is not public).
        /// </summary>
        /// <value>Optional: URL of a file to operate on as input.  This can be a public URL, or you can also use the begin-editing API to upload a document and pass in the secure URL result from that operation as the URL here (this URL is not public).</value>
        [DataMember(Name="InputFileUrl", EmitDefaultValue=false)]
        public string InputFileUrl { get; set; }

        /// <summary>
        /// Path to the table to delete the row from
        /// </summary>
        /// <value>Path to the table to delete the row from</value>
        [DataMember(Name="TablePath", EmitDefaultValue=false)]
        public string TablePath { get; set; }

        /// <summary>
        /// 0-based index of the row to begin deleting rows (e.g. 0, 1, 2, ...) in the table
        /// </summary>
        /// <value>0-based index of the row to begin deleting rows (e.g. 0, 1, 2, ...) in the table</value>
        [DataMember(Name="TableRowRowIndexStart", EmitDefaultValue=false)]
        public int? TableRowRowIndexStart { get; set; }

        /// <summary>
        /// 0-based index of the row to stop deleting rows (e.g. 0, 1, 2, ...) in the table
        /// </summary>
        /// <value>0-based index of the row to stop deleting rows (e.g. 0, 1, 2, ...) in the table</value>
        [DataMember(Name="TableRowRowIndexEnd", EmitDefaultValue=false)]
        public int? TableRowRowIndexEnd { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteDocxTableRowRangeRequest {\n");
            sb.Append("  InputFileBytes: ").Append(InputFileBytes).Append("\n");
            sb.Append("  InputFileUrl: ").Append(InputFileUrl).Append("\n");
            sb.Append("  TablePath: ").Append(TablePath).Append("\n");
            sb.Append("  TableRowRowIndexStart: ").Append(TableRowRowIndexStart).Append("\n");
            sb.Append("  TableRowRowIndexEnd: ").Append(TableRowRowIndexEnd).Append("\n");
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
            return this.Equals(input as DeleteDocxTableRowRangeRequest);
        }

        /// <summary>
        /// Returns true if DeleteDocxTableRowRangeRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DeleteDocxTableRowRangeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeleteDocxTableRowRangeRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InputFileBytes == input.InputFileBytes ||
                    (this.InputFileBytes != null &&
                    this.InputFileBytes.Equals(input.InputFileBytes))
                ) && 
                (
                    this.InputFileUrl == input.InputFileUrl ||
                    (this.InputFileUrl != null &&
                    this.InputFileUrl.Equals(input.InputFileUrl))
                ) && 
                (
                    this.TablePath == input.TablePath ||
                    (this.TablePath != null &&
                    this.TablePath.Equals(input.TablePath))
                ) && 
                (
                    this.TableRowRowIndexStart == input.TableRowRowIndexStart ||
                    (this.TableRowRowIndexStart != null &&
                    this.TableRowRowIndexStart.Equals(input.TableRowRowIndexStart))
                ) && 
                (
                    this.TableRowRowIndexEnd == input.TableRowRowIndexEnd ||
                    (this.TableRowRowIndexEnd != null &&
                    this.TableRowRowIndexEnd.Equals(input.TableRowRowIndexEnd))
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
                if (this.InputFileBytes != null)
                    hashCode = hashCode * 59 + this.InputFileBytes.GetHashCode();
                if (this.InputFileUrl != null)
                    hashCode = hashCode * 59 + this.InputFileUrl.GetHashCode();
                if (this.TablePath != null)
                    hashCode = hashCode * 59 + this.TablePath.GetHashCode();
                if (this.TableRowRowIndexStart != null)
                    hashCode = hashCode * 59 + this.TableRowRowIndexStart.GetHashCode();
                if (this.TableRowRowIndexEnd != null)
                    hashCode = hashCode * 59 + this.TableRowRowIndexEnd.GetHashCode();
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
