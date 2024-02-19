/// 88.  https://leetcode.com/problems/remove-element/?envType=study-plan-v2&envId=top-interview-150


namespace Array;

public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int i = 0;
        while (n > 0)
        {
            nums1[m] = nums2[i];
            n--;
            i++;
            m++;
        }
        Array.Sort(nums1);
    }
}