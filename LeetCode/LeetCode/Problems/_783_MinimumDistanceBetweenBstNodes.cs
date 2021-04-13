using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problems
{
    public class _783_MinimumDistanceBetweenBstNodes
    {
        public int MinDiffInBST(TreeNode root)
        {
            return mySolution(root);
        }

        int mySolution(TreeNode root)
        {
            int result = int.MaxValue;


            int pre = -1;
            TreeNode precessor = null;
            while (root != null)
            {
                if (root.left != null)
                {
                    precessor = root.left;
                    while (precessor.right != null && precessor.right != root)
                        precessor = precessor.right;
                    if (precessor.right == null)
                    {
                        precessor.right = root;
                        root = root.left;
                    }
                    else
                    {
                        if (pre == -1)
                        {
                            pre = root.val;
                        }
                        else
                        {
                            result = Math.Min(result, Math.Abs(pre - root.val));
                            pre = root.val;
                        }
                        root = root.right;
                    }
                }
                else
                {
                    if (pre == -1)
                    {
                        pre = root.val;
                    }
                    else
                    {
                        result = Math.Min(result, Math.Abs(pre - root.val));
                        pre = root.val;
                    }
                    root = root.right;
                }
            }

            return result;
        }
        



        #region 内部类
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
        #endregion
    }
}
