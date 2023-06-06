using System;

namespace P9.PalindromeIntegers
{
    internal class Program
    {
        static int FindTheReversedNumber(int number)
        {
            int remainder, reverse = 0;
            while (number != 0)
            {
                remainder = number % 10;
                reverse = reverse * 10 + remainder;
                number /= 10;
            }
            return reverse;
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            

            while (input != "END")
            {
                int stringToNum = int.Parse(input);
                int reversedNum = FindTheReversedNumber(stringToNum);

                if (reversedNum == stringToNum)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                } 
                input = Console.ReadLine();
            }
        }
    }
}
