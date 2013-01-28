using System;
using System.Linq;


namespace _02.FindingMaximumSum
{
    class FindingMaximumSum
    {
        static void Main(string[] args)
        {
            int n = 10;
            int m = 10;
            int[,] numberArray = new int[n, m];
            Random generator = new Random();

            for (int row = 0; row < numberArray.GetLength(0); row++)
            {
                for (int col = 0; col < numberArray.GetLength(1); col++)
                {
                    numberArray[row, col] = generator.Next(0, 21);
                    Console.Write(numberArray[row, col] + " ");
                }
                Console.WriteLine();
            }
            int currentSum = 0;
            int maxSum = 0;
            int maxRow = 0;
            int maxCol = 0;
            for (int row = 0; row < numberArray.GetLength(0) - 3; row++)
            {
                for (int col = 0; col < numberArray.GetLength(0) - 3; col++)
                {
                    currentSum = numberArray[row, col] + numberArray[row + 1, col] + numberArray[row + 1, col + 1] 
                        + numberArray[row, col + 1];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        maxRow = row;
                        maxCol = col;
                    }

                }
            }

            Console.WriteLine(maxSum + " on begining possition row {0} and col {1}", maxRow, maxCol);
        }
    }
}
