using System.Xml;
using AdventOfCode2025.Core;

namespace Day4;

public class Solution : ISolution<long>
{
    private long _total = 0;

    public async Task<long> Solve()
    {
        var input = await InputHelper.GetInputAsync("input.txt");

        var rows = input.Count;
        var columns = input[0].Length;

        var inputArray = new char[rows, columns];
        FillArray(input, inputArray, rows, columns);

        while (true)
        {
            var previousTotal = _total;
            for (var rowIndex = 0; rowIndex < rows; rowIndex++)
            {
                // read a character on the line 
                // if the character is a @ it is a potential paper roll
                // read all adjacent 8 positions depending on the paper roll
                // if there are fewer than 4 paper rolls adjacent to the input then ita a valid paper roll

                for (var columnIndex = 0; columnIndex < columns; columnIndex++)
                {
                    if (IsPaperRoll(rowIndex, columnIndex, inputArray))
                    {
                        var numberOfAdjacentPaperRolls =
                            DetermineNumberOfAdjacentPaperRolls(rowIndex, columnIndex, rows, columns, inputArray);
                        if (numberOfAdjacentPaperRolls <= 3)
                        {
                            inputArray[rowIndex, columnIndex] = '.'; // mark as counted
                            _total++;
                        }
                    }
                }
            }

            if (previousTotal == _total)
            {
                break;
            }
            
        }
        return _total;
    }

    private void FillArray(List<string> input, char[,] inputArray, int rows, int columns)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                inputArray[i, j] = input[i][j];
            }
        }
    }

    private int DetermineNumberOfAdjacentPaperRolls(int rowIndex, int columnIndex, int rows, int columns,
        char[,] inputArray)
    {
        var totalAdjacentPaperRolls = 0;
        // check all 8 adjacent positions
        var adjacentPaperPositions = new[]
        {
            (rowIndex - 1, columnIndex - 1), // top-left
            (rowIndex - 1, columnIndex + 0), // top
            (rowIndex - 1, columnIndex + 1), // top-right
            (rowIndex + 0, columnIndex - 1), // left
            (rowIndex + 0, columnIndex + 1), // right
            (rowIndex + 1, columnIndex - 1), // bottom-left
            (rowIndex + 1, columnIndex + 0), // bottom
            (rowIndex + 1, columnIndex + 1) // bottom-right
        };

        foreach (var adjacentPaperPosition in adjacentPaperPositions)
        {
            if (IsPaperRoll(adjacentPaperPosition.Item1, adjacentPaperPosition.Item2, inputArray))
            {
                totalAdjacentPaperRolls++;
            }
        }

        return totalAdjacentPaperRolls;
    }

    private bool IsPaperRoll(int rowIndex, int columnIndex, char[,] inputArray)
    {
        try
        {
            var character = inputArray[rowIndex, columnIndex];
            return character == '@';
        }
        catch (IndexOutOfRangeException)
        {
            return false;
        }
    }
}