using SolutionDay1 = Day1.Solution;
using SolutionDay2 = Day2.Solution;
using SolutionDay3 = Day3.Solution;
using SolutionDay4 = Day4.Solution;
using SolutionDay5 = Day5.Solution;


Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("Advent of Code 2025!\n");

Console.WriteLine("============================================");
Console.WriteLine("1) Day 1: Secret Entrance");
Console.WriteLine("2) Day 2: Gift Shop");
Console.WriteLine("3) Day 3: Lobby");
Console.WriteLine("4) Day 4: Printing Department");
Console.WriteLine("5) Day 5: Cafeteria");
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
        Console.WriteLine($"Day 3 solution: {outcome}");
        Console.ResetColor();
        break;
    }
    case 4:
    {
        var solution = new SolutionDay4();
        var outcome = await solution.Solve();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Day 4 solution: {outcome}");
        Console.ResetColor();
        break;
    }
    case 5:
    {
        var solution = new SolutionDay5();
        var outcome = await solution.Solve();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Day 5 solution: {outcome}");
        Console.ResetColor();
        break;
    }
}