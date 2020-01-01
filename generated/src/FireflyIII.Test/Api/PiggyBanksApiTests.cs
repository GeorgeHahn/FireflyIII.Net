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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using FireflyIII.Client;
using FireflyIII.Api;
using FireflyIII.Model;

namespace FireflyIII.Test
{
    /// <summary>
    ///  Class for testing PiggyBanksApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PiggyBanksApiTests : IDisposable
    {
        private PiggyBanksApi instance;

        public PiggyBanksApiTests()
        {
            instance = new PiggyBanksApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PiggyBanksApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PiggyBanksApi
            //Assert.IsType(typeof(PiggyBanksApi), instance, "instance is a PiggyBanksApi");
        }

        
        /// <summary>
        /// Test DeletePiggyBank
        /// </summary>
        [Fact]
        public void DeletePiggyBankTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //instance.DeletePiggyBank(id);
            
        }
        
        /// <summary>
        /// Test GetPiggyBank
        /// </summary>
        [Fact]
        public void GetPiggyBankTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //var response = instance.GetPiggyBank(id);
            //Assert.IsType<PiggyBankSingle> (response, "response is PiggyBankSingle");
        }
        
        /// <summary>
        /// Test ListEventByPiggyBank
        /// </summary>
        [Fact]
        public void ListEventByPiggyBankTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //int? page = null;
            //var response = instance.ListEventByPiggyBank(id, page);
            //Assert.IsType<PiggyBankEventArray> (response, "response is PiggyBankEventArray");
        }
        
        /// <summary>
        /// Test ListPiggyBank
        /// </summary>
        [Fact]
        public void ListPiggyBankTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //var response = instance.ListPiggyBank(page);
            //Assert.IsType<PiggyBankArray> (response, "response is PiggyBankArray");
        }
        
        /// <summary>
        /// Test StorePiggyBank
        /// </summary>
        [Fact]
        public void StorePiggyBankTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PiggyBank piggyBank = null;
            //var response = instance.StorePiggyBank(piggyBank);
            //Assert.IsType<PiggyBankSingle> (response, "response is PiggyBankSingle");
        }
        
        /// <summary>
        /// Test UpdatePiggyBank
        /// </summary>
        [Fact]
        public void UpdatePiggyBankTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //PiggyBank piggyBank = null;
            //var response = instance.UpdatePiggyBank(id, piggyBank);
            //Assert.IsType<PiggyBankSingle> (response, "response is PiggyBankSingle");
        }
        
    }

}