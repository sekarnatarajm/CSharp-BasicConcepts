using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace LeetCode
{
    public static class DateHelper
    {
        public static bool IsDefaultDate(this DateTime dateTime)
        {
            return dateTime == DateTime.MinValue;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            string s = "01110011";

            var left = s.Substring(0, 2);
            var right = s.Substring(2);


            //DateTime dateTime = new DateTime();
            //TestDate(dateTime);

            ProductDifference();
            //NumberOfMatches(7);
            int[][] jaggedArray = {
                 new int[] { 0, 1, 0 },
                 new int[] { 0, 0, 0 },
                 new int[] { 1, 0, 0 },
                 new int[] { 1, 0, 0 }
              };
            DestinationCityData();
            NumSpecial(jaggedArray);
            HammingWeight(00000000000000000000000000001011);
            LargestOddNumberInString();
            CountCharacters_2();
            TotalMoney(20);
            SameDigitNumberInString("42352338");
            Console.WriteLine("Hello World!");
        }

        public static void TestDate(DateTime createdDate)
        {
            if (createdDate.IsDefaultDate())
            {

            }
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
        public static int TotalMoney(int n)
        {
            int week = 1;
            int day = 1;
            int totalMoney = 0;
            for (int i = 1; i <= n; i++)
            {
                totalMoney += day + (week - 1);
                Console.WriteLine("Week {0}, Day {1}, Amount {2}", week, day, totalMoney);
                if (day == 7)
                {
                    day = 1;
                    week++;
                }
                else
                {
                    day++;
                }
            }
            return totalMoney;
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

        public static int CountCharacters()
        {
            var chars = "welldonehoneyr";
            string[] words = new string[] { "hello", "world", "leetcode" };
            var charCountData = GetCharCount(chars);
            int charCount = 0;
            int totalCharCount = 0;
            string previousChar = "";

            for (int i = 0; i < words.Length; i++)
            {
                previousChar = "";
                var wordsCharCountData = GetCharCount(words[i].ToString());
                for (int j = 0; j < words[i].Length; j++)
                {
                    if (chars.Contains(words[i].ToString()[j]))
                    {
                        if (previousChar != (words[i].ToString()[j]).ToString())
                        {
                            var charCounts = charCountData.FirstOrDefault(f => f.Key == words[i].ToString()[j]).Value;
                            var wordsCharCounts = wordsCharCountData.FirstOrDefault(f => f.Key == words[i].ToString()[j]).Value;
                            if (wordsCharCounts <= charCounts)
                            {
                                charCount += wordsCharCounts;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                    else
                    {
                        break;
                    }
                    previousChar = words[i].ToString()[j].ToString();
                }
                if (charCount == words[i].Length)
                {
                    totalCharCount += words[i].Length;
                }
                charCount = 0;
            }
            return totalCharCount;
        }

        public static Dictionary<char, int> GetCharCount(string chars)
        {
            Dictionary<char, int> count = new Dictionary<char, int>();
            for (int i = 0; i < chars.Length; i++)
            {
                if (count.ContainsKey(chars[i]))
                {
                    count[chars[i]]++;
                }
                else
                {
                    count.Add(chars[i], 1);
                }
            }
            return count;
        }

        public static int CountCharacters_2()
        {
            var chars = "welldonehoneyr";
            string[] words = new string[] { "hello", "world", "leetcode" };
            var charCountData = GetCharCount(chars);
            int charCount = 0;
            int totalCharCount = 0;

            for (int i = 0; i < words.Length; i++)
            {
                charCount = 0;
                var wordCountData = GetCharCount(words[i].ToString()).ToList();

                for (int j = 0; j < wordCountData.Count; j++)
                {
                    if (chars.Contains(wordCountData[j].Key))
                    {
                        var wordCounts = wordCountData.FirstOrDefault(c => c.Key == wordCountData[j].Key).Value;
                        var charCounts = charCountData.FirstOrDefault(c => c.Key == wordCountData[j].Key).Value;
                        if (wordCounts <= charCounts)
                        {
                            charCount += wordCounts;
                        }
                        else
                        {
                            charCount = 0;
                            break;
                        }
                    }
                    else
                    {
                        charCount = 0;
                        break;
                    }
                }
                totalCharCount += charCount;
            }
            return totalCharCount;
        }

        public static string LargestOddNumberInString()
        {
            string num = "35427";
            var latValue = Convert.ToInt32(num.Substring(num.Length - 1, 1));
            if (latValue % 2 == 1)
            {
                return num;
            }
            int i = num.Length - 1;
            while (i >= 0)
            {
                if (!(Convert.ToInt32(num[i].ToString()) % 2 == 0))
                {
                    return num.Substring(0, i + 1);
                }
                i--;
            }
            return "";
        }

        public bool ArrayStringsAreEqual(string[] word1, string[] word2)
        {
            uint zdfd = 00000000000000000000000000001011;


            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();
            for (int i = 0; i < word1.Length; i++)
            {
                sb1.Append(word1[i]);
            }
            for (int i = 0; i < word2.Length; i++)
            {
                sb2.Append(word2[i]);
            }
            if (sb1.ToString() == sb2.ToString())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int HammingWeight(uint n)
        {
            int cnt = 0;
            while (n != 0)
            {
                n = n & (n - 1);
                cnt++;
            }

            return cnt;
        }

        public static int NumSpecial(int[][] mat)
        {
            int specialCount = 0;
            for (int i = 0; i < mat.Length; i++)
            {
                var index = CheckRow(mat, i);
                if (index >= 0 && CheckColumn(mat, i, index))
                {
                    specialCount++;
                }
            }
            return specialCount;
        }

        public static int CheckRow(int[][] intArr, int row)
        {
            int index = -1;

            for (int i = 0; i < intArr[0].Length; i++)
            {
                if (intArr[row][i] == 1)
                {
                    if (index >= 0)
                    {
                        return -1;
                    }
                    else
                    {
                        index = i;
                    }
                }
            }
            return index;
        }
        public static bool CheckColumn(int[][] intArr, int row, int index)
        {
            for (int i = 0; i < intArr.Length; i++)
            {
                if (intArr[i][index] == 1 && row != i)
                {
                    return false;
                }
            }
            return true;
        }

        public static void DestinationCityData()
        {
            IList<IList<string>> paths = new List<IList<string>>();
            var list = new List<string>() { "London", "New York" };
            var list2 = new List<string>() { "New York", "Lima" };
            var list3 = new List<string>() { "Lima", "Sao Paulo" };
            paths.Add(list);
            paths.Add(list2);
            paths.Add(list3);

            var dest = DestinationCity(paths);
        }

        public static string DestinationCity(IList<IList<string>> paths)
        {
            var sourceCities = new List<string>();
            foreach (var item in paths)
            {
                sourceCities.Add(item.FirstOrDefault());
            }

            foreach (var item in paths)
            {
                string destination = item.LastOrDefault();
                if (!sourceCities.Contains(destination))
                {
                    return destination;
                }
            }
            return "";
        }

        public static void ProductDifference()
        {
            int[] arrInt = new int[] { 4, 2, 5, 9, 7, 4, 8 };
            int[] orderArr = new int[arrInt.Length];
            int previousValue = 0;

            for (int i = 0; i < arrInt.Length; i++)
            {
                for (int j = i; j < arrInt.Length; j++)
                {
                    if (arrInt[i] >= arrInt[j])
                    {
                        previousValue = arrInt[i];
                        arrInt[i] = arrInt[j];
                        arrInt[j] = previousValue;
                    }
                }
            }

            var result = (arrInt[arrInt.Length - 1] * arrInt[arrInt.Length - 2]) - (arrInt[0] * arrInt[1]);
        }

        public static bool IsAnagram(string s, string t)
        {
            if (!(s.Length == t.Length))
                return false;

            for (int i = 0; i < t.Length; i++)
            {
                var charPosition = s.IndexOf(t[i].ToString());
                if (charPosition >= 0)
                    s = s.Remove(charPosition, 1);

            }
            if (string.IsNullOrEmpty(s))
                return true;
            else
                return false;
        }
        public int MaxScore(string s)
        {
            int max = 0;
            int left = 0;
            int right = 0;

            for (int i = 0; i < s.Length - 1; i++)
            {
                left = 0;
                right = 0;
                for (int j = 0; j < s.Length; j++)
                {
                    if (j <= i)
                    {
                        if (s[j].ToString() == "0")
                        {
                            left += 1;
                        }
                    }
                    else
                    {
                        if (s[j].ToString() == "1")
                        {
                            right += 1;
                        }
                    }
                }
                if ((left + right) > max)
                {
                    max = (left + right);
                }
            }
            return max;
        }
    }
}
