using System;

class Factorial
{
    static void Main()
    {
        int number = 5;
        Console.WriteLine("Factorial of " + number + ": " + Factorial(number)); // Output: 120
    }

    static int Factorial(int n)
    {
        if (n == 0) return 1;
        return n * Factorial(n - 1);
    }
}
