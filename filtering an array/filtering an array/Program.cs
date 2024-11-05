using System;
using System.Linq;
public class Program
{
    public static void Main()
    {
        int[] originalArray = { 1, 2, 9, 234, -65, -7, 6 };
        int[] filterArray = { 6, 234, -7 };
        int[] resultArray = FilterArray(originalArray, filterArray);
        Console.WriteLine("Результат фильтрации: " + string.Join(" ", resultArray));
    }

    public static int[] FilterArray(int[] originalArray, int[] filterArray)
    {
        return originalArray.Where(element => !filterArray.Contains(element)).ToArray();
    }
}