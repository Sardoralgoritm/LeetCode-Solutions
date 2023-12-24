/// 1758. https://leetcode.com/problems/minimum-changes-to-make-alternating-binary-string/description


namespace String;
public class Solution
{
    public int MinOperations(string s)
    {
        int roleNumberOne = 0;
        int roleNumberTwo = 0;
        int n = s.Length;

        if (n % 2 == 1)
        {
            if (s[^1] == '1') roleNumberTwo++;
            else roleNumberOne++;
        }

        for (int i = 0; i < n - 1; i += 2)
        {
            if (s[i] != '1' && s[i + 1] != '0') roleNumberOne += 2;
            if (s[i] == '1' && s[i + 1] != '0') roleNumberOne++;
            if (s[i] != '1' && s[i + 1] == '0') roleNumberOne++;

            if (s[i] != '0' && s[i + 1] != '1') roleNumberTwo += 2;
            if (s[i] != '0' && s[i + 1] == '1') roleNumberTwo++;
            if (s[i] == '0' && s[i + 1] != '1') roleNumberTwo++;
        }
        return (roleNumberTwo >= roleNumberOne) ? roleNumberOne : roleNumberTwo;
    }
}