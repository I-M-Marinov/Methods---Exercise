using System;

namespace P1.SmallestOfThreeNumbers
{
    internal class Program
    {
        static void GetSmallestNumber(int a, int b, int c)
        {
            if (a < b && a < c)
            {
                Console.WriteLine(a);
            }
            else if (c < b && c < a)
            {
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine(b);
            }
        }
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            GetSmallestNumber(number1,number2,number3);
        }
    }
}
