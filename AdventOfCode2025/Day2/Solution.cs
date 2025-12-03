using AdventOfCode2025.Core;

namespace Day2;

public class Solution : ISolution<long>
{
    private long _total = 0;
    public async Task<long> Solve()
    {
        var input = await InputHelper.GetInputAsync("input.txt", ",");
        foreach (var line in input)
        {
            var ids = line.Split("-");
            Console.WriteLine($"id1: {ids[0]}, id2: {ids[1]}");
            
            var lowerId = long.Parse(ids[0]);
            var upperId = long.Parse(ids[1]);
            
            for (long id = lowerId; id <= upperId; id++)
            {
                var strId = id.ToString();
                int len = strId.Length;
                for (int subLen = 1; subLen <= len / 2; subLen++)
                {
                    if (len % subLen == 0)
                    {
                        string pattern = strId.Substring(0, subLen);
                        string repeated = string.Concat(Enumerable.Repeat(pattern, len / subLen));
                        if (repeated == strId)
                        {
                            _total += id;
                            Console.WriteLine($"id {id} is invalid (repeated sequence)");
                            break;
                        }
                    }
                }
            }
        }
        return _total;
    }
}