/// 1481. https://leetcode.com/problems/least-number-of-unique-integers-after-k-removals/description/?envType=daily-question&envId=2024-02-16

namespace Hash_Table;

public class Solution
{
    public int FindLeastNumOfUniqueInts(int[] arr, int k)
    {
        Dictionary<int, int> countOfNumber = new Dictionary<int, int>();
        for (int i = 0; i < arr.Length; i++)
        {
            if (countOfNumber.ContainsKey(arr[i])) countOfNumber[arr[i]]++;
            else countOfNumber[arr[i]] = 1;
        }

        var values = countOfNumber.Values.OrderBy(x => x).ToList();
        int minus = 0;
        foreach (var i in values)
        {
            if (i <= k)
            {
                k -= i;
                minus++;
            }
            else break;
        }
        return countOfNumber.Count() - minus;
    }
}
