using System;

namespace P10.TopNumber
{
    internal class Program
    {
        static bool CheckIfDigitsDivideBy8(int currentNumber)
        {
            double sumOfDigits = 0;

            while (currentNumber != 0)
            {
                int lastDigit = currentNumber % 10;
                currentNumber /= 10;
                sumOfDigits += lastDigit;
            }

            if (sumOfDigits % 8 == 0)
            {
                return true;
            }

            return false;
        }

        static bool CheckIfHoldsAtLeastOneOddDigit(int currentNumber)
        {

            while (currentNumber != 0)
            {
                int lastDigit = currentNumber % 10;
                currentNumber /= 10;

                if (lastDigit % 2 == 1)
                {
                    return true;
                }
                
            }
            return false;
        }

        static bool PrintAllNumbersFrom1toN(int stringToNum)
        {
            for (int i = 1; i < stringToNum; i++)
            {
                int currentNumber = i;

                bool check1 = CheckIfDigitsDivideBy8(currentNumber);
                bool check2 = CheckIfHoldsAtLeastOneOddDigit(currentNumber);

                if (check1 && check2)
                {
                    Console.WriteLine(i);
                }
            }
            return true;
        }
        
        static void Main(string[] args)
        {
            string inputNum = Console.ReadLine();
            int stringToNum = int.Parse(inputNum);

            PrintAllNumbersFrom1toN(stringToNum);
        }
    }
}
