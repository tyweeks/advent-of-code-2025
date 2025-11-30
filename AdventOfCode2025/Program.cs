// See https://aka.ms/new-console-template for more information
using AdventOfCode2025.Days;
Console.WriteLine("Hello, World!");

var problem = new Day00();
var input = System.IO.File.ReadAllText("Inputs/day00.txt");
Console.WriteLine(problem.SolvePart1(input));
Console.WriteLine(problem.SolvePart2(input));