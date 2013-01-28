using System;
using System.Linq;


namespace _03.ComparintArraysLexicographically
{
    class ComparintArraysLexicographically
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter length of the array:");
            int length = int.Parse(Console.ReadLine());
            char[] charArrayOne = new char[length];
            char[] charArrayTwo = new char[length];
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Please enter value for first array:");
                charArrayOne[i] = char.Parse(Console.ReadLine());
            }
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Please enter value for second array:");
                charArrayTwo[i] = char.Parse(Console.ReadLine());
            }
            bool areSame = true;
            for (int i = 0; i < length; i++)
            {
                if ((int)charArrayOne[i] == (int)charArrayTwo[i])
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Arrays are not the same! ");
                    areSame = false;
                    break;
                }
            }

            if (areSame == true)
            {
                Console.WriteLine("Arrays are the same! ");
            }

        }
    }
}

