using AdventOfCode2025.Core;

namespace Day3;

public class Solution : ISolution<long>
{
    private long _total = 0;
    public async Task<long> Solve()
    {
        var input = await InputHelper.GetInputAsync("testcase.txt");
        foreach (var line in input)
        {
            FindLargestTwoDigitsConcatInLine(line);
        }
        return _total;
    }

    private void FindLargestTwoDigitsConcatInLine(string line)
    {
        var digits = new List<int>();
        foreach (char c in line)
        {
            if (char.IsDigit(c))
                digits.Add(c - '0');
        }
        if (digits.Count >= 2)
        {
            // Find the index of the first largest digit
            int firstIdx = 0;
            for (int i = 1; i < digits.Count; i++)
            {
                if (digits[i] > digits[firstIdx])
                    firstIdx = i;
            }
            // Find the index of the next largest digit, skipping firstIdx
            int secondIdx = -1;
            int secondMax = int.MinValue;
            for (int i = 0; i < digits.Count; i++)
            {
                if (i == firstIdx) continue;
                if (digits[i] > secondMax)
                {
                    secondMax = digits[i];
                    secondIdx = i;
                }
            }
            // Concatenate in their order of appearance
            string concat = firstIdx < secondIdx
                ? $"{digits[firstIdx]}{digits[secondIdx]}"
                : $"{digits[secondIdx]}{digits[firstIdx]}";
            int result = int.Parse(concat);
            Console.WriteLine(concat);
            _total += result;
        }
        else if (digits.Count == 1)
        {
            _total += digits[0];
        }
    }
}