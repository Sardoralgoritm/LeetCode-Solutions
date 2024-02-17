/// 121.  https://leetcode.com/problems/best-time-to-buy-and-sell-stock/

namespace Dynamic_Programming;

public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int left = 0;
        int right = 1;
        int result = 0;

        while (right < prices.Length)
        {
            if (prices[right] >= prices[left])
            {
                result = Math.Max(result, prices[right] - prices[left]);
            }
            else
            {
                left = right;
            }
            right++;
        }
        return result;
    }
}