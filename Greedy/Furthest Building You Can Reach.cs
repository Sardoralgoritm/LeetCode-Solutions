/// 1642.  https://leetcode.com/problems/furthest-building-you-can-reach/?envType=daily-question&envId=2024-02-17

namespace Greedy;

public class Solution
{
    public int FurthestBuilding(int[] heights, int bricks, int ladders)
    {
        PriorityQueue<int, int> jumps = new PriorityQueue<int, int>();

        for (int i = 1; i < heights.Length; i++)
        {
            int difference = heights[i] - heights[i - 1];

            if (difference > 0)
            {
                bricks -= difference;
                jumps.Enqueue(difference, -difference);

                if (bricks < 0)
                {
                    if (ladders == 0)
                    {
                        return i - 1;
                    }
                    else
                    {
                        bricks += jumps.Dequeue();
                        ladders--;
                    }
                }
            }
        }
        return heights.Length - 1;
    }
}