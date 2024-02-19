/// 69.  https://leetcode.com/problems/sqrtx/description/?envType=study-plan-v2&envId=top-interview-150


namespace Binary_Search;

public class Solution
{
    public int MySqrt(int x)
    {
        if (x == 0) return 0;
        int left = 1;
        int right = x;
        while (left <= right)
        {
            int mid = (left + right) / 2;
            int sqrt = x / mid;
            if (mid == sqrt) return mid;
            else if (sqrt < mid) right = mid - 1;
            else left = mid + 1;
        }
        return right;
    }
}