/// 231.  https://leetcode.com/problems/power-of-two/?envType=daily-question&envId=2024-02-19


namespace Math;

public class Solution
{
    public bool IsPowerOfTwo(int n)
    {
        if (n == 0) return false;
        while (n % 2 == 0) n /= 2;
        return n == 1;
    }
}