using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    public class _190_ReverseBits
    {
        public uint reverseBits(uint n)
        {
            return mySolution(n);
        }

        uint mySolution(uint n)
        {
            uint result = 0;

            for (int i = 0; i < 32; i++)
            {
                if ((n & 1) == 1)
                {
                    result += 1;
                }
                n >>= 1;
                if (i != 31)
                    result <<= 1;
            }


            return result;
        }

        uint bestSolution(uint n)
        {
            int M1 = 0x55555555; // 01010101010101010101010101010101
            int M2 = 0x33333333; // 00110011001100110011001100110011
            int M4 = 0x0f0f0f0f; // 00001111000011110000111100001111
            int M8 = 0x00ff00ff; // 00000000111111110000000011111111

            n = (uint)(n >> 1 & M1 | (n & M1) << 1);
            n = (uint)(n >> 2 & M2 | (n & M2) << 2);
            n = (uint)(n >> 4 & M4 | (n & M4) << 4);
            n = (uint)(n >> 8 & M8 | (n & M8) << 8);
            return n >> 16 | n << 16;
        }
    }
}
