namespace AdventOfCode2025.Core;

public interface ISolution<T>
{
    Task<T> Solve();
}