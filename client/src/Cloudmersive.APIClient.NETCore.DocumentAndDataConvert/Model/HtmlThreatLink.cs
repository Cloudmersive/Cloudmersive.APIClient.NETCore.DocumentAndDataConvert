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
    /// Threat assessment for a hyperlink URL
    /// </summary>
    [DataContract]
    public partial class HtmlThreatLink :  IEquatable<HtmlThreatLink>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlThreatLink" /> class.
        /// </summary>
        /// <param name="linkUrl">URL of the link.</param>
        /// <param name="threatLevel">Threat assessment level; possible values are None, Low, Medium and High.</param>
        public HtmlThreatLink(string linkUrl = default(string), string threatLevel = default(string))
        {
            this.LinkUrl = linkUrl;
            this.ThreatLevel = threatLevel;
        }
        
        /// <summary>
        /// URL of the link
        /// </summary>
        /// <value>URL of the link</value>
        [DataMember(Name="LinkUrl", EmitDefaultValue=false)]
        public string LinkUrl { get; set; }

        /// <summary>
        /// Threat assessment level; possible values are None, Low, Medium and High
        /// </summary>
        /// <value>Threat assessment level; possible values are None, Low, Medium and High</value>
        [DataMember(Name="ThreatLevel", EmitDefaultValue=false)]
        public string ThreatLevel { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HtmlThreatLink {\n");
            sb.Append("  LinkUrl: ").Append(LinkUrl).Append("\n");
            sb.Append("  ThreatLevel: ").Append(ThreatLevel).Append("\n");
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
            return this.Equals(input as HtmlThreatLink);
        }

        /// <summary>
        /// Returns true if HtmlThreatLink instances are equal
        /// </summary>
        /// <param name="input">Instance of HtmlThreatLink to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HtmlThreatLink input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LinkUrl == input.LinkUrl ||
                    (this.LinkUrl != null &&
                    this.LinkUrl.Equals(input.LinkUrl))
                ) && 
                (
                    this.ThreatLevel == input.ThreatLevel ||
                    (this.ThreatLevel != null &&
                    this.ThreatLevel.Equals(input.ThreatLevel))
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
                if (this.LinkUrl != null)
                    hashCode = hashCode * 59 + this.LinkUrl.GetHashCode();
                if (this.ThreatLevel != null)
                    hashCode = hashCode * 59 + this.ThreatLevel.GetHashCode();
                return hashCode;
            }
        }
    }

}
