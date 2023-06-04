using System;

namespace P2.VowelsCount
{
    internal class Program
    {
        static int GetNumberOfVowels(string a, char[] b)
        {
            int vowelsCount = 0;
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] == 'a' || b[i] == 'e' || b[i] == 'i' ||
                    b[i] == 'o' || b[i] == 'u' || b[i] == 'y' || 
                    b[i] == 'A' || b[i] == 'E' || b[i] == 'I' || 
                    b[i] == 'O' || b[i] == 'U' || b[i] == 'Y')
                {
                    vowelsCount += 1;
                }
            }

            Console.WriteLine(vowelsCount);
            return vowelsCount;
        }
        static void Main(string[] args)
        {
            //*  A, E, I, O, U, Y  *//

            string inputText = Console.ReadLine();
            char[] stringToArray = inputText.ToCharArray();

            GetNumberOfVowels(inputText, stringToArray);



        }
    }
}
