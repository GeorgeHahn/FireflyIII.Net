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
    ///  Class for testing RulesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class RulesApiTests : IDisposable
    {
        private RulesApi instance;

        public RulesApiTests()
        {
            instance = new RulesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of RulesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' RulesApi
            //Assert.IsType(typeof(RulesApi), instance, "instance is a RulesApi");
        }

        
        /// <summary>
        /// Test DeleteRule
        /// </summary>
        [Fact]
        public void DeleteRuleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //instance.DeleteRule(id);
            
        }
        
        /// <summary>
        /// Test FireRule
        /// </summary>
        [Fact]
        public void FireRuleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //DateTime? start = null;
            //DateTime? end = null;
            //string accounts = null;
            //instance.FireRule(id, start, end, accounts);
            
        }
        
        /// <summary>
        /// Test GetRule
        /// </summary>
        [Fact]
        public void GetRuleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //var response = instance.GetRule(id);
            //Assert.IsType<RuleSingle> (response, "response is RuleSingle");
        }
        
        /// <summary>
        /// Test ListRule
        /// </summary>
        [Fact]
        public void ListRuleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //var response = instance.ListRule(page);
            //Assert.IsType<RuleArray> (response, "response is RuleArray");
        }
        
        /// <summary>
        /// Test StoreRule
        /// </summary>
        [Fact]
        public void StoreRuleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Rule rule = null;
            //var response = instance.StoreRule(rule);
            //Assert.IsType<RuleSingle> (response, "response is RuleSingle");
        }
        
        /// <summary>
        /// Test TestRule
        /// </summary>
        [Fact]
        public void TestRuleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //int? page = null;
            //DateTime? start = null;
            //DateTime? end = null;
            //int? searchLimit = null;
            //int? triggeredLimit = null;
            //string accounts = null;
            //var response = instance.TestRule(id, page, start, end, searchLimit, triggeredLimit, accounts);
            //Assert.IsType<TransactionArray> (response, "response is TransactionArray");
        }
        
        /// <summary>
        /// Test UpdateRule
        /// </summary>
        [Fact]
        public void UpdateRuleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //Rule rule = null;
            //var response = instance.UpdateRule(id, rule);
            //Assert.IsType<RuleSingle> (response, "response is RuleSingle");
        }
        
    }

}
