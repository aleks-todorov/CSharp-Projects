using System;
using System.Linq;

namespace _04.MaxSequence
{
    class MaxSequence
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
            int currentNumber = array[0];
            int maxNumber = 0;
            int maxSequence = 0;
            int currentSequence = 1;

            for (int i = 1; i < array.Length; i++)
            {
                if (currentNumber == array[i])
                {
                    currentSequence++;
                    if (maxSequence < currentSequence)
                    {
                        maxSequence = currentSequence;
                        maxNumber = array[i];
                    }
                    continue;
                }
                currentNumber = array[i];
                currentSequence = 1;
            }
            for (int i = 0; i < maxSequence; i++)
            {
                Console.Write(maxNumber + " ");
            }
        }
    }
}
