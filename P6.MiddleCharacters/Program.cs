using System;
using System.Linq;

namespace P6.MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] stringToArray = input.ToCharArray();

            static string FindTheMiddleCharacter(string input)
            {
                int extraDigit = 1 - input.Length % 2; 
                return input.Substring(input.Length / 2 - extraDigit, 1 + extraDigit);

            }
            Console.WriteLine(FindTheMiddleCharacter(input));
            FindTheMiddleCharacter(input);
        }
    }
}
