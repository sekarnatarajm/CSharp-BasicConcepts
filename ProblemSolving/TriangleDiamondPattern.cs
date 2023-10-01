using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    public class TriangleDiamondPattern
    {
         // Output

         //      *
         //     ***
         //    *****
         //   *******
         //  *********
         // ***********
         //*************
        public static void TriangleOne()
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

        //Output

        //*
        //***
        //*****
        //*******
        //*********
        //***********
        //*************
        public static void TriangleTwo()
        {
            int number, count = 1;
            Console.Write("Enter number of rows:");
            number = int.Parse(Console.ReadLine());
            count = number;
            for (int j = 1; j <= number; j++)
            {
                for (int i = 1; i <= 2 * j - 1; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        // Output

        //-------*
        //------***
        //-----*****
        //----*******
        //---*********
        //--***********
        //-*************
        //--***********
        //---*********
        //----*******
        //-----*****
        //------***
        //-------*
        public static void DiamondOne()
        {
            int number, count = 1;
            Console.Write("Enter number of rows:");
            number = int.Parse(Console.ReadLine());
            count = number;
            for (int j = 1; j <= number; j++)
            {
                for (int i = 1; i <= count; i++)
                {
                    Console.Write("-");
                }
                count--;
                for (int i = 1; i <= 2 * j - 1; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            count = number;
            for (int j = 1; j <= number - 1; j++)
            {
                for (int i = 1; i <= j + 1; i++)
                {
                    Console.Write("-");
                }
                count--;
                for (int i = 1; i <= 2 * count - 1; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }        
    }
}
