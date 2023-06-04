using System;

namespace P5.AddAndSubtract
{
    internal class Program
    {
        static int SumNum1AndNum2(int number1, int number2)
        {
            int sum = number1 + number2;
            return sum;
        }
        static int SubtractTheThirdNumber(int num1, int num2)
        {
            int result = 0;
            result = num1 - num2;
            Console.WriteLine(result);
            return result;
        }
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            int sum = SumNum1AndNum2(number1, number2);

            SubtractTheThirdNumber(sum, number3);

        }
    }
}
