// See https://aka.ms/new-console-template for more information
string _filePath =  @"C:\Advent of Code\2018\Advent of Code 2018 Day 1\PuzzleInput.txt";
string[] input = File.ReadAllLines(_filePath);
int frequency = 0;
int repeat = 1;
List<int> frequencies = new List<int>();
List<int> visitedFrequencies = new List<int>();
while(visitedFrequencies.Count == 0)
{
    foreach (string line in input)
    {
        int freafrequencyChange = int.Parse(line.Substring(1));
        if (line[0] == '+')
        {
            frequency += freafrequencyChange;
            if (!frequencies.Contains(frequency))
            {
                frequencies.Add(frequency);
            }
            else
            {
                visitedFrequencies.Add(frequency);
            }
        
        }
        else if (line[0] == '-')
        {
            frequency -= freafrequencyChange;
            if (!frequencies.Contains(frequency))
            {
                frequencies.Add(frequency);
            }
            else
            {
                visitedFrequencies.Add(frequency);
            }
        }
    }
}
Console.WriteLine(frequency);
Console.WriteLine(visitedFrequencies[0]);
