using C5;
using System;
using System.Collections.Generic;

namespace DataStructuresAndAlgorithms
{
    public class InvestmentAnalyzer
    {
        private IStockTrader stockTrader;
        IntervalHeap<InvestmentQuery> queries = new IntervalHeap<InvestmentQuery>();
        private Dictionary<string, int> stock2rating = new Dictionary<string, int>();
        Random random = new Random(29);

        public InvestmentAnalyzer(IStockTrader stockTrader)
        {
            this.stockTrader = stockTrader;
        }

        internal void HandleQuery(InvestmentQuery query)
        {
            queries.Add(query);
        }

        internal void AnalyzeQueries()
        {
            while (queries.Count > 0)
            {
                int rating;
                var query = queries.DeleteMin();

                if (stock2rating.ContainsKey(query.StockID))
                    rating = stock2rating[query.StockID];
                else
                {
                    rating = CalculateRating(query.StockID);
                    stock2rating.Add(query.StockID, rating);
                }
                if (rating > 80)
                    stockTrader.EnqueueStockForTrading(query);
            }
        }

        private int CalculateRating(string stockID)
        {
            // Simulate some computation time that might involve
            // fetching data from various external data sources:
            //            Thread.Sleep(100);

            // Simulate some calculation result:
            return random.Next(100);
        }
    }
}