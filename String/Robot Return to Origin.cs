/// 657. https://leetcode.com/problems/robot-return-to-origin/description/

namespace String;

public class Solution
{
    public bool JudgeCircle(string moves)
    {
        int row = 0;
        int col = 0;
        for (int i = 0; i < moves.Length; i++)
        {
            if (moves[i] == 'U') col++;
            else if (moves[i] == 'D') col--;

            if (moves[i] == 'L') row--;
            else if (moves[i] == 'R') row++;
        }
        return row == 0 && col == 0;

    }
}
