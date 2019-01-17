namespace DivideAndConquer
{
    public class FibonacciAlgorithm
    {
        static long[] fibCache = new long[200];

        public static long Fibonacci(int n)
        {
            if (n <= 1)
                fibCache[n] = 1;
            if (fibCache[n] == 0)
                fibCache[n] = Fibonacci(n - 1) + Fibonacci(n - 2);

            return fibCache[n];
        }
    }
}
