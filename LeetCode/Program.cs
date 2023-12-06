using System;
using System.Linq;
using System.Text;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //NumberOfMatches(7);
            var gfdfgdf = SameDigitNumberInString("42352338");
            Console.WriteLine("Hello World!");
        }

        public static int NumberOfMatches(int totalTeam)
        {
            if (totalTeam <= 1) { return 0; }
            int matchCount = 0;
            int remainingTeam = 0;

            while (true)
            {
                if (totalTeam % 2 == 0)
                {
                    remainingTeam = totalTeam / 2;
                    matchCount += remainingTeam;
                    totalTeam = remainingTeam;
                }
                else
                {
                    remainingTeam = (totalTeam - 1) / 2;
                    matchCount += remainingTeam;
                    totalTeam = remainingTeam + 1;
                }
                if (totalTeam == 1)
                {
                    break;
                }
            }
            return matchCount;
        }
        public static string SameDigitNumberInString(string num)
        {
            int result = -1;
            for (int i = 0; i < num.Length - 2; i++)
            {
                if (num[i] == num[i + 1] && num[i] == num[i + 2])
                {
                    result = Math.Max(result, Convert.ToInt32(num[i].ToString()));
                }
            }
            if (result >= 0)
            {
                return string.Concat(Enumerable.Repeat(result, 3));
            }
            else
            {
                return "";
            }
        }

        public static string SameDigitNumberInString_Old(string num)
        {
            string previousCharecter = "";
            string sameCharecter = "";
            string maxNumber = "0";

            foreach (char c in num)
            {
                if (previousCharecter == c.ToString())
                {
                    sameCharecter += c.ToString();
                }
                else
                {
                    if (!string.IsNullOrEmpty(sameCharecter) && sameCharecter.Length >= 3)
                    {
                        maxNumber = Convert.ToInt32(sameCharecter.Substring(0, 3)) >= Convert.ToInt32(maxNumber) ? sameCharecter.Substring(0, 3) : maxNumber;
                        sameCharecter = "";
                    }
                    sameCharecter = c.ToString();
                }
                previousCharecter = c.ToString();
            }
            if (!string.IsNullOrEmpty(sameCharecter) && sameCharecter.Length >= 3)
            {
                maxNumber = Convert.ToInt32(sameCharecter.Substring(0, 3)) >= Convert.ToInt32(maxNumber) ? sameCharecter.Substring(0, 3) : maxNumber;
                sameCharecter = "";
            }
            return maxNumber == "0" ? "" : maxNumber;
        }        
    }
}
