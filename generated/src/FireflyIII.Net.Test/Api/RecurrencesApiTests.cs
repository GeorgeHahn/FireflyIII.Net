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

using FireflyIII.Net.Client;
using FireflyIII.Net.Api;
using FireflyIII.Net.Model;

namespace FireflyIII.Net.Test
{
    /// <summary>
    ///  Class for testing RecurrencesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class RecurrencesApiTests : IDisposable
    {
        private RecurrencesApi instance;

        public RecurrencesApiTests()
        {
            instance = new RecurrencesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of RecurrencesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' RecurrencesApi
            //Assert.IsType(typeof(RecurrencesApi), instance, "instance is a RecurrencesApi");
        }

        
        /// <summary>
        /// Test DeleteRecurrence
        /// </summary>
        [Fact]
        public void DeleteRecurrenceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //instance.DeleteRecurrence(id);
            
        }
        
        /// <summary>
        /// Test GetRecurrence
        /// </summary>
        [Fact]
        public void GetRecurrenceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //var response = instance.GetRecurrence(id);
            //Assert.IsType<RecurrenceSingle> (response, "response is RecurrenceSingle");
        }
        
        /// <summary>
        /// Test ListRecurrence
        /// </summary>
        [Fact]
        public void ListRecurrenceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //var response = instance.ListRecurrence(page);
            //Assert.IsType<RecurrenceArray> (response, "response is RecurrenceArray");
        }
        
        /// <summary>
        /// Test ListTransactionByRecurrence
        /// </summary>
        [Fact]
        public void ListTransactionByRecurrenceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //int? page = null;
            //DateTime? start = null;
            //DateTime? end = null;
            //TransactionTypeFilter type = null;
            //var response = instance.ListTransactionByRecurrence(id, page, start, end, type);
            //Assert.IsType<TransactionArray> (response, "response is TransactionArray");
        }
        
        /// <summary>
        /// Test StoreRecurrence
        /// </summary>
        [Fact]
        public void StoreRecurrenceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Recurrence recurrence = null;
            //var response = instance.StoreRecurrence(recurrence);
            //Assert.IsType<RecurrenceSingle> (response, "response is RecurrenceSingle");
        }
        
        /// <summary>
        /// Test TriggerRecurrence
        /// </summary>
        [Fact]
        public void TriggerRecurrenceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.TriggerRecurrence();
            
        }
        
        /// <summary>
        /// Test UpdateRecurrence
        /// </summary>
        [Fact]
        public void UpdateRecurrenceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //Recurrence recurrence = null;
            //var response = instance.UpdateRecurrence(id, recurrence);
            //Assert.IsType<RecurrenceSingle> (response, "response is RecurrenceSingle");
        }
        
    }

}
