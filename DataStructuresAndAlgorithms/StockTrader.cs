using System;
using System.Collections.Generic;

namespace DataStructuresAndAlgorithms
{
    internal class StockTrader : IStockTrader
    {
        LinkedList<InvestmentQuery> stocksToTrade = new LinkedList<InvestmentQuery>();

        public void EnqueueStockForTrading(InvestmentQuery query)
        {
            stocksToTrade.AddLast(query);
        }

        internal void HandleTradings()
        {
            Console.Write($"[{stocksToTrade.Count} stocks]");
            while (stocksToTrade.Count > 0)
            {
                var query = stocksToTrade.First;
                stocksToTrade.RemoveFirst();

                //Thread.Sleep(100);
            }
        }
    }
}