using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    public class _12_IntegerToRoman
    {
        public string IntToRoman(int num)
        {
            return mySolution(num);
        }

        string mySolution(int num)
        {
            string result = "";
            int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] strings = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            
            for(int i= 0; i < values.Length; i++)
            {
                int digit = num / values[i];
                for(int j = 0; j < digit; j++)
                {
                    result += strings[i];
                }

                num -= digit * values[i];
            }

            return result;
        }
    }
}
