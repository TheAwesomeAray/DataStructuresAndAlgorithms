using System;
using System.Diagnostics;

namespace DataStructuresAndAlgorithms
{
    class Program
    {
        static Random random = new Random(29);
        static void Main(string[] args)
        {
            var stockTrader = new StockTrader();
            var analyzer = new InvestmentAnalyzer(stockTrader);
            var stopwatch = new Stopwatch();

            Console.Write("Querying... ");
            stopwatch.Start();
            for (var i = 0; i < 100000; i++)
                analyzer.HandleQuery(CreateQuery());
            Console.WriteLine($"Done in {Math.Round(stopwatch.Elapsed.TotalSeconds, 2)} s");

            Console.Write("Analyzing queries... ");
            stopwatch.Restart();
            analyzer.AnalyzeQueries();
            Console.WriteLine($"Done in {Math.Round(stopwatch.Elapsed.TotalSeconds, 2)} s");

            Console.Write("Handling tradings... ");
            stopwatch.Restart();
            stockTrader.HandleTradings();
            Console.WriteLine($"Done in {Math.Round(stopwatch.Elapsed.TotalSeconds, 2)} s");

            Console.WriteLine("Press enter to exit.");
            Console.ReadKey();
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
