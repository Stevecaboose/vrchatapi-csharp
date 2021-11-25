/*
 * VRChat API Documentation
 *
 *
 * The version of the OpenAPI document: 1.6.0
 * Contact: me@ruby.js.org
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = VRChat.API.Client.OpenAPIDateConverter;

namespace VRChat.API.Model
{
    /// <summary>
    /// CreateFileVersionRequest
    /// </summary>
    [DataContract(Name = "CreateFileVersionRequest")]
    public partial class CreateFileVersionRequest : IEquatable<CreateFileVersionRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFileVersionRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateFileVersionRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFileVersionRequest" /> class.
        /// </summary>
        /// <param name="signatureMd5">signatureMd5 (required).</param>
        /// <param name="signatureSizeInBytes">signatureSizeInBytes (required).</param>
        /// <param name="fileMd5">fileMd5.</param>
        /// <param name="fileSizeInBytes">fileSizeInBytes.</param>
        public CreateFileVersionRequest(string signatureMd5 = default(string), decimal signatureSizeInBytes = default(decimal), string fileMd5 = default(string), decimal fileSizeInBytes = default(decimal))
        {
            // to ensure "signatureMd5" is required (not null)
            if (signatureMd5 == null) {
                throw new ArgumentNullException("signatureMd5 is a required property for CreateFileVersionRequest and cannot be null");
            }
            this.SignatureMd5 = signatureMd5;
            this.SignatureSizeInBytes = signatureSizeInBytes;
            this.FileMd5 = fileMd5;
            this.FileSizeInBytes = fileSizeInBytes;
        }

        /// <summary>
        /// Gets or Sets SignatureMd5
        /// </summary>
        [DataMember(Name = "signatureMd5", IsRequired = true, EmitDefaultValue = false)]
        public string SignatureMd5 { get; set; }

        /// <summary>
        /// Gets or Sets SignatureSizeInBytes
        /// </summary>
        [DataMember(Name = "signatureSizeInBytes", IsRequired = true, EmitDefaultValue = false)]
        public decimal SignatureSizeInBytes { get; set; }

        /// <summary>
        /// Gets or Sets FileMd5
        /// </summary>
        [DataMember(Name = "fileMd5", EmitDefaultValue = false)]
        public string FileMd5 { get; set; }

        /// <summary>
        /// Gets or Sets FileSizeInBytes
        /// </summary>
        [DataMember(Name = "fileSizeInBytes", EmitDefaultValue = false)]
        public decimal FileSizeInBytes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateFileVersionRequest {\n");
            sb.Append("  SignatureMd5: ").Append(SignatureMd5).Append("\n");
            sb.Append("  SignatureSizeInBytes: ").Append(SignatureSizeInBytes).Append("\n");
            sb.Append("  FileMd5: ").Append(FileMd5).Append("\n");
            sb.Append("  FileSizeInBytes: ").Append(FileSizeInBytes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateFileVersionRequest);
        }

        /// <summary>
        /// Returns true if CreateFileVersionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateFileVersionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateFileVersionRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SignatureMd5 == input.SignatureMd5 ||
                    (this.SignatureMd5 != null &&
                    this.SignatureMd5.Equals(input.SignatureMd5))
                ) && 
                (
                    this.SignatureSizeInBytes == input.SignatureSizeInBytes ||
                    this.SignatureSizeInBytes.Equals(input.SignatureSizeInBytes)
                ) && 
                (
                    this.FileMd5 == input.FileMd5 ||
                    (this.FileMd5 != null &&
                    this.FileMd5.Equals(input.FileMd5))
                ) && 
                (
                    this.FileSizeInBytes == input.FileSizeInBytes ||
                    this.FileSizeInBytes.Equals(input.FileSizeInBytes)
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
                if (this.SignatureMd5 != null)
                    hashCode = hashCode * 59 + this.SignatureMd5.GetHashCode();
                hashCode = hashCode * 59 + this.SignatureSizeInBytes.GetHashCode();
                if (this.FileMd5 != null)
                    hashCode = hashCode * 59 + this.FileMd5.GetHashCode();
                hashCode = hashCode * 59 + this.FileSizeInBytes.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            // SignatureMd5 (string) minLength
            if(this.SignatureMd5 != null && this.SignatureMd5.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SignatureMd5, length must be greater than 1.", new [] { "SignatureMd5" });
            }

            // FileMd5 (string) minLength
            if(this.FileMd5 != null && this.FileMd5.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FileMd5, length must be greater than 1.", new [] { "FileMd5" });
            }

            yield break;
        }
    }

}
