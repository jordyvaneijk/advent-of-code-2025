using SolutionDay1 = Day1.Solution;
using SolutionDay2 = Day2.Solution;
using SolutionDay3 = Day3.Solution;


Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("Advent of Code 2025!\n");

Console.WriteLine("============================================");
Console.WriteLine("1) Day 1: Secret Entrance");
Console.WriteLine("1) Day 2: Gift Shop");
Console.WriteLine("1) Day 2: Lobby");
Console.ResetColor();
Console.WriteLine("Select day to run (1-12): ");
var input = Console.ReadLine();
if (!Int32.TryParse(input, out var dayToRun))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Invalid input. Please enter a number between 1 and 12. or 'q' to quit.");
    Console.ResetColor();
}

switch (dayToRun)
{
    case 1:
    {
        var solution = new SolutionDay1();
        var outcome = await solution.Solve();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Day 1 solution: {outcome}");
        Console.ResetColor();
        break;
    }
    case 2:
    {
        var solution = new SolutionDay2();
        var outcome = await solution.Solve();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Day 2 solution: {outcome}");
        Console.ResetColor();
        break;
    }
    case 3:
    {
        var solution = new SolutionDay3();
        var outcome = await solution.Solve();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Day 2 solution: {outcome}");
        Console.ResetColor();
        break;
    }
}