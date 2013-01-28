using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.PrintingLettersIndex
{
    class PrintingLettersIndex
    {
        static void Main(string[] args)
        {
            string[] lettersArray = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            string word = Console.ReadLine();
            word.ToLower();
            foreach (var letter in word)
            {
                for (int i = 0; i < lettersArray.Length; i++)
                {
                    if (letter + "" == lettersArray[i])
                    {
                        Console.WriteLine(i);
                        break;
                    }
                }
            }
        }
    }
}
