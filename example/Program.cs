using System;
using System.Linq;
using System.Collections.Generic;
using FireflyIII.Api;
using FireflyIII.Model;

namespace example
{
    class Program
    {
        private static string ff3_demo_url = "https://demo.firefly-iii.org/";
        private static string ff3_demo_pat = "<FF3 personal access token>";

        static void Main(string[] args)
        {
            var txn_client = new TransactionsApi(new FireflyIII.Client.Configuration()
            {
                BasePath = ff3_demo_url,
                AccessToken = ff3_demo_pat,
            });

            var txn = new FireflyIII.Model.TransactionSplit(
                date: DateTime.Now,
                description: "Test FireflyIII .Net Transaction",
                amount: 12.54,
                currencyCode: "EUR",
                type: TransactionSplit.TypeEnum.Withdrawal,
                // Can set source/dest by account ID or name
                // sourceId: 1,
                sourceName: "Checking Account",
                destinationId: 7
            );

            var txn_rsp = txn_client.StoreTransaction(new FireflyIII.Model.Transaction(new[] { txn }.ToList()));
            Console.WriteLine($"Created transaction {txn_rsp.Data.Id}");

            // Set a breakpoint here:
            txn_client.DeleteTransaction(txn_rsp.Data.Id);
            Console.WriteLine($"Deleted transaction");
        }
    }
}
