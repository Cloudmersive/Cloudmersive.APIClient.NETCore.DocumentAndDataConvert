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
    /// Input to a Update Table Cell request
    /// </summary>
    [DataContract]
    public partial class UpdateDocxTableCellRequest :  IEquatable<UpdateDocxTableCellRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDocxTableCellRequest" /> class.
        /// </summary>
        /// <param name="InputFileBytes">Optional: Bytes of the input file to operate on.</param>
        /// <param name="InputFileUrl">Optional: URL of a file to operate on as input.  This can be a public URL, or you can also use the begin-editing API to upload a document and pass in the secure URL result from that operation as the URL here (this URL is not public)..</param>
        /// <param name="CellToUpdate">Table cell contents you would like to update the cell with.</param>
        /// <param name="TableRowIndex">0-based index of the Table Row to update.</param>
        /// <param name="TableCellIndex">0-based index of the Table Cell (within the row) to update.</param>
        /// <param name="ExistingTablePath">Required; the path to the existing table to modify.</param>
        public UpdateDocxTableCellRequest(byte[] InputFileBytes = default(byte[]), string InputFileUrl = default(string), DocxTableCell CellToUpdate = default(DocxTableCell), int? TableRowIndex = default(int?), int? TableCellIndex = default(int?), string ExistingTablePath = default(string))
        {
            this.InputFileBytes = InputFileBytes;
            this.InputFileUrl = InputFileUrl;
            this.CellToUpdate = CellToUpdate;
            this.TableRowIndex = TableRowIndex;
            this.TableCellIndex = TableCellIndex;
            this.ExistingTablePath = ExistingTablePath;
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
        /// Table cell contents you would like to update the cell with
        /// </summary>
        /// <value>Table cell contents you would like to update the cell with</value>
        [DataMember(Name="CellToUpdate", EmitDefaultValue=false)]
        public DocxTableCell CellToUpdate { get; set; }

        /// <summary>
        /// 0-based index of the Table Row to update
        /// </summary>
        /// <value>0-based index of the Table Row to update</value>
        [DataMember(Name="TableRowIndex", EmitDefaultValue=false)]
        public int? TableRowIndex { get; set; }

        /// <summary>
        /// 0-based index of the Table Cell (within the row) to update
        /// </summary>
        /// <value>0-based index of the Table Cell (within the row) to update</value>
        [DataMember(Name="TableCellIndex", EmitDefaultValue=false)]
        public int? TableCellIndex { get; set; }

        /// <summary>
        /// Required; the path to the existing table to modify
        /// </summary>
        /// <value>Required; the path to the existing table to modify</value>
        [DataMember(Name="ExistingTablePath", EmitDefaultValue=false)]
        public string ExistingTablePath { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateDocxTableCellRequest {\n");
            sb.Append("  InputFileBytes: ").Append(InputFileBytes).Append("\n");
            sb.Append("  InputFileUrl: ").Append(InputFileUrl).Append("\n");
            sb.Append("  CellToUpdate: ").Append(CellToUpdate).Append("\n");
            sb.Append("  TableRowIndex: ").Append(TableRowIndex).Append("\n");
            sb.Append("  TableCellIndex: ").Append(TableCellIndex).Append("\n");
            sb.Append("  ExistingTablePath: ").Append(ExistingTablePath).Append("\n");
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
            return this.Equals(input as UpdateDocxTableCellRequest);
        }

        /// <summary>
        /// Returns true if UpdateDocxTableCellRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateDocxTableCellRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateDocxTableCellRequest input)
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
                    this.CellToUpdate == input.CellToUpdate ||
                    (this.CellToUpdate != null &&
                    this.CellToUpdate.Equals(input.CellToUpdate))
                ) && 
                (
                    this.TableRowIndex == input.TableRowIndex ||
                    (this.TableRowIndex != null &&
                    this.TableRowIndex.Equals(input.TableRowIndex))
                ) && 
                (
                    this.TableCellIndex == input.TableCellIndex ||
                    (this.TableCellIndex != null &&
                    this.TableCellIndex.Equals(input.TableCellIndex))
                ) && 
                (
                    this.ExistingTablePath == input.ExistingTablePath ||
                    (this.ExistingTablePath != null &&
                    this.ExistingTablePath.Equals(input.ExistingTablePath))
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
                if (this.CellToUpdate != null)
                    hashCode = hashCode * 59 + this.CellToUpdate.GetHashCode();
                if (this.TableRowIndex != null)
                    hashCode = hashCode * 59 + this.TableRowIndex.GetHashCode();
                if (this.TableCellIndex != null)
                    hashCode = hashCode * 59 + this.TableCellIndex.GetHashCode();
                if (this.ExistingTablePath != null)
                    hashCode = hashCode * 59 + this.ExistingTablePath.GetHashCode();
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
