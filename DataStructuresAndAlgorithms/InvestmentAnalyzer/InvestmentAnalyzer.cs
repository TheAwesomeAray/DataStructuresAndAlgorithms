using C5;
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
        IntervalHeap<InvestmentQuery> queries = new IntervalHeap<InvestmentQuery>();
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
                var query = queries.DeleteMin();

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