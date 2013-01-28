using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ConvertNumsFromBinToHex
{
    class ConvertNumsFromBinToHex
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter binary number: ");
            string binNumber = Console.ReadLine();
            int n = 4 - (binNumber.Length % 4);
            string prefix = new string('0', n);
            binNumber = prefix + binNumber;
            string hexNumber = "";
            string binHalfByte = "";
            Console.WriteLine(binNumber);
            for (int i = 1; i <= binNumber.Length; i++)
            {
                if (i % 4 == 0)
                {
                    binHalfByte += binNumber[i - 1];
                    switch (binHalfByte)
                    {
                        case "0001": binHalfByte = "1"; break;
                        case "0010": binHalfByte = "2"; break;
                        case "0011": binHalfByte = "3"; break;
                        case "0100": binHalfByte = "4"; break;
                        case "0101": binHalfByte = "5"; break;
                        case "0110": binHalfByte = "6"; break;
                        case "0111": binHalfByte = "7"; break;
                        case "1000": binHalfByte = "8"; break;
                        case "1001": binHalfByte = "9"; break;
                        case "1010": binHalfByte = "A"; break;
                        case "1011": binHalfByte = "B"; break;
                        case "1100": binHalfByte = "C"; break;
                        case "1101": binHalfByte = "D"; break;
                        case "1110": binHalfByte = "E"; break;
                        case "1111": binHalfByte = "F"; break;
                        default: binHalfByte = "0"; break;
                    }
                    hexNumber += binHalfByte;
                    binHalfByte = "";
                }
                else
                {
                    binHalfByte += binNumber[i - 1];
                }
            }
            Console.WriteLine(hexNumber);
        }
    }
}
