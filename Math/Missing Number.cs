/// 268.  https://leetcode.com/problems/missing-number/?envType=daily-question&envId=2024-02-20


namespace Math;

public class Solution
{
    public int MissingNumber(int[] nums)
    {
        int n = nums.Length;
        int sumOfNums = (n * (n + 1)) / 2;
        int sum = 0;
        foreach (int i in nums) sum += i;
        return sumOfNums - sum;
    }
}