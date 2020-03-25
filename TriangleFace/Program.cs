using System;

namespace TriangleFace
{
    class Program
    {
        static void Main(string[] args)
        {
            // Входни данни
            Console.WriteLine("What is the size of side A?");
            double sideA = double.Parse(Console.ReadLine());

            Console.WriteLine("What is the size of height A?");
            double heightA = double.Parse(Console.ReadLine());

            //Обработка на данни
            double result = (sideA * heightA) / 2;

            //Показваме данни
            Console.WriteLine("The face of the triangle is: " + result);

            
        }
    }
}
