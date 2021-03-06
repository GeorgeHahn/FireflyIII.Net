/* 
 * Firefly III API
 *
 * This is the official documentation of the Firefly III API. You can find accompanying documentation on the website of Firefly III itself (see below). Please report any bugs or issues. This version of the API is live from version v4.7.9 and onwards. You may use the \"Authorize\" button to try the API below. 
 *
 * The version of the OpenAPI document: 0.10.4-modified
 * Contact: thegrumpydictator@gmail.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using FireflyIII.Api;
using FireflyIII.Model;
using FireflyIII.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace FireflyIII.Test
{
    /// <summary>
    ///  Class for testing Account
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class AccountTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for Account
        //private Account instance;

        public AccountTests()
        {
            // TODO uncomment below to create an instance of Account
            //instance = new Account();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of Account
        /// </summary>
        [Fact]
        public void AccountInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Account
            //Assert.IsInstanceOfType<Account> (instance, "variable 'instance' is a Account");
        }


        /// <summary>
        /// Test the property 'CreatedAt'
        /// </summary>
        [Fact]
        public void CreatedAtTest()
        {
            // TODO unit test for the property 'CreatedAt'
        }
        /// <summary>
        /// Test the property 'UpdatedAt'
        /// </summary>
        [Fact]
        public void UpdatedAtTest()
        {
            // TODO unit test for the property 'UpdatedAt'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Fact]
        public void TypeTest()
        {
            // TODO unit test for the property 'Type'
        }
        /// <summary>
        /// Test the property 'Iban'
        /// </summary>
        [Fact]
        public void IbanTest()
        {
            // TODO unit test for the property 'Iban'
        }
        /// <summary>
        /// Test the property 'Bic'
        /// </summary>
        [Fact]
        public void BicTest()
        {
            // TODO unit test for the property 'Bic'
        }
        /// <summary>
        /// Test the property 'AccountNumber'
        /// </summary>
        [Fact]
        public void AccountNumberTest()
        {
            // TODO unit test for the property 'AccountNumber'
        }
        /// <summary>
        /// Test the property 'OpeningBalance'
        /// </summary>
        [Fact]
        public void OpeningBalanceTest()
        {
            // TODO unit test for the property 'OpeningBalance'
        }
        /// <summary>
        /// Test the property 'OpeningBalanceDate'
        /// </summary>
        [Fact]
        public void OpeningBalanceDateTest()
        {
            // TODO unit test for the property 'OpeningBalanceDate'
        }
        /// <summary>
        /// Test the property 'VirtualBalance'
        /// </summary>
        [Fact]
        public void VirtualBalanceTest()
        {
            // TODO unit test for the property 'VirtualBalance'
        }
        /// <summary>
        /// Test the property 'CurrentBalance'
        /// </summary>
        [Fact]
        public void CurrentBalanceTest()
        {
            // TODO unit test for the property 'CurrentBalance'
        }
        /// <summary>
        /// Test the property 'CurrentBalanceDate'
        /// </summary>
        [Fact]
        public void CurrentBalanceDateTest()
        {
            // TODO unit test for the property 'CurrentBalanceDate'
        }
        /// <summary>
        /// Test the property 'CurrencyId'
        /// </summary>
        [Fact]
        public void CurrencyIdTest()
        {
            // TODO unit test for the property 'CurrencyId'
        }
        /// <summary>
        /// Test the property 'CurrencyCode'
        /// </summary>
        [Fact]
        public void CurrencyCodeTest()
        {
            // TODO unit test for the property 'CurrencyCode'
        }
        /// <summary>
        /// Test the property 'CurrencySymbol'
        /// </summary>
        [Fact]
        public void CurrencySymbolTest()
        {
            // TODO unit test for the property 'CurrencySymbol'
        }
        /// <summary>
        /// Test the property 'CurrencyDecimalPlaces'
        /// </summary>
        [Fact]
        public void CurrencyDecimalPlacesTest()
        {
            // TODO unit test for the property 'CurrencyDecimalPlaces'
        }
        /// <summary>
        /// Test the property 'Active'
        /// </summary>
        [Fact]
        public void ActiveTest()
        {
            // TODO unit test for the property 'Active'
        }
        /// <summary>
        /// Test the property 'IncludeNetWorth'
        /// </summary>
        [Fact]
        public void IncludeNetWorthTest()
        {
            // TODO unit test for the property 'IncludeNetWorth'
        }
        /// <summary>
        /// Test the property 'AccountRole'
        /// </summary>
        [Fact]
        public void AccountRoleTest()
        {
            // TODO unit test for the property 'AccountRole'
        }
        /// <summary>
        /// Test the property 'CreditCardType'
        /// </summary>
        [Fact]
        public void CreditCardTypeTest()
        {
            // TODO unit test for the property 'CreditCardType'
        }
        /// <summary>
        /// Test the property 'MonthlyPaymentDate'
        /// </summary>
        [Fact]
        public void MonthlyPaymentDateTest()
        {
            // TODO unit test for the property 'MonthlyPaymentDate'
        }
        /// <summary>
        /// Test the property 'LiabilityType'
        /// </summary>
        [Fact]
        public void LiabilityTypeTest()
        {
            // TODO unit test for the property 'LiabilityType'
        }
        /// <summary>
        /// Test the property 'LiabilityAmount'
        /// </summary>
        [Fact]
        public void LiabilityAmountTest()
        {
            // TODO unit test for the property 'LiabilityAmount'
        }
        /// <summary>
        /// Test the property 'LiabilityStartDate'
        /// </summary>
        [Fact]
        public void LiabilityStartDateTest()
        {
            // TODO unit test for the property 'LiabilityStartDate'
        }
        /// <summary>
        /// Test the property 'Interest'
        /// </summary>
        [Fact]
        public void InterestTest()
        {
            // TODO unit test for the property 'Interest'
        }
        /// <summary>
        /// Test the property 'InterestPeriod'
        /// </summary>
        [Fact]
        public void InterestPeriodTest()
        {
            // TODO unit test for the property 'InterestPeriod'
        }
        /// <summary>
        /// Test the property 'Notes'
        /// </summary>
        [Fact]
        public void NotesTest()
        {
            // TODO unit test for the property 'Notes'
        }

    }

}
