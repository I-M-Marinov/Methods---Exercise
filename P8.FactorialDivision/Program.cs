using System;

namespace P8.FactorialDivision
{
    internal class Program
    {
        static double CalculateFactorialOfANumber(double number)
        {
            double fact = 1;
            for (int i = 1; i <= number; i++)
            {
               fact = fact * i;
            }
            return fact;
        }

        static void DivideTheTwoFactorials(double number, double number2)
        {
            double result = number / number2;
            Console.WriteLine($"{result:f2}");
        }
   

        static void Main(string[] args)
        {
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());

            double factorial1 = CalculateFactorialOfANumber(number1);
            double factorial2 = CalculateFactorialOfANumber(number2);

            DivideTheTwoFactorials(factorial1,factorial2);

        }
    }
}
