using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    public class _17_LetterCombinationsOfAPhoneNumber
    {
        public IList<string> LetterCombinations(string digits)
        {
            return mySolution(digits);
        }

        IList<string> mySolution(string digits)
        {
            if (string.IsNullOrEmpty(digits))
            {
                return new List<string>();
            }

            IList<string> result = new List<string>() { "" };
            Dictionary<char, List<char>> dic = new Dictionary<char, List<char>>()
            {
                {'2',new List<char>(){'a','b','c'} },
                {'3',new List<char>(){'d','e','f'} },
                {'4',new List<char>(){'g','h','i'} },
                {'5',new List<char>(){'j','k','l'} },
                {'6',new List<char>(){'m','n','o'} },
                {'7',new List<char>(){'p','q','r','s'} },
                {'8',new List<char>(){'t','u','v'} },
                {'9',new List<char>(){'w','x','y','z'} }
            };

            List<string> temp = new List<string>();
            foreach (var digit in digits)
            {
                foreach (var str in result)
                {
                    foreach (var ch in dic[digit])
                    {
                        temp.Add(str + ch);
                    }
                }
                result.Clear();
                foreach (var str in temp)
                {
                    result.Add(str);
                }
                temp.Clear();
            }


            return result;
        }


        public IList<string> bestSolution(string digits)
        {
            List<string> res = new List<string>();
            if (digits.Length == 0)
            {
                return res;
            }
            Dictionary<int, string> dirNum = new Dictionary<int, string>();
            dirNum.Add(2, "abc");
            dirNum.Add(3, "def");
            dirNum.Add(4, "ghi");
            dirNum.Add(5, "jkl");
            dirNum.Add(6, "mno");
            dirNum.Add(7, "pqrs");
            dirNum.Add(8, "tuv");
            dirNum.Add(9, "wxyz");
            getRes(0, dirNum, digits, "", res);
            return res;
        }
        void getRes(int startIdx, Dictionary<int, string> dirNum, string digits, string childStr, List<string> res)
        {
            if (childStr.Length == digits.Length)//长度等于字符串长度就添加到结果集
            {
                string newChild = childStr;
                res.Add(newChild);
            }
            if (startIdx == digits.Length) return;//开始位置超出了就不用继续套娃了

            char[] chrs = digits.ToCharArray();
            int chrInt = 0;
            for (int i = startIdx; i < chrs.Length; i++)//从哪节开始套娃
            {
                chrInt = Convert.ToInt32(chrs[i].ToString());
                string strChr = dirNum[chrInt];
                char[] dicChrs = strChr.ToCharArray();
                foreach (char dicChr in dicChrs) //拿到数字对应字典里的每个字母循环
                {
                    childStr += dicChr;
                    getRes(i + 1, dirNum, digits, childStr, res);
                    childStr = childStr.Remove(childStr.Length - 1);//移除掉最后一位，用来循环下一个字母
                }
            }
        }
    }
}
