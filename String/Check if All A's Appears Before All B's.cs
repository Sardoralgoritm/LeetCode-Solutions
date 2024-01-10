// 2124. https://leetcode.com/problems/check-if-all-as-appears-before-all-bs/

namespace String;

public class Solution
{
    public bool CheckString(string s)
    {
        int indexA = FindLastIndex(s, 'a');
        int indexB = FindIndex(s, 'b');
        return (indexB == -1 || indexA < indexB) ? true : false;
    }

    private int FindIndex(string s, char a)
    {
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == a) return i;
        }
        return -1;
    }

    private int FindLastIndex(string s, char a)
    {
        int index = s.Length - 1;
        for (int i = index; i >= 0; i--)
        {
            if (s[i] == a) return i;
        }
        return -1;
    }
}