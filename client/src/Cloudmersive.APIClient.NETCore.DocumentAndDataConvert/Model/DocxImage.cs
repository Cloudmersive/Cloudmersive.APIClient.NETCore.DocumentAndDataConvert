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
    /// DocxImage
    /// </summary>
    [DataContract]
    public partial class DocxImage :  IEquatable<DocxImage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocxImage" /> class.
        /// </summary>
        /// <param name="Path">The Path of the location of this object; leave blank for new tables.</param>
        /// <param name="ImageName">The Name of the image.</param>
        /// <param name="ImageId">The Id of the image.</param>
        /// <param name="ImageDescription">The Description of the image.</param>
        /// <param name="ImageWidth">Width of the image in EMUs (English Metric Units); set to 0 to default to page width and aspect-ratio based height.</param>
        /// <param name="ImageHeight">Height of the image in EMUs (English Metric Units); set to 0 to default to page width and aspect-ratio based height.</param>
        /// <param name="XOffset">X (horizontal) offset of the image.</param>
        /// <param name="YOffset">Y (vertical) offset of the image.</param>
        /// <param name="ImageDataEmbedId">Read-only; internal ID for the image contents.</param>
        /// <param name="ImageDataContentType">Read-only; image data MIME content-type.</param>
        /// <param name="ImageInternalFileName">Read-only; internal file name/path for the image.</param>
        /// <param name="ImageContentsURL">URL to the image contents; file is stored in an in-memory cache and will be deleted.  Call Finish-Editing to get the contents..</param>
        /// <param name="Inline">True if the image is inline with the text; false if it is floating.</param>
        public DocxImage(string Path = default(string), string ImageName = default(string), long? ImageId = default(long?), string ImageDescription = default(string), long? ImageWidth = default(long?), long? ImageHeight = default(long?), long? XOffset = default(long?), long? YOffset = default(long?), string ImageDataEmbedId = default(string), string ImageDataContentType = default(string), string ImageInternalFileName = default(string), string ImageContentsURL = default(string), bool? Inline = default(bool?))
        {
            this.Path = Path;
            this.ImageName = ImageName;
            this.ImageId = ImageId;
            this.ImageDescription = ImageDescription;
            this.ImageWidth = ImageWidth;
            this.ImageHeight = ImageHeight;
            this.XOffset = XOffset;
            this.YOffset = YOffset;
            this.ImageDataEmbedId = ImageDataEmbedId;
            this.ImageDataContentType = ImageDataContentType;
            this.ImageInternalFileName = ImageInternalFileName;
            this.ImageContentsURL = ImageContentsURL;
            this.Inline = Inline;
        }
        
        /// <summary>
        /// The Path of the location of this object; leave blank for new tables
        /// </summary>
        /// <value>The Path of the location of this object; leave blank for new tables</value>
        [DataMember(Name="Path", EmitDefaultValue=false)]
        public string Path { get; set; }

        /// <summary>
        /// The Name of the image
        /// </summary>
        /// <value>The Name of the image</value>
        [DataMember(Name="ImageName", EmitDefaultValue=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// The Id of the image
        /// </summary>
        /// <value>The Id of the image</value>
        [DataMember(Name="ImageId", EmitDefaultValue=false)]
        public long? ImageId { get; set; }

        /// <summary>
        /// The Description of the image
        /// </summary>
        /// <value>The Description of the image</value>
        [DataMember(Name="ImageDescription", EmitDefaultValue=false)]
        public string ImageDescription { get; set; }

        /// <summary>
        /// Width of the image in EMUs (English Metric Units); set to 0 to default to page width and aspect-ratio based height
        /// </summary>
        /// <value>Width of the image in EMUs (English Metric Units); set to 0 to default to page width and aspect-ratio based height</value>
        [DataMember(Name="ImageWidth", EmitDefaultValue=false)]
        public long? ImageWidth { get; set; }

        /// <summary>
        /// Height of the image in EMUs (English Metric Units); set to 0 to default to page width and aspect-ratio based height
        /// </summary>
        /// <value>Height of the image in EMUs (English Metric Units); set to 0 to default to page width and aspect-ratio based height</value>
        [DataMember(Name="ImageHeight", EmitDefaultValue=false)]
        public long? ImageHeight { get; set; }

        /// <summary>
        /// X (horizontal) offset of the image
        /// </summary>
        /// <value>X (horizontal) offset of the image</value>
        [DataMember(Name="XOffset", EmitDefaultValue=false)]
        public long? XOffset { get; set; }

        /// <summary>
        /// Y (vertical) offset of the image
        /// </summary>
        /// <value>Y (vertical) offset of the image</value>
        [DataMember(Name="YOffset", EmitDefaultValue=false)]
        public long? YOffset { get; set; }

        /// <summary>
        /// Read-only; internal ID for the image contents
        /// </summary>
        /// <value>Read-only; internal ID for the image contents</value>
        [DataMember(Name="ImageDataEmbedId", EmitDefaultValue=false)]
        public string ImageDataEmbedId { get; set; }

        /// <summary>
        /// Read-only; image data MIME content-type
        /// </summary>
        /// <value>Read-only; image data MIME content-type</value>
        [DataMember(Name="ImageDataContentType", EmitDefaultValue=false)]
        public string ImageDataContentType { get; set; }

        /// <summary>
        /// Read-only; internal file name/path for the image
        /// </summary>
        /// <value>Read-only; internal file name/path for the image</value>
        [DataMember(Name="ImageInternalFileName", EmitDefaultValue=false)]
        public string ImageInternalFileName { get; set; }

        /// <summary>
        /// URL to the image contents; file is stored in an in-memory cache and will be deleted.  Call Finish-Editing to get the contents.
        /// </summary>
        /// <value>URL to the image contents; file is stored in an in-memory cache and will be deleted.  Call Finish-Editing to get the contents.</value>
        [DataMember(Name="ImageContentsURL", EmitDefaultValue=false)]
        public string ImageContentsURL { get; set; }

        /// <summary>
        /// True if the image is inline with the text; false if it is floating
        /// </summary>
        /// <value>True if the image is inline with the text; false if it is floating</value>
        [DataMember(Name="Inline", EmitDefaultValue=false)]
        public bool? Inline { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocxImage {\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  ImageName: ").Append(ImageName).Append("\n");
            sb.Append("  ImageId: ").Append(ImageId).Append("\n");
            sb.Append("  ImageDescription: ").Append(ImageDescription).Append("\n");
            sb.Append("  ImageWidth: ").Append(ImageWidth).Append("\n");
            sb.Append("  ImageHeight: ").Append(ImageHeight).Append("\n");
            sb.Append("  XOffset: ").Append(XOffset).Append("\n");
            sb.Append("  YOffset: ").Append(YOffset).Append("\n");
            sb.Append("  ImageDataEmbedId: ").Append(ImageDataEmbedId).Append("\n");
            sb.Append("  ImageDataContentType: ").Append(ImageDataContentType).Append("\n");
            sb.Append("  ImageInternalFileName: ").Append(ImageInternalFileName).Append("\n");
            sb.Append("  ImageContentsURL: ").Append(ImageContentsURL).Append("\n");
            sb.Append("  Inline: ").Append(Inline).Append("\n");
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
            return this.Equals(input as DocxImage);
        }

        /// <summary>
        /// Returns true if DocxImage instances are equal
        /// </summary>
        /// <param name="input">Instance of DocxImage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocxImage input)
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
                    this.ImageName == input.ImageName ||
                    (this.ImageName != null &&
                    this.ImageName.Equals(input.ImageName))
                ) && 
                (
                    this.ImageId == input.ImageId ||
                    (this.ImageId != null &&
                    this.ImageId.Equals(input.ImageId))
                ) && 
                (
                    this.ImageDescription == input.ImageDescription ||
                    (this.ImageDescription != null &&
                    this.ImageDescription.Equals(input.ImageDescription))
                ) && 
                (
                    this.ImageWidth == input.ImageWidth ||
                    (this.ImageWidth != null &&
                    this.ImageWidth.Equals(input.ImageWidth))
                ) && 
                (
                    this.ImageHeight == input.ImageHeight ||
                    (this.ImageHeight != null &&
                    this.ImageHeight.Equals(input.ImageHeight))
                ) && 
                (
                    this.XOffset == input.XOffset ||
                    (this.XOffset != null &&
                    this.XOffset.Equals(input.XOffset))
                ) && 
                (
                    this.YOffset == input.YOffset ||
                    (this.YOffset != null &&
                    this.YOffset.Equals(input.YOffset))
                ) && 
                (
                    this.ImageDataEmbedId == input.ImageDataEmbedId ||
                    (this.ImageDataEmbedId != null &&
                    this.ImageDataEmbedId.Equals(input.ImageDataEmbedId))
                ) && 
                (
                    this.ImageDataContentType == input.ImageDataContentType ||
                    (this.ImageDataContentType != null &&
                    this.ImageDataContentType.Equals(input.ImageDataContentType))
                ) && 
                (
                    this.ImageInternalFileName == input.ImageInternalFileName ||
                    (this.ImageInternalFileName != null &&
                    this.ImageInternalFileName.Equals(input.ImageInternalFileName))
                ) && 
                (
                    this.ImageContentsURL == input.ImageContentsURL ||
                    (this.ImageContentsURL != null &&
                    this.ImageContentsURL.Equals(input.ImageContentsURL))
                ) && 
                (
                    this.Inline == input.Inline ||
                    (this.Inline != null &&
                    this.Inline.Equals(input.Inline))
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
                if (this.ImageName != null)
                    hashCode = hashCode * 59 + this.ImageName.GetHashCode();
                if (this.ImageId != null)
                    hashCode = hashCode * 59 + this.ImageId.GetHashCode();
                if (this.ImageDescription != null)
                    hashCode = hashCode * 59 + this.ImageDescription.GetHashCode();
                if (this.ImageWidth != null)
                    hashCode = hashCode * 59 + this.ImageWidth.GetHashCode();
                if (this.ImageHeight != null)
                    hashCode = hashCode * 59 + this.ImageHeight.GetHashCode();
                if (this.XOffset != null)
                    hashCode = hashCode * 59 + this.XOffset.GetHashCode();
                if (this.YOffset != null)
                    hashCode = hashCode * 59 + this.YOffset.GetHashCode();
                if (this.ImageDataEmbedId != null)
                    hashCode = hashCode * 59 + this.ImageDataEmbedId.GetHashCode();
                if (this.ImageDataContentType != null)
                    hashCode = hashCode * 59 + this.ImageDataContentType.GetHashCode();
                if (this.ImageInternalFileName != null)
                    hashCode = hashCode * 59 + this.ImageInternalFileName.GetHashCode();
                if (this.ImageContentsURL != null)
                    hashCode = hashCode * 59 + this.ImageContentsURL.GetHashCode();
                if (this.Inline != null)
                    hashCode = hashCode * 59 + this.Inline.GetHashCode();
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