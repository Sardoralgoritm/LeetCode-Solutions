/// 58.  https://leetcode.com/problems/length-of-last-word/description/?envType=study-plan-v2&envId=top-interview-150


namespace String;

public class Solution
{
    public int LengthOfLastWord(string s)
    {
        return s.Trim().Split()[^1].Length;
    }
}