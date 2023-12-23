/// 1108. https://leetcode.com/problems/defanging-an-ip-address/

using System.Text;
namespace String;
public class Solution
{
    public string DefangIPaddr(string address)
    {
        StringBuilder result = new StringBuilder();
        foreach (char i in address)
        {
            if (i == '.') result.Append("[.]");
            else result.Append(i);
        }
        return result.ToString();
    }
}