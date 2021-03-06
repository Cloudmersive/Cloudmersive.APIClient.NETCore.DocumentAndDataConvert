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
    /// Result of converting a MSG input to a JPG array
    /// </summary>
    [DataContract]
    public partial class MsgToJpgResult :  IEquatable<MsgToJpgResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MsgToJpgResult" /> class.
        /// </summary>
        /// <param name="successful">True if the operation was successful, false otherwise.</param>
        /// <param name="jpgResultPages">Array of converted pages.</param>
        public MsgToJpgResult(bool? successful = default(bool?), List<ConvertedJpgPage> jpgResultPages = default(List<ConvertedJpgPage>))
        {
            this.Successful = successful;
            this.JpgResultPages = jpgResultPages;
        }
        
        /// <summary>
        /// True if the operation was successful, false otherwise
        /// </summary>
        /// <value>True if the operation was successful, false otherwise</value>
        [DataMember(Name="Successful", EmitDefaultValue=false)]
        public bool? Successful { get; set; }

        /// <summary>
        /// Array of converted pages
        /// </summary>
        /// <value>Array of converted pages</value>
        [DataMember(Name="JpgResultPages", EmitDefaultValue=false)]
        public List<ConvertedJpgPage> JpgResultPages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MsgToJpgResult {\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
            sb.Append("  JpgResultPages: ").Append(JpgResultPages).Append("\n");
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
            return this.Equals(input as MsgToJpgResult);
        }

        /// <summary>
        /// Returns true if MsgToJpgResult instances are equal
        /// </summary>
        /// <param name="input">Instance of MsgToJpgResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MsgToJpgResult input)
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
                    this.JpgResultPages == input.JpgResultPages ||
                    this.JpgResultPages != null &&
                    this.JpgResultPages.SequenceEqual(input.JpgResultPages)
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
                if (this.JpgResultPages != null)
                    hashCode = hashCode * 59 + this.JpgResultPages.GetHashCode();
                return hashCode;
            }
        }
    }

}
