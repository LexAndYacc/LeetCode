/*
 * @lc app=leetcode.cn id=116 lang=csharp
 *
 * [116] 填充每个节点的下一个右侧节点指针
 */

// @lc code=start
/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}
*/

public class Solution
{
    public Node Connect(Node root)
    {
        if (root == null) return null;
        connectTwoNode(root.left, root.right);
        return root;
    }

    void connectTwoNode(Node node1, Node node2)
    {
        if (node1 == null || node2 == null)
        {
            return;
        }
        
        
        node1.next = node2;


        connectTwoNode(node1.left, node1.right);
        connectTwoNode(node2.left, node2.right);
        
        connectTwoNode(node1.right, node2.left);
    }
}
// @lc code=end

