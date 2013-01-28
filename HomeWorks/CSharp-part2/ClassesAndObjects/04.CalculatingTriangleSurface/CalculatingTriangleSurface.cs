using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CalculatingTriangleSurface
{
    class CalculatingTriangleSurface
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please specify how do you want ot calculate the area: ");
            Console.WriteLine("1. By Given Side and Altitude ? Enter 1");
            Console.WriteLine("2. By Given 3 sides? Enter 2");
            Console.WriteLine("3. By 2 sides and angle between them? Enter 3");
            double choice = double.Parse(Console.ReadLine());
            if (choice == 1)
            {
                CalculateAreaBySideAndAltitude();
            }
            else if (choice == 2)
            {
                CalculteAreaByThreeSides();
            }
            else if (choice == 3)
            {
                CalculateAreaByTwoSidesAndAngle();
            }
        }

        private static void CalculateAreaByTwoSidesAndAngle()
        {
            Console.WriteLine("Please enter first side(a)");
            double sideOne = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second side(b)");
            double sideTwo = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter angle");
            double angle = double.Parse(Console.ReadLine());
            double surface = sideOne * sideTwo * Math.Sin(angle * Math.PI / 180) * 1 / 2;
            Console.WriteLine("The surface is: {0}", surface);
        }

        private static void CalculteAreaByThreeSides()
        {
            Console.WriteLine("Please enter first side(a)");
            double sideOne = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second side(b)");
            double sideTwo = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter third side(c)");
            double sideThree = double.Parse(Console.ReadLine());
            double semiPerimeter = (sideOne + sideTwo + sideThree) / 2;
            double surface = (double)Math.Sqrt((double)(semiPerimeter * (semiPerimeter - sideOne) * (semiPerimeter - sideTwo) * (semiPerimeter - sideThree)));
            Console.WriteLine("The surface is: {0}", surface);
        }

        private static void CalculateAreaBySideAndAltitude()
        {
            Console.WriteLine("Please enter side");
            double side = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter altitude");
            double altitude = double.Parse(Console.ReadLine());
            double surface = side * altitude / 2;
            Console.WriteLine("The surface is: {0}", surface);
        }
    }
}
