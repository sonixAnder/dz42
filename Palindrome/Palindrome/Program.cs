using System;

public class Program
{
    public static void Main()
    {
        int number = 1221;
        bool isPalindrome = IsPalindrome(number);
        Console.WriteLine($"Число {number} палиндром: {isPalindrome}");
    }

    public static bool IsPalindrome(int number)
    {
        string strNumber = number.ToString();
        int length = strNumber.Length;

        for (int i = 0; i < length / 2; i++)
        {
            if (strNumber[i] != strNumber[length - i - 1])
            {
                return false;
            }
        }
        return true;
    }
}
