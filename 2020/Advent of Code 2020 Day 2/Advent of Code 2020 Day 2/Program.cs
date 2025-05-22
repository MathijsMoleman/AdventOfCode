// See https://aka.ms/new-console-template for more information
// p1 60min
// p2 15min
string _filePath =  @"C:\Advent of Code\2020\Advent of Code 2020 Day 2\PuzzleInput.txt";
string[] input = File.ReadAllLines(_filePath);
int totalValid = 0;
/*
foreach (var line in input)
{
    string[] instructions = line.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
    string[] range = instructions[0].Split('-');
    int lowNumber =  int.Parse(range.First());
    int highNumber = int.Parse(range.Last());
    char characterToCheck = instructions[1].First();
    int checkAmount = 0;

    foreach (char character in instructions[2])
    {
        if (character == characterToCheck)
        {
            checkAmount++;
        }
    }
    Console.WriteLine($"{lowNumber} , {highNumber} , {checkAmount}");

    if (lowNumber <= checkAmount && checkAmount <= highNumber)
    {
        Console.WriteLine("Valid input");
        totalValid++;
    }
    else
    {
        Console.WriteLine("Invalid input");
    }
}
*/

foreach (var line in input)
{
    string[] instructions = line.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
    string[] indexesToCheck = instructions[0].Split('-');
    int lowIndex =  int.Parse(indexesToCheck.First());
    int highIndex = int.Parse(indexesToCheck.Last());
    char characterToCheck = instructions[1].First();
    int checkAmount = 0;
    bool lowSame = characterToCheck == instructions[2][lowIndex -1];
    bool highSame = characterToCheck == instructions[2][highIndex -1];
    
    Console.WriteLine("lowSame" + "," + lowSame);
    Console.WriteLine("highSame" + "," + highSame);



    if (lowSame == true && highSame == true)
    {
        Console.WriteLine("Invalid input");
        continue;
    }
    else if (lowSame == true || highSame == true)
    {
        Console.WriteLine("Valid input");
        totalValid++;
    }
    else
    {
        Console.WriteLine("Invalid input");
    }
}

Console.WriteLine(totalValid);
