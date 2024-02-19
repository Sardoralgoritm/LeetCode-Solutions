/// 169. https://leetcode.com/problems/majority-element/description/?envType=study-plan-v2&envId=top-interview-150


namespace Array;

public class Solution
{
    public int MajorityElement(int[] nums)
    {
        Array.Sort(nums);
        return nums[nums.Length / 2];
    }
}