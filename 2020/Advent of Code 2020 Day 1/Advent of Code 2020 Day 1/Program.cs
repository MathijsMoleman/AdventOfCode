// See https://aka.ms/new-console-template for more information

string _filePath =  @"C:\Advent of Code\2020\Advent of Code 2020 Day 1\PuzzleInput.txt";
string[] input = File.ReadAllLines(_filePath);
int answer = 0;
for (int i = 0; i < input.Length; i++)
{
    for (int j = 0; j < input.Length; j++)
    {
        for (int k = 0; k < input.Length; k++)
        {
            if (Convert.ToInt32(input[i]) + Convert.ToInt32(input[j]) + Convert.ToInt32(input[k]) == 2020)
            {
                answer =Convert.ToInt32(input[i]) * Convert.ToInt32(input[j]) * Convert.ToInt32(input[k]);
            }
        }
    }
}
Console.WriteLine(answer);
