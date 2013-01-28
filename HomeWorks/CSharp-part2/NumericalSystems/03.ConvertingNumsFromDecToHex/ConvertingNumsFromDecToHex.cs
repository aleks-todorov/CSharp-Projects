using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ConvertingNumsFromDecToHex
{
    class ConvertingNumsFromDecToHex
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number to convert: ");
            int number = int.Parse(Console.ReadLine());
            string hexNumber = "";
            while (number > 0)
            {
                string dividor = (number % 16) + "";
                switch (dividor)
                {
                    case "10": dividor = "A"; break;
                    case "11": dividor = "B"; break;
                    case "12": dividor = "C"; break;
                    case "13": dividor = "D"; break;
                    case "14": dividor = "E"; break;
                    case "15": dividor = "F"; break;
                }
                hexNumber = dividor + hexNumber;
                number /= 16;
            }
            Console.WriteLine(hexNumber);
        }
    }
}
