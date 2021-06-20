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
    /// Result of running a Get Macro Information command
    /// </summary>
    [DataContract]
    public partial class GetMacrosResponse :  IEquatable<GetMacrosResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetMacrosResponse" /> class.
        /// </summary>
        /// <param name="successful">True if successful, false otherwise.</param>
        /// <param name="containsVbaMacros">True if the document contains VBA macros, false otherwise.</param>
        public GetMacrosResponse(bool? successful = default(bool?), bool? containsVbaMacros = default(bool?))
        {
            this.Successful = successful;
            this.ContainsVbaMacros = containsVbaMacros;
        }
        
        /// <summary>
        /// True if successful, false otherwise
        /// </summary>
        /// <value>True if successful, false otherwise</value>
        [DataMember(Name="Successful", EmitDefaultValue=false)]
        public bool? Successful { get; set; }

        /// <summary>
        /// True if the document contains VBA macros, false otherwise
        /// </summary>
        /// <value>True if the document contains VBA macros, false otherwise</value>
        [DataMember(Name="ContainsVbaMacros", EmitDefaultValue=false)]
        public bool? ContainsVbaMacros { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetMacrosResponse {\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
            sb.Append("  ContainsVbaMacros: ").Append(ContainsVbaMacros).Append("\n");
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
            return this.Equals(input as GetMacrosResponse);
        }

        /// <summary>
        /// Returns true if GetMacrosResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetMacrosResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetMacrosResponse input)
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
                    this.ContainsVbaMacros == input.ContainsVbaMacros ||
                    (this.ContainsVbaMacros != null &&
                    this.ContainsVbaMacros.Equals(input.ContainsVbaMacros))
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
                if (this.ContainsVbaMacros != null)
                    hashCode = hashCode * 59 + this.ContainsVbaMacros.GetHashCode();
                return hashCode;
            }
        }
    }

}