using AdventOfCode2025.Core;

namespace Day1;

public class Solution : ISolution<int>
{
    private int _startingPoint = 50;
    private int _numberOfTimesExactly0 = 0;
    public async Task<int> Solve()
    {
        var input = await InputHelper.GetInputAsync("input.txt");

        foreach (var line in input)
        {
            var direction = line[0];
            var number = int.Parse(line.Substring(1));
            var result = MoveOnCircle(_startingPoint, direction == 'L' ? -number : number);
            _startingPoint = result.newPosition;
            _numberOfTimesExactly0 += result.zeroCount;
            Console.WriteLine(line);
            Console.WriteLine(_startingPoint);
            
            // var direction = line[0];
            // var number = int.Parse(line.Substring(1));
            // Console.WriteLine(line);
            // switch (direction)
            // {
            //     case 'L':
            //     {
            //         _startingPoint = MoveOnCircle(_startingPoint, -number);
            //         break;
            //     }
            //     case 'R':
            //     {
            //         _startingPoint = MoveOnCircle(_startingPoint, number);
            //         break;
            //     }
            //     
            // }
            // CheckForZero(_startingPoint);
            // Console.WriteLine(_startingPoint);
        }
        
        return _numberOfTimesExactly0;
    }
    
    private (int newPosition, int zeroCount) MoveOnCircle(int current, int change)
    {
        int size = 100;
        int zeroCount = 0;
        int direction = change > 0 ? 1 : -1;
        int steps = Math.Abs(change);

        for (int i = 1; i <= steps; i++)
        {
            int pos = (current + i * direction) % size;
            if (pos < 0) pos += size;
            if (pos == 0) zeroCount++;
        }

        int newPosition = (current + change) % size;
        if (newPosition < 0) newPosition += size;
        return (newPosition, zeroCount);
    }

    // private int MoveOnCircle(int current, int change)
    // {
    //     int size = 100;
    //     int result = (current + change) % size;
    //     if (result < 0) result += size;
    //     return result;
    // }
    
    private void CheckForZero(int input)
    {
        if (input == 0)
        {
            _numberOfTimesExactly0++;
        }
    }
}