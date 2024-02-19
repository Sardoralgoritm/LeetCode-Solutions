/// 383. https://leetcode.com/problems/ransom-note/description/?envType=study-plan-v2&envId=top-interview-150


namespace Counting;

public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        int[] counter = new int[26];
        foreach (char i in magazine)
        {
            counter[i - 'a']++;
        }

        foreach (char i in ransomNote)
        {
            if (counter[i - 'a'] == 0) return false;
            counter[i - 'a']--;
        }
        return true;
    }
}