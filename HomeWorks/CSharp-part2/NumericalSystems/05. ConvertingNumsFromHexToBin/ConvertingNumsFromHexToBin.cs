using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ConvertingNumsFromHexToBin
{
    class ConvertingNumsFromHexToBin
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the hex number: ");
            string hexNumber = Console.ReadLine();
            hexNumber = hexNumber.ToUpper();
            string binNumber = "";
            for (int i = 0; i < hexNumber.Length; i++)
            {
                string symbol = hexNumber[i] + "";
                switch (symbol)
                {
                    case "1": symbol = "0001"; break;
                    case "2": symbol = "0010"; break;
                    case "3": symbol = "0011"; break;
                    case "4": symbol = "0100"; break;
                    case "5": symbol = "0101"; break;
                    case "6": symbol = "0110"; break;
                    case "7": symbol = "0111"; break;
                    case "8": symbol = "1000"; break;
                    case "9": symbol = "1001"; break;
                    case "A": symbol = "1010"; break;
                    case "B": symbol = "1011"; break;
                    case "C": symbol = "1100"; break;
                    case "D": symbol = "1101"; break;
                    case "E": symbol = "1110"; break;
                    case "F": symbol = "1111"; break;
                    default: symbol = "0000"; break;
                }
                binNumber += symbol;
            }
            Console.WriteLine(binNumber);
        }
    }
}
