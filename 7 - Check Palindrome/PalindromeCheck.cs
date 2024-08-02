using System;

class PalindromeCheck
{
    static void Main()
    {
        Console.WriteLine("Check if 'radar' is a palindrome: " + IsPalindrome("radar")); // Output: True
    }

    static bool IsPalindrome(string s)
    {
        int left = 0, right = s.Length - 1;
        while (left < right)
        {
            if (s[left] != s[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}
