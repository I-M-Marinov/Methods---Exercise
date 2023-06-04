using System;
using System.Text;

namespace P3.CharactersInRange
{
    internal class Program
    {
        
        static int PrintCharsInBetween(int num1, int num2)
        {
            if (num1 < num2)
            {
                for (int i = num1 + 1; i < num2; i++)
                {
                    Console.Write($"{(char)i} ");
                }
            }
            else if (num1 > num2)
            {
                for (int i = num2 + 1; i < num1; i++)
                {
                    Console.Write($"{(char)i} ");
                }
            }

            return num1;
        }
        static void Main(string[] args)
        {
            char character1 = char.Parse(Console.ReadLine());
            char character2 = char.Parse(Console.ReadLine());
            int num1 = (int)character1;
            int num2 = (int)character2;

            PrintCharsInBetween(num1, num2);
        }
    }
}
