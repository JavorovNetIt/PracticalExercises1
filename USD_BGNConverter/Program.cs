using System;

namespace USD_BGNConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 USD => 1.79549 BGN
            decimal course = 1.79549m;

            // We receive amount of usd from the user
            decimal usd = decimal.Parse(Console.ReadLine());

            // Calculate the amount of BGN with the constant course;
            decimal bgn = usd * course;

            Console.WriteLine($"{usd} USD = {Math.Round(bgn,2)} BGN");


        }
    }
}
