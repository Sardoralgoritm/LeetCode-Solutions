/// 1920. https://leetcode.com/problems/build-array-from-permutation/description/

namespace Array;
public class Solution
{
    public int[] GetConcatenation(int[] nums)
    {
        int n = nums.Length;
        int[] ans = new int[n * 2];
        for (int i = 0; i < n; i++)
        {
            ans[i] = nums[i];
            ans[i + n] = nums[i];
        }
        return ans;
    }
}