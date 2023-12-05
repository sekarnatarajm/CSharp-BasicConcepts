using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    public class StringFunction
    {
        public static void IsEqual()
        {
            string string1 = "GOOGLE";
            string string2 = "google";

            var isEqual = string1.Equals(string2, StringComparison.OrdinalIgnoreCase);
        }
    }
}
