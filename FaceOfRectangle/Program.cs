using System;

namespace FaceOfRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double a = Math.Abs(y1 - y2);
            double b = Math.Abs(x1 - x2);

            double p = 2 * (a + b);
            double area = Math.Round((a * b), 2);

            Console.WriteLine(string.Format("{0:0.00}", Math.Round(p,2)));
            Console.WriteLine(area);
        }
    }
}
