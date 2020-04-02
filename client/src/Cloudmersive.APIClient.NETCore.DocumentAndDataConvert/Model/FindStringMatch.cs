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
    /// Individual match result of finding a target string in a longer text string
    /// </summary>
    [DataContract]
    public partial class FindStringMatch :  IEquatable<FindStringMatch>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FindStringMatch" /> class.
        /// </summary>
        /// <param name="characterOffsetStart">0-based index of the start of the match.</param>
        /// <param name="characterOffsetEnd">0-based index of the end of the match.</param>
        /// <param name="containingLine">Text content of the line containing the match.</param>
        public FindStringMatch(int? characterOffsetStart = default(int?), int? characterOffsetEnd = default(int?), string containingLine = default(string))
        {
            this.CharacterOffsetStart = characterOffsetStart;
            this.CharacterOffsetEnd = characterOffsetEnd;
            this.ContainingLine = containingLine;
        }
        
        /// <summary>
        /// 0-based index of the start of the match
        /// </summary>
        /// <value>0-based index of the start of the match</value>
        [DataMember(Name="CharacterOffsetStart", EmitDefaultValue=false)]
        public int? CharacterOffsetStart { get; set; }

        /// <summary>
        /// 0-based index of the end of the match
        /// </summary>
        /// <value>0-based index of the end of the match</value>
        [DataMember(Name="CharacterOffsetEnd", EmitDefaultValue=false)]
        public int? CharacterOffsetEnd { get; set; }

        /// <summary>
        /// Text content of the line containing the match
        /// </summary>
        /// <value>Text content of the line containing the match</value>
        [DataMember(Name="ContainingLine", EmitDefaultValue=false)]
        public string ContainingLine { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FindStringMatch {\n");
            sb.Append("  CharacterOffsetStart: ").Append(CharacterOffsetStart).Append("\n");
            sb.Append("  CharacterOffsetEnd: ").Append(CharacterOffsetEnd).Append("\n");
            sb.Append("  ContainingLine: ").Append(ContainingLine).Append("\n");
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
            return this.Equals(input as FindStringMatch);
        }

        /// <summary>
        /// Returns true if FindStringMatch instances are equal
        /// </summary>
        /// <param name="input">Instance of FindStringMatch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FindStringMatch input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CharacterOffsetStart == input.CharacterOffsetStart ||
                    (this.CharacterOffsetStart != null &&
                    this.CharacterOffsetStart.Equals(input.CharacterOffsetStart))
                ) && 
                (
                    this.CharacterOffsetEnd == input.CharacterOffsetEnd ||
                    (this.CharacterOffsetEnd != null &&
                    this.CharacterOffsetEnd.Equals(input.CharacterOffsetEnd))
                ) && 
                (
                    this.ContainingLine == input.ContainingLine ||
                    (this.ContainingLine != null &&
                    this.ContainingLine.Equals(input.ContainingLine))
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
                if (this.CharacterOffsetStart != null)
                    hashCode = hashCode * 59 + this.CharacterOffsetStart.GetHashCode();
                if (this.CharacterOffsetEnd != null)
                    hashCode = hashCode * 59 + this.CharacterOffsetEnd.GetHashCode();
                if (this.ContainingLine != null)
                    hashCode = hashCode * 59 + this.ContainingLine.GetHashCode();
                return hashCode;
            }
        }
    }

}
