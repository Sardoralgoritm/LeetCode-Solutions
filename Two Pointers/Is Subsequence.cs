/// 392.  https://leetcode.com/problems/is-subsequence/description/?envType=study-plan-v2&envId=top-interview-150


namespace Two_Pointers;

public class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        if (s.Length == 0 && t.Length == 0) return true;

        if (s.Length == 0) return true;

        int currIndex = 0;
        int i = 0;
        while (currIndex < s.Length && i < t.Length)
        {
            if (s[currIndex] == t[i]) currIndex++;
            i++;
        }
        return currIndex == s.Length;
    }
}