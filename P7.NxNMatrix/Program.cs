using System;

namespace P7.NxNMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            static void PrintNxNMatrix(int num)
            {
                for (int i = 1; i <= num; i++)
                {
                    for (int j = 1; j <= num; j++)
                    {
                        Console.Write($"{num} ");
                    }
                    Console.WriteLine();
                }
            }
            PrintNxNMatrix(num);
            
        }
    }
}
