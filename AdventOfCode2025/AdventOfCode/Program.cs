using SolutionDay1 = Day1.Solution;


Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("Advent of Code 2025!\n");

Console.WriteLine("============================================");
Console.WriteLine("1) Day 1: Secret Entrance");
Console.ResetColor();
Console.Write("Select day to run (1-12): ");
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
}