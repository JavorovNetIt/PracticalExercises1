using System;

namespace SwitchValues
{
    class Program
    {
        static void Main(string[] args)
        {
            //Декларираме първо число
            int firstNumber = 1;

            //Декларираме второ число
            int secondNumber = 2;

            ////Запазваме ст-цт на първото число, за да я имаме
            //int tempFirstNumber = firstNumber;

            ////На първото число сменяме ст-ста с ст-ста на второто
            //firstNumber = secondNumber;

            //// на второто слагаме стойността от темп променливата
            //secondNumber = tempFirstNumber;
            int result;
            int result2;

            SwitchNumbers(firstNumber, secondNumber,out result, out result2);

            Console.WriteLine($"firstNumber: {result}");
            Console.WriteLine($"secondNumber: {result2}");

        }

        public static void SwitchNumbers(int a, int b, out int x, out int y)
        {
            int temp = a;

            //На първото число сменяме ст-ста с ст-ста на второто
            a = b;

            // на второто слагаме стойността от темп променливата
            b = temp;

            x = a;

            y = b;
        }
    }
}
