/// 27.  https://leetcode.com/problems/remove-element/?envType=study-plan-v2&envId=top-interview-150


namespace Array;

public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        int index = 0;
        foreach (int i in nums)
        {
            if (i != val)
            {
                nums[index] = i;
                index++;
            }
        }
        return index;
    }
}