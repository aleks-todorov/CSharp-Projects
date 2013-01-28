using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.AddingNumbersWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine();
            // string firstNumber = "678678";
            string secondNumber = Console.ReadLine();
            //string secondNumber = "567865";
            int[] numbersArrayOne = (int[])ConvertStringToArray(firstNumber).Clone();
            int[] numbersArrayTwo = (int[])ConvertStringToArray(secondNumber).Clone();

            string result = Addition(numbersArrayOne, numbersArrayTwo);
            // Console.WriteLine(int.Parse(firstNumber) + int.Parse(secondNumber));
            Console.WriteLine(result);
        }

        private static string Addition(int[] numbersArrayOne, int[] numbersArrayTwo)
        {
            int counter = 0;
            string result = string.Empty;
            int overflow = 0;
            int sum = 0;
            while (true)
            {

                if (counter > numbersArrayOne.Length - 1 && counter < numbersArrayTwo.Length)
                {
                    sum = numbersArrayTwo[counter] + overflow;
                    result = PerformAddition(ref result, ref overflow, ref sum);
                    for (int i = counter + 1; i < numbersArrayTwo.Length; i++)
                    {
                        result = numbersArrayTwo[i] + result;
                    }
                    break;
                }
                else if (counter > numbersArrayTwo.Length - 1 && counter < numbersArrayOne.Length)
                {
                    sum = numbersArrayOne[counter] + overflow;
                    result = PerformAddition(ref result, ref overflow, ref sum);
                    for (int i = counter + 1; i < numbersArrayOne.Length; i++)
                    {
                        result = numbersArrayOne[i] + result;
                    }
                    break;
                }
                if (numbersArrayOne.Length == numbersArrayTwo.Length && counter == numbersArrayTwo.Length)
                {
                    if (overflow > 0)
                    {
                        result = overflow + result;
                        break;
                    }
                    break;
                }
                sum = numbersArrayOne[counter] + numbersArrayTwo[counter] + overflow;
                result = PerformAddition(ref result, ref overflow, ref sum);
                counter++;
            }
            return result;
        }

        private static string PerformAddition(ref string result, ref int overflow, ref int sum)
        {
            if (sum > 9)
            {
                overflow = sum / 10;
                sum = sum % 10;
            }
            else
            {
                overflow = 0;
            }
            result = sum + result;
            return result;
        }

        private static int[] ConvertStringToArray(string number)
        {
            int[] numbersArray = new int[number.Length];
            int counter = 0;
            foreach (var symbol in number)
            {
                numbersArray[number.Length - counter - 1] = int.Parse(symbol.ToString());
                counter++;
            }
            return numbersArray;
        }
    }
}
