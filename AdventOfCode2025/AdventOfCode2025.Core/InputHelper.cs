namespace AdventOfCode2025.Core;

public class InputHelper
{
    public static async Task<List<string>> GetInputAsync(string fileName)
    {
        var outputDir = AppDomain.CurrentDomain.BaseDirectory;
        var filePath = Path.Combine(outputDir, fileName);
        var lines = await File.ReadAllLinesAsync(filePath);
        return lines.ToList();
    }
    
    public static async Task<List<string>> GetInputAsync(string fileName, string separator)
    {
        var outputDir = AppDomain.CurrentDomain.BaseDirectory;
        var filePath = Path.Combine(outputDir, fileName);
        var text = await File.ReadAllTextAsync(filePath);
        return text
            .ReplaceLineEndings("")
            .Split(separator, StringSplitOptions.RemoveEmptyEntries)
            .ToList();
    }
}