using System;
using System.Linq;

namespace _07.SelectionSorting
{
    class SelectionSorting
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 3, 4, 2, 1, 8, 4, 7, 3, 4, 6, 7, 8, 9 };
            int[] sortedArray = new int[array.Length];

            for (int i = 0; i < sortedArray.Length; i++)
            {
                int minNumber = int.MaxValue;
                int position = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if (minNumber > array[j])
                    {
                        minNumber = array[j];
                        position = j;
                    }
                    if (j == array.Length - 1)
                    {
                        sortedArray[i] = array[position];
                        array[position] = int.MaxValue;
                    }
                }
            }
            foreach (var element in sortedArray)
            {
                Console.WriteLine(element);
            }
        }
    }
}