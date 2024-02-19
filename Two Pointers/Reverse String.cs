/// 344.  https://leetcode.com/problems/reverse-string/


namespace Two_Pointers;

public class Solution
{
    public void ReverseString(char[] s)
    {
        for (int i = 0; i < s.Length / 2; i++)
        {
            char tmp = s[i];
            s[i] = s[s.Length - i - 1];
            s[s.Length - i - 1] = tmp;
        }
    }
}