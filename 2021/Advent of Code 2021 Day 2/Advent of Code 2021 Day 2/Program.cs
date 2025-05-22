// See https://aka.ms/new-console-template for more information

//p1 30 min 
//p2 30 min

using System.Numerics;

string _filePath =  @"C:\Advent of Code\2021\Advent of Code 2021 Day 2\PuzzleInput.txt";
string[] input = File.ReadAllLines(_filePath);
Vector2 end = new Vector2(0, 0);
int depth = 0;
int distance = 0;
Dictionary<string, Vector2> directions = new Dictionary<string, Vector2>()
{
    { "forward", new Vector2(1, 0) },
    { "up", new Vector2(0, 1) },
    { "down", new Vector2(0, -1) },
};
foreach (var line in input)
{
    string[] instructions = line.Split((char[])null!, StringSplitOptions.RemoveEmptyEntries);
    int moveAmount = int.Parse(instructions[1]);
    end += directions[instructions[0]] * new Vector2(moveAmount, moveAmount);
    if (instructions[0] == "forward")
    {
        depth += moveAmount * (int)end.Y;
    }
    distance = (int)end.X * depth;
}

if (distance < 0)
{
    distance *= -1;
}
Console.WriteLine(distance);
