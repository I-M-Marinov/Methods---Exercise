using System;

namespace P8.FactorialDivision
{
    internal class Program
    {
        static int CalculateFactorialOfANumber(int number)
        {
            int fact = 1;
            for (int i = 1; i <= number; i++)
            {
               fact = fact * i;
            }
            return fact;
        }

        static void DivideTheTwoFactorials(int number, int number2)
        {
            int result = number / number2;
            Console.WriteLine($"{result:f2}");
        }
   

        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            int factorial1 = CalculateFactorialOfANumber(number1);
            int factorial2 = CalculateFactorialOfANumber(number2);

            DivideTheTwoFactorials(factorial1,factorial2);

        }
    }
}
