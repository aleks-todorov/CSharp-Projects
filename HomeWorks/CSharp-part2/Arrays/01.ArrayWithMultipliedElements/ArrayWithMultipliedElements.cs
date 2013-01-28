using System;
using System.Linq;


namespace Arrays
{
    class ArrayWithMultipliedElements
    {
        static void Main()
        {
            int[] array = new int[20];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 5;
                Console.WriteLine(array[i]);
            }
        }
    }
}
