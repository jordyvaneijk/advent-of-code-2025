using AdventOfCode2025.Core;

namespace Day3;

public class Solution : ISolution<long>
{
    private long _total = 0;
    public async Task<long> Solve()
    {
        var input = await InputHelper.GetInputAsync("input.txt");
        foreach (var line in input)
        {
            FindLargestTwoDigitsConcatInLine(line);
        }
        return _total;
    }

    private void FindLargestTwoDigitsConcatInLine(string line)
    {
        int maxJoltage = int.MinValue;
        var digits = new List<int>();
        foreach (char c in line)
        {
            if (char.IsDigit(c))
                digits.Add(c - '0');
        }
        for (int i = 0; i < digits.Count - 1; i++)
        {
            for (int j = i + 1; j < digits.Count; j++)
            {
                int joltage = digits[i] * 10 + digits[j];
                if (joltage > maxJoltage)
                    maxJoltage = joltage;
            }
        }
        if (maxJoltage != int.MinValue)
        {
            Console.WriteLine(maxJoltage);
            _total += maxJoltage;
        }
    }
}