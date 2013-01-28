using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.MultiTaskingCalculator
{
    class MultiTaskingCalculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number for the desired manipulation: ");
            Console.WriteLine("1 Reverse the digits of a number");
            Console.WriteLine("2 Calculate tge average of sequence of integers");
            Console.WriteLine("3 Solve linear equation of type: a*x + b = 0");
            int option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                Console.WriteLine("Please enter valid possitive number!");
                int number = 0;
                do
                {
                    number = int.Parse(Console.ReadLine());
                }
                while (number <= 0);
                int reversed = _07.ReversingDigits.ReversingDigits.ReverseNumber(number);
                Console.WriteLine(reversed);
            }
            else if (option == 2)
            {
                Console.WriteLine("Please enter the sequence of numbers with space between them!");
                string sequence;
                do
                {
                    sequence = Console.ReadLine();
                    sequence = sequence + " ";
                }
                while (sequence == string.Empty);
                FindAverage(sequence);
            }
            else if (option == 3)
            {
                int a = 0;
                do
                {
                    Console.WriteLine("Please enter value for a(a should not be 0)");
                    a = int.Parse(Console.ReadLine());
                }
                while (a == 0);
                Console.WriteLine("Please enter b");
                int b = int.Parse(Console.ReadLine());
                int x = -b / a;
                Console.WriteLine("The unknown 'x' is equal to: {0}", x);
            }
            else
            {
                Console.WriteLine("Wrong Option was selected");
            }
        }

        private static void FindAverage(string sequence)
        {
            string[] rowData = sequence.Split(' ');
            int[] numbers = new int[rowData.Length];
            for (int i = 0; i < rowData.Length - 1; i++)
            {
                numbers[i] = int.Parse(rowData[i]);
            }
            int sum = 0;
            foreach (var element in numbers)
            {
                sum += element;
            }
            Console.WriteLine((decimal)sum / (numbers.Length - 1));
        }
    }
}
