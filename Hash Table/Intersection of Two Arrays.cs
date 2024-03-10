/// 349 https://leetcode.com/problems/intersection-of-two-arrays/description/?envType=daily-question&envId=2024-03-10

namespace Hash_Table;

public class Solution
{
    public int[] Intersection(int[] nums1, int[] nums2)
    {
        var set1 = nums1.ToHashSet();
        var set2 = nums2.ToHashSet();
        return set1.Intersect(set2).ToArray();
    }
}