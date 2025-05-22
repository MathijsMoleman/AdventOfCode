// See https://aka.ms/new-console-template for more information
using System.Numerics;
string _filePath =  @"C:\Advent of Code\2016\Advent of Code 2016 Day 1\PuzzleInput.txt";
string input = File.ReadAllText(_filePath);
int lookDirection = 0;
Vector2 distance = new Vector2(0, 0);
List<Vector2> turns = new List<Vector2>();
List<Vector2> heaqueredTurns = new List<Vector2>();
string direction = "north";
string[] instructions = input.Split(", ");
turns.Add(distance);
foreach (var instruction in instructions)
{
    if (instruction[0] == 'R')
    { 
        if (lookDirection == 3) 
        { 
            lookDirection = 0;
        }
        else 
        {
            lookDirection += 1;
        }
    }
    else if (instruction[0] == 'L') 
    {
        if (lookDirection == 0)
        {
            lookDirection = 3;
        }
        else
        {
            lookDirection -= 1;
        }
    }
    
    int walkDistance = int.Parse(instruction.Substring(1));
    for (int i = 0; i < walkDistance; i++)
    {
        if (lookDirection == 0)
        {
            direction = "north";
            distance.Y += 1;
        }
        else if (lookDirection == 1)
        {
            direction = "east";
            distance.X += 1;
        }
        else if (lookDirection == 2)
        {
            direction = "south";
            distance.Y -= 1;
        }
        else if (lookDirection == 3)
        {
            direction = "west";
            distance.X -= 1;
        }
        if (!turns.Contains(distance))
        {
            turns.Add(distance);
        }
        else if (!heaqueredTurns.Contains(distance))
        {
            heaqueredTurns.Add(distance);
            Console.WriteLine("Headquarters found!");
            Console.WriteLine(heaqueredTurns[0]);
        }
        else
        {
            continue;
        }
        
    }
}
Console.WriteLine(direction);
Console.WriteLine(distance);


