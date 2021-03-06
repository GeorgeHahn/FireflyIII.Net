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
    ///  Class for testing AvailableBudgetsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AvailableBudgetsApiTests : IDisposable
    {
        private AvailableBudgetsApi instance;

        public AvailableBudgetsApiTests()
        {
            instance = new AvailableBudgetsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AvailableBudgetsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AvailableBudgetsApi
            //Assert.IsType(typeof(AvailableBudgetsApi), instance, "instance is a AvailableBudgetsApi");
        }

        
        /// <summary>
        /// Test DeleteAvailableBudget
        /// </summary>
        [Fact]
        public void DeleteAvailableBudgetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //instance.DeleteAvailableBudget(id);
            
        }
        
        /// <summary>
        /// Test GetAvailableBudget
        /// </summary>
        [Fact]
        public void GetAvailableBudgetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //var response = instance.GetAvailableBudget(id);
            //Assert.IsType<AvailableBudgetSingle> (response, "response is AvailableBudgetSingle");
        }
        
        /// <summary>
        /// Test ListAvailableBudget
        /// </summary>
        [Fact]
        public void ListAvailableBudgetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //DateTime? start = null;
            //DateTime? end = null;
            //var response = instance.ListAvailableBudget(page, start, end);
            //Assert.IsType<AvailableBudgetArray> (response, "response is AvailableBudgetArray");
        }
        
        /// <summary>
        /// Test StoreAvailableBudget
        /// </summary>
        [Fact]
        public void StoreAvailableBudgetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AvailableBudget availableBudget = null;
            //var response = instance.StoreAvailableBudget(availableBudget);
            //Assert.IsType<AvailableBudgetSingle> (response, "response is AvailableBudgetSingle");
        }
        
        /// <summary>
        /// Test UpdateAvailableBudget
        /// </summary>
        [Fact]
        public void UpdateAvailableBudgetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //AvailableBudget availableBudget = null;
            //var response = instance.UpdateAvailableBudget(id, availableBudget);
            //Assert.IsType<AvailableBudgetSingle> (response, "response is AvailableBudgetSingle");
        }
        
    }

}
