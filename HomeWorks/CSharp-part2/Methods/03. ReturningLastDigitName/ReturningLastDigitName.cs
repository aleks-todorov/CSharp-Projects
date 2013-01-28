using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ReturningLastDigitName
{
    class ReturningLastDigitName
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number");
            int number = int.Parse(Console.ReadLine());
            int lastDigit = number % 10;
            Console.WriteLine(ReturnLastDigitName(lastDigit));
        }

        private static string ReturnLastDigitName(int lastDigit)
        {
            string diginName = string.Empty;
            switch (lastDigit)
            {
                case 1: diginName = "one"; break;
                case 2: diginName = "two"; break;
                case 3: diginName = "three"; break;
                case 4: diginName = "four"; break;
                case 5: diginName = "five"; break;
                case 6: diginName = "six"; break;
                case 7: diginName = "seven"; break;
                case 8: diginName = "eight"; break;
                case 9: diginName = "nine"; break;
                default: diginName = "zero"; break;
            }
            return diginName;
        }
    }
}
