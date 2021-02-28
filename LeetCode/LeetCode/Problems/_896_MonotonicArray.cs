using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    public class _896_MonotonicArray
    {
        public bool IsMonotonic(int[] A)
        {
            return mySolution(A);
        }

        bool mySolution(int[] A)
        {
            bool result = true;

            if (A != null && A.Length > 2)
            {
                int type = 0;
                for (int i = 0; i < A.Length - 1; i++)
                {
                    if (type == 0)
                    {
                        if (A[i] - A[i + 1] > 0)
                        {
                            type = 1;
                        }
                        else if (A[i] - A[i + 1] < 0)
                        {
                            type = -1;
                        }
                    }
                    else if (type == 1)
                    {
                        if (A[i] - A[i + 1] < 0)
                        {
                            result = false;
                            break;
                        }
                    }
                    else
                    {

                        if (A[i] - A[i + 1] > 0)
                        {
                            result = false;
                            break;
                        }
                    }
                }

            }

            return result;
        }
    }
}
