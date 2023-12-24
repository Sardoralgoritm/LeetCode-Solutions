/// 2433. https://leetcode.com/problems/find-the-original-array-of-prefix-xor/

namespace Array;

public class Solution
{
    public int[] FindArray(int[] pref)
    {
        int n = pref.Length;
        int[] result = new int[n];
        result[0] = pref[0];
        for (int i = 1; i < n; i++)
        {
            result[i] = pref[i] ^ pref[i - 1];
        }
        return result;
    }
}