/// 917.  https://leetcode.com/problems/reverse-only-letters/


namespace Two_Pointers;

public class Solution
{
    public string ReverseOnlyLetters(string s)
    {
        int left = 0, right = s.Length - 1;
        char[] result = new char[s.Length];
        while (left <= right)
        {
            if (char.IsLetter(s[left]) && char.IsLetter(s[right]))
            {
                result[left] = s[right];
                result[right] = s[left];
                left++;
                right--;
            }
            else if (char.IsLetter(s[left])) // "!ab-cd"
            {
                result[right] = s[right--];
            }
            else if (char.IsLetter(s[right]))
            {
                result[left] = s[left++];
            }
            else
            {
                result[left] = s[left++];
                result[right] = s[right--];
            }
        }
        return new string(result);
    }
}