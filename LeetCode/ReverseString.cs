using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class ReverseString
    {
        public static string ReverseStringData(string input)
        {
            //string input = "hello world";
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= input.Length; i++)
            {
                sb.Append(input[input.Length - i]);
            }
            Console.WriteLine(sb.ToString());
            return sb.ToString();
        }
        public static void ReverseCharecter(string input)
        {
            //string input = "hello world";
            var strArray = input.Split(' ');
            StringBuilder sb = new StringBuilder();

            foreach (var item in strArray)
            {
                sb.Append(ReverseStringData(item));
                sb.Append(" ");
            }
            Console.WriteLine(sb.ToString());
        }

        public static string ReverseCharecterData(string input)
        {
            var charArray = input.ToCharArray();

            for (int i = 0, j = charArray.Length - 1; i < j; i++, j--)
            {
                charArray[i] = input[j];
                charArray[j] = input[i];
            }
            string recerseStr = new string(charArray);
            return recerseStr;
        }

        public static bool IsPalindrome()
        {
            string input = "1234321";
            var strCharArray = input.ToCharArray();

            for (int i = 0, j = strCharArray.Length - 1; i < j; i++, j--)
            {
                if (input[i] != input[j])
                {
                    return false;
                }
            }
            return true;
        }


        public static string Reverse()
        {
            string input = "Welcome to Csharp corner";
            char[] arr = new char[input.Length];

            for (int i = 1; i <= input.Length; i++)
            {
                arr[input.Length - i] = input[i - 1];
            }
            return new string(arr);
        }

        public static void Reverses_new()
        {
            string input = "Welcome to Csharp corner";
            var listStr = input.Split(' ');
            string[] arr = new string[listStr.Count()];
            int index = listStr.Count() - 1;
            StringBuilder sb = new StringBuilder();

            foreach (var item in listStr)
            {
                arr[index] = item;
                index--;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                sb.Append(arr[i] + " ");
            }
            Console.WriteLine(sb.ToString());
        }

        public static string Reverses_Two()
        {
            string input = "Welcome to Csharp corner";
            int i = input.Length - 1;
            StringBuilder sb = new StringBuilder();
            StringBuilder mainSb = new StringBuilder();

            while (i >= 0)
            {
                if (input[i] != ' ' || i == 0)
                {
                    sb.Append(input[i]);
                    if (i == 0)
                    {
                        mainSb.Append(ReverseCharecterData(sb.ToString() + " "));
                        sb.Clear();
                    }
                }
                else
                {
                    mainSb.Append(ReverseCharecterData(sb.ToString() + " "));
                    sb.Clear();
                }
                i--;
            }
            var result = mainSb.ToString().Trim();
            return result;
        }

        public static void ReverseWordOrder()
        {
            string str = "Welcome to Csharp corner";
            StringBuilder sb = new StringBuilder();
            int start = str.Length - 1;
            int end = str.Length - 1;

            while (start >= 0)
            {
                if (str[start] == ' ')
                {
                    int i = start + 1;
                    while (i <= end)
                    {
                        sb.Append(str[i]);
                        i++;
                    }
                    sb.Append(" ");
                    end = start - 1;
                }
                start--;
            }
            for (int i = 0; i <= end; i++)
            {
                sb.Append(str[i]);
            }
            var fgdf = sb.ToString();
        }
    }
}
