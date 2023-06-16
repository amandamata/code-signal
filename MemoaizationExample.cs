namespace code_signal;

public static class MemoaizationExample
{
    private static Dictionary<int, long> _fibonacciCache = new Dictionary<int, long>();

    public static long Fibonacci(int n)
    {
        if (_fibonacciCache.ContainsKey(n))
            return _fibonacciCache[n];

        long result;
        if (n <= 1)
            result = n;
        else
            result = Fibonacci(n - 1) + Fibonacci(n - 2);

        _fibonacciCache[n] = result;
        return result;
    }
}
