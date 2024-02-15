/// 1417. https://leetcode.com/problems/reformat-the-string/description/

using System.Text;

namespace String;

public class Solution
{
    public string Reformat(string s)
    {
        var checkItems = CheckItems(s);
        int lengthOfNumbers = checkItems.numbers.Length;
        int lengthOfLetters = checkItems.letters.Length;

        if (Math.Abs(lengthOfNumbers - lengthOfLetters) > 1) return string.Empty;

        char[] sortingNumber = checkItems.numbers.ToCharArray().OrderBy(i => i).ToArray();
        char[] sortingLetter = checkItems.letters.ToCharArray().OrderBy(i => i).ToArray();

        StringBuilder result = new StringBuilder();
        if (lengthOfLetters > lengthOfNumbers)
        {
            for (int i = 0; i < lengthOfNumbers; i++)
            {
                result.Append(sortingLetter[i]);
                result.Append(sortingNumber[i]);
            }
            result.Append(sortingLetter[lengthOfNumbers]);
        }
        else if (lengthOfNumbers > lengthOfLetters)
        {
            for (int i = 0; i < lengthOfLetters; i++)
            {
                result.Append(sortingNumber[i]);
                result.Append(sortingLetter[i]);
            }
            result.Append(sortingNumber[lengthOfLetters]);
        }
        else
        {
            for (int i = 0; i < lengthOfLetters; i++)
            {
                result.Append(sortingNumber[i]);
                result.Append(sortingLetter[i]);
            }
        }
        return result.ToString();
    }

    public (string numbers, string letters) CheckItems(string s)
    {
        StringBuilder numbers = new StringBuilder();
        StringBuilder letters = new StringBuilder();
        for (int i = 0; i < s.Length; i++)
        {
            if (char.IsDigit(s[i])) numbers.Append(s[i]);
            else letters.Append(s[i]);
        }
        return (numbers.ToString(), letters.ToString());
    }
}
