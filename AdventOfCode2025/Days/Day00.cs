using AdventOfCode2025.Common;

namespace AdventOfCode2025.Days;

public class Day00 : IProblem
{
    public string SolvePart1(string input)
    {
        return (int.Parse(input) + 1).ToString();
    }
    public string SolvePart2(string input)
    {
        return (int.Parse(input) + 2).ToString();
    }
}