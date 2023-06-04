using System;
using static System.Char;

namespace P4.PasswordValidator
{

    internal class Program
    {
        static bool CheckIfbetween6and10Ch(int passwordLength)
        {
            if (passwordLength >= 6 && passwordLength <= 10)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                return false;
            }
        }

        static bool CheckifOnlyNumbersAndDigits(char[] password)
        {

            for (int i = 0; i < password.Length; i++)
            {
                bool a = IsDigit(password[i]); // check if the char from the char array is actually a DIGIT 
                bool b = IsLetter(password[i]); // check if the char from the char array is actually a LETTER 


                if (a == true && i < password.Length) // If a is a DIGIT 
                {
                    continue;
                }
                else if (b == true && i < password.Length) // If b is a LETTER
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    return false;
                }

            }
            return true;
        }

        static bool CheckIfAtLeast2Digits(char[] password)
        {
            int digits = 0;

            for (int i = 0; i < password.Length; i++)
            {
                bool a = IsDigit(password[i]);

                if (a) // Checks if the CHAR is actually a DIGIT 
                {
                    digits++;
                }

                if (digits >= 2)
                {
                    return true;
                }
            }
            if (digits < 2)
            {
                
                Console.WriteLine("Password must have at least 2 digits");
                return false;
            }

            return true;
        }
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            char[] passwordToCharArray = password.ToCharArray();
            int passwordLength = passwordToCharArray.Length;


            bool lengthCheckPassed = CheckIfbetween6and10Ch(passwordLength);
            bool symbolsCheckPassed = CheckifOnlyNumbersAndDigits(passwordToCharArray);
            bool twoDigitsCheckPassed = CheckIfAtLeast2Digits(passwordToCharArray);


            if (lengthCheckPassed && symbolsCheckPassed && twoDigitsCheckPassed)
            {
                Console.WriteLine("Password is valid");
            }

        }
        
    }
}


