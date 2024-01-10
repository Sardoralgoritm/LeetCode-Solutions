/// 2418. https://leetcode.com/problems/sort-the-people/description/

namespace Array;

public class Solution
{
    public string[] SortPeople(string[] names, int[] heights)
    {
        List<Tuple<string, int>> list = new();
        for (int i = 0; i < names.Length; i++)
        {
            list.Add(Tuple.Create(names[i], heights[i]));
        }
        var ans = list.OrderByDescending(i => i.Item2).Select(i => i.Item1).ToArray();
        return ans;
    }
}
