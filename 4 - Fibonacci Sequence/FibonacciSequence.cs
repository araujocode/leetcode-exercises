using System;

class FibonacciSequence
{
    static void Main()
    {
        int n = 10;
        Console.WriteLine("Fibonacci number at position " + n + ": " + Fibonacci(n)); // Output: 55
    }

    static int Fibonacci(int n)
    {
        if (n <= 1) return n;
        int a = 0, b = 1;

        for (int i = 2; i <= n; i++)
        {
            int temp = a + b;
            a = b;
            b = temp;
        }

        return b;
    }
}
