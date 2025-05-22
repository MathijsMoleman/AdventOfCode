// See https://aka.ms/new-console-template for more information

string _filePath =  @"C:\Advent of Code\2021\Advent of Code 2021 Day 1\PuzzleInput.txt";
string[] input = File.ReadAllLines(_filePath);
List<int> sums = new List<int>();
int increases = 0;
int decreases = 0;
for (int i = 0; i < input.Length; i++)
{
    int j = i + 1;
    int k = j + 1;
    if (k >= input.Length)
    {
        continue;
    }
    else
    {
        int sum = Convert.ToInt32(input[i]) + Convert.ToInt32(input[j]) + Convert.ToInt32(input[k]);
        sums.Add(sum);
    }
}

for (int i = 0; i < sums.Count; i++)
{
    int j = i + 1;
    if (j == sums.Count)
    {
        continue;
    }
    else if (sums[i] == sums[j])
    {
        continue;
    }
    else if (sums[j] > sums[i])
    {
        increases++;
    }
    else if (sums[j] < sums[i])
    {
        decreases++;
    }

    
}
Console.WriteLine(increases);