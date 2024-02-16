/// 2149. https://leetcode.com/problems/rearrange-array-elements-by-sign/

namespace Array;

public class Solution
{
    public int[] RearrangeArray(int[] nums)
    {
        var items = Helper(nums);
        var positive = items.positive;
        var negative = items.negative;
        List<int> result = new List<int>();
        for (int i = 0; i < nums.Length / 2; i++)
        {
            result.Add(positive[i]);
            result.Add(negative[i]);
        }

        return result.ToArray();
    }

    public (int[] positive, int[] negative) Helper(int[] arr)
    {
        List<int> pos = new List<int>();
        List<int> neg = new List<int>();
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] >= 0) pos.Add(arr[i]);
            else neg.Add(arr[i]);
        }
        return (pos.ToArray(), neg.ToArray());
    }
}
