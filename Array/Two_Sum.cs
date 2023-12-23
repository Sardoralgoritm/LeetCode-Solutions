
/// Problem 1
/// 
/// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
///You may assume that each input would have exactly one solution, and you may not use the same element twice.
///You can return the answer in any order.
namespace Array;
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> dict = new();
        for (int i = 0; i < nums.Length; i++)
        {
            int check = target - nums[i];
            if (dict.ContainsKey(check)) return new int[] { dict[check], i };
            dict[nums[i]] = i;
        }
        return new int[2];
    }
}
