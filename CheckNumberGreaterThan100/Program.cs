using System;

namespace CheckNumberGreaterThan100
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string greaterResult = "The number is greater or equal than 100";
            string smallerResult = "The number is smaller than 100";


            string result = number > 100 ? greaterResult : smallerResult;

            //if (number > 100)
            //{
            //    Console.WriteLine(greaterResult);
            //}
            //else
            //{
            //    Console.WriteLine(smallerResult);
            //}

            Console.WriteLine(result);
        }
    }
}
