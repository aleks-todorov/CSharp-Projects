using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ConvertNumsFromBinToDec
{
    class ConvertNumsFromBinToDec
    {
        static void Main(string[] args)
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
