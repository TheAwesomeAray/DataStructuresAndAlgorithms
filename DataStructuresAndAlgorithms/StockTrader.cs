using System;
using System.Collections.Generic;

namespace DataStructuresAndAlgorithms
{
    internal class StockTrader : IStockTrader
    {
        List<InvestmentQuery> stocksToTrade = new List<InvestmentQuery>();

        public void EnqueueStockForTrading(InvestmentQuery query)
        {
            stocksToTrade.Add(query);
        }

        internal void HandleTradings()
        {
            Console.Write($"[{stocksToTrade.Count} stocks]");
            while (stocksToTrade.Count > 0)
            {
                var query = stocksToTrade[0];
                stocksToTrade.RemoveAt(0);

                //Thread.Sleep(100);
            }
        }
    }
}