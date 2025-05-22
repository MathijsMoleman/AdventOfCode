// See https://aka.ms/new-console-template for more information

using System.Numerics;
// 30 min
string _filePath =  @"C:\Advent of Code\2016\Advent of Code 2016 Day 2\PuzzleInput.txt";
string[] input = File.ReadAllLines(_filePath);
Vector2 numpadPosition = new Vector2(-2, 0);
List<Vector2> numpad = new List<Vector2>()
{
    new Vector2(0, 0),
    new Vector2(1, 0),
    new Vector2(1, 1),
    new Vector2(0, 1),
    new Vector2(-1, 0),
    new Vector2(0, -1),
    new Vector2(-1, 1),
    new Vector2(1, -1),
    new Vector2(-1, -1),
    new Vector2(0, 2),
    new Vector2(0, -2),
    new Vector2(2, 0),
    new Vector2(-2, 0),
};
Dictionary<Vector2, string> numpadNumbers = new Dictionary<Vector2, string>()
{
    { new Vector2(0, 2), "1" },
    { new Vector2(-1, 1), "2" },
    { new Vector2(0, 1), "3" },
    { new Vector2(1, 1), "4" },
    { new Vector2(-2, 0), "5" },
    { new Vector2(-1, 0), "6" },
    { new Vector2(0, 0), "7" },
    { new Vector2(1, 0), "8" },
    { new Vector2(2, 0), "9" },
    { new Vector2(-1, -1), "A" },
    { new Vector2(0, -1), "B" },
    { new Vector2(1, -1), "C" },
    { new Vector2(0, -2), "D" },
};

foreach (var line in input)
{
    foreach (var c in line)
    {
        if (c == 'U')
        {
            if (!numpad.Contains(numpadPosition + new Vector2(0, 1)))
            {
                continue;
            }
            numpadPosition += new Vector2(0, 1);
        }
        else if (c == 'D')
        {
            if (!numpad.Contains(numpadPosition + new Vector2(0, -1)))
            {
                continue;
            }
            numpadPosition += new Vector2(0, -1);
        }
        else if (c == 'L')
        {
            if (!numpad.Contains(numpadPosition + new Vector2(-1, 0)))
            {
                continue;
            }
            numpadPosition += new Vector2(-1, 0);
        }
        else if (c == 'R')
        {
            if (!numpad.Contains(numpadPosition + new Vector2(1, 0)))
            {
                continue;
            }
            numpadPosition += new Vector2(1, 0);
        }
    }
    Console.Write(numpadNumbers[numpadPosition]);
}