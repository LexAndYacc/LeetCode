using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    public class _13_RomanToInteger
    {
        public int RomanToInt(string s)
        {

            return bestSolution(s);
        }

        int mySolution(string s)
        {
            int result = 0;
            int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] strings = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            for (int i = 0; i < values.Length; i++)
            {
                if (string.IsNullOrEmpty(s))
                {
                    break;
                }

                while (s.StartsWith(strings[i]))
                {
                    result += values[i];
                    s = s.Substring(strings[i].Length);
                }
            }

            return result;
        }

        int bestSolution(string s)
        {
            s = s.Replace("IV", "a");
            s = s.Replace("IX", "b");
            s = s.Replace("XL", "c");
            s = s.Replace("XC", "d");
            s = s.Replace("CD", "e");
            s = s.Replace("CM", "f");

            int result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                result += which(s[i]);
            }
            return result;
        }

        int which(char ch)
        {
            switch (ch)
            {
                case 'I': return 1;
                case 'V': return 5;
                case 'X': return 10;
                case 'L': return 50;
                case 'C': return 100;
                case 'D': return 500;
                case 'M': return 1000;
                case 'a': return 4;
                case 'b': return 9;
                case 'c': return 40;
                case 'd': return 90;
                case 'e': return 400;
                case 'f': return 900;
            }
            return 0;
        }

    }
}
