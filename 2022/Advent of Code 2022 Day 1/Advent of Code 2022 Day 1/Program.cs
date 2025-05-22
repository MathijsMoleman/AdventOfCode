// See https://aka.ms/new-console-template for more information

string _filePath =  @"C:\Advent of Code\2022\Advent of Code 2022 Day 1\PuzzleInput.txt";

string[] input = File.ReadAllLines(_filePath);
List<int> caloriesToBeAdded = new List<int>();
List<int> caloties = new List<int>();
foreach (string line in input)
{

    if (line == "")
    {
        int calorieToAdd = 0;
        foreach (var calorie in caloriesToBeAdded)
        {
            calorieToAdd += calorie;
        }
        caloriesToBeAdded.Clear();
        Console.WriteLine($"Calories added: {calorieToAdd}");
        
        caloties.Add(calorieToAdd);
    }
    else if (line == input.Last())
    {
        int number = Convert.ToInt32(line);
        caloriesToBeAdded.Add(number);
        
        int calorieToAdd = 0;
        foreach (var calorie in caloriesToBeAdded)
        {
            calorieToAdd += calorie;
        }
        caloriesToBeAdded.Clear();
        Console.WriteLine($"Calories added: {calorieToAdd}");

        caloties.Add(calorieToAdd);
    }
    else
    {
        int number = Convert.ToInt32(line);
        caloriesToBeAdded.Add(number);
    }
}
caloties.Sort((a, b) => b - a);
int result = caloties[0] + caloties[1] + caloties[2];
Console.WriteLine(result);