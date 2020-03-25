using System;

namespace CheckNumberIsEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string evenNumber = "The number is even";
            string oddNumber = "The number is odd";

            string result = number % 2 == 0 ? evenNumber : oddNumber;

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine(evenNumber);
            //}
            //else
            //{
            //    Console.WriteLine(oddNumber);
            //}     

            Console.WriteLine(result);
        }
    }
}
