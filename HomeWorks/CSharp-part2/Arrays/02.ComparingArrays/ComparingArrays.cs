using System;
using System.Linq;


namespace _02.ComparingArrays
{
    class ComparingArrays
    {
        static void Main()
        {
            Console.WriteLine("Please specify first array lenght: ");
            int length = int.Parse(Console.ReadLine());
            int [] arrayOne = new int [length];
            int [] arrayTwo = new int [arrayOne.Length];
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Please enter first array elements:");
                arrayOne[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Please enter second array elements:");
                arrayTwo[i] = int.Parse(Console.ReadLine());
            }

            bool areSame = true;
            for (int i = 0; i < length; i++)
            {
                if (arrayOne[i] == arrayTwo[i])
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
