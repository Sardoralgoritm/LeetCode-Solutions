/// 162.  https://leetcode.com/problems/find-peak-element/description/?envType=study-plan-v2&envId=top-interview-150


namespace Array;

public class Solution
{
    public int FindPeakElement(int[] nums)
    {
        if (nums.Length == 1) return 0;

        int max = nums[0];
        int result = 0;

        int left = -1;
        int right = nums.Length;

        while (left++ + 1 < right--)
        {
            if (left != 0)
            {
                if (nums[left] > nums[left + 1] && nums[left] > nums[left - 1])
                {
                    if (max < nums[left])
                    {
                        max = nums[left];
                        result = left;
                    }
                }
            }
            else
            {
                if (nums[left] > nums[left + 1])
                {
                    if (nums[left] > max)
                    {
                        result = left;
                        max = nums[result];
                    }
                }
                if (nums[left] < nums[left + 1])
                {
                    if (nums[left] > max)
                    {
                        result = left;
                        max = nums[result];
                    }
                }
            }
            if (right != nums.Length - 1)
            {
                if (nums[right] > nums[right + 1] && nums[right] > nums[right - 1])
                {
                    if (max < nums[right])
                    {
                        max = nums[right];
                        result = right;
                    }
                }
            }
            else
            {
                if (nums[right] > nums[right - 1])
                {
                    if (nums[right] > max)
                    {
                        result = right;
                        max = nums[result];
                    }
                }
                if (nums[right] < nums[right - 1])
                {
                    if (nums[right] > max)
                    {
                        result = right;
                        max = nums[result];
                    }
                }
            }
        }
        return result;
    }
}