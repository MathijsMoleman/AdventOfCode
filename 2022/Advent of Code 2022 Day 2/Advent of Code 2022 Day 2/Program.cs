// See https://aka.ms/new-console-template for more information
//p1 30 min
//p2 30 min

string _filePath =  @"C:\Advent of Code\2022\Advent of Code 2022 Day 2\PuzzleInput.txt";
string[] input = File.ReadAllLines(_filePath);
List<int> outcomes = new List<int>();
int awnser = 0;
/*
Dictionary<char, string> rockPaperScissors = new Dictionary<char, string>()
{
    { 'A', "Rock" },
    { 'B', "Paper" },
    { 'C', "Scissors" },
    { 'X', "Rock" },
    { 'Y', "Paper" },
    { 'Z', "Scissors" },
};
Dictionary<char, int> value = new Dictionary<char, int>()
{
    { 'X', 1 },
    { 'Y', 2 },
    { 'Z', 3 },
};
foreach (var line in input)
{
    string[] instructions = line.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
    
    int outcome = 0;
    if (rockPaperScissors[instructions[0][0]] == rockPaperScissors[instructions[1][0]])
    {
        outcome = 3;
    }
    else if (rockPaperScissors[instructions[0][0]] == "Rock" && rockPaperScissors[instructions[1][0]] == "Paper")
    {
        outcome = 6;
    }
    else if (rockPaperScissors[instructions[0][0]] == "Paper" && rockPaperScissors[instructions[1][0]] == "Scissors")
    {
        outcome = 6;
    }
    else if (rockPaperScissors[instructions[0][0]] == "Scissors" && rockPaperScissors[instructions[1][0]] == "Rock")
    {
        outcome = 6;
    }
    outcomes.Add(outcome + value[instructions[1][0]]);
}
*/
Dictionary<char, string> rockPaperScissors = new Dictionary<char, string>()
{
    { 'A', "Rock" },
    { 'B', "Paper" },
    { 'C', "Scissors" },
    
};
Dictionary<char, string> outcomeRockPaperScissors = new Dictionary<char, string>()
{
    { 'X', "Lose" },
    { 'Y', "Draw" },
    { 'Z', "Win" }
};
Dictionary<string, int> value = new Dictionary<string, int>()
{
    { "Rock", 1 },
    { "Paper", 2 },
    { "Scissors", 3 }
};
foreach (var line in input)
{
    string[] instructions = line.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
    
    int outcome = 0;
    if (outcomeRockPaperScissors[instructions[1][0]] == "Lose")
    {
        if (rockPaperScissors[instructions[0][0]] == "Rock")
        {
            outcome = value["Scissors"];
        }
        else if (rockPaperScissors[instructions[0][0]] == "Paper")
        {
            outcome = value["Rock"];
        }
        else
        {
            outcome = value["Paper"];
        }
    }
    else if (outcomeRockPaperScissors[instructions[1][0]] == "Draw")
    {
        outcome = value[rockPaperScissors[instructions[0][0]]] + 3;
    }
    else if (outcomeRockPaperScissors[instructions[1][0]] == "Win")
    {
        if (rockPaperScissors[instructions[0][0]] == "Rock")
        {
            outcome = value["Paper"] + 6;
        }
        else if (rockPaperScissors[instructions[0][0]] == "Paper")
        {
            outcome = value["Scissors"] + 6;
        }
        else
        {
            outcome = value["Rock"] + 6;
        }
    }
    outcomes.Add(outcome);
}

foreach (var number in outcomes)
{
    awnser += number;
}
Console.WriteLine(awnser);
