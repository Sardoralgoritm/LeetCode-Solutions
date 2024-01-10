/// 1773. https://leetcode.com/problems/count-items-matching-a-rule/

namespace Array;

public class Solution
{
    public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
    {
        int count = 0;
        for (int i = 0; i < items.Count(); i++)
        {
            var item = items[i];
            if (ruleKey == "type")
            {
                if (item[0] == ruleValue) count++;
            }
            else if (ruleKey == "color")
            {
                if (item[1] == ruleValue) count++;
            }
            else
            {
                if (item[2] == ruleValue) count++;
            }
        }
        return count;
    }
}