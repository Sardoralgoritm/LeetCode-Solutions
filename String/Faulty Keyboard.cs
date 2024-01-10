using System.Text;

namespace String;

public class Solution
{
    public string FinalString(string s)
    {
        string result = "";
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == 'i')
            {
                result = MyMethod(result);
            }
            else result += s[i];
        }
        return result.ToString();
    }

    private string MyMethod(string a)
    {
        StringBuilder builder = new();
        int ln = a.Length;
        for (int i = 0; i < ln; i++)
        {
            builder.Append(a[ln - i - 1]);
        }
        return builder.ToString();
    }
}