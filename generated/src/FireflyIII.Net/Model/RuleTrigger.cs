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
    /// RuleTrigger
    /// </summary>
    [DataContract]
    public partial class RuleTrigger :  IEquatable<RuleTrigger>, IValidatableObject
    {
        /// <summary>
        /// The type of thing this trigger responds to. A limited set is possible
        /// </summary>
        /// <value>The type of thing this trigger responds to. A limited set is possible</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Fromaccountstarts for value: from_account_starts
            /// </summary>
            [EnumMember(Value = "from_account_starts")]
            Fromaccountstarts = 1,

            /// <summary>
            /// Enum Fromaccountends for value: from_account_ends
            /// </summary>
            [EnumMember(Value = "from_account_ends")]
            Fromaccountends = 2,

            /// <summary>
            /// Enum Fromaccountis for value: from_account_is
            /// </summary>
            [EnumMember(Value = "from_account_is")]
            Fromaccountis = 3,

            /// <summary>
            /// Enum Fromaccountcontains for value: from_account_contains
            /// </summary>
            [EnumMember(Value = "from_account_contains")]
            Fromaccountcontains = 4,

            /// <summary>
            /// Enum Toaccountstarts for value: to_account_starts
            /// </summary>
            [EnumMember(Value = "to_account_starts")]
            Toaccountstarts = 5,

            /// <summary>
            /// Enum Toaccountends for value: to_account_ends
            /// </summary>
            [EnumMember(Value = "to_account_ends")]
            Toaccountends = 6,

            /// <summary>
            /// Enum Toaccountis for value: to_account_is
            /// </summary>
            [EnumMember(Value = "to_account_is")]
            Toaccountis = 7,

            /// <summary>
            /// Enum Toaccountcontains for value: to_account_contains
            /// </summary>
            [EnumMember(Value = "to_account_contains")]
            Toaccountcontains = 8,

            /// <summary>
            /// Enum Amountless for value: amount_less
            /// </summary>
            [EnumMember(Value = "amount_less")]
            Amountless = 9,

            /// <summary>
            /// Enum Amountexactly for value: amount_exactly
            /// </summary>
            [EnumMember(Value = "amount_exactly")]
            Amountexactly = 10,

            /// <summary>
            /// Enum Amountmore for value: amount_more
            /// </summary>
            [EnumMember(Value = "amount_more")]
            Amountmore = 11,

            /// <summary>
            /// Enum Descriptionstarts for value: description_starts
            /// </summary>
            [EnumMember(Value = "description_starts")]
            Descriptionstarts = 12,

            /// <summary>
            /// Enum Descriptionends for value: description_ends
            /// </summary>
            [EnumMember(Value = "description_ends")]
            Descriptionends = 13,

            /// <summary>
            /// Enum Descriptioncontains for value: description_contains
            /// </summary>
            [EnumMember(Value = "description_contains")]
            Descriptioncontains = 14,

            /// <summary>
            /// Enum Descriptionis for value: description_is
            /// </summary>
            [EnumMember(Value = "description_is")]
            Descriptionis = 15,

            /// <summary>
            /// Enum Transactiontype for value: transaction_type
            /// </summary>
            [EnumMember(Value = "transaction_type")]
            Transactiontype = 16,

            /// <summary>
            /// Enum Categoryis for value: category_is
            /// </summary>
            [EnumMember(Value = "category_is")]
            Categoryis = 17,

            /// <summary>
            /// Enum Budgetis for value: budget_is
            /// </summary>
            [EnumMember(Value = "budget_is")]
            Budgetis = 18,

            /// <summary>
            /// Enum Tagis for value: tag_is
            /// </summary>
            [EnumMember(Value = "tag_is")]
            Tagis = 19,

            /// <summary>
            /// Enum Currencyis for value: currency_is
            /// </summary>
            [EnumMember(Value = "currency_is")]
            Currencyis = 20,

            /// <summary>
            /// Enum Hasattachments for value: has_attachments
            /// </summary>
            [EnumMember(Value = "has_attachments")]
            Hasattachments = 21,

            /// <summary>
            /// Enum Hasnocategory for value: has_no_category
            /// </summary>
            [EnumMember(Value = "has_no_category")]
            Hasnocategory = 22,

            /// <summary>
            /// Enum Hasanycategory for value: has_any_category
            /// </summary>
            [EnumMember(Value = "has_any_category")]
            Hasanycategory = 23,

            /// <summary>
            /// Enum Hasnobudget for value: has_no_budget
            /// </summary>
            [EnumMember(Value = "has_no_budget")]
            Hasnobudget = 24,

            /// <summary>
            /// Enum Hasanybudget for value: has_any_budget
            /// </summary>
            [EnumMember(Value = "has_any_budget")]
            Hasanybudget = 25,

            /// <summary>
            /// Enum Hasnotag for value: has_no_tag
            /// </summary>
            [EnumMember(Value = "has_no_tag")]
            Hasnotag = 26,

            /// <summary>
            /// Enum Hasanytag for value: has_any_tag
            /// </summary>
            [EnumMember(Value = "has_any_tag")]
            Hasanytag = 27,

            /// <summary>
            /// Enum Notescontain for value: notes_contain
            /// </summary>
            [EnumMember(Value = "notes_contain")]
            Notescontain = 28,

            /// <summary>
            /// Enum Notesstart for value: notes_start
            /// </summary>
            [EnumMember(Value = "notes_start")]
            Notesstart = 29,

            /// <summary>
            /// Enum Notesend for value: notes_end
            /// </summary>
            [EnumMember(Value = "notes_end")]
            Notesend = 30,

            /// <summary>
            /// Enum Notesare for value: notes_are
            /// </summary>
            [EnumMember(Value = "notes_are")]
            Notesare = 31,

            /// <summary>
            /// Enum Nonotes for value: no_notes
            /// </summary>
            [EnumMember(Value = "no_notes")]
            Nonotes = 32,

            /// <summary>
            /// Enum Anynotes for value: any_notes
            /// </summary>
            [EnumMember(Value = "any_notes")]
            Anynotes = 33

        }

        /// <summary>
        /// The type of thing this trigger responds to. A limited set is possible
        /// </summary>
        /// <value>The type of thing this trigger responds to. A limited set is possible</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RuleTrigger" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RuleTrigger() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RuleTrigger" /> class.
        /// </summary>
        /// <param name="type">The type of thing this trigger responds to. A limited set is possible (required).</param>
        /// <param name="value">The accompanying value the trigger responds to. This value is often mandatory, but this depends on the trigger. (required).</param>
        /// <param name="active">If the trigger is active..</param>
        /// <param name="stopProcessing">When true, other triggers will not be checked if this trigger was triggered..</param>
        public RuleTrigger(TypeEnum type = default(TypeEnum), string value = default(string), bool active = default(bool), bool stopProcessing = default(bool))
        {
            this.Type = type;
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new InvalidDataException("value is a required property for RuleTrigger and cannot be null");
            }
            else
            {
                this.Value = value;
            }

            this.Active = active;
            this.StopProcessing = stopProcessing;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int Id { get; private set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime CreatedAt { get; private set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public DateTime UpdatedAt { get; private set; }

        /// <summary>
        /// The accompanying value the trigger responds to. This value is often mandatory, but this depends on the trigger.
        /// </summary>
        /// <value>The accompanying value the trigger responds to. This value is often mandatory, but this depends on the trigger.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Order of the trigger
        /// </summary>
        /// <value>Order of the trigger</value>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public int Order { get; private set; }

        /// <summary>
        /// If the trigger is active.
        /// </summary>
        /// <value>If the trigger is active.</value>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool Active { get; set; }

        /// <summary>
        /// When true, other triggers will not be checked if this trigger was triggered.
        /// </summary>
        /// <value>When true, other triggers will not be checked if this trigger was triggered.</value>
        [DataMember(Name="stop_processing", EmitDefaultValue=false)]
        public bool StopProcessing { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RuleTrigger {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  StopProcessing: ").Append(StopProcessing).Append("\n");
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
            return this.Equals(input as RuleTrigger);
        }

        /// <summary>
        /// Returns true if RuleTrigger instances are equal
        /// </summary>
        /// <param name="input">Instance of RuleTrigger to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RuleTrigger input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Order == input.Order ||
                    this.Order.Equals(input.Order)
                ) && 
                (
                    this.Active == input.Active ||
                    this.Active.Equals(input.Active)
                ) && 
                (
                    this.StopProcessing == input.StopProcessing ||
                    this.StopProcessing.Equals(input.StopProcessing)
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
                hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                hashCode = hashCode * 59 + this.Order.GetHashCode();
                hashCode = hashCode * 59 + this.Active.GetHashCode();
                hashCode = hashCode * 59 + this.StopProcessing.GetHashCode();
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