using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures
{
    internal class GCD : IExecutable
    {
        public void Execute()
        {
            string[] inputs = Console.ReadLine().Split();
            int x = int.Parse(inputs[0]);
            int y = int.Parse(inputs[1]);
            Console.WriteLine(CalcGCD(x, y));
        }

        private int CalcGCD(int x, int y)
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

