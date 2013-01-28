using System;
using System.IO;

namespace _05.ReadingSquareMatrix
{
    class ReadingSquareMatrix
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("../../input.txt");
            int N = 0;
            int[,] numbersArray;
            using (reader)
            {
                N = int.Parse(reader.ReadLine());
                numbersArray = new int[N, N];
                for (int row = 0; row < numbersArray.GetLength(0); row++)
                {
                    string rowData = reader.ReadLine();
                    string[] rowCell = rowData.Split(' ');

                    for (int col = 0; col < numbersArray.GetLength(1); col++)
                    {
                        numbersArray[row, col] = int.Parse(rowCell[col]);
                    }
                }
            }
            int maxSum = 0;
            int currentSum = 0;
            for (int row = 0; row < numbersArray.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < numbersArray.GetLength(0) - 1; col++)
                {
                    currentSum = numbersArray[row, col] + numbersArray[row + 1, col] + numbersArray[row, col + 1] + numbersArray[row + 1, col + 1];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                    }

                }
            }
            StreamWriter writer = new StreamWriter("../../output.txt");
            using (writer)
            {
                writer.WriteLine(maxSum);
            }
        }
    }
}
