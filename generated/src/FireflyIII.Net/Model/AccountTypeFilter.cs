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
    /// Defines AccountTypeFilter
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum AccountTypeFilter
    {
        /// <summary>
        /// Enum All for value: all
        /// </summary>
        [EnumMember(Value = "all")]
        All = 1,

        /// <summary>
        /// Enum Asset for value: asset
        /// </summary>
        [EnumMember(Value = "asset")]
        Asset = 2,

        /// <summary>
        /// Enum Cash for value: cash
        /// </summary>
        [EnumMember(Value = "cash")]
        Cash = 3,

        /// <summary>
        /// Enum Expense for value: expense
        /// </summary>
        [EnumMember(Value = "expense")]
        Expense = 4,

        /// <summary>
        /// Enum Revenue for value: revenue
        /// </summary>
        [EnumMember(Value = "revenue")]
        Revenue = 5,

        /// <summary>
        /// Enum Special for value: special
        /// </summary>
        [EnumMember(Value = "special")]
        Special = 6,

        /// <summary>
        /// Enum Hidden for value: hidden
        /// </summary>
        [EnumMember(Value = "hidden")]
        Hidden = 7,

        /// <summary>
        /// Enum Liability for value: liability
        /// </summary>
        [EnumMember(Value = "liability")]
        Liability = 8,

        /// <summary>
        /// Enum Liabilities for value: liabilities
        /// </summary>
        [EnumMember(Value = "liabilities")]
        Liabilities = 9,

        /// <summary>
        /// Enum Defaultaccount for value: Default account
        /// </summary>
        [EnumMember(Value = "Default account")]
        Defaultaccount = 10,

        /// <summary>
        /// Enum Cashaccount for value: Cash account
        /// </summary>
        [EnumMember(Value = "Cash account")]
        Cashaccount = 11,

        /// <summary>
        /// Enum Assetaccount for value: Asset account
        /// </summary>
        [EnumMember(Value = "Asset account")]
        Assetaccount = 12,

        /// <summary>
        /// Enum Expenseaccount for value: Expense account
        /// </summary>
        [EnumMember(Value = "Expense account")]
        Expenseaccount = 13,

        /// <summary>
        /// Enum Revenueaccount for value: Revenue account
        /// </summary>
        [EnumMember(Value = "Revenue account")]
        Revenueaccount = 14,

        /// <summary>
        /// Enum Initialbalanceaccount for value: Initial balance account
        /// </summary>
        [EnumMember(Value = "Initial balance account")]
        Initialbalanceaccount = 15,

        /// <summary>
        /// Enum Beneficiaryaccount for value: Beneficiary account
        /// </summary>
        [EnumMember(Value = "Beneficiary account")]
        Beneficiaryaccount = 16,

        /// <summary>
        /// Enum Importaccount for value: Import account
        /// </summary>
        [EnumMember(Value = "Import account")]
        Importaccount = 17,

        /// <summary>
        /// Enum Reconciliationaccount for value: Reconciliation account
        /// </summary>
        [EnumMember(Value = "Reconciliation account")]
        Reconciliationaccount = 18,

        /// <summary>
        /// Enum Loan for value: Loan
        /// </summary>
        [EnumMember(Value = "Loan")]
        Loan = 19,

        /// <summary>
        /// Enum Debt for value: Debt
        /// </summary>
        [EnumMember(Value = "Debt")]
        Debt = 20,

        /// <summary>
        /// Enum Mortgage for value: Mortgage
        /// </summary>
        [EnumMember(Value = "Mortgage")]
        Mortgage = 21

    }

}
