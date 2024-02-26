/// 100.  https://leetcode.com/problems/same-tree/?envType=daily-question&envId=2024-02-26

namespace Tree;

//Definition for a binary tree node.
public class TreeNode {
     public int val;
     public TreeNode left;
     public TreeNode right;
     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
         this.val = val;
         this.left = left;
         this.right = right;
     }
 }
 
public class Solution
{
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        if (p == null && q == null) return true;

        if (p == null || q == null) return false;

        if (p.val == q.val)
        {
            return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
        }

        return false;
    }
}