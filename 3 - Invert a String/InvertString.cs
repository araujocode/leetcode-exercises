using System;

class InvertString
{
    static void Main()
    {
        string original = "hello";
        Console.WriteLine("Reversed string: " + ReverseString(original)); // Output: "olleh"
    }

    static string ReverseString(string s)
    {
        char[] charArray = s.ToCharArray();
        int left = 0;
        int right = charArray.Length - 1;

        while (left < right)
        {
            char temp = charArray[left];
            charArray[left] = charArray[right];
            charArray[right] = temp;
            left++;
            right--;
        }

        return new string(charArray);
    }
}
