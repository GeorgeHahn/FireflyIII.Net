/* 
 * Firefly III API
 *
 * This is the official documentation of the Firefly III API. You can find accompanying documentation on the website of Firefly III itself (see below). Please report any bugs or issues. This version of the API is live from version v4.7.9 and onwards. You may use the \"Authorize\" button to try the API below. 
 *
 * The version of the OpenAPI document: 0.10.4-modified
 * Contact: thegrumpydictator@gmail.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = FireflyIII.Net.Client.OpenAPIDateConverter;

namespace FireflyIII.Net.Model
{
    /// <summary>
    /// SystemInfoData
    /// </summary>
    [DataContract]
    public partial class SystemInfoData :  IEquatable<SystemInfoData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemInfoData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SystemInfoData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SystemInfoData" /> class.
        /// </summary>
        /// <param name="version">version (required).</param>
        /// <param name="apiVersion">apiVersion (required).</param>
        /// <param name="phpVersion">phpVersion (required).</param>
        /// <param name="os">os (required).</param>
        /// <param name="driver">driver (required).</param>
        public SystemInfoData(string version = default(string), string apiVersion = default(string), string phpVersion = default(string), string os = default(string), string driver = default(string))
        {
            // to ensure "version" is required (not null)
            if (version == null)
            {
                throw new InvalidDataException("version is a required property for SystemInfoData and cannot be null");
            }
            else
            {
                this.Version = version;
            }

            // to ensure "apiVersion" is required (not null)
            if (apiVersion == null)
            {
                throw new InvalidDataException("apiVersion is a required property for SystemInfoData and cannot be null");
            }
            else
            {
                this.ApiVersion = apiVersion;
            }

            // to ensure "phpVersion" is required (not null)
            if (phpVersion == null)
            {
                throw new InvalidDataException("phpVersion is a required property for SystemInfoData and cannot be null");
            }
            else
            {
                this.PhpVersion = phpVersion;
            }

            // to ensure "os" is required (not null)
            if (os == null)
            {
                throw new InvalidDataException("os is a required property for SystemInfoData and cannot be null");
            }
            else
            {
                this.Os = os;
            }

            // to ensure "driver" is required (not null)
            if (driver == null)
            {
                throw new InvalidDataException("driver is a required property for SystemInfoData and cannot be null");
            }
            else
            {
                this.Driver = driver;
            }

        }
        
        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }

        /// <summary>
        /// Gets or Sets ApiVersion
        /// </summary>
        [DataMember(Name="api_version", EmitDefaultValue=false)]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Gets or Sets PhpVersion
        /// </summary>
        [DataMember(Name="php_version", EmitDefaultValue=false)]
        public string PhpVersion { get; set; }

        /// <summary>
        /// Gets or Sets Os
        /// </summary>
        [DataMember(Name="os", EmitDefaultValue=false)]
        public string Os { get; set; }

        /// <summary>
        /// Gets or Sets Driver
        /// </summary>
        [DataMember(Name="driver", EmitDefaultValue=false)]
        public string Driver { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SystemInfoData {\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  ApiVersion: ").Append(ApiVersion).Append("\n");
            sb.Append("  PhpVersion: ").Append(PhpVersion).Append("\n");
            sb.Append("  Os: ").Append(Os).Append("\n");
            sb.Append("  Driver: ").Append(Driver).Append("\n");
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
            return this.Equals(input as SystemInfoData);
        }

        /// <summary>
        /// Returns true if SystemInfoData instances are equal
        /// </summary>
        /// <param name="input">Instance of SystemInfoData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SystemInfoData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.ApiVersion == input.ApiVersion ||
                    (this.ApiVersion != null &&
                    this.ApiVersion.Equals(input.ApiVersion))
                ) && 
                (
                    this.PhpVersion == input.PhpVersion ||
                    (this.PhpVersion != null &&
                    this.PhpVersion.Equals(input.PhpVersion))
                ) && 
                (
                    this.Os == input.Os ||
                    (this.Os != null &&
                    this.Os.Equals(input.Os))
                ) && 
                (
                    this.Driver == input.Driver ||
                    (this.Driver != null &&
                    this.Driver.Equals(input.Driver))
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
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.ApiVersion != null)
                    hashCode = hashCode * 59 + this.ApiVersion.GetHashCode();
                if (this.PhpVersion != null)
                    hashCode = hashCode * 59 + this.PhpVersion.GetHashCode();
                if (this.Os != null)
                    hashCode = hashCode * 59 + this.Os.GetHashCode();
                if (this.Driver != null)
                    hashCode = hashCode * 59 + this.Driver.GetHashCode();
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
