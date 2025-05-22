// See https://aka.ms/new-console-template for more information
//60min
string _filePath =  @"C:\Advent of Code\2017\Advent of Code 2017 Day 2\PuzzleInput.txt";
string[] input = File.ReadAllLines(_filePath);
List<int> distances = new List<int>();
int totalDistance = 0;

foreach (var line in input)
{
    List<int> numbers = new List<int>();
    string[] instructions = line.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
    foreach (var instruction in instructions)
    {
        int number = int.Parse(instruction);
        numbers.Add(number);
    }
    numbers.Sort();
    for (int i = 0; i < numbers.Count; i++)
    {
        for (int j = 0; j < numbers.Count; j++)
        {
            if (numbers[i] % numbers[j] == 0 && i != j)
            {
                int number1 = numbers[i] / numbers[j];
                distances.Add(number1);
            }
        }
    }
}

foreach (var distance in distances)
{
    totalDistance += distance;
}
Console.WriteLine(totalDistance);