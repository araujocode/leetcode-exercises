using System;
using System.Collections.Generic;

class TwoSum
{
    static void Main()
    {
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;
        int[] result = TwoSum(nums, target);
        Console.WriteLine($"Two Sum for [2, 7, 11, 15] and target 9: [{result[0]}, {result[1]}]"); // Output: [0, 1]
    }

    static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> numMap = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (numMap.ContainsKey(complement))
            {
                return new int[] { numMap[complement], i };
            }
            numMap[nums[i]] = i;
        }
        throw new ArgumentException("No two sum solution");
    }
}
