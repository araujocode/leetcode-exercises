using System;

class SumArray
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        Console.WriteLine("Sum of array elements: " + SumArray(numbers)); // Output: 15
    }

    static int SumArray(int[] array)
    {
        int sum = 0;
        foreach (int num in array)
        {
            sum += num;
        }

        return sum;
    }
}
