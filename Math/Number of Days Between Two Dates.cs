// 1360. https://leetcode.com/problems/number-of-days-between-two-dates/

namespace Math;

public class Solution
{
    public int DaysBetweenDates(string date1, string date2)
    {
        DateTime dateTime1 = DateTime.Parse(date1);
        DateTime dateTime2 = DateTime.Parse(date2);
        TimeSpan different = dateTime1 - dateTime2;
        return Math.Abs(different.Days);
    }
}
