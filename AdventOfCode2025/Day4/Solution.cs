using AdventOfCode2025.Core;

namespace Day4;

public class Solution : ISolution<long>
{
    private long _total = 0;
    public async Task<long> Solve()
    {
        var input = await InputHelper.GetInputAsync("input.txt");
        foreach (var line in input)
        {
            FindLargestTwelveDigitsConcatInLine(line);
        }
        return _total;
    }

    private void FindLargestTwelveDigitsConcatInLine(string line)
    {
        int keep = 12;
        int remove = line.Length - keep;
        var stack = new List<char>();
        foreach (char c in line)
        {
            while (remove > 0 && stack.Count > 0 && stack[stack.Count - 1] < c)
            {
                stack.RemoveAt(stack.Count - 1);
                remove--;
            }
            stack.Add(c);
        }
        // If there are still digits to remove, remove from the end
        while (stack.Count > keep)
            stack.RemoveAt(stack.Count - 1);
        string result = new string(stack.ToArray());
        Console.WriteLine(result);
        _total += long.Parse(result);
    }
}