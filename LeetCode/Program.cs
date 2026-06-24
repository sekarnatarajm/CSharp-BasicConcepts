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
            missingNum();
            TwoRepeated1();
            var rrr = GetDuplicateNumber();
            FindRank();
            FixedWindow_2();
            FixedWindow();
            LengthOfLongestSubstring();
            ChatCount();
            Factorial(5);
            ChatCount();
            RevStr45();
            Palindrome();
            ReStr();
            ReverseString_method222();
            ReverseString_method2();

            string ab = "Hi";
            ab += "Hello";
            Console.WriteLine(ab);

            int xx = 3;
            Console.WriteLine(xx++ + ++xx);


            for (int i = 1; i <= 3; i++) Console.Write(i);

            int a = 5;
            Console.WriteLine(" ++5 = {0}", a++);
            Console.WriteLine(" ++5 = {0}", a++);

            int b = 2;
            Console.WriteLine(" ++2 = {0}", ++b);
            Console.WriteLine(" ++2 = {0}", ++b);


            int x = 3;
            Console.WriteLine(x * x++);



            string ss = "Hello";
            Console.WriteLine(ss.Length);






            ReverseString.Reverse();
            ReverseString.ReverseStringData("Welcome to Csharp corner");
            ReverseString.ReverseCharecter("Welcome to Csharp corner");


            FindClosestValue();
            CountCharecter();

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

        public static void CountCharecter()
        {
            string input = "Hello World";
            Dictionary<char, int> charCounts = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (charCounts.ContainsKey(input[i]))
                {
                    charCounts[input[i]] += 1;
                }
                else
                {
                    charCounts.Add(input[i], 1);
                }
            }

            foreach (var charData in charCounts)
            {
                Console.WriteLine("Charecter : {0}, TotalCount : {1}", charData.Key, charData.Value);
            }
        }

        public static int FindClosestValue_3()
        {
            //int[] nums = { -4, -2, 1, 4, 8 };
            int[] nums = { 2, -1, 1 };
            //int[] nums = { -100000, -100000 };
            //int[] nums = { -10, -12, -54, -12, -544, -10000 };
            int closest = 0;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (Math.Abs(nums[i]) <= Math.Abs(nums[i + 1]))
                {
                    if (closest == 0)
                    {
                        closest = Math.Abs(nums[i]).Equals(Math.Abs(nums[i + 1])) ? Math.Max(nums[i], nums[i + 1]) : nums[i];
                    }
                    else
                    {
                        int m = Math.Abs(nums[i]).Equals(Math.Abs(nums[i + 1])) ? Math.Max(nums[i], nums[i + 1]) : nums[i];
                        closest = m < closest ? m : closest;
                    }
                }
            }
            return closest;
        }

        public static int FindClosestValue()
        {
            //int[] nums = { -4, -2, 1, 4, 8 };
            int[] nums = { 2, -1, 1 };
            //int[] nums = { -100000, -100000 };
            //int[] nums = { -10, -12, -54, -12, -544, -10000 };


            int closest = int.MaxValue;
            int val = int.MaxValue;

            for (int i = 0; i < nums.Length; i++)
            {
                if (Math.Abs(nums[i] - 0) < closest)
                {
                    closest = Math.Abs(nums[i] - 0);
                    val = nums[i];
                }
                else if (Math.Abs(nums[i]) == closest)
                {
                    val = Math.Max(val, nums[i]);
                }
            }
            return closest;
        }

        public static int FindClosestValue_566()
        {
            //int[] nums = { -4, -2, 1, 4, 8 };
            //int[] nums = { 2, -1, 1, -1 };
            //int[] nums = { -100000, -100000 };
            int[] nums = { -10, -12, -54, -12, -544, -10000 };
            int closest = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (Math.Abs(nums[i]) < Math.Abs(closest) || Math.Abs(nums[i]) == Math.Abs(closest) && closest < nums[i])
                {
                    closest = nums[i];
                }
            }
            return closest;
        }

        public static void ReverseStrings()
        {
            string s = "hello";
            string result = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                result += s[i];
            }
            Console.WriteLine(result);
        }
        public static void ReverseString_method2()
        {
            string s = "Welcome to Csharp corner";
            int start = s.Length - 1;
            int end = s.Length - 1;
            StringBuilder sb = new StringBuilder();

            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == ' ')
                {
                    start = i + 1;
                    for (int j = start; j < end; j++)
                    {
                        sb.Append(s[j]);
                    }
                    sb.Append(" ");
                    end = start;
                }
                Console.WriteLine(s[i]);
            }
            for (int i = 0; i < end; i++)
            {
                sb.Append(s[i]);
            }
            var dd = sb.ToString();
        }
        public static void ReverseString_method222()
        {
            try
            {
                Console.WriteLine("cheers : {0}", 1 / Convert.ToInt32(0));
            }
            catch (ArithmeticException dd)
            {

                throw;
            }
        }

        public static string ReStr()
        {
            string word = "hello";
            string result = "";

            for (int i = word.Length; i > 0; i--)
            {
                result += word[i - 1];
            }
            return result;
        }
        //input: 1221, output: Palindrome
        public static string Palindrome()
        {
            string word = "kalyak";
            string result = "";

            int k = word.Length / 2;

            for (int i = 0, j = word.Length; i < k; i++, j--)
            {
                if (word[i] != word[j - 1])
                {
                    result = "Not Palindrome";
                    return result;
                }
                result = "Palindrome";
            }
            return result;
        }

        //input: Welcome to Csharp corner, output: corner Csharp to Welcome
        public static string RevStr45()
        {
            string word = "Welcome to Csharp corner";
            StringBuilder result = new StringBuilder();

            int start = word.Length;
            int end = word.Length;


            for (int i = word.Length; i > 0; i--)
            {
                if (word[i - 1] == ' ')
                {
                    start = i;
                    for (int j = start; j <= end; j++)
                    {
                        result.Append(word[j - 1]);
                    }
                    end = start;
                }
            }
            for (int i = 0; i < end; i++)
            {
                result.Append(word[i]);
            }
            return result.ToString();
        }

        //input: hello world;
        public static void ChatCount()
        {
            string word = "hello world";
            Dictionary<char, int> chatCount = new Dictionary<char, int>();
            for (int i = 0; i < word.Length; i++)
            {
                if (chatCount.ContainsKey(word[i]))
                {
                    chatCount[word[i]] += 1;
                }
                else
                {
                    chatCount[word[i]] = 1;
                }
            }
        }

        public static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            var result = n * Factorial(n - 1);
            return result;
        }

        public static int LengthOfLongestSubstring()
        {
            string s = "abcabcbb";
            var set = new HashSet<char>();
            int left = 0, maxLength = 0;

            for (int right = 0; right < s.Length; right++)
            {
                while (set.Contains(s[right]))
                {
                    set.Remove(s[left]);
                    left++;
                }

                set.Add(s[right]);
                maxLength = Math.Max(maxLength, right - left + 1);
            }

            return maxLength;
        }
        public static int FixedWindow()
        {
            int[] arr = new int[] { 2, 1, 5, 1, 3, 2 };
            int k = 3;
            int windowSum = 0;
            int maxSum = 0;

            for (int i = 0; i < k; i++)
            {
                windowSum += arr[i];
            }
            maxSum = windowSum;

            for (int i = k; i < arr.Length; i++)
            {
                windowSum += arr[i] - arr[i - k];
                maxSum = Math.Max(maxSum, windowSum);
            }
            return maxSum;
        }

        public static void FixedWindow_1()
        {
            int[] arr = new int[] { 2, 1, 5, 1, 3, 2 };
            int k = 3;
            int windowSum = 0;
            int maxSum = 0;

            for (int i = 0; i < k; i++)
            {
                windowSum += arr[i];
            }
            maxSum = windowSum;

            for (int i = k; i < arr.Length; i++)
            {
                windowSum += arr[i] - arr[i - k];
            }
        }

        public static void FixedWindow_2()
        {
            string s = "pwwkew";
            int maxLenght = 0;
            int left = 0;
            List<char> charList = new List<char>();

            for (int right = 0; right < s.Length; right++)
            {
                while (charList.Contains(s[right]))
                {
                    charList.Remove(s[left]);
                    left++;
                }
                //if (charList.Contains(s[right]))
                //{
                //    charList.Remove(s[left]);
                //    left++;
                //}
                charList.Add(s[right]);

                maxLenght = Math.Max(maxLenght, right - left + 1);
            }

            var dd = maxLenght;
        }

        public static void FindRank()
        {
            int[] arr = new int[] { 93, 52, 11, 35, 6, 14, 11, 14, 35 };
            int k = 3;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            var result = RemoveDuplicates(arr)[k - 1];
        }

        public static int[] RemoveDuplicates(int[] arr)
        {
            //[1, 1, 1, 2, 2, 3,4]
            int previous = 0;
            List<int> ints = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    previous = arr[i];
                    ints.Add(arr[i]);
                }
                if (arr[i] != previous)
                {
                    previous = arr[i];
                    ints.Add(arr[i]);
                }
            }
            var ss = ints.ToArray();
            return ss;
        }

        public static int GetDuplicateNumber()
        {
            int[] arr = new int[] { 3, 4, 5, 3, 6, 4, 7 };
            int k = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                k = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (k == arr[j])
                    {
                        return k;
                    }
                }
            }
            return 0;
        }

        public static int[] TwoRepeated()
        {
            int[] arr = new int[6] { 1, 2, 1, 3, 4, 3 };
            // code here
            int first = 0;
            int second = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        if (first == 0)
                        {
                            first = arr[i];
                            continue;
                        }

                        if (second == 0)
                        {
                            second = arr[i];
                            break;
                        }
                    }
                }
            }
            int[] res = new int[2];
            res[0] = first;
            res[1] = second;
            return res;
        }

        public static int[] TwoRepeated1()
        {
            int[] arr = new int[12] { 9, 1, 5, 6, 4, 3, 10, 8, 4, 2, 2, 7 };
            //code here
            int first = 0;
            int second = 0;
            List<int> dict = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (dict.Contains(arr[i]))
                {
                    if (first == 0)
                    {
                        first = i;
                        dict.Add(arr[i]);
                    }
                    else
                    {
                        second = i;
                        dict.Add(arr[i]);
                        break;
                    }
                }
                else
                {
                    dict.Add(arr[i]);
                }
            }
            if (first <= second)
            {
                return new int[2] { dict[first], dict[second] };
            }
            else
            {
                return new int[2] { dict[second], dict[first] };
            }
        }


        public static int missingNum()
        {
            int[] arr = new int[5] { 2, 6, 5, 1, 3 };
            int n = arr.Length;

            long expectedSum = (long)(n + 1) * (n + 2) / 2;
            long actualSum = 0;

            foreach (int num in arr)
            {
                actualSum += num;
            }

            return (int)(expectedSum - actualSum);
        }

    }
}
