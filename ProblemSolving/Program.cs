using System;

namespace ProblemSolving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TriangleTwo();
            PrintDiamondPattern();
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }

        public static void PrintDiamondPattern()
        {
            try
            {
                int midValue = 3;
                int row = 5;
                int previous = midValue, next = midValue;


                for (int i = 1; i <= row; i++)
                {
                    for (int j = 1; j <= row; j++)
                    {

                        if (previous <= j && next >= j)
                            Console.Write("*");
                        else
                            Console.Write(" ");

                    }
                    if (midValue > i)
                    {
                        previous -= 1;
                        next += 1;
                    }
                    else
                    {
                        previous += 1;
                        next -= 1;
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
            }
        }        

        private static void TriangleTwo()
        {
            int number, count = 1;
            Console.Write("Enter number of rows:");
            number = int.Parse(Console.ReadLine());
            count = number;
            for (int j = 1; j <= number; j++)
            {
                for (int i = 1; i <= count; i++)
                {
                    Console.Write(" ");
                }
                count--;
                for (int i = 1; i <= 2 * j - 1; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
