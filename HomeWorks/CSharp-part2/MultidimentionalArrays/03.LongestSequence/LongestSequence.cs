using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LongestSequence
{
    class LongestSequence
    {
        static void Main(string[] args)
        {
            string[,] stringMatrix = 
           {
            {"ha","fifi","ho","hi"},
            {"fo","ha","hi","xx"},
            {"xxx","ho","ha","xx"},
         };
            string currentString = "";
            string mostFrequentString = "";
            int occurence = 1;
            int maxOccurence = 0;

            //Checking for horizontal max sequence 

            for (int row = 0; row < stringMatrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < stringMatrix.GetLength(1) - 1; col++)
                {
                    currentString = stringMatrix[row, col];
                    occurence++;
                    if (currentString == stringMatrix[row, col + 1])
                    {
                        if (occurence > maxOccurence)
                        {
                            maxOccurence = occurence;
                            mostFrequentString = currentString;
                        }
                    }
                    else
                    {
                        occurence = 1;
                    }
                }
            }

            //Checking for vertical max sequence 

            for (int col = 0; col < stringMatrix.GetLength(1) - 1; col++)
            {
                for (int row = 0; row < stringMatrix.GetLength(0); row++)
                {
                    currentString = stringMatrix[row, col];
                    occurence++;
                    if (currentString == stringMatrix[row, col + 1])
                    {
                        if (occurence > maxOccurence)
                        {
                            maxOccurence = occurence;
                            mostFrequentString = currentString;
                        }
                    }
                    else
                    {
                        occurence = 1;
                    }
                }
            }

            //Checking for diagonal max sequence 

            occurence = 1;

            for (int row = 0; row < 1; row++)
            {
                for (int col = 0; col < stringMatrix.GetLength(1) - 1; col++)
                {
                    int rows = row;
                    int cols = col;
                    while (rows < stringMatrix.GetLength(0) - 1 && cols <= stringMatrix.GetLength(0) - 1)
                    {
                        currentString = stringMatrix[rows, cols];
                        occurence++;
                        if (currentString == stringMatrix[rows + 1, cols + 1])
                        {
                            if (occurence > maxOccurence)
                            {
                                maxOccurence = occurence;
                                mostFrequentString = currentString;
                            }
                        }
                        else
                        {
                            occurence = 1;
                        }
                        rows++;
                        cols++;
                    }
                }
            }

            occurence = 1;
            for (int col = 0; col < 1; col++)
            {
                for (int row = 1; row < stringMatrix.GetLength(0) - 1; row++)
                {
                    int rows = row;
                    int cols = col;
                    while (rows < stringMatrix.GetLength(0) - 1 && cols < stringMatrix.GetLength(0) - 1)
                    {
                        currentString = stringMatrix[rows, cols];
                        occurence++;
                        if (currentString == stringMatrix[rows + 1, cols + 1])
                        {
                            if (occurence > maxOccurence)
                            {
                                maxOccurence = occurence;
                                mostFrequentString = currentString;
                            }
                        }
                        else
                        {
                            occurence = 1;
                        }
                        rows++;
                        cols++;
                    }
                }
            }

            Console.WriteLine(maxOccurence + " " + mostFrequentString);
        }
    }
}
