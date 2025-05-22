// See https://aka.ms/new-console-template for more information

//p1 75 min
//p2 15 min
string filePath = @"C:\Advent of Code\2023\Advent of Code 2023 Day 2\PuzzleInput.txt"; 
List<string> input = File.ReadAllLines(filePath).ToList();
List<string> colors = new List<string>()
{
    "blue",
    "green",
    "red" 
};
int totalNumber = 0;
/*
List<int> possibleGames = new List<int>();
foreach (string line in input)
{
    string[] inststruction = line.Split(':');
    string[] sets = inststruction[1].Split(';');
    string[] games = inststruction[0].Split(' ');
    int game = int .Parse(games[1]);
    bool posibleGame = true;
    foreach (var set in sets)
    {
        Dictionary<string, int> colorAmount = new Dictionary<string, int>()
        {
            { "blue", 0 },
            { "green", 0 },
            { "red", 0 }
        };
        string[] cubes = set.Split(',');
        foreach (var cube in cubes)
        {
            string[] cubeParts = cube.Split(' ');
            if (colors.Contains(cubeParts[2]))
            {

                int number = int.Parse(cubeParts[1]);
                colorAmount[cubeParts[2]] += number;
            }
        }
        if (colorAmount["blue"] > 14)
        {
            posibleGame = false;
        }
        else if (colorAmount["green"] > 13)
        {
            posibleGame = false;
        }
        else if (colorAmount["red"] > 12)
        {
            posibleGame = false;
        }
        
    }

    if (posibleGame == true)
    {
        if (!possibleGames.Contains(game))
        {
            Console.WriteLine(game);
            possibleGames.Add(game);     
        }
    }
}


foreach (var game in possibleGames)
{
    totalNumber += game;
}
*/
List<int> numbers = new List<int>();
foreach (string line in input)
{
    string[] inststruction = line.Split(':');
    string[] sets = inststruction[1].Split(';');
    Dictionary<string, int> minimumCubes = new Dictionary<string, int>()
    {
        { "blue", 0 },
        { "green", 0 },
        { "red", 0 }
    };
    foreach (var set in sets)
    {
        Dictionary<string, int> colorAmount = new Dictionary<string, int>()
        {
            { "blue", 0 },
            { "green", 0 },
            { "red", 0 }
        };
        string[] cubes = set.Split(',');
        foreach (var cube in cubes)
        {
            string[] cubeParts = cube.Split(' ');
            if (colors.Contains(cubeParts[2]))
            {

                int number = int.Parse(cubeParts[1]);
                colorAmount[cubeParts[2]] += number;
            }
        }

        if (colorAmount["blue"] > minimumCubes["blue"])
        {
            minimumCubes["blue"] = colorAmount["blue"];
        }

        if (colorAmount["green"] > minimumCubes["green"])
        {
            minimumCubes["green"] = colorAmount["green"];
        }

        if (colorAmount["red"] > minimumCubes["red"])
        {
            minimumCubes["red"] = colorAmount["red"];
        }
    }
    Console.WriteLine(minimumCubes["blue"] +","+ minimumCubes["green"] +","+ minimumCubes["red"]);
    numbers.Add(minimumCubes["blue"] * minimumCubes["green"] * minimumCubes["red"]);

}

foreach (var number in numbers)
{
    totalNumber += number;
}
Console.WriteLine(totalNumber);