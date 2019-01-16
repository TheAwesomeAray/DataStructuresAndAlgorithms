using System;
using System.Collections.Generic;

namespace DataStructuresAndAlgorithms
{
    class RatingCacheElement
    {
        public string StockID { get; set; }
        public int Rating { get; set; }
    }


    public class InvestmentAnalyzer
    {
        private IStockTrader stockTrader;
        List<InvestmentQuery> queries = new List<InvestmentQuery>();
        private List<RatingCacheElement> stock2rating = new List<RatingCacheElement>();
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
                var query = GetFirstPriority(queries);

                var cacheElement = stock2rating.Find(x => x.StockID == query.StockID);
                if (cacheElement != null)
                    rating = cacheElement.Rating;
                else
                {
                    rating = CalculateRating(query.StockID);
                    stock2rating.Add(
                        new RatingCacheElement() { StockID = query.StockID, Rating = rating }
                    );
                }
                if (rating > 80)
                    stockTrader.EnqueueStockForTrading(query);
            }
        }

        private InvestmentQuery GetFirstPriority(List<InvestmentQuery> queries)
        {
            InvestmentQuery minQuery = null;
            foreach (var query in queries)
            {
                if (minQuery == null || query.CompareTo(minQuery) == 0)
                    minQuery = query;
            }
            queries.Remove(minQuery);
            return minQuery;
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