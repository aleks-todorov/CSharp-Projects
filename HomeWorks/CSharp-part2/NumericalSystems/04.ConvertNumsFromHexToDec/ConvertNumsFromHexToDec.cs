using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ConvertNumsFromHexToDec
{
    class ConvertNumsFromHexToDec
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter Hex number: ");
            string hexNumber = Console.ReadLine();
            int decNumber = 0;
            for (int i = 0; i < hexNumber.Length; i++)
            {
                string multiplyer = hexNumber[i] + "";
                switch (multiplyer)
                {
                    case "A": multiplyer = "10"; break;
                    case "B": multiplyer = "11"; break;
                    case "C": multiplyer = "12"; break;
                    case "D": multiplyer = "13"; break;
                    case "E": multiplyer = "14"; break;
                    case "F": multiplyer = "15"; break;
                }
                decNumber += int.Parse(multiplyer) * (int)Math.Pow((double)16, (double)hexNumber.Length - i - 1);
            }
            Console.WriteLine(decNumber);
        }
    }
}
