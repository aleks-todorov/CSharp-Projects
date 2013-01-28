using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PrintingPatterns
{
    class PrintingPatterns
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] array = new int[n, n];
            int value = 1;

            // Subsection a
            for (int col = 0; col < array.GetLength(0); col++)
            {
                for (int row = 0; row < array.GetLength(1); row++)
                {
                    array[row, col] = value;
                    value++;
                }
            }

            PrintArray(array);
            value = 1;

            // Subsection b
            for (int col = 0; col < array.GetLength(0); col++)
            {
                if (col % 2 == 0)
                {
                    for (int row = 0; row < array.GetLength(1); row++)
                    {
                        array[row, col] = value;
                        value++;
                    }
                }
                if (col % 2 != 0)
                {
                    for (int row = array.GetLength(1) - 1; row >= 0; row--)
                    {
                        array[row, col] = value;
                        value++;
                    }
                }
            }

            PrintArray(array);

            //Subsection C
            value = 1;

            for (int i = 0; i <= n - 1; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    array[n - i + j - 1, j] = value++;
                }
            }

            for (int i = n - 2; i >= 0; i--)
            {

                for (int j = i; j >= 0; j--)
                {
                    array[i - j, n - j - 1] = value++;
                }
            }

            PrintArray(array);

            //  int rows = 0;
            //  int cols = 0;
            //  int steps = n;
            //  int cycles = 0;
            //  value = 1;
            //
            //  while (value <= 10)
            //  {
            //
            //      for (int i = 0; i < steps; i++)
            //      {
            //          rows = i + cycles;
            //          array[rows, cols] = value;
            //          value++;
            //      }
            //
            //      cycles++;
            //
            //      for (int i = 0; i < steps - 1; i++)
            //      {
            //          cols = i + cycles;
            //          array[rows, cols] = value;
            //          value++;
            //      }
            //      steps--;
            //
            //
            //
            //      for (int i = rows; i > 0; i--)
            //      {
            //          rows = i - cycles;
            //          array[rows, cols] = value;
            //          value++;
            //          PrintArray(array);
            //      }
            //
            //      PrintArray(array);
            //
            //      steps--;
            //
            //      for (int i = cols; i > 1; i--)
            //      {
            //          cols = i - cycles;
            //          array[rows, cols] = value;
            //          value++;
            //      }
            //
            //      // for (int i = steps; i >= 0; i--)
            //      // {
            //      //     cols = i + cycles;
            //      //     array[rows, cols] = value;
            //      //     value++;
            //      // }
            //      //
            //      // cycles++;
            //  }
            //
            //  PrintArray(array);
        }

        private static void PrintArray(int[,] array)
        {
            for (int row = 0; row < array.GetLength(0); row++)
            {
                for (int col = 0; col < array.GetLength(1); col++)
                {
                    Console.Write(array[row, col] + "\t ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
