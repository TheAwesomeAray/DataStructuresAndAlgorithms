using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace DataStructuresAndAlgorithms
{
    public static class StockTraderExample
    {
        static Random random = new Random(29);
        public static void Run()
        {
            var stockTrader = new StockTrader();
            var analyzer = new InvestmentAnalyzer(stockTrader);
            var stopwatch = new Stopwatch();

            var q = CreateQuery();
            stopwatch.Start();
            Console.WriteLine("Trading 200000 stocks");
            for (int i = 0; i < 200000; i++)
                stockTrader.EnqueueStockForTrading(q);
            stockTrader.HandleTradings();
            WriteStopWatchElapsedTime(stopwatch);

            Console.Write("Querying... ");
            stopwatch.Restart();
            for (var i = 0; i < 100000; i++)
                analyzer.HandleQuery(CreateQuery());
            WriteStopWatchElapsedTime(stopwatch);

            Console.Write("Analyzing queries... ");
            stopwatch.Restart();
            analyzer.AnalyzeQueries();
            WriteStopWatchElapsedTime(stopwatch);

            Console.Write("Handling tradings... ");
            stopwatch.Restart();
            stockTrader.HandleTradings();
            WriteStopWatchElapsedTime(stopwatch);

            Console.WriteLine("Press enter to exit.");
            Console.ReadKey();
        }

        private static void WriteStopWatchElapsedTime(Stopwatch stopwatch)
        {
            Console.WriteLine($"Done in {Math.Round(stopwatch.Elapsed.TotalSeconds, 2)} s");
        }

        static InvestmentQuery CreateQuery()
        {
            return new InvestmentQuery
            {
                StockID = "Stock" + random.Next(10000),
                QueryTime = DateTime.Now,
                Priority = random.Next(5),
                Investor = Guid.NewGuid()
            };
        }
    }
}
