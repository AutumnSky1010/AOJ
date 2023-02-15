using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndDataStructures
{
    internal class InsertionSort : IExecutable
    {
        public void Execute()
        {
            Console.ReadLine();
            var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Sort(array);
        }

        private void Sort(int[] array)
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
}

