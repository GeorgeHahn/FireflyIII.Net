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
using OpenAPIDateConverter = FireflyIII.Client.OpenAPIDateConverter;

namespace FireflyIII.Model
{
    /// <summary>
    /// ChartDataPoint
    /// </summary>
    [DataContract]
    public partial class ChartDataPoint :  IEquatable<ChartDataPoint>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChartDataPoint" /> class.
        /// </summary>
        /// <param name="key">The key is the label of the value, so for example: &#39;2018-01-01&#39; &#x3D;&gt; 13 or &#39;Groceries&#39; &#x3D;&gt; -123..</param>
        public ChartDataPoint(string key = default(string))
        {
            this.Key = key;
        }

        /// <summary>
        /// The key is the label of the value, so for example: &#39;2018-01-01&#39; &#x3D;&gt; 13 or &#39;Groceries&#39; &#x3D;&gt; -123.
        /// </summary>
        /// <value>The key is the label of the value, so for example: &#39;2018-01-01&#39; &#x3D;&gt; 13 or &#39;Groceries&#39; &#x3D;&gt; -123.</value>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChartDataPoint {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
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
            return this.Equals(input as ChartDataPoint);
        }

        /// <summary>
        /// Returns true if ChartDataPoint instances are equal
        /// </summary>
        /// <param name="input">Instance of ChartDataPoint to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChartDataPoint input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
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
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
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
