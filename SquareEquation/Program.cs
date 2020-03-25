using System;

namespace SquareEquation
{
    class Program
    {
        static void Main(string[] args)
        {   // ax2 +bx +c = 0
            //D = b^2 -4ac
            // (-b +/- Sq D) / 2a

            Console.WriteLine("Please enter a:");
            double a = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("Please Enter 'a' greater than 0");
                return;
            }

            Console.WriteLine("Please enter b:");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter c:");
            double c = double.Parse(Console.ReadLine());

            double d = Math.Pow(b, 2) - 4 * a * c;
            Console.WriteLine("Discrim... is "+ d);

            if (d < 0)
            {
                Console.WriteLine("There are no real root");
            }
            else if (d == 0)
            {
                double x = -1 * (b / 2 * a);
                Console.WriteLine("There is only one root. x=" + x);
            }
            else
            {
                double x1 = (-b + Math.Sqrt(d)) / 2 * a;
                double x2 = (-b - Math.Sqrt(d)) / 2 * a;

                Console.WriteLine("There is two roots. x1=" + x1 + " x2=" + x2);
            }

        }
    }
}
