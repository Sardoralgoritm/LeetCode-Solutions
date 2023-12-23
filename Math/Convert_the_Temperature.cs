/// 2469. https://leetcode.com/problems/convert-the-temperature/description/

namespace Math;
public class Solution
{
    public double[] ConvertTemperature(double celsius)
    {
        return new double[] { celsius + 273.15d, celsius * 1.80d + 32.00d };
    }
}
