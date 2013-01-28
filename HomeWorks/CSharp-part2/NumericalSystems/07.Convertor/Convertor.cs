using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Convertor
{
    class Convertor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the base of the inital Numerical System (s = 2,10,16)");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the base of the final Numerical System (d = 2,10,16)");
            int d = int.Parse(Console.ReadLine());

            if (s == 2)
            {
                if (d == 10)
                {
                    ConvertFromBinToDec();
                }
                else if (d == 16)
                {
                    ConvertFromBinToHex();
                }
                else
                {
                    Console.WriteLine("Please enter number: ");
                    string number = Console.ReadLine();
                    Console.WriteLine(number);
                }
            }
            else if (s == 10)
            {
                if (d == 2)
                {
                    ConvertFromDecToBin();
                }
                else if (d == 16)
                {
                    ConvertFromDecToHex();
                }
                else
                {
                    Console.WriteLine("Please enter number: ");
                    string number = Console.ReadLine();
                    Console.WriteLine(number);
                }
            }
            else if (s == 16)
            {
                if (d == 2)
                {
                    ConvertFromHexToBin();
                }
                else if (d == 10)
                {
                    ConvertFromHexToDec();
                }
                else
                {
                    Console.WriteLine("Please enter number: ");
                    string number = Console.ReadLine();
                    Console.WriteLine(number);
                }
            }

        }

        private static void ConvertFromHexToDec()
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

        private static void ConvertFromHexToBin()
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

        private static void ConvertFromDecToHex()
        {
            Console.WriteLine("Please enter dec number to be converted: ");
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

        private static void ConvertFromDecToBin()
        {
            Console.WriteLine("Please enter dec number to be converted: ");
            int number = int.Parse(Console.ReadLine());
            string binNumber = "";
            while (number > 0)
            {
                binNumber = number % 2 + binNumber;
                number /= 2;
            }
            Console.WriteLine(binNumber);
        }

        private static void ConvertFromBinToHex()
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

        private static void ConvertFromBinToDec()
        {
            Console.WriteLine("Please enter binary number: ");
            string binNumber = Console.ReadLine();
            int decNumber = 0;
            for (int i = 0; i < binNumber.Length; i++)
            {
                if (binNumber[i] == '1')
                {
                    decNumber += (int)Math.Pow((double)2, (double)binNumber.Length - i - 1);
                }
            }
            Console.WriteLine(decNumber);
        }
    }
}
