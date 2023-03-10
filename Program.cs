using System;

namespace AlgorithmsAndDataStructures
{
    public class Program
    {
        private static void Main()
        {
            string[] inputs = Console.ReadLine().Split();
            int x = int.Parse(inputs[0]);
            int y = int.Parse(inputs[1]);
            Console.WriteLine(CalcGCD(x, y));
        }

        private static int CalcGCD(int x, int y)
        {
            if (x < y)
            {
                (x, y) = (y, x);
            }
            if (y == 0)
            {
                return x;
            }
            return CalcGCD(y, x % y);
        }
    }
}