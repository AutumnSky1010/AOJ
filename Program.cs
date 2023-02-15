using System;
using System.Linq;

namespace AlgorithmsAndDataStructures;
public class Program
{
    private static void Main()
    {
        Console.ReadLine();
        var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
        InsertionSort(array);
    }
    private static void InsertionSort(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int v = array[i];
            int j = i - 1;
            while (j >= 0 && array[j] > v)
            {
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = v;
            System.Console.WriteLine(string.Join(' ', array));
        }
    }
}